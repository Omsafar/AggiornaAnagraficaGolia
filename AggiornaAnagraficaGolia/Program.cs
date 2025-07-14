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
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

internal sealed record Employee(string FullName,
                                DateTime? HireDate,
                                DateTime? FireDate);

// piccola classe per serializzare il cache file
public class CompanyCache
{
    public int CompanyId { get; set; }
}

public class RestWrapper<T>
{
    public T @return { get; set; }
}

public class GetDriversRestResult
{
    public LoginResult loginResult { get; set; }
    public Driver[] drivers { get; set; }
}

public class SetDriverRestResult
{
    public LoginResult loginResult { get; set; }
    public bool driverUpdated { get; set; }
}

class Program
{
    private const string ConnectionString =
       "Server=192.168.1.24\\sgam;Database=Sgam;User Id=sapara;Password=S@p4ra;Encrypt=True;TrustServerCertificate=True;";
    static async Task Main()
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

        // 3) Client HTTP per REST
        using var http = new HttpClient { BaseAddress = new Uri("https://manager.golia.goliaweb.it/") };

        // 4) GetDrivers via REST
        var getDriversPayload = new
        {
            request = new
            {
                loginCredentials = new { login = user, password = pwd },
                companyId,
                gmCulture = new
                {
                    infringmentNation = "ITA",
                    timeZone = "W. Europe Standard Time",
                    translationLanguage = "it-IT"
                }
            }
        };

        var getResp = await http.PostAsJsonAsync("services/GoliaManagerREST/GetDrivers", getDriversPayload);
        getResp.EnsureSuccessStatusCode();

        // Leggo il JSON grezzo
        var rawJson = await getResp.Content.ReadAsStringAsync();
        using var doc = JsonDocument.Parse(rawJson);
        var root = doc.RootElement.GetProperty("GetDriversResult");

        // Controllo loginResult
        var loginResultElem = root.GetProperty("loginResult");
        bool success = loginResultElem.GetProperty("success").GetBoolean();
        if (!success)
        {
            var errors = loginResultElem.GetProperty("errors")
                                       .EnumerateArray()
                                       .Select(e => e.GetString())
                                       .Where(s => s != null);
            Console.Error.WriteLine("Errore REST GetDrivers: " + string.Join(", ", errors));
            return;
        }

        // Deserializzo l'array drivers
        var driversElem = root.GetProperty("drivers");
        var goliaDrivers = driversElem.ValueKind == JsonValueKind.Array
            ? driversElem.Deserialize<Driver[]>() ?? Array.Empty<Driver>()
            : Array.Empty<Driver>();

        Console.WriteLine($"REST: trovati {goliaDrivers.Length} autisti");

        // 5) Lettura dipendenti dal gestionale
        const string sql = """
    SELECT 
        COGNOME_NOME    AS FullName,
        DATA_ASSUNZIONE AS HireDate,
        DATA_LICENZIAMENTO AS FireDate
    FROM Sgam.dbo.T2BaseDipendenti
    WHERE AUTISTA = 'S'
    """;

        using var db = new SqlConnection(ConnectionString);
        var employees = (await db.QueryAsync<Employee>(sql)).ToList();
        Console.WriteLine($"Gestionale: {employees.Count} dipendenti autisti");

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

        Console.WriteLine($"Modifiche da applicare: {changes.Count}");
        if (changes.Count == 0) return;

        Console.Write("Procedere? (S/N): ");
        var key = Console.ReadKey().KeyChar;
        Console.WriteLine();
        if (char.ToUpperInvariant(key) != 'S')
        {
            Console.WriteLine("Annullato.");
            return;
        }

        // 7) SetDriver via REST
        int ok = 0, ko = 0;
        foreach (var (drv, emp) in changes)
        {
            drv.assumptionDate = emp.HireDate;
            drv.dismissalDate = emp.FireDate;

            var setPayload = new
            {
                request = new
                {
                    loginCompanyRequest = new
                    {
                        loginCredentials = new { login = user, password = pwd },
                        companyId,
                        gmCulture = new
                        {
                            infringmentNation = "ITA",
                            timeZone = "W. Europe Standard Time",
                            translationLanguage = "it-IT"
                        }
                    },
                    driver = new
                    {
                        driverId = drv.driverId,
                        assumptionDate = drv.assumptionDate,
                        dismissalDate = drv.dismissalDate
                    }
                }
            };



HttpResponseMessage setResp;
            string rawSet;
            try
            {
                setResp = await http.PostAsJsonAsync("services/GoliaManagerREST/SetDriver", setPayload);
                rawSet = await setResp.Content.ReadAsStringAsync();
                if (!setResp.IsSuccessStatusCode)
                {
                    Console.Error.WriteLine("❌ SetDriver BAD REQUEST (400)");
                    Console.Error.WriteLine("-- Payload JSON --");
                    Console.Error.WriteLine(JsonSerializer.Serialize(setPayload, new JsonSerializerOptions { WriteIndented = true }));
                    Console.Error.WriteLine("-- Response body --");
                    Console.Error.WriteLine(rawSet);
                    continue;
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("❌ Errore durante PostAsJsonAsync:");
                Console.Error.WriteLine(ex);
                continue;
            }
            using var docSet = JsonDocument.Parse(rawSet);
            var rootSet = docSet.RootElement.GetProperty("SetDriverResult");

            var loginResSet = rootSet.GetProperty("loginResult");
            bool setOk = loginResSet.GetProperty("success").GetBoolean();
            if (!setOk)
            {
                var errs = loginResSet.GetProperty("errors")
                                     .EnumerateArray()
                                     .Select(e => e.GetString())
                                     .Where(s => s != null);
                Console.Error.WriteLine($"✗ Errore SetDriver {drv.surname} {drv.name}: " + string.Join(", ", errs));
                ko++;
                continue;
            }

            bool updated = rootSet.GetProperty("driverUpdated").GetBoolean();
            if (updated)
            {
                Console.WriteLine($"✓ {drv.surname} {drv.name} aggiornato");
                ok++;
            }
            else
            {
                Console.WriteLine($"– {drv.surname} {drv.name} nulla da fare");
                ko++;
            }
        }

        Console.WriteLine($"Fatto. OK: {ok}, KO: {ko}");
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

}
