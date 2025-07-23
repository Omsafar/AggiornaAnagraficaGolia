// Program.cs – .NET 8 console app con caching di companyId
// NuGet:
//   Dapper
//   Microsoft.Data.SqlClient
//   Microsoft.Extensions.Configuration.Json
//   Microsoft.Extensions.Configuration.Binder
//   Microsoft.Extensions.Configuration.EnvironmentVariables
//   System.ServiceModel.Http
//   System.ServiceModel.Primitives
//   System.Net.Http.Json

#nullable disable
using Dapper;
using GoliaService;          // per GetCompaniesAsync
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Globalization;
using System.Text.Json;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

internal sealed record Employee(string FullName,
                                DateTime? HireDate,
                                DateTime? FireDate,
                                DateTime? UpdateDateTime);
// piccola classe per serializzare il cache file
public class CompanyCache
{
    public int CompanyId { get; set; }
}

class Program
{
    private const string ConnectionString =
       "Server=192.168.1.24\\sgam;Database=Sgam;User Id=sapara;Password=S@p4ra;Encrypt=True;TrustServerCertificate=True;";
    static async Task Main()
    {
        try
        {
            // 1) Configurazione
            IConfiguration config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", optional: true)
            .AddEnvironmentVariables()
            .Build();

        string user = config["Golia:User"] ?? "ParatoriAM";
        string pwd = config["Golia:Password"] ?? "ParatoriAM_34872";
        var loginReq = new LoginRequest { login = user, password = pwd };

        // 2) Recupero o cache del companyId
        const string cacheFile = "companyCache.json";
        int companyId;
        if (File.Exists(cacheFile))
        {
            try
            {
                var cache = JsonSerializer.Deserialize<CompanyCache>(File.ReadAllText(cacheFile));
                if (cache is { CompanyId: > 0 })
                {
                    companyId = cache.CompanyId;
                    Console.WriteLine($"Usando companyId da cache: {companyId}");
                }
                else
                {
                    companyId = await FetchAndCacheCompanyId(loginReq);
                }
            }
            catch
            {
                companyId = await FetchAndCacheCompanyId(loginReq);
            }
        }
        else
        {
            companyId = await FetchAndCacheCompanyId(loginReq);
        }

        // 3) Client SOAP WCF
        using var client = new GoliaManagerSOAPClient();


        // Data.txt con la data dell'ultima modifica applicata
        const string dataFile = "Data.txt";
        DateTime lastUpdate = DateTime.MinValue;
        if (File.Exists(dataFile))
        {
            var text = File.ReadAllText(dataFile).Trim();
            DateTime.TryParseExact(text,
                "yyyy-MM-dd HH:mm:ss.fff",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out lastUpdate);
        }
        
        // 4) GetDrivers via SOAP
        var loginCompanyRequest = new LoginCompanyCultureRequest
        {
            loginCredentials = loginReq,
            companyId = companyId,
            gmCulture = new GMCulture
            {
                infringmentNation = "ITA",
                timeZone = "W. Europe Standard Time",
                translationLanguage = "it-IT"
            }
        };

        var getRes = await client.GetDriversAsync(loginCompanyRequest);
        if (getRes.loginResult is null || !getRes.loginResult.success)
        {
            var errors = getRes.loginResult?.errors ?? Array.Empty<string>();
                var msg = "Errore SOAP GetDrivers: " + string.Join(", ", errors);
                Console.Error.WriteLine(msg);
                SendErrorEmail(new Exception(msg));
                return;
        }

        var goliaDrivers = getRes.drivers ?? Array.Empty<Driver>();
        Console.WriteLine($"SOAP: trovati {goliaDrivers.Length} autisti");

        // 5) Lettura dipendenti dal gestionale
        const string sql = """
    SELECT
    COGNOME_NOME       AS FullName,
    DATA_ASSUNZIONE    AS HireDate,
    DATA_LICENZIAMENTO AS FireDate,
    UPDATE_DATA_ORA    AS UpdateDateTime
    FROM Sgam.dbo.T2BaseDipendenti
    WHERE AUTISTA = 'S'
    """;

        using var db = new SqlConnection(ConnectionString);
        var employees = (await db.QueryAsync<Employee>(sql)).ToList();
        Console.WriteLine($"Gestionale: {employees.Count} dipendenti autisti");

        // filtra le righe modificate dopo l'ultima esecuzione
        employees = employees
            .Where(e => e.UpdateDateTime.HasValue && e.UpdateDateTime > lastUpdate)
            .ToList();
        Console.WriteLine($"Da aggiornare dopo {lastUpdate}: {employees.Count}");

        // 6) Calcolo differenze
        var changes = new List<(Driver drv, Employee emp)>();
        foreach (var emp in employees)
        {
            var parts = emp.FullName?.Split(' ', 2, StringSplitOptions.RemoveEmptyEntries);
            if (parts?.Length != 2) continue;
            var surname = parts[0];
            var name = parts[1];

            var match = goliaDrivers.FirstOrDefault(d =>
                string.Equals(d.name, name, StringComparison.OrdinalIgnoreCase) &&
                string.Equals(d.surname, surname, StringComparison.OrdinalIgnoreCase));

            if (match == null) continue;
            bool diff = match.assumptionDate != emp.HireDate ||
                        match.dismissalDate != emp.FireDate;
            if (diff) changes.Add((match, emp));
        }

        // Rimuove i duplicati di driverId prendendo la HireDate più recente
        var uniqueChanges = changes
            .GroupBy(c => c.drv.driverId)
            .Select(g => g.OrderByDescending(x => x.emp.HireDate).First())
            .ToList();

        Console.WriteLine($"Modifiche da applicare: {uniqueChanges.Count}");
        if (uniqueChanges.Count == 0) return;
        Console.Write("Procedere? (S/N): ");
        var key = Console.ReadKey().KeyChar;
        Console.WriteLine();
        if (char.ToUpperInvariant(key) != 'S')
        {
            Console.WriteLine("Annullato.");
            return;
        }

        // 7) SetDriver via SOAP
        int ok = 0, ko = 0;
        foreach (var (drv, emp) in uniqueChanges)
        {
            drv.assumptionDate = emp.HireDate;
            drv.dismissalDate = emp.FireDate;

            var setReq = new SetDriverRequest
            {
                loginCompanyRequest = loginCompanyRequest,
                driver = drv
            };



            SetDriverResult setRes;
            try
            {
                setRes = await client.SetDriverAsync(setReq);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"❌ Errore SetDriver {drv.surname} {drv.name}: {ex.Message}");
                ko++;
                await Task.Delay(TimeSpan.FromSeconds(5));
                continue;
            }
            if (!setRes.loginResult.success)
            {
                var errs = setRes.loginResult.errors ?? Array.Empty<string>();
                Console.Error.WriteLine($"✗ Errore SetDriver {drv.surname} {drv.name}: " + string.Join(", ", errs));
                ko++;
            }
            else if (setRes.driverUpdated)
            {
                Console.WriteLine($"✓ {drv.surname} {drv.name} aggiornato");
                ok++;
            }
            else
            {
                Console.WriteLine($"– {drv.surname} {drv.name} nulla da fare");
                ko++;
            }

            await Task.Delay(TimeSpan.FromSeconds(5));
        }

        Console.WriteLine($"Fatto. OK: {ok}, KO: {ko}");
        if (uniqueChanges.Count > 0)
        {
            var latest = uniqueChanges
                .Max(c => c.emp.UpdateDateTime) ?? lastUpdate;
            File.WriteAllText(dataFile, latest.ToString("yyyy-MM-dd HH:mm:ss.fff"));
        }
    }
        catch (Exception ex)
        {
            Console.Error.WriteLine($"Errore bloccante: {ex.Message}");
            try
            {
                SendErrorEmail(ex);
            }
            catch (Exception emailEx)
            {
                Console.Error.WriteLine("Errore invio email: " + emailEx.Message);
            }
        }

    }

    // Metodo helper per chiamare GetCompaniesAsync e salvare la cache
    static async Task<int> FetchAndCacheCompanyId(LoginRequest loginReq)
    {
        Console.WriteLine("Recupero lista società da Golia (solo 1 volta) …");
        using var client = new GoliaManagerSOAPClient();
        var compRes = await client.GetCompaniesAsync(loginReq);
        if (!compRes.loginResult.success || compRes.companies is null || compRes.companies.Length == 0)
            throw new Exception("Impossibile recuperare società da Golia.");

        // selezione interattiva
        var companies = compRes.companies;
        for (int i = 0; i < companies.Length; i++)
            Console.WriteLine($"{i + 1}) {companies[i].description} (ID {companies[i].companyId})");

        int choice;
        do
            Console.Write("Scelta società: ");
        while (!int.TryParse(Console.ReadLine(), out choice)
               || choice < 1 || choice > companies.Length);

        int selected = companies[choice - 1].companyId;
        File.WriteAllText("companyCache.json",
            JsonSerializer.Serialize(new CompanyCache { CompanyId = selected },
                                     new JsonSerializerOptions { WriteIndented = true }));
        Console.WriteLine($"CompanyId {selected} salvato in companyCache.json");
        return selected;
    }

    static void SendErrorEmail(Exception ex)
    {
        using var message = new MailMessage();
        message.From = new MailAddress("AnagraficaGolia@paratorispa.it");
        message.To.Add("omar.tagliabue@paratorispa.it");
        message.Subject = "Errore AggiornaAnagraficaGolia";
        message.Body = ex.ToString();

        using var smtp = new SmtpClient("192.168.1.11");
        smtp.Credentials = new NetworkCredential("scanner@paraspa.local", "],M4`V~8q967");
        smtp.Send(message);
    }

}
