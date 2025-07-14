#nullable disable


namespace GoliaService
{
    using System.Runtime.Serialization;
    using System.ServiceModel;


    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LoginRequest", Namespace="https://www.golia.goliaweb.it/")]
    public partial class LoginRequest : object
    {
        
        private string loginField;
        
        private string passwordField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string login
        {
            get
            {
                return this.loginField;
            }
            set
            {
                this.loginField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string password
        {
            get
            {
                return this.passwordField;
            }
            set
            {
                this.passwordField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TimeZoneListResult", Namespace="https://www.golia.goliaweb.it/")]
    public partial class TimeZoneListResult : object
    {
        
        private GoliaService.LoginResult loginResultField;
        
        private GoliaService.TimeZoneListItem[] timeZonesField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.LoginResult loginResult
        {
            get
            {
                return this.loginResultField;
            }
            set
            {
                this.loginResultField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.TimeZoneListItem[] timeZones
        {
            get
            {
                return this.timeZonesField;
            }
            set
            {
                this.timeZonesField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LoginResult", Namespace="https://www.golia.goliaweb.it/")]
    public partial class LoginResult : object
    {
        
        private string descriptionField;
        
        private string[] errorsField;
        
        private System.Nullable<System.DateTime> expireDateField;
        
        private int numLoginAttemptsField;
        
        private bool successField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] errors
        {
            get
            {
                return this.errorsField;
            }
            set
            {
                this.errorsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> expireDate
        {
            get
            {
                return this.expireDateField;
            }
            set
            {
                this.expireDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int numLoginAttempts
        {
            get
            {
                return this.numLoginAttemptsField;
            }
            set
            {
                this.numLoginAttemptsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool success
        {
            get
            {
                return this.successField;
            }
            set
            {
                this.successField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TimeZoneListItem", Namespace="https://www.golia.goliaweb.it/")]
    public partial class TimeZoneListItem : object
    {
        
        private string ianaField;
        
        private string timeZoneField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string iana
        {
            get
            {
                return this.ianaField;
            }
            set
            {
                this.ianaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string timeZone
        {
            get
            {
                return this.timeZoneField;
            }
            set
            {
                this.timeZoneField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetCompaniesResult", Namespace="https://www.golia.goliaweb.it/")]
    public partial class GetCompaniesResult : object
    {
        
        private GoliaService.Company[] companiesField;
        
        private GoliaService.LoginResult loginResultField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.Company[] companies
        {
            get
            {
                return this.companiesField;
            }
            set
            {
                this.companiesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.LoginResult loginResult
        {
            get
            {
                return this.loginResultField;
            }
            set
            {
                this.loginResultField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Company", Namespace="https://www.golia.goliaweb.it/")]
    public partial class Company : object
    {
        
        private bool activeField;
        
        private string addressField;
        
        private int affiliateField;
        
        private int companyIdField;
        
        private string countryField;
        
        private string customerIdField;
        
        private string descriptionField;
        
        private string emailField;
        
        private System.Nullable<System.DateTime> expireDateField;
        
        private string fiscalCodeField;
        
        private string localityField;
        
        private GoliaService.CompanyParameter[] parametersField;
        
        private string phoneNumberField;
        
        private string postalCodeField;
        
        private string provinceField;
        
        private string referenceField;
        
        private string vatField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool active
        {
            get
            {
                return this.activeField;
            }
            set
            {
                this.activeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int affiliate
        {
            get
            {
                return this.affiliateField;
            }
            set
            {
                this.affiliateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int companyId
        {
            get
            {
                return this.companyIdField;
            }
            set
            {
                this.companyIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string customerId
        {
            get
            {
                return this.customerIdField;
            }
            set
            {
                this.customerIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> expireDate
        {
            get
            {
                return this.expireDateField;
            }
            set
            {
                this.expireDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string fiscalCode
        {
            get
            {
                return this.fiscalCodeField;
            }
            set
            {
                this.fiscalCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string locality
        {
            get
            {
                return this.localityField;
            }
            set
            {
                this.localityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.CompanyParameter[] parameters
        {
            get
            {
                return this.parametersField;
            }
            set
            {
                this.parametersField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string phoneNumber
        {
            get
            {
                return this.phoneNumberField;
            }
            set
            {
                this.phoneNumberField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string postalCode
        {
            get
            {
                return this.postalCodeField;
            }
            set
            {
                this.postalCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string province
        {
            get
            {
                return this.provinceField;
            }
            set
            {
                this.provinceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string reference
        {
            get
            {
                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string vat
        {
            get
            {
                return this.vatField;
            }
            set
            {
                this.vatField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompanyParameter", Namespace="https://www.golia.goliaweb.it/")]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.RestoreAnagraficaResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.DeleteAnagraficaResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.LoginRequest))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.TimeZoneListResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.LoginResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.TimeZoneListItem[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.TimeZoneListItem))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.GetCompaniesResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.Company[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.Company))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.CompanyParameter[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.LoginCompanyCultureRequest))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.GMCulture))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.GetDriversResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.Driver[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.Driver))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.GetVehiclesResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.Vehicle[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.Vehicle))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.VehicleRevision[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.VehicleRevision))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.Tachograph))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.VehicleTypology))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.SendTachoFileRequest))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.SendTachoFileResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.TachoFileResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.DriverTachoFile[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.DriverTachoFile))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.VehicleTachoFile[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.VehicleTachoFile))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.WarningTachoFile[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.WarningTachoFile))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.SendTachoRealtimeRequest))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.TachoRealtimeMovement[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.TachoRealtimeMovement))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.RealtimePosition))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.TachographSlot))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.SendTachoRealtimeResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.TachoRealtimeResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.TachoRealtimeError[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.TachoRealtimeError))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.GetInfringmentsRequest))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.GetInfringmentsResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.InfringmentsResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.Infringment[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.Infringment))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.ImageDay[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.ImageDay))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.ImageMapSpot[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.ImageMapSpot))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.GetDriverPlafondRequest))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.GetDriverPlafondResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.PlafondResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.DriverPlafond[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.DriverPlafond))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.TachoFileDownloadStatus))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.DetectionActState))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.TypeNextRest))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.WeeklyRestInfo))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.WeeklyRestInfo[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.DriverPlafondView[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.DriverPlafondView))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.DriverPlafondView1))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.DriverPlafondView2))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.DriverPlafondView3))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.DriverPlafondView4))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.DriverPlafondView4Bonus))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.DriverPlafondView4DateCalc))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.DriverPlafondView4EndWD))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.DriverPlafondView4ResWD))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.DriverPlafondView4StartWD))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.DriverPlafondView5))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.DriverPlafondView5Bonus))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.DriverPlafondView5DayDrive))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.DriverPlafondView5ResDrive))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.DriverPlafondView6))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.DriverPlafondView7))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.DriverPlafondView7.DriverPlafondView7BiWeeklyDrive))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.DriverPlafondView7.DriverPlafondView7ResDrive))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.DriverPlafondView8))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.DriverPlafondView9[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.DriverPlafondView9))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.GetActivitiesRequest))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.driverRequest))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.vehicleRequest))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.GetActivitiesResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.ActivitiesResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.ActivityDay[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.ActivityDay))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.ActivityCountry[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.ActivityCountry))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.ActivityAnalogicDisk[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.ActivityAnalogicDisk))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.ActivityDriver[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.ActivityDriver))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.ActivityVehicle[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.ActivityVehicle))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.GetTimelineRequest))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.TimelineOptions))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.TimelineOptionsGeofencing))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.TimelineOptionsLul))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.TimelineOptionsNationRealtime))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.GetTimelineResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.TimelineResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.ActivityAbsence[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.ActivityAbsence))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.TimelineActivity[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.TimelineActivity))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.ActivityAttachments[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.ActivityAttachments))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.ActivityAttachmentsDetail[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.ActivityAttachmentsDetail))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.ActivityComments[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.ActivityComments))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.ActivityCommentsDetail[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.ActivityCommentsDetail))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.ActivityEvents[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.ActivityEvents))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.TimelineInfringment[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.TimelineInfringment))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.TimelineInsertionExtraction[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.TimelineInsertionExtraction))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.TimelineKmDay[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.TimelineKmDay))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.VehicleDriverKm[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.VehicleDriverKm))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.OdometerDate[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.OdometerDate))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.ActivityPositionDay[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.ActivityPositionDay))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.ActivityPositionNation[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.ActivityPositionNation))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.ActivityPositionNationPeriod[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.ActivityPositionNationPeriod))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.ActivityOverwrited[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.ActivityOverwrited))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.TimelineSummary[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.TimelineSummary))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.ActivityGeofencing))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.TimelineSummaryRestType))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.ActivityTachoFiles[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.ActivityTachoFiles))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.GetDriverActivityRequest))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.GetDriverActivityResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.DriverIdentityActivity[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.DriverIdentityActivity))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.DriverActivity[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.DriverActivity))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.DriverActivityVehicle[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.DriverActivityVehicle))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.GetMissingTachoFilePeriodsRequest))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.GetMissingTachoFilePeriodsResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.MissingTachoFile[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.MissingTachoFile))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.DetailTachoFilePeriod[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.DetailTachoFilePeriod))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.TachoFile))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.MissingTachoFilePeriod[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.MissingTachoFilePeriod))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.SetVehicleRequest))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.SetVehicleResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.SetDriverRequest))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.SetDriverResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.InsertCompanyUserRequest))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.User))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.InsertCompanyUserResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.GetTachoFileRequest))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.GetTachoFileResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.GetDiskFileRequest))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.GetDiskFileResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.DiskFile))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.GetTachoFileTextExplainResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.GetInfringmentsReportRequest))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.GetInfringmentsReportResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.SendPositionsRequest))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.SendPositionsPosition[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.SendPositionsPosition))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.SendPositionsResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.SendPositionsStatus))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.SendPositionsError[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.SendPositionsError))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.AuthTokenRequest))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.AuthTokenResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.GetVehiclesLastPositionRequest))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.GetVehiclesLastPositionResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.vehiclePosition[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.vehiclePosition))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.GetVehiclePositionsRequest))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.GetVehiclePositionsResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.GetNormalizedVehicleParametersRequest))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.GetNormalizedVehicleParametersResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.VehicleParameter[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.VehicleParameter))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.GetVehiclesDataRequest))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.GetVehiclesDataOptions))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.GetVehiclesDataResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.NormalizedData[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.NormalizedData))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.NormalizedDataParameter[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.NormalizedDataParameter))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.RawData[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.RawData))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.SendDocumentRequest))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.SendDocumentResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.DownloadDocumentRequest))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.DownloadDocumentResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.DeleteDocumentRequest))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.DeleteDocumentResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.GetReportsRequest))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.GetReportsResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.reportDetail[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.reportDetail))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.reportParameter[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.reportParameter))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.reportCategory[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.reportCategory))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.ExecReportRequest))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.ExecReportParameter[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.ExecReportParameter))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.ExecReportResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.SendSanificationDataRequest))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.SendSanificationDataResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.GetVehicleLastSanificationRequest))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.GetVehicleLastSanificationResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.sanification))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.ExecReportDriversWorkingDayRequest))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.ExecReportDriversWorkingDayResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.ExecReportDriversRestWeekRequest))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.ExecReportDriversRestWeekResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.ReportDriversRestWeekResult[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.ReportDriversRestWeekResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.ReportArrayWeek))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.GetNationsFromPositionRequest))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.GetNationsFromPositionResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.ActivityPosition))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.GetTachoFilesRequest))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.GetTachoFilesResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.TachoFile[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.GetAutistiCamionsPlaceRequest))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.GetAutistiCamionsPlaceResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.GetLockVehicleRequest))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.GetLockVehicleResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.GetFaultEventRequest))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.GetFaultEventResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.RestoreAnagraficaRequest))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.DeleteAnagraficaRequest))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.AutistiCamionsPlace[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.AutistiCamionsPlace))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.Lock[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.Lock))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.FaultEvent[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.FaultEvent))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GoliaService.AnomalyType))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(string[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(System.DateTime[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(int[]))]
    public partial class CompanyParameter : object
    {
        
        private bool cleafixField;
        
        private int contextField;
        
        private string descriptionField;
        
        private string nameField;
        
        private bool onlyHelpdeskField;
        
        private int parameterField;
        
        private object queryValueField;
        
        private bool readOnlyField;
        
        private string typeField;
        
        private string valueField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public bool cleafix
        {
            get
            {
                return this.cleafixField;
            }
            set
            {
                this.cleafixField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int context
        {
            get
            {
                return this.contextField;
            }
            set
            {
                this.contextField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public bool onlyHelpdesk
        {
            get
            {
                return this.onlyHelpdeskField;
            }
            set
            {
                this.onlyHelpdeskField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int parameter
        {
            get
            {
                return this.parameterField;
            }
            set
            {
                this.parameterField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public object queryValue
        {
            get
            {
                return this.queryValueField;
            }
            set
            {
                this.queryValueField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public bool readOnly
        {
            get
            {
                return this.readOnlyField;
            }
            set
            {
                this.readOnlyField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RestoreAnagraficaResult", Namespace="http://www.gestionale.goliaweb.com/")]
    public partial class RestoreAnagraficaResult : object
    {
        
        private GoliaService.LoginResult loginResultField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.LoginResult loginResult
        {
            get
            {
                return this.loginResultField;
            }
            set
            {
                this.loginResultField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DeleteAnagraficaResult", Namespace="http://www.gestionale.goliaweb.com/")]
    public partial class DeleteAnagraficaResult : object
    {
        
        private GoliaService.LoginResult loginResultField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.LoginResult loginResult
        {
            get
            {
                return this.loginResultField;
            }
            set
            {
                this.loginResultField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LoginCompanyCultureRequest", Namespace="https://www.golia.goliaweb.it/")]
    public partial class LoginCompanyCultureRequest : object
    {
        
        private int companyIdField;
        
        private string countryField;
        
        private GoliaService.GMCulture gmCultureField;
        
        private GoliaService.LoginRequest loginCredentialsField;
        
        private string vatField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int companyId
        {
            get
            {
                return this.companyIdField;
            }
            set
            {
                this.companyIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.GMCulture gmCulture
        {
            get
            {
                return this.gmCultureField;
            }
            set
            {
                this.gmCultureField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.LoginRequest loginCredentials
        {
            get
            {
                return this.loginCredentialsField;
            }
            set
            {
                this.loginCredentialsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string vat
        {
            get
            {
                return this.vatField;
            }
            set
            {
                this.vatField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GMCulture", Namespace="https://www.golia.goliaweb.it/")]
    public partial class GMCulture : object
    {
        
        private string infringmentNationField;
        
        private string timeZoneField;
        
        private string translationLanguageField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string infringmentNation
        {
            get
            {
                return this.infringmentNationField;
            }
            set
            {
                this.infringmentNationField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string timeZone
        {
            get
            {
                return this.timeZoneField;
            }
            set
            {
                this.timeZoneField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string translationLanguage
        {
            get
            {
                return this.translationLanguageField;
            }
            set
            {
                this.translationLanguageField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetDriversResult", Namespace="https://www.golia.goliaweb.it/")]
    public partial class GetDriversResult : object
    {
        
        private GoliaService.Driver[] driversField;
        
        private GoliaService.LoginResult loginResultField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.Driver[] drivers
        {
            get
            {
                return this.driversField;
            }
            set
            {
                this.driversField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.LoginResult loginResult
        {
            get
            {
                return this.loginResultField;
            }
            set
            {
                this.loginResultField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Driver", Namespace="https://www.golia.goliaweb.it/")]
    public partial class Driver : object
    {
        
        private string addressField;
        
        private string areaField;
        
        private string areaIdField;
        
        private System.Nullable<System.DateTime> assumptionDateField;
        
        private System.Nullable<System.DateTime> birthDateField;
        
        private string branchField;
        
        private string branchIdField;
        
        private System.Nullable<System.DateTime> cardExpiryDateField;
        
        private string cardIdField;
        
        private System.Nullable<System.DateTime> cpcExpiryDateField;
        
        private string cpcNumberField;
        
        private string customerIdField;
        
        private System.Nullable<System.DateTime> dismissalDateField;
        
        private int driverIdField;
        
        private System.Nullable<System.DateTime> drivingLicenceExpiryDateField;
        
        private string drivingLicenceNumberField;
        
        private string fiscalCodeField;
        
        private string localityField;
        
        private System.Nullable<System.DateTime> maxActivityDateField;
        
        private string nameField;
        
        private string provinceField;
        
        private System.Nullable<int> secondary_companyField;
        
        private string surnameField;
        
        private System.Nullable<System.DateTime> tachoFileLastActivityDateField;
        
        private System.Nullable<System.DateTime> tachoFileLastUploadDateField;
        
        private bool visibleField;
        
        private string zipCodeField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string area
        {
            get
            {
                return this.areaField;
            }
            set
            {
                this.areaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string areaId
        {
            get
            {
                return this.areaIdField;
            }
            set
            {
                this.areaIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> assumptionDate
        {
            get
            {
                return this.assumptionDateField;
            }
            set
            {
                this.assumptionDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> birthDate
        {
            get
            {
                return this.birthDateField;
            }
            set
            {
                this.birthDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string branch
        {
            get
            {
                return this.branchField;
            }
            set
            {
                this.branchField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string branchId
        {
            get
            {
                return this.branchIdField;
            }
            set
            {
                this.branchIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> cardExpiryDate
        {
            get
            {
                return this.cardExpiryDateField;
            }
            set
            {
                this.cardExpiryDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cardId
        {
            get
            {
                return this.cardIdField;
            }
            set
            {
                this.cardIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> cpcExpiryDate
        {
            get
            {
                return this.cpcExpiryDateField;
            }
            set
            {
                this.cpcExpiryDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cpcNumber
        {
            get
            {
                return this.cpcNumberField;
            }
            set
            {
                this.cpcNumberField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string customerId
        {
            get
            {
                return this.customerIdField;
            }
            set
            {
                this.customerIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> dismissalDate
        {
            get
            {
                return this.dismissalDateField;
            }
            set
            {
                this.dismissalDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int driverId
        {
            get
            {
                return this.driverIdField;
            }
            set
            {
                this.driverIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> drivingLicenceExpiryDate
        {
            get
            {
                return this.drivingLicenceExpiryDateField;
            }
            set
            {
                this.drivingLicenceExpiryDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string drivingLicenceNumber
        {
            get
            {
                return this.drivingLicenceNumberField;
            }
            set
            {
                this.drivingLicenceNumberField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string fiscalCode
        {
            get
            {
                return this.fiscalCodeField;
            }
            set
            {
                this.fiscalCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string locality
        {
            get
            {
                return this.localityField;
            }
            set
            {
                this.localityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> maxActivityDate
        {
            get
            {
                return this.maxActivityDateField;
            }
            set
            {
                this.maxActivityDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string province
        {
            get
            {
                return this.provinceField;
            }
            set
            {
                this.provinceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> secondary_company
        {
            get
            {
                return this.secondary_companyField;
            }
            set
            {
                this.secondary_companyField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string surname
        {
            get
            {
                return this.surnameField;
            }
            set
            {
                this.surnameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> tachoFileLastActivityDate
        {
            get
            {
                return this.tachoFileLastActivityDateField;
            }
            set
            {
                this.tachoFileLastActivityDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> tachoFileLastUploadDate
        {
            get
            {
                return this.tachoFileLastUploadDateField;
            }
            set
            {
                this.tachoFileLastUploadDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public bool visible
        {
            get
            {
                return this.visibleField;
            }
            set
            {
                this.visibleField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string zipCode
        {
            get
            {
                return this.zipCodeField;
            }
            set
            {
                this.zipCodeField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetVehiclesResult", Namespace="https://www.golia.goliaweb.it/")]
    public partial class GetVehiclesResult : object
    {
        
        private GoliaService.LoginResult loginResultField;
        
        private GoliaService.Vehicle[] vehiclesField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.LoginResult loginResult
        {
            get
            {
                return this.loginResultField;
            }
            set
            {
                this.loginResultField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.Vehicle[] vehicles
        {
            get
            {
                return this.vehiclesField;
            }
            set
            {
                this.vehiclesField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Vehicle", Namespace="https://www.golia.goliaweb.it/")]
    public partial class Vehicle : object
    {
        
        private string areaField;
        
        private string areaIdField;
        
        private string branchField;
        
        private string branchIdField;
        
        private string brandField;
        
        private string categoryField;
        
        private string chassisField;
        
        private string countryField;
        
        private string customerIdField;
        
        private System.Nullable<System.DateTime> disposalDateField;
        
        private System.Nullable<System.DateTime> maxActivityDateField;
        
        private string modelField;
        
        private int odometerField;
        
        private string plateField;
        
        private System.Nullable<System.DateTime> realtimeLastActivityDateField;
        
        private System.Nullable<System.DateTime> realtimeLastUploadDateField;
        
        private System.Nullable<System.DateTime> registrationDateField;
        
        private GoliaService.VehicleRevision[] revisionsField;
        
        private System.Nullable<System.DateTime> startDateField;
        
        private System.Nullable<System.DateTime> tachoFileLastActivityDateField;
        
        private System.Nullable<System.DateTime> tachoFileLastUploadDateField;
        
        private GoliaService.Tachograph tachographField;
        
        private string trailerIdField;
        
        private int typeIdField;
        
        private GoliaService.VehicleTypology typologyField;
        
        private int vehicleIdField;
        
        private bool visibleField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string area
        {
            get
            {
                return this.areaField;
            }
            set
            {
                this.areaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string areaId
        {
            get
            {
                return this.areaIdField;
            }
            set
            {
                this.areaIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string branch
        {
            get
            {
                return this.branchField;
            }
            set
            {
                this.branchField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string branchId
        {
            get
            {
                return this.branchIdField;
            }
            set
            {
                this.branchIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string brand
        {
            get
            {
                return this.brandField;
            }
            set
            {
                this.brandField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string category
        {
            get
            {
                return this.categoryField;
            }
            set
            {
                this.categoryField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string chassis
        {
            get
            {
                return this.chassisField;
            }
            set
            {
                this.chassisField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string customerId
        {
            get
            {
                return this.customerIdField;
            }
            set
            {
                this.customerIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> disposalDate
        {
            get
            {
                return this.disposalDateField;
            }
            set
            {
                this.disposalDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> maxActivityDate
        {
            get
            {
                return this.maxActivityDateField;
            }
            set
            {
                this.maxActivityDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string model
        {
            get
            {
                return this.modelField;
            }
            set
            {
                this.modelField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int odometer
        {
            get
            {
                return this.odometerField;
            }
            set
            {
                this.odometerField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string plate
        {
            get
            {
                return this.plateField;
            }
            set
            {
                this.plateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> realtimeLastActivityDate
        {
            get
            {
                return this.realtimeLastActivityDateField;
            }
            set
            {
                this.realtimeLastActivityDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> realtimeLastUploadDate
        {
            get
            {
                return this.realtimeLastUploadDateField;
            }
            set
            {
                this.realtimeLastUploadDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> registrationDate
        {
            get
            {
                return this.registrationDateField;
            }
            set
            {
                this.registrationDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.VehicleRevision[] revisions
        {
            get
            {
                return this.revisionsField;
            }
            set
            {
                this.revisionsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> startDate
        {
            get
            {
                return this.startDateField;
            }
            set
            {
                this.startDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> tachoFileLastActivityDate
        {
            get
            {
                return this.tachoFileLastActivityDateField;
            }
            set
            {
                this.tachoFileLastActivityDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> tachoFileLastUploadDate
        {
            get
            {
                return this.tachoFileLastUploadDateField;
            }
            set
            {
                this.tachoFileLastUploadDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.Tachograph tachograph
        {
            get
            {
                return this.tachographField;
            }
            set
            {
                this.tachographField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string trailerId
        {
            get
            {
                return this.trailerIdField;
            }
            set
            {
                this.trailerIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int typeId
        {
            get
            {
                return this.typeIdField;
            }
            set
            {
                this.typeIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.VehicleTypology typology
        {
            get
            {
                return this.typologyField;
            }
            set
            {
                this.typologyField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int vehicleId
        {
            get
            {
                return this.vehicleIdField;
            }
            set
            {
                this.vehicleIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public bool visible
        {
            get
            {
                return this.visibleField;
            }
            set
            {
                this.visibleField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="VehicleRevision", Namespace="https://www.golia.goliaweb.it/")]
    public partial class VehicleRevision : object
    {
        
        private string addressField;
        
        private string cardField;
        
        private System.Nullable<System.DateTime> cardExpiryDateField;
        
        private System.Nullable<System.DateTime> revisionDateField;
        
        private string tiresField;
        
        private string workshopField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string card
        {
            get
            {
                return this.cardField;
            }
            set
            {
                this.cardField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> cardExpiryDate
        {
            get
            {
                return this.cardExpiryDateField;
            }
            set
            {
                this.cardExpiryDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> revisionDate
        {
            get
            {
                return this.revisionDateField;
            }
            set
            {
                this.revisionDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string tires
        {
            get
            {
                return this.tiresField;
            }
            set
            {
                this.tiresField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string workshop
        {
            get
            {
                return this.workshopField;
            }
            set
            {
                this.workshopField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Tachograph", Namespace="https://www.golia.goliaweb.it/")]
    public partial class Tachograph : object
    {
        
        private string approvalNumberField;
        
        private string manufacturerAddressField;
        
        private string manufacturerNameField;
        
        private System.Nullable<System.DateTime> manufacturingDateField;
        
        private string partNumberField;
        
        private string registrationNumberField;
        
        private string sensorApprovalNumberField;
        
        private System.Nullable<System.DateTime> sensorJoiningDateField;
        
        private string sensorRegistrationNumberField;
        
        private System.Nullable<System.DateTime> softwareInstallationDateField;
        
        private string softwareVersionField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string approvalNumber
        {
            get
            {
                return this.approvalNumberField;
            }
            set
            {
                this.approvalNumberField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string manufacturerAddress
        {
            get
            {
                return this.manufacturerAddressField;
            }
            set
            {
                this.manufacturerAddressField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string manufacturerName
        {
            get
            {
                return this.manufacturerNameField;
            }
            set
            {
                this.manufacturerNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> manufacturingDate
        {
            get
            {
                return this.manufacturingDateField;
            }
            set
            {
                this.manufacturingDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string partNumber
        {
            get
            {
                return this.partNumberField;
            }
            set
            {
                this.partNumberField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string registrationNumber
        {
            get
            {
                return this.registrationNumberField;
            }
            set
            {
                this.registrationNumberField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string sensorApprovalNumber
        {
            get
            {
                return this.sensorApprovalNumberField;
            }
            set
            {
                this.sensorApprovalNumberField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> sensorJoiningDate
        {
            get
            {
                return this.sensorJoiningDateField;
            }
            set
            {
                this.sensorJoiningDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string sensorRegistrationNumber
        {
            get
            {
                return this.sensorRegistrationNumberField;
            }
            set
            {
                this.sensorRegistrationNumberField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> softwareInstallationDate
        {
            get
            {
                return this.softwareInstallationDateField;
            }
            set
            {
                this.softwareInstallationDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string softwareVersion
        {
            get
            {
                return this.softwareVersionField;
            }
            set
            {
                this.softwareVersionField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="VehicleTypology", Namespace="https://www.golia.goliaweb.it/")]
    public enum VehicleTypology : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Standard = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Pullman = 1,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SendTachoFileRequest", Namespace="https://www.golia.goliaweb.it/")]
    public partial class SendTachoFileRequest : object
    {
        
        private string ProvenienceCodeField;
        
        private int companyIdField;
        
        private string countryField;
        
        private byte[] fileContentField;
        
        private string fileNameField;
        
        private GoliaService.GMCulture gmCultureField;
        
        private GoliaService.LoginRequest loginCredentialsField;
        
        private bool notReturnInfoField;
        
        private string vatField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string ProvenienceCode
        {
            get
            {
                return this.ProvenienceCodeField;
            }
            set
            {
                this.ProvenienceCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int companyId
        {
            get
            {
                return this.companyIdField;
            }
            set
            {
                this.companyIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public byte[] fileContent
        {
            get
            {
                return this.fileContentField;
            }
            set
            {
                this.fileContentField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string fileName
        {
            get
            {
                return this.fileNameField;
            }
            set
            {
                this.fileNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.GMCulture gmCulture
        {
            get
            {
                return this.gmCultureField;
            }
            set
            {
                this.gmCultureField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.LoginRequest loginCredentials
        {
            get
            {
                return this.loginCredentialsField;
            }
            set
            {
                this.loginCredentialsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool notReturnInfo
        {
            get
            {
                return this.notReturnInfoField;
            }
            set
            {
                this.notReturnInfoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string vat
        {
            get
            {
                return this.vatField;
            }
            set
            {
                this.vatField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SendTachoFileResult", Namespace="https://www.golia.goliaweb.it/")]
    public partial class SendTachoFileResult : object
    {
        
        private GoliaService.LoginResult loginResultField;
        
        private GoliaService.TachoFileResult tachoFileResultField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.LoginResult loginResult
        {
            get
            {
                return this.loginResultField;
            }
            set
            {
                this.loginResultField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.TachoFileResult tachoFileResult
        {
            get
            {
                return this.tachoFileResultField;
            }
            set
            {
                this.tachoFileResultField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TachoFileResult", Namespace="https://www.golia.goliaweb.it/")]
    public partial class TachoFileResult : object
    {
        
        private string cardIdField;
        
        private string chassisField;
        
        private string[] digitalSignatureErrorsField;
        
        private int driverIdField;
        
        private GoliaService.DriverTachoFile[] driversTachoFileField;
        
        private bool fileAlreadySentField;
        
        private int idField;
        
        private string nameField;
        
        private System.Nullable<System.DateTime> periodEndField;
        
        private System.Nullable<System.DateTime> periodPrecInspectionField;
        
        private System.Nullable<System.DateTime> periodStartField;
        
        private string plateField;
        
        private bool successField;
        
        private string surnameField;
        
        private int vehicleIdField;
        
        private GoliaService.VehicleTachoFile[] vehiclesTachoFileField;
        
        private GoliaService.WarningTachoFile[] warningsField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cardId
        {
            get
            {
                return this.cardIdField;
            }
            set
            {
                this.cardIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string chassis
        {
            get
            {
                return this.chassisField;
            }
            set
            {
                this.chassisField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] digitalSignatureErrors
        {
            get
            {
                return this.digitalSignatureErrorsField;
            }
            set
            {
                this.digitalSignatureErrorsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int driverId
        {
            get
            {
                return this.driverIdField;
            }
            set
            {
                this.driverIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.DriverTachoFile[] driversTachoFile
        {
            get
            {
                return this.driversTachoFileField;
            }
            set
            {
                this.driversTachoFileField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool fileAlreadySent
        {
            get
            {
                return this.fileAlreadySentField;
            }
            set
            {
                this.fileAlreadySentField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> periodEnd
        {
            get
            {
                return this.periodEndField;
            }
            set
            {
                this.periodEndField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> periodPrecInspection
        {
            get
            {
                return this.periodPrecInspectionField;
            }
            set
            {
                this.periodPrecInspectionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> periodStart
        {
            get
            {
                return this.periodStartField;
            }
            set
            {
                this.periodStartField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string plate
        {
            get
            {
                return this.plateField;
            }
            set
            {
                this.plateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool success
        {
            get
            {
                return this.successField;
            }
            set
            {
                this.successField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string surname
        {
            get
            {
                return this.surnameField;
            }
            set
            {
                this.surnameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int vehicleId
        {
            get
            {
                return this.vehicleIdField;
            }
            set
            {
                this.vehicleIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.VehicleTachoFile[] vehiclesTachoFile
        {
            get
            {
                return this.vehiclesTachoFileField;
            }
            set
            {
                this.vehiclesTachoFileField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.WarningTachoFile[] warnings
        {
            get
            {
                return this.warningsField;
            }
            set
            {
                this.warningsField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DriverTachoFile", Namespace="https://www.golia.goliaweb.it/")]
    public partial class DriverTachoFile : object
    {
        
        private string cardIdField;
        
        private System.Nullable<System.DateTime> lastActivityDateField;
        
        private string lastAnalogicPlateField;
        
        private System.Nullable<System.DateTime> lastAnalogicUploadDateField;
        
        private string nameField;
        
        private string surnameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cardId
        {
            get
            {
                return this.cardIdField;
            }
            set
            {
                this.cardIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> lastActivityDate
        {
            get
            {
                return this.lastActivityDateField;
            }
            set
            {
                this.lastActivityDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string lastAnalogicPlate
        {
            get
            {
                return this.lastAnalogicPlateField;
            }
            set
            {
                this.lastAnalogicPlateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> lastAnalogicUploadDate
        {
            get
            {
                return this.lastAnalogicUploadDateField;
            }
            set
            {
                this.lastAnalogicUploadDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string surname
        {
            get
            {
                return this.surnameField;
            }
            set
            {
                this.surnameField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="VehicleTachoFile", Namespace="https://www.golia.goliaweb.it/")]
    public partial class VehicleTachoFile : object
    {
        
        private string chassisField;
        
        private System.Nullable<System.DateTime> lastActivityDateField;
        
        private string plateField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string chassis
        {
            get
            {
                return this.chassisField;
            }
            set
            {
                this.chassisField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> lastActivityDate
        {
            get
            {
                return this.lastActivityDateField;
            }
            set
            {
                this.lastActivityDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string plate
        {
            get
            {
                return this.plateField;
            }
            set
            {
                this.plateField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="WarningTachoFile", Namespace="https://www.golia.goliaweb.it/")]
    public partial class WarningTachoFile : object
    {
        
        private string identificationField;
        
        private string textField;
        
        private System.Nullable<System.DateTime> timestampField;
        
        private string value1Field;
        
        private string value2Field;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string identification
        {
            get
            {
                return this.identificationField;
            }
            set
            {
                this.identificationField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> timestamp
        {
            get
            {
                return this.timestampField;
            }
            set
            {
                this.timestampField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string value1
        {
            get
            {
                return this.value1Field;
            }
            set
            {
                this.value1Field = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string value2
        {
            get
            {
                return this.value2Field;
            }
            set
            {
                this.value2Field = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SendTachoRealtimeRequest", Namespace="https://www.golia.goliaweb.it/")]
    public partial class SendTachoRealtimeRequest : object
    {
        
        private GoliaService.TachoRealtimeMovement[] MovementsField;
        
        private string ProvenienceCodeField;
        
        private int companyIdField;
        
        private string countryField;
        
        private GoliaService.GMCulture gmCultureField;
        
        private GoliaService.LoginRequest loginCredentialsField;
        
        private string vatField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.TachoRealtimeMovement[] Movements
        {
            get
            {
                return this.MovementsField;
            }
            set
            {
                this.MovementsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string ProvenienceCode
        {
            get
            {
                return this.ProvenienceCodeField;
            }
            set
            {
                this.ProvenienceCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int companyId
        {
            get
            {
                return this.companyIdField;
            }
            set
            {
                this.companyIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.GMCulture gmCulture
        {
            get
            {
                return this.gmCultureField;
            }
            set
            {
                this.gmCultureField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.LoginRequest loginCredentials
        {
            get
            {
                return this.loginCredentialsField;
            }
            set
            {
                this.loginCredentialsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string vat
        {
            get
            {
                return this.vatField;
            }
            set
            {
                this.vatField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TachoRealtimeMovement", Namespace="https://www.golia.goliaweb.it/")]
    public partial class TachoRealtimeMovement : object
    {
        
        private string chassisField;
        
        private int ignitionField;
        
        private System.DateTime movementDateField;
        
        private string nationField;
        
        private int odometerField;
        
        private string plateField;
        
        private GoliaService.RealtimePosition positionField;
        
        private GoliaService.TachographSlot slot1Field;
        
        private GoliaService.TachographSlot slot2Field;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string chassis
        {
            get
            {
                return this.chassisField;
            }
            set
            {
                this.chassisField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int ignition
        {
            get
            {
                return this.ignitionField;
            }
            set
            {
                this.ignitionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.DateTime movementDate
        {
            get
            {
                return this.movementDateField;
            }
            set
            {
                this.movementDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nation
        {
            get
            {
                return this.nationField;
            }
            set
            {
                this.nationField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int odometer
        {
            get
            {
                return this.odometerField;
            }
            set
            {
                this.odometerField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string plate
        {
            get
            {
                return this.plateField;
            }
            set
            {
                this.plateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.RealtimePosition position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.TachographSlot slot1
        {
            get
            {
                return this.slot1Field;
            }
            set
            {
                this.slot1Field = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.TachographSlot slot2
        {
            get
            {
                return this.slot2Field;
            }
            set
            {
                this.slot2Field = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RealtimePosition", Namespace="https://www.golia.goliaweb.it/")]
    public partial class RealtimePosition : object
    {
        
        private double altitudeField;
        
        private double headingField;
        
        private double latitudeField;
        
        private double longitudeField;
        
        private double speedField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double altitude
        {
            get
            {
                return this.altitudeField;
            }
            set
            {
                this.altitudeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double heading
        {
            get
            {
                return this.headingField;
            }
            set
            {
                this.headingField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public double latitude
        {
            get
            {
                return this.latitudeField;
            }
            set
            {
                this.latitudeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public double longitude
        {
            get
            {
                return this.longitudeField;
            }
            set
            {
                this.longitudeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double speed
        {
            get
            {
                return this.speedField;
            }
            set
            {
                this.speedField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TachographSlot", Namespace="https://www.golia.goliaweb.it/")]
    public partial class TachographSlot : object
    {
        
        private string cardIdField;
        
        private int cardTypeField;
        
        private string firstNameField;
        
        private string lastNameField;
        
        private int shiftField;
        
        private int statusField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string cardId
        {
            get
            {
                return this.cardIdField;
            }
            set
            {
                this.cardIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int cardType
        {
            get
            {
                return this.cardTypeField;
            }
            set
            {
                this.cardTypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string firstName
        {
            get
            {
                return this.firstNameField;
            }
            set
            {
                this.firstNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string lastName
        {
            get
            {
                return this.lastNameField;
            }
            set
            {
                this.lastNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int shift
        {
            get
            {
                return this.shiftField;
            }
            set
            {
                this.shiftField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SendTachoRealtimeResult", Namespace="https://www.golia.goliaweb.it/")]
    public partial class SendTachoRealtimeResult : object
    {
        
        private GoliaService.LoginResult loginResultField;
        
        private GoliaService.TachoRealtimeResult tachoRealtimeResultField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.LoginResult loginResult
        {
            get
            {
                return this.loginResultField;
            }
            set
            {
                this.loginResultField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.TachoRealtimeResult tachoRealtimeResult
        {
            get
            {
                return this.tachoRealtimeResultField;
            }
            set
            {
                this.tachoRealtimeResultField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TachoRealtimeResult", Namespace="https://www.golia.goliaweb.it/")]
    public partial class TachoRealtimeResult : object
    {
        
        private GoliaService.TachoRealtimeError[] errorsField;
        
        private int numMovementsFailedField;
        
        private int numMovementsInsertedField;
        
        private int numMovementsSentField;
        
        private int numPositionsInsertedField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.TachoRealtimeError[] errors
        {
            get
            {
                return this.errorsField;
            }
            set
            {
                this.errorsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int numMovementsFailed
        {
            get
            {
                return this.numMovementsFailedField;
            }
            set
            {
                this.numMovementsFailedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int numMovementsInserted
        {
            get
            {
                return this.numMovementsInsertedField;
            }
            set
            {
                this.numMovementsInsertedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int numMovementsSent
        {
            get
            {
                return this.numMovementsSentField;
            }
            set
            {
                this.numMovementsSentField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int numPositionsInserted
        {
            get
            {
                return this.numPositionsInsertedField;
            }
            set
            {
                this.numPositionsInsertedField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TachoRealtimeError", Namespace="https://www.golia.goliaweb.it/")]
    public partial class TachoRealtimeError : object
    {
        
        private string errorFoundField;
        
        private int movementIndexField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string errorFound
        {
            get
            {
                return this.errorFoundField;
            }
            set
            {
                this.errorFoundField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int movementIndex
        {
            get
            {
                return this.movementIndexField;
            }
            set
            {
                this.movementIndexField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetInfringmentsRequest", Namespace="https://www.golia.goliaweb.it/")]
    public partial class GetInfringmentsRequest : object
    {
        
        private int companyIdField;
        
        private string countryField;
        
        private int driverIdField;
        
        private GoliaService.GMCulture gmCultureField;
        
        private GoliaService.LoginRequest loginCredentialsField;
        
        private System.DateTime periodEndField;
        
        private System.DateTime periodStartField;
        
        private bool solarSummaryField;
        
        private string vatField;
        
        private int vehicleIdField;
        
        private bool withDescriptionField;
        
        private bool withImagesField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int companyId
        {
            get
            {
                return this.companyIdField;
            }
            set
            {
                this.companyIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int driverId
        {
            get
            {
                return this.driverIdField;
            }
            set
            {
                this.driverIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.GMCulture gmCulture
        {
            get
            {
                return this.gmCultureField;
            }
            set
            {
                this.gmCultureField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.LoginRequest loginCredentials
        {
            get
            {
                return this.loginCredentialsField;
            }
            set
            {
                this.loginCredentialsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.DateTime periodEnd
        {
            get
            {
                return this.periodEndField;
            }
            set
            {
                this.periodEndField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.DateTime periodStart
        {
            get
            {
                return this.periodStartField;
            }
            set
            {
                this.periodStartField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public bool solarSummary
        {
            get
            {
                return this.solarSummaryField;
            }
            set
            {
                this.solarSummaryField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string vat
        {
            get
            {
                return this.vatField;
            }
            set
            {
                this.vatField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int vehicleId
        {
            get
            {
                return this.vehicleIdField;
            }
            set
            {
                this.vehicleIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public bool withDescription
        {
            get
            {
                return this.withDescriptionField;
            }
            set
            {
                this.withDescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public bool withImages
        {
            get
            {
                return this.withImagesField;
            }
            set
            {
                this.withImagesField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetInfringmentsResult", Namespace="https://www.golia.goliaweb.it/")]
    public partial class GetInfringmentsResult : object
    {
        
        private GoliaService.InfringmentsResult driverInfringmentsResultField;
        
        private GoliaService.LoginResult loginResultField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.InfringmentsResult driverInfringmentsResult
        {
            get
            {
                return this.driverInfringmentsResultField;
            }
            set
            {
                this.driverInfringmentsResultField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.LoginResult loginResult
        {
            get
            {
                return this.loginResultField;
            }
            set
            {
                this.loginResultField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="InfringmentsResult", Namespace="https://www.golia.goliaweb.it/")]
    public partial class InfringmentsResult : object
    {
        
        private string[] errorsField;
        
        private GoliaService.Infringment[] infringmentsField;
        
        private bool successField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] errors
        {
            get
            {
                return this.errorsField;
            }
            set
            {
                this.errorsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.Infringment[] infringments
        {
            get
            {
                return this.infringmentsField;
            }
            set
            {
                this.infringmentsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool success
        {
            get
            {
                return this.successField;
            }
            set
            {
                this.successField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Infringment", Namespace="https://www.golia.goliaweb.it/")]
    public partial class Infringment : object
    {
        
        private string articleField;
        
        private string articleCDSField;
        
        private string cardIdField;
        
        private GoliaService.ImageDay[] daysField;
        
        private string descriptionField;
        
        private int discountField;
        
        private System.Nullable<System.DateTime> driveEndField;
        
        private System.Nullable<System.DateTime> driveStartField;
        
        private int driverIdField;
        
        private int driverLicencePointsField;
        
        private bool driverLicenceSuspensionField;
        
        private string driverSurnameNameField;
        
        private bool flag_20200820_packetField;
        
        private double gravityField;
        
        private int infringmentIdField;
        
        private string infringmentTextField;
        
        private bool isAnalogicField;
        
        private bool isRealtimeField;
        
        private bool nightGravityField;
        
        private double penaltyField;
        
        private double penaltyOther1Field;
        
        private double penaltyOther2Field;
        
        private double penaltyOther3Field;
        
        private System.Nullable<System.DateTime> periodField;
        
        private string plateField;
        
        private int regulationIdField;
        
        private int vehicleIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string article
        {
            get
            {
                return this.articleField;
            }
            set
            {
                this.articleField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string articleCDS
        {
            get
            {
                return this.articleCDSField;
            }
            set
            {
                this.articleCDSField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cardId
        {
            get
            {
                return this.cardIdField;
            }
            set
            {
                this.cardIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.ImageDay[] days
        {
            get
            {
                return this.daysField;
            }
            set
            {
                this.daysField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int discount
        {
            get
            {
                return this.discountField;
            }
            set
            {
                this.discountField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> driveEnd
        {
            get
            {
                return this.driveEndField;
            }
            set
            {
                this.driveEndField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> driveStart
        {
            get
            {
                return this.driveStartField;
            }
            set
            {
                this.driveStartField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int driverId
        {
            get
            {
                return this.driverIdField;
            }
            set
            {
                this.driverIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int driverLicencePoints
        {
            get
            {
                return this.driverLicencePointsField;
            }
            set
            {
                this.driverLicencePointsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool driverLicenceSuspension
        {
            get
            {
                return this.driverLicenceSuspensionField;
            }
            set
            {
                this.driverLicenceSuspensionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string driverSurnameName
        {
            get
            {
                return this.driverSurnameNameField;
            }
            set
            {
                this.driverSurnameNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool flag_20200820_packet
        {
            get
            {
                return this.flag_20200820_packetField;
            }
            set
            {
                this.flag_20200820_packetField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double gravity
        {
            get
            {
                return this.gravityField;
            }
            set
            {
                this.gravityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int infringmentId
        {
            get
            {
                return this.infringmentIdField;
            }
            set
            {
                this.infringmentIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string infringmentText
        {
            get
            {
                return this.infringmentTextField;
            }
            set
            {
                this.infringmentTextField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool isAnalogic
        {
            get
            {
                return this.isAnalogicField;
            }
            set
            {
                this.isAnalogicField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool isRealtime
        {
            get
            {
                return this.isRealtimeField;
            }
            set
            {
                this.isRealtimeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool nightGravity
        {
            get
            {
                return this.nightGravityField;
            }
            set
            {
                this.nightGravityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double penalty
        {
            get
            {
                return this.penaltyField;
            }
            set
            {
                this.penaltyField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double penaltyOther1
        {
            get
            {
                return this.penaltyOther1Field;
            }
            set
            {
                this.penaltyOther1Field = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double penaltyOther2
        {
            get
            {
                return this.penaltyOther2Field;
            }
            set
            {
                this.penaltyOther2Field = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double penaltyOther3
        {
            get
            {
                return this.penaltyOther3Field;
            }
            set
            {
                this.penaltyOther3Field = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> period
        {
            get
            {
                return this.periodField;
            }
            set
            {
                this.periodField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string plate
        {
            get
            {
                return this.plateField;
            }
            set
            {
                this.plateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int regulationId
        {
            get
            {
                return this.regulationIdField;
            }
            set
            {
                this.regulationIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int vehicleId
        {
            get
            {
                return this.vehicleIdField;
            }
            set
            {
                this.vehicleIdField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ImageDay", Namespace="https://www.golia.goliaweb.it/")]
    public partial class ImageDay : object
    {
        
        private System.Nullable<System.DateTime> dayField;
        
        private byte[] imageField;
        
        private GoliaService.ImageMapSpot[] imageMapSpotsField;
        
        private string mimeField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> day
        {
            get
            {
                return this.dayField;
            }
            set
            {
                this.dayField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] image
        {
            get
            {
                return this.imageField;
            }
            set
            {
                this.imageField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.ImageMapSpot[] imageMapSpots
        {
            get
            {
                return this.imageMapSpotsField;
            }
            set
            {
                this.imageMapSpotsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string mime
        {
            get
            {
                return this.mimeField;
            }
            set
            {
                this.mimeField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ImageMapSpot", Namespace="https://www.golia.goliaweb.it/")]
    public partial class ImageMapSpot : object
    {
        
        private int heightField;
        
        private string[] textField;
        
        private int widthField;
        
        private int xField;
        
        private int yField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int x
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetDriverPlafondRequest", Namespace="https://www.golia.goliaweb.it/")]
    public partial class GetDriverPlafondRequest : object
    {
        
        private string cardIdField;
        
        private int companyIdField;
        
        private string countryField;
        
        private int driverIdField;
        
        private GoliaService.GMCulture gmCultureField;
        
        private GoliaService.LoginRequest loginCredentialsField;
        
        private System.DateTime screenToField;
        
        private string vatField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cardId
        {
            get
            {
                return this.cardIdField;
            }
            set
            {
                this.cardIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int companyId
        {
            get
            {
                return this.companyIdField;
            }
            set
            {
                this.companyIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int driverId
        {
            get
            {
                return this.driverIdField;
            }
            set
            {
                this.driverIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.GMCulture gmCulture
        {
            get
            {
                return this.gmCultureField;
            }
            set
            {
                this.gmCultureField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.LoginRequest loginCredentials
        {
            get
            {
                return this.loginCredentialsField;
            }
            set
            {
                this.loginCredentialsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime screenTo
        {
            get
            {
                return this.screenToField;
            }
            set
            {
                this.screenToField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string vat
        {
            get
            {
                return this.vatField;
            }
            set
            {
                this.vatField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetDriverPlafondResult", Namespace="https://www.golia.goliaweb.it/")]
    public partial class GetDriverPlafondResult : object
    {
        
        private GoliaService.LoginResult loginResultField;
        
        private GoliaService.PlafondResult plafondResultField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.LoginResult loginResult
        {
            get
            {
                return this.loginResultField;
            }
            set
            {
                this.loginResultField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.PlafondResult plafondResult
        {
            get
            {
                return this.plafondResultField;
            }
            set
            {
                this.plafondResultField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PlafondResult", Namespace="https://www.golia.goliaweb.it/")]
    public partial class PlafondResult : object
    {
        
        private string[] errorsField;
        
        private GoliaService.DriverPlafond[] plafondsField;
        
        private GoliaService.DriverPlafondView[] plafondsViewField;
        
        private bool resultOkField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] errors
        {
            get
            {
                return this.errorsField;
            }
            set
            {
                this.errorsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.DriverPlafond[] plafonds
        {
            get
            {
                return this.plafondsField;
            }
            set
            {
                this.plafondsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.DriverPlafondView[] plafondsView
        {
            get
            {
                return this.plafondsViewField;
            }
            set
            {
                this.plafondsViewField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool resultOk
        {
            get
            {
                return this.resultOkField;
            }
            set
            {
                this.resultOkField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DriverPlafond", Namespace="https://www.golia.goliaweb.it/")]
    public partial class DriverPlafond : object
    {
        
        private System.DateTime actualDateField;
        
        private System.TimeSpan biWeeklyDriveTotalField;
        
        private System.TimeSpan biWeeklyPlafondDriveField;
        
        private string cardIdField;
        
        private GoliaService.TachoFileDownloadStatus cardTachoFileDownloadStatusField;
        
        private System.TimeSpan dailyCommitmentField;
        
        private System.TimeSpan dailyPlafondDriveField;
        
        private System.DateTime dailyRestMaxStartDateField;
        
        private System.DateTime detectionDateField;
        
        private GoliaService.DetectionActState detectionStateField;
        
        private int driveBonusField;
        
        private System.TimeSpan drivePlafondField;
        
        private System.Nullable<System.DateTime> driveRestStartField;
        
        private GoliaService.TypeNextRest driveTypeNextRestField;
        
        private int driverIdField;
        
        private string driverSurnameNameField;
        
        private bool inRestField;
        
        private GoliaService.WeeklyRestInfo lastWeeklyRestField;
        
        private string plateField;
        
        private GoliaService.TachoFileDownloadStatus plateTachoFileDownloadStatusField;
        
        private int provenienceField;
        
        private string provenienceDescriptionField;
        
        private string provenienceMasterField;
        
        private int restBonusField;
        
        private System.DateTime restDailyEndField;
        
        private System.Nullable<System.DateTime> restDriveStartField;
        
        private System.TimeSpan restPlafondField;
        
        private System.DateTime restSessionEndField;
        
        private System.DateTime restStartField;
        
        private System.DateTime restWeeklyEndField;
        
        private System.TimeSpan totalDailyDriveField;
        
        private int vehicleIdField;
        
        private System.TimeSpan weeklyPlafondDriveField;
        
        private GoliaService.WeeklyRestInfo[] weeklyReducedRestToRecoveryField;
        
        private System.DateTime workingDayStartField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime actualDate
        {
            get
            {
                return this.actualDateField;
            }
            set
            {
                this.actualDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.TimeSpan biWeeklyDriveTotal
        {
            get
            {
                return this.biWeeklyDriveTotalField;
            }
            set
            {
                this.biWeeklyDriveTotalField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.TimeSpan biWeeklyPlafondDrive
        {
            get
            {
                return this.biWeeklyPlafondDriveField;
            }
            set
            {
                this.biWeeklyPlafondDriveField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cardId
        {
            get
            {
                return this.cardIdField;
            }
            set
            {
                this.cardIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.TachoFileDownloadStatus cardTachoFileDownloadStatus
        {
            get
            {
                return this.cardTachoFileDownloadStatusField;
            }
            set
            {
                this.cardTachoFileDownloadStatusField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.TimeSpan dailyCommitment
        {
            get
            {
                return this.dailyCommitmentField;
            }
            set
            {
                this.dailyCommitmentField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.TimeSpan dailyPlafondDrive
        {
            get
            {
                return this.dailyPlafondDriveField;
            }
            set
            {
                this.dailyPlafondDriveField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime dailyRestMaxStartDate
        {
            get
            {
                return this.dailyRestMaxStartDateField;
            }
            set
            {
                this.dailyRestMaxStartDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime detectionDate
        {
            get
            {
                return this.detectionDateField;
            }
            set
            {
                this.detectionDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.DetectionActState detectionState
        {
            get
            {
                return this.detectionStateField;
            }
            set
            {
                this.detectionStateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int driveBonus
        {
            get
            {
                return this.driveBonusField;
            }
            set
            {
                this.driveBonusField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.TimeSpan drivePlafond
        {
            get
            {
                return this.drivePlafondField;
            }
            set
            {
                this.drivePlafondField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> driveRestStart
        {
            get
            {
                return this.driveRestStartField;
            }
            set
            {
                this.driveRestStartField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.TypeNextRest driveTypeNextRest
        {
            get
            {
                return this.driveTypeNextRestField;
            }
            set
            {
                this.driveTypeNextRestField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int driverId
        {
            get
            {
                return this.driverIdField;
            }
            set
            {
                this.driverIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string driverSurnameName
        {
            get
            {
                return this.driverSurnameNameField;
            }
            set
            {
                this.driverSurnameNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool inRest
        {
            get
            {
                return this.inRestField;
            }
            set
            {
                this.inRestField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.WeeklyRestInfo lastWeeklyRest
        {
            get
            {
                return this.lastWeeklyRestField;
            }
            set
            {
                this.lastWeeklyRestField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string plate
        {
            get
            {
                return this.plateField;
            }
            set
            {
                this.plateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.TachoFileDownloadStatus plateTachoFileDownloadStatus
        {
            get
            {
                return this.plateTachoFileDownloadStatusField;
            }
            set
            {
                this.plateTachoFileDownloadStatusField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int provenience
        {
            get
            {
                return this.provenienceField;
            }
            set
            {
                this.provenienceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string provenienceDescription
        {
            get
            {
                return this.provenienceDescriptionField;
            }
            set
            {
                this.provenienceDescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string provenienceMaster
        {
            get
            {
                return this.provenienceMasterField;
            }
            set
            {
                this.provenienceMasterField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int restBonus
        {
            get
            {
                return this.restBonusField;
            }
            set
            {
                this.restBonusField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime restDailyEnd
        {
            get
            {
                return this.restDailyEndField;
            }
            set
            {
                this.restDailyEndField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> restDriveStart
        {
            get
            {
                return this.restDriveStartField;
            }
            set
            {
                this.restDriveStartField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.TimeSpan restPlafond
        {
            get
            {
                return this.restPlafondField;
            }
            set
            {
                this.restPlafondField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime restSessionEnd
        {
            get
            {
                return this.restSessionEndField;
            }
            set
            {
                this.restSessionEndField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime restStart
        {
            get
            {
                return this.restStartField;
            }
            set
            {
                this.restStartField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime restWeeklyEnd
        {
            get
            {
                return this.restWeeklyEndField;
            }
            set
            {
                this.restWeeklyEndField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.TimeSpan totalDailyDrive
        {
            get
            {
                return this.totalDailyDriveField;
            }
            set
            {
                this.totalDailyDriveField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int vehicleId
        {
            get
            {
                return this.vehicleIdField;
            }
            set
            {
                this.vehicleIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.TimeSpan weeklyPlafondDrive
        {
            get
            {
                return this.weeklyPlafondDriveField;
            }
            set
            {
                this.weeklyPlafondDriveField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.WeeklyRestInfo[] weeklyReducedRestToRecovery
        {
            get
            {
                return this.weeklyReducedRestToRecoveryField;
            }
            set
            {
                this.weeklyReducedRestToRecoveryField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime workingDayStart
        {
            get
            {
                return this.workingDayStartField;
            }
            set
            {
                this.workingDayStartField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TachoFileDownloadStatus", Namespace="https://www.golia.goliaweb.it/")]
    public partial class TachoFileDownloadStatus : object
    {
        
        private int daysElapsedField;
        
        private string elapsedAlarmField;
        
        private System.DateTime lastActivityField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int daysElapsed
        {
            get
            {
                return this.daysElapsedField;
            }
            set
            {
                this.daysElapsedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string elapsedAlarm
        {
            get
            {
                return this.elapsedAlarmField;
            }
            set
            {
                this.elapsedAlarmField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime lastActivity
        {
            get
            {
                return this.lastActivityField;
            }
            set
            {
                this.lastActivityField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DetectionActState", Namespace="https://www.golia.goliaweb.it/")]
    public enum DetectionActState : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        REST = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        AVAILABILITY = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        WORK = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        DRIVE = 3,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TypeNextRest", Namespace="https://www.golia.goliaweb.it/")]
    public enum TypeNextRest : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        SESSION = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        DAILY = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        WEEKLY = 2,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="WeeklyRestInfo", Namespace="https://www.golia.goliaweb.it/")]
    public partial class WeeklyRestInfo : object
    {
        
        private System.TimeSpan durationField;
        
        private System.TimeSpan nextDurationField;
        
        private System.DateTime nextPeriodField;
        
        private System.TimeSpan nextRecoveryField;
        
        private System.DateTime periodEndField;
        
        private System.DateTime periodStartField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.TimeSpan duration
        {
            get
            {
                return this.durationField;
            }
            set
            {
                this.durationField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.TimeSpan nextDuration
        {
            get
            {
                return this.nextDurationField;
            }
            set
            {
                this.nextDurationField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime nextPeriod
        {
            get
            {
                return this.nextPeriodField;
            }
            set
            {
                this.nextPeriodField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.TimeSpan nextRecovery
        {
            get
            {
                return this.nextRecoveryField;
            }
            set
            {
                this.nextRecoveryField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime periodEnd
        {
            get
            {
                return this.periodEndField;
            }
            set
            {
                this.periodEndField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime periodStart
        {
            get
            {
                return this.periodStartField;
            }
            set
            {
                this.periodStartField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DriverPlafondView", Namespace="https://www.golia.goliaweb.it/")]
    public partial class DriverPlafondView : object
    {
        
        private GoliaService.DriverPlafondView1 dpv1Field;
        
        private GoliaService.DriverPlafondView2 dpv2Field;
        
        private GoliaService.DriverPlafondView3 dpv3Field;
        
        private GoliaService.DriverPlafondView4 dpv4Field;
        
        private GoliaService.DriverPlafondView5 dpv5Field;
        
        private GoliaService.DriverPlafondView6 dpv6Field;
        
        private GoliaService.DriverPlafondView7 dpv7Field;
        
        private GoliaService.DriverPlafondView8 dpv8Field;
        
        private GoliaService.DriverPlafondView9[] dpv9Field;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.DriverPlafondView1 dpv1
        {
            get
            {
                return this.dpv1Field;
            }
            set
            {
                this.dpv1Field = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.DriverPlafondView2 dpv2
        {
            get
            {
                return this.dpv2Field;
            }
            set
            {
                this.dpv2Field = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.DriverPlafondView3 dpv3
        {
            get
            {
                return this.dpv3Field;
            }
            set
            {
                this.dpv3Field = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.DriverPlafondView4 dpv4
        {
            get
            {
                return this.dpv4Field;
            }
            set
            {
                this.dpv4Field = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.DriverPlafondView5 dpv5
        {
            get
            {
                return this.dpv5Field;
            }
            set
            {
                this.dpv5Field = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.DriverPlafondView6 dpv6
        {
            get
            {
                return this.dpv6Field;
            }
            set
            {
                this.dpv6Field = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.DriverPlafondView7 dpv7
        {
            get
            {
                return this.dpv7Field;
            }
            set
            {
                this.dpv7Field = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.DriverPlafondView8 dpv8
        {
            get
            {
                return this.dpv8Field;
            }
            set
            {
                this.dpv8Field = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.DriverPlafondView9[] dpv9
        {
            get
            {
                return this.dpv9Field;
            }
            set
            {
                this.dpv9Field = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DriverPlafondView1", Namespace="https://www.golia.goliaweb.it/")]
    public partial class DriverPlafondView1 : object
    {
        
        private GoliaService.DetectionActState activityField;
        
        private System.DateTime dtField;
        
        private string headingDriverField;
        
        private string headingVehicleField;
        
        private bool recentField;
        
        private string timeLabelField;
        
        private string titleField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.DetectionActState activity
        {
            get
            {
                return this.activityField;
            }
            set
            {
                this.activityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime dt
        {
            get
            {
                return this.dtField;
            }
            set
            {
                this.dtField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string headingDriver
        {
            get
            {
                return this.headingDriverField;
            }
            set
            {
                this.headingDriverField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string headingVehicle
        {
            get
            {
                return this.headingVehicleField;
            }
            set
            {
                this.headingVehicleField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool recent
        {
            get
            {
                return this.recentField;
            }
            set
            {
                this.recentField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string timeLabel
        {
            get
            {
                return this.timeLabelField;
            }
            set
            {
                this.timeLabelField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DriverPlafondView2", Namespace="https://www.golia.goliaweb.it/")]
    public partial class DriverPlafondView2 : object
    {
        
        private GoliaService.DetectionActState activityField;
        
        private string rowActualStateField;
        
        private string rowActualStateMinutesField;
        
        private string rowWhyStopField;
        
        private string titleField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.DetectionActState activity
        {
            get
            {
                return this.activityField;
            }
            set
            {
                this.activityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string rowActualState
        {
            get
            {
                return this.rowActualStateField;
            }
            set
            {
                this.rowActualStateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string rowActualStateMinutes
        {
            get
            {
                return this.rowActualStateMinutesField;
            }
            set
            {
                this.rowActualStateMinutesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string rowWhyStop
        {
            get
            {
                return this.rowWhyStopField;
            }
            set
            {
                this.rowWhyStopField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DriverPlafondView3", Namespace="https://www.golia.goliaweb.it/")]
    public partial class DriverPlafondView3 : object
    {
        
        private GoliaService.DetectionActState activityField;
        
        private string rowActualStateField;
        
        private System.DateTime rowActualStateMinutesField;
        
        private string titleField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.DetectionActState activity
        {
            get
            {
                return this.activityField;
            }
            set
            {
                this.activityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string rowActualState
        {
            get
            {
                return this.rowActualStateField;
            }
            set
            {
                this.rowActualStateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime rowActualStateMinutes
        {
            get
            {
                return this.rowActualStateMinutesField;
            }
            set
            {
                this.rowActualStateMinutesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DriverPlafondView4", Namespace="https://www.golia.goliaweb.it/")]
    public partial class DriverPlafondView4 : object
    {
        
        private GoliaService.DriverPlafondView4Bonus dpv4BonusField;
        
        private GoliaService.DriverPlafondView4DateCalc dpv4DateCalcField;
        
        private GoliaService.DriverPlafondView4EndWD dpv4EndWDField;
        
        private GoliaService.DriverPlafondView4ResWD dpv4ResWDField;
        
        private GoliaService.DriverPlafondView4StartWD dpv4StartWDField;
        
        private double percWorkingDayField;
        
        private string residualField;
        
        private int residualHoursField;
        
        private int residualMinutesField;
        
        private int restBonusField;
        
        private string timeLabelField;
        
        private string titleField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.DriverPlafondView4Bonus dpv4Bonus
        {
            get
            {
                return this.dpv4BonusField;
            }
            set
            {
                this.dpv4BonusField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.DriverPlafondView4DateCalc dpv4DateCalc
        {
            get
            {
                return this.dpv4DateCalcField;
            }
            set
            {
                this.dpv4DateCalcField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.DriverPlafondView4EndWD dpv4EndWD
        {
            get
            {
                return this.dpv4EndWDField;
            }
            set
            {
                this.dpv4EndWDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.DriverPlafondView4ResWD dpv4ResWD
        {
            get
            {
                return this.dpv4ResWDField;
            }
            set
            {
                this.dpv4ResWDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.DriverPlafondView4StartWD dpv4StartWD
        {
            get
            {
                return this.dpv4StartWDField;
            }
            set
            {
                this.dpv4StartWDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double percWorkingDay
        {
            get
            {
                return this.percWorkingDayField;
            }
            set
            {
                this.percWorkingDayField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string residual
        {
            get
            {
                return this.residualField;
            }
            set
            {
                this.residualField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int residualHours
        {
            get
            {
                return this.residualHoursField;
            }
            set
            {
                this.residualHoursField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int residualMinutes
        {
            get
            {
                return this.residualMinutesField;
            }
            set
            {
                this.residualMinutesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int restBonus
        {
            get
            {
                return this.restBonusField;
            }
            set
            {
                this.restBonusField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string timeLabel
        {
            get
            {
                return this.timeLabelField;
            }
            set
            {
                this.timeLabelField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DriverPlafondView4Bonus", Namespace="https://www.golia.goliaweb.it/")]
    public partial class DriverPlafondView4Bonus : object
    {
        
        private int numBonusField;
        
        private string titleField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int numBonus
        {
            get
            {
                return this.numBonusField;
            }
            set
            {
                this.numBonusField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DriverPlafondView4DateCalc", Namespace="https://www.golia.goliaweb.it/")]
    public partial class DriverPlafondView4DateCalc : object
    {
        
        private System.DateTime dateCalcField;
        
        private string titleField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime dateCalc
        {
            get
            {
                return this.dateCalcField;
            }
            set
            {
                this.dateCalcField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DriverPlafondView4EndWD", Namespace="https://www.golia.goliaweb.it/")]
    public partial class DriverPlafondView4EndWD : object
    {
        
        private System.DateTime endWorkingDayField;
        
        private string titleField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime endWorkingDay
        {
            get
            {
                return this.endWorkingDayField;
            }
            set
            {
                this.endWorkingDayField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DriverPlafondView4ResWD", Namespace="https://www.golia.goliaweb.it/")]
    public partial class DriverPlafondView4ResWD : object
    {
        
        private string residualWorkingDayField;
        
        private string titleField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string residualWorkingDay
        {
            get
            {
                return this.residualWorkingDayField;
            }
            set
            {
                this.residualWorkingDayField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DriverPlafondView4StartWD", Namespace="https://www.golia.goliaweb.it/")]
    public partial class DriverPlafondView4StartWD : object
    {
        
        private System.DateTime startWorkingDayField;
        
        private string titleField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime startWorkingDay
        {
            get
            {
                return this.startWorkingDayField;
            }
            set
            {
                this.startWorkingDayField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DriverPlafondView5", Namespace="https://www.golia.goliaweb.it/")]
    public partial class DriverPlafondView5 : object
    {
        
        private GoliaService.DriverPlafondView5Bonus dpv5BonusField;
        
        private GoliaService.DriverPlafondView5DayDrive dpv5DayDriveField;
        
        private GoliaService.DriverPlafondView5ResDrive dpv5ResDriveField;
        
        private int driveBonusField;
        
        private double percDrivingDayField;
        
        private int plafondDailyHoursField;
        
        private int plafondDailyMinutesField;
        
        private string timeLabelField;
        
        private string titleField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.DriverPlafondView5Bonus dpv5Bonus
        {
            get
            {
                return this.dpv5BonusField;
            }
            set
            {
                this.dpv5BonusField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.DriverPlafondView5DayDrive dpv5DayDrive
        {
            get
            {
                return this.dpv5DayDriveField;
            }
            set
            {
                this.dpv5DayDriveField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.DriverPlafondView5ResDrive dpv5ResDrive
        {
            get
            {
                return this.dpv5ResDriveField;
            }
            set
            {
                this.dpv5ResDriveField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int driveBonus
        {
            get
            {
                return this.driveBonusField;
            }
            set
            {
                this.driveBonusField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double percDrivingDay
        {
            get
            {
                return this.percDrivingDayField;
            }
            set
            {
                this.percDrivingDayField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int plafondDailyHours
        {
            get
            {
                return this.plafondDailyHoursField;
            }
            set
            {
                this.plafondDailyHoursField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int plafondDailyMinutes
        {
            get
            {
                return this.plafondDailyMinutesField;
            }
            set
            {
                this.plafondDailyMinutesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string timeLabel
        {
            get
            {
                return this.timeLabelField;
            }
            set
            {
                this.timeLabelField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DriverPlafondView5Bonus", Namespace="https://www.golia.goliaweb.it/")]
    public partial class DriverPlafondView5Bonus : object
    {
        
        private int numBonusField;
        
        private string titleField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int numBonus
        {
            get
            {
                return this.numBonusField;
            }
            set
            {
                this.numBonusField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DriverPlafondView5DayDrive", Namespace="https://www.golia.goliaweb.it/")]
    public partial class DriverPlafondView5DayDrive : object
    {
        
        private string driveDayField;
        
        private string titleField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string driveDay
        {
            get
            {
                return this.driveDayField;
            }
            set
            {
                this.driveDayField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DriverPlafondView5ResDrive", Namespace="https://www.golia.goliaweb.it/")]
    public partial class DriverPlafondView5ResDrive : object
    {
        
        private string residualDriveDayField;
        
        private string titleField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string residualDriveDay
        {
            get
            {
                return this.residualDriveDayField;
            }
            set
            {
                this.residualDriveDayField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DriverPlafondView6", Namespace="https://www.golia.goliaweb.it/")]
    public partial class DriverPlafondView6 : object
    {
        
        private double percDrivingWeeklyField;
        
        private int plafondWeeklyHoursField;
        
        private int plafondWeeklyMinutesField;
        
        private string timeLabelField;
        
        private string titleField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double percDrivingWeekly
        {
            get
            {
                return this.percDrivingWeeklyField;
            }
            set
            {
                this.percDrivingWeeklyField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int plafondWeeklyHours
        {
            get
            {
                return this.plafondWeeklyHoursField;
            }
            set
            {
                this.plafondWeeklyHoursField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int plafondWeeklyMinutes
        {
            get
            {
                return this.plafondWeeklyMinutesField;
            }
            set
            {
                this.plafondWeeklyMinutesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string timeLabel
        {
            get
            {
                return this.timeLabelField;
            }
            set
            {
                this.timeLabelField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DriverPlafondView7", Namespace="https://www.golia.goliaweb.it/")]
    public partial class DriverPlafondView7 : object
    {
        
        private GoliaService.DriverPlafondView7.DriverPlafondView7BiWeeklyDrive dpv7BiWeeklyDriveField;
        
        private GoliaService.DriverPlafondView7.DriverPlafondView7ResDrive dpv7ResDriveField;
        
        private double percDrivingBiWeeklyField;
        
        private int plafondBiWeeklyHoursField;
        
        private int plafondBiWeeklyMinutesField;
        
        private string timeLabelField;
        
        private string titleField;
        
        private string titleTooltipField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.DriverPlafondView7.DriverPlafondView7BiWeeklyDrive dpv7BiWeeklyDrive
        {
            get
            {
                return this.dpv7BiWeeklyDriveField;
            }
            set
            {
                this.dpv7BiWeeklyDriveField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.DriverPlafondView7.DriverPlafondView7ResDrive dpv7ResDrive
        {
            get
            {
                return this.dpv7ResDriveField;
            }
            set
            {
                this.dpv7ResDriveField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double percDrivingBiWeekly
        {
            get
            {
                return this.percDrivingBiWeeklyField;
            }
            set
            {
                this.percDrivingBiWeeklyField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int plafondBiWeeklyHours
        {
            get
            {
                return this.plafondBiWeeklyHoursField;
            }
            set
            {
                this.plafondBiWeeklyHoursField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int plafondBiWeeklyMinutes
        {
            get
            {
                return this.plafondBiWeeklyMinutesField;
            }
            set
            {
                this.plafondBiWeeklyMinutesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string timeLabel
        {
            get
            {
                return this.timeLabelField;
            }
            set
            {
                this.timeLabelField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string titleTooltip
        {
            get
            {
                return this.titleTooltipField;
            }
            set
            {
                this.titleTooltipField = value;
            }
        }
        
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name="DriverPlafondView7.DriverPlafondView7BiWeeklyDrive", Namespace="https://www.golia.goliaweb.it/")]
        public partial class DriverPlafondView7BiWeeklyDrive : object
        {
            
            private string driveDayField;
            
            private string titleField;
            
            [System.Runtime.Serialization.DataMemberAttribute()]
            public string driveDay
            {
                get
                {
                    return this.driveDayField;
                }
                set
                {
                    this.driveDayField = value;
                }
            }
            
            [System.Runtime.Serialization.DataMemberAttribute()]
            public string title
            {
                get
                {
                    return this.titleField;
                }
                set
                {
                    this.titleField = value;
                }
            }
        }
        
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name="DriverPlafondView7.DriverPlafondView7ResDrive", Namespace="https://www.golia.goliaweb.it/")]
        public partial class DriverPlafondView7ResDrive : object
        {
            
            private string residualDriveDayField;
            
            private string titleField;
            
            [System.Runtime.Serialization.DataMemberAttribute()]
            public string residualDriveDay
            {
                get
                {
                    return this.residualDriveDayField;
                }
                set
                {
                    this.residualDriveDayField = value;
                }
            }
            
            [System.Runtime.Serialization.DataMemberAttribute()]
            public string title
            {
                get
                {
                    return this.titleField;
                }
                set
                {
                    this.titleField = value;
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DriverPlafondView8", Namespace="https://www.golia.goliaweb.it/")]
    public partial class DriverPlafondView8 : object
    {
        
        private string durationField;
        
        private string nextDurationHoursField;
        
        private System.DateTime nextStartPeriodField;
        
        private System.DateTime periodEndField;
        
        private System.DateTime periodStartField;
        
        private string titleField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string duration
        {
            get
            {
                return this.durationField;
            }
            set
            {
                this.durationField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nextDurationHours
        {
            get
            {
                return this.nextDurationHoursField;
            }
            set
            {
                this.nextDurationHoursField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime nextStartPeriod
        {
            get
            {
                return this.nextStartPeriodField;
            }
            set
            {
                this.nextStartPeriodField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime periodEnd
        {
            get
            {
                return this.periodEndField;
            }
            set
            {
                this.periodEndField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime periodStart
        {
            get
            {
                return this.periodStartField;
            }
            set
            {
                this.periodStartField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DriverPlafondView9", Namespace="https://www.golia.goliaweb.it/")]
    public partial class DriverPlafondView9 : object
    {
        
        private string durationField;
        
        private System.DateTime nextStartPeriodField;
        
        private System.DateTime periodEndField;
        
        private System.DateTime periodStartField;
        
        private string recoveryHoursField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string duration
        {
            get
            {
                return this.durationField;
            }
            set
            {
                this.durationField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime nextStartPeriod
        {
            get
            {
                return this.nextStartPeriodField;
            }
            set
            {
                this.nextStartPeriodField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime periodEnd
        {
            get
            {
                return this.periodEndField;
            }
            set
            {
                this.periodEndField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime periodStart
        {
            get
            {
                return this.periodStartField;
            }
            set
            {
                this.periodStartField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string recoveryHours
        {
            get
            {
                return this.recoveryHoursField;
            }
            set
            {
                this.recoveryHoursField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetActivitiesRequest", Namespace="https://www.golia.goliaweb.it/")]
    public partial class GetActivitiesRequest : object
    {
        
        private string countryField;
        
        private GoliaService.driverRequest driverRequestField;
        
        private GoliaService.LoginCompanyCultureRequest loginCompanyRequestField;
        
        private bool onlyDayBusyField;
        
        private bool onlyOverwrittedRealtimeField;
        
        private System.DateTime periodEndField;
        
        private System.DateTime periodStartField;
        
        private bool solarSummaryField;
        
        private string vatField;
        
        private GoliaService.vehicleRequest vehicleRequestField;
        
        private bool withImagesField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.driverRequest driverRequest
        {
            get
            {
                return this.driverRequestField;
            }
            set
            {
                this.driverRequestField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.LoginCompanyCultureRequest loginCompanyRequest
        {
            get
            {
                return this.loginCompanyRequestField;
            }
            set
            {
                this.loginCompanyRequestField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public bool onlyDayBusy
        {
            get
            {
                return this.onlyDayBusyField;
            }
            set
            {
                this.onlyDayBusyField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool onlyOverwrittedRealtime
        {
            get
            {
                return this.onlyOverwrittedRealtimeField;
            }
            set
            {
                this.onlyOverwrittedRealtimeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.DateTime periodEnd
        {
            get
            {
                return this.periodEndField;
            }
            set
            {
                this.periodEndField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.DateTime periodStart
        {
            get
            {
                return this.periodStartField;
            }
            set
            {
                this.periodStartField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public bool solarSummary
        {
            get
            {
                return this.solarSummaryField;
            }
            set
            {
                this.solarSummaryField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string vat
        {
            get
            {
                return this.vatField;
            }
            set
            {
                this.vatField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.vehicleRequest vehicleRequest
        {
            get
            {
                return this.vehicleRequestField;
            }
            set
            {
                this.vehicleRequestField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public bool withImages
        {
            get
            {
                return this.withImagesField;
            }
            set
            {
                this.withImagesField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="driverRequest", Namespace="https://www.golia.goliaweb.it/")]
    public partial class driverRequest : object
    {
        
        private string cardIdField;
        
        private int driverIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cardId
        {
            get
            {
                return this.cardIdField;
            }
            set
            {
                this.cardIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int driverId
        {
            get
            {
                return this.driverIdField;
            }
            set
            {
                this.driverIdField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="vehicleRequest", Namespace="https://www.golia.goliaweb.it/")]
    public partial class vehicleRequest : object
    {
        
        private string plateField;
        
        private int vehicleIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string plate
        {
            get
            {
                return this.plateField;
            }
            set
            {
                this.plateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int vehicleId
        {
            get
            {
                return this.vehicleIdField;
            }
            set
            {
                this.vehicleIdField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetActivitiesResult", Namespace="https://www.golia.goliaweb.it/")]
    public partial class GetActivitiesResult : object
    {
        
        private GoliaService.ActivitiesResult activitiesResultField;
        
        private GoliaService.LoginResult loginResultField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.ActivitiesResult activitiesResult
        {
            get
            {
                return this.activitiesResultField;
            }
            set
            {
                this.activitiesResultField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.LoginResult loginResult
        {
            get
            {
                return this.loginResultField;
            }
            set
            {
                this.loginResultField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ActivitiesResult", Namespace="https://www.golia.goliaweb.it/")]
    public partial class ActivitiesResult : object
    {
        
        private GoliaService.ActivityDay[] activitiesField;
        
        private string[] errorsField;
        
        private bool resultOkField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.ActivityDay[] activities
        {
            get
            {
                return this.activitiesField;
            }
            set
            {
                this.activitiesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] errors
        {
            get
            {
                return this.errorsField;
            }
            set
            {
                this.errorsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool resultOk
        {
            get
            {
                return this.resultOkField;
            }
            set
            {
                this.resultOkField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ActivityDay", Namespace="https://www.golia.goliaweb.it/")]
    public partial class ActivityDay : object
    {
        
        private GoliaService.ActivityCountry[] countriesField;
        
        private System.Nullable<System.DateTime> dayField;
        
        private GoliaService.ActivityAnalogicDisk[] disksField;
        
        private GoliaService.ActivityDriver[] driversField;
        
        private GoliaService.ImageDay imgDayField;
        
        private bool isAnalogicField;
        
        private bool isRealtimeField;
        
        private int kmTotField;
        
        private GoliaService.ActivityVehicle[] vehiclesField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.ActivityCountry[] countries
        {
            get
            {
                return this.countriesField;
            }
            set
            {
                this.countriesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> day
        {
            get
            {
                return this.dayField;
            }
            set
            {
                this.dayField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.ActivityAnalogicDisk[] disks
        {
            get
            {
                return this.disksField;
            }
            set
            {
                this.disksField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.ActivityDriver[] drivers
        {
            get
            {
                return this.driversField;
            }
            set
            {
                this.driversField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.ImageDay imgDay
        {
            get
            {
                return this.imgDayField;
            }
            set
            {
                this.imgDayField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool isAnalogic
        {
            get
            {
                return this.isAnalogicField;
            }
            set
            {
                this.isAnalogicField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool isRealtime
        {
            get
            {
                return this.isRealtimeField;
            }
            set
            {
                this.isRealtimeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int kmTot
        {
            get
            {
                return this.kmTotField;
            }
            set
            {
                this.kmTotField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.ActivityVehicle[] vehicles
        {
            get
            {
                return this.vehiclesField;
            }
            set
            {
                this.vehiclesField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ActivityCountry", Namespace="https://www.golia.goliaweb.it/")]
    public partial class ActivityCountry : object
    {
        
        private string descriptionField;
        
        private int entryTypeField;
        
        private int idTachoField;
        
        private System.DateTime periodEndField;
        
        private System.DateTime periodStartField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int entryType
        {
            get
            {
                return this.entryTypeField;
            }
            set
            {
                this.entryTypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int idTacho
        {
            get
            {
                return this.idTachoField;
            }
            set
            {
                this.idTachoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime periodEnd
        {
            get
            {
                return this.periodEndField;
            }
            set
            {
                this.periodEndField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime periodStart
        {
            get
            {
                return this.periodStartField;
            }
            set
            {
                this.periodStartField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ActivityAnalogicDisk", Namespace="https://www.golia.goliaweb.it/")]
    public partial class ActivityAnalogicDisk : object
    {
        
        private string driverSurnameNameField;
        
        private int idField;
        
        private System.DateTime periodEndField;
        
        private System.DateTime periodStartField;
        
        private string plateField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string driverSurnameName
        {
            get
            {
                return this.driverSurnameNameField;
            }
            set
            {
                this.driverSurnameNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime periodEnd
        {
            get
            {
                return this.periodEndField;
            }
            set
            {
                this.periodEndField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime periodStart
        {
            get
            {
                return this.periodStartField;
            }
            set
            {
                this.periodStartField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string plate
        {
            get
            {
                return this.plateField;
            }
            set
            {
                this.plateField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ActivityDriver", Namespace="https://www.golia.goliaweb.it/")]
    public partial class ActivityDriver : object
    {
        
        private string cardIdField;
        
        private int drivenKmField;
        
        private string nameField;
        
        private string surnameField;
        
        private int traveledKmField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cardId
        {
            get
            {
                return this.cardIdField;
            }
            set
            {
                this.cardIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int drivenKm
        {
            get
            {
                return this.drivenKmField;
            }
            set
            {
                this.drivenKmField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string surname
        {
            get
            {
                return this.surnameField;
            }
            set
            {
                this.surnameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int traveledKm
        {
            get
            {
                return this.traveledKmField;
            }
            set
            {
                this.traveledKmField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ActivityVehicle", Namespace="https://www.golia.goliaweb.it/")]
    public partial class ActivityVehicle : object
    {
        
        private int drivenKmField;
        
        private string plateField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int drivenKm
        {
            get
            {
                return this.drivenKmField;
            }
            set
            {
                this.drivenKmField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string plate
        {
            get
            {
                return this.plateField;
            }
            set
            {
                this.plateField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetTimelineRequest", Namespace="https://www.golia.goliaweb.it/")]
    public partial class GetTimelineRequest : object
    {
        
        private string cardIdField;
        
        private int driverIdField;
        
        private GoliaService.LoginCompanyCultureRequest loginCompanyRequestField;
        
        private bool onlyOverwrittedRealtimeField;
        
        private System.DateTime periodEndField;
        
        private System.DateTime periodStartField;
        
        private string plateField;
        
        private GoliaService.TimelineOptions timelineOptionsField;
        
        private int vehicleIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cardId
        {
            get
            {
                return this.cardIdField;
            }
            set
            {
                this.cardIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int driverId
        {
            get
            {
                return this.driverIdField;
            }
            set
            {
                this.driverIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.LoginCompanyCultureRequest loginCompanyRequest
        {
            get
            {
                return this.loginCompanyRequestField;
            }
            set
            {
                this.loginCompanyRequestField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool onlyOverwrittedRealtime
        {
            get
            {
                return this.onlyOverwrittedRealtimeField;
            }
            set
            {
                this.onlyOverwrittedRealtimeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.DateTime periodEnd
        {
            get
            {
                return this.periodEndField;
            }
            set
            {
                this.periodEndField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.DateTime periodStart
        {
            get
            {
                return this.periodStartField;
            }
            set
            {
                this.periodStartField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string plate
        {
            get
            {
                return this.plateField;
            }
            set
            {
                this.plateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.TimelineOptions timelineOptions
        {
            get
            {
                return this.timelineOptionsField;
            }
            set
            {
                this.timelineOptionsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int vehicleId
        {
            get
            {
                return this.vehicleIdField;
            }
            set
            {
                this.vehicleIdField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TimelineOptions", Namespace="https://www.golia.goliaweb.it/")]
    public partial class TimelineOptions : object
    {
        
        private bool absencesField;
        
        private bool attachmentsField;
        
        private bool commentsField;
        
        private bool countrysField;
        
        private bool eventsField;
        
        private GoliaService.TimelineOptionsGeofencing geofencingField;
        
        private bool infringmentsField;
        
        private GoliaService.TimelineOptionsLul lulInfoField;
        
        private GoliaService.TimelineOptionsNationRealtime nationFromRealtimeField;
        
        private bool odometerDetailsField;
        
        private bool overwritedField;
        
        private bool tachoFileField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool absences
        {
            get
            {
                return this.absencesField;
            }
            set
            {
                this.absencesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool attachments
        {
            get
            {
                return this.attachmentsField;
            }
            set
            {
                this.attachmentsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool comments
        {
            get
            {
                return this.commentsField;
            }
            set
            {
                this.commentsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool countrys
        {
            get
            {
                return this.countrysField;
            }
            set
            {
                this.countrysField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool events
        {
            get
            {
                return this.eventsField;
            }
            set
            {
                this.eventsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.TimelineOptionsGeofencing geofencing
        {
            get
            {
                return this.geofencingField;
            }
            set
            {
                this.geofencingField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool infringments
        {
            get
            {
                return this.infringmentsField;
            }
            set
            {
                this.infringmentsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.TimelineOptionsLul lulInfo
        {
            get
            {
                return this.lulInfoField;
            }
            set
            {
                this.lulInfoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.TimelineOptionsNationRealtime nationFromRealtime
        {
            get
            {
                return this.nationFromRealtimeField;
            }
            set
            {
                this.nationFromRealtimeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool odometerDetails
        {
            get
            {
                return this.odometerDetailsField;
            }
            set
            {
                this.odometerDetailsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool overwrited
        {
            get
            {
                return this.overwritedField;
            }
            set
            {
                this.overwritedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool tachoFile
        {
            get
            {
                return this.tachoFileField;
            }
            set
            {
                this.tachoFileField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TimelineOptionsGeofencing", Namespace="https://www.golia.goliaweb.it/")]
    public partial class TimelineOptionsGeofencing : object
    {
        
        private bool geofencingField;
        
        private int geofencingMinField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public bool geofencing
        {
            get
            {
                return this.geofencingField;
            }
            set
            {
                this.geofencingField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int geofencingMin
        {
            get
            {
                return this.geofencingMinField;
            }
            set
            {
                this.geofencingMinField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TimelineOptionsLul", Namespace="https://www.golia.goliaweb.it/")]
    public partial class TimelineOptionsLul : object
    {
        
        private System.TimeSpan lulNightEndField;
        
        private System.TimeSpan lulNightStartField;
        
        private string lulTimeZoneField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.TimeSpan lulNightEnd
        {
            get
            {
                return this.lulNightEndField;
            }
            set
            {
                this.lulNightEndField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.TimeSpan lulNightStart
        {
            get
            {
                return this.lulNightStartField;
            }
            set
            {
                this.lulNightStartField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string lulTimeZone
        {
            get
            {
                return this.lulTimeZoneField;
            }
            set
            {
                this.lulTimeZoneField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TimelineOptionsNationRealtime", Namespace="https://www.golia.goliaweb.it/")]
    public partial class TimelineOptionsNationRealtime : object
    {
        
        private bool nationRealtimeField;
        
        private bool totalActivityNationRealtimeField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public bool nationRealtime
        {
            get
            {
                return this.nationRealtimeField;
            }
            set
            {
                this.nationRealtimeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public bool totalActivityNationRealtime
        {
            get
            {
                return this.totalActivityNationRealtimeField;
            }
            set
            {
                this.totalActivityNationRealtimeField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetTimelineResult", Namespace="https://www.golia.goliaweb.it/")]
    public partial class GetTimelineResult : object
    {
        
        private GoliaService.LoginResult loginResultField;
        
        private GoliaService.TimelineResult timelineResultField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.LoginResult loginResult
        {
            get
            {
                return this.loginResultField;
            }
            set
            {
                this.loginResultField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.TimelineResult timelineResult
        {
            get
            {
                return this.timelineResultField;
            }
            set
            {
                this.timelineResultField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TimelineResult", Namespace="https://www.golia.goliaweb.it/")]
    public partial class TimelineResult : object
    {
        
        private GoliaService.ActivityAbsence[] absencesField;
        
        private GoliaService.TimelineActivity[] activitiesField;
        
        private GoliaService.ActivityAttachments[] attachmentsField;
        
        private GoliaService.ActivityComments[] commentsField;
        
        private GoliaService.ActivityCountry[] countriesField;
        
        private GoliaService.ActivityAnalogicDisk[] disksField;
        
        private GoliaService.Driver[] driversField;
        
        private string[] errorsField;
        
        private GoliaService.ActivityEvents[] eventsField;
        
        private GoliaService.TimelineInfringment[] infringmentsField;
        
        private GoliaService.TimelineInsertionExtraction[] insertedExtratedField;
        
        private GoliaService.TimelineKmDay[] kmDaysField;
        
        private GoliaService.ActivityPositionDay[] nationsRealtimeField;
        
        private GoliaService.ActivityOverwrited[] overwritedField;
        
        private bool successField;
        
        private GoliaService.TimelineSummary[] summariesField;
        
        private GoliaService.TimelineSummary[] summariesDayField;
        
        private GoliaService.TimelineSummary[] summariesNightField;
        
        private GoliaService.ActivityTachoFiles[] tachoFilesField;
        
        private GoliaService.Vehicle[] vehiclesField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.ActivityAbsence[] absences
        {
            get
            {
                return this.absencesField;
            }
            set
            {
                this.absencesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.TimelineActivity[] activities
        {
            get
            {
                return this.activitiesField;
            }
            set
            {
                this.activitiesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.ActivityAttachments[] attachments
        {
            get
            {
                return this.attachmentsField;
            }
            set
            {
                this.attachmentsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.ActivityComments[] comments
        {
            get
            {
                return this.commentsField;
            }
            set
            {
                this.commentsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.ActivityCountry[] countries
        {
            get
            {
                return this.countriesField;
            }
            set
            {
                this.countriesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.ActivityAnalogicDisk[] disks
        {
            get
            {
                return this.disksField;
            }
            set
            {
                this.disksField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.Driver[] drivers
        {
            get
            {
                return this.driversField;
            }
            set
            {
                this.driversField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] errors
        {
            get
            {
                return this.errorsField;
            }
            set
            {
                this.errorsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.ActivityEvents[] events
        {
            get
            {
                return this.eventsField;
            }
            set
            {
                this.eventsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.TimelineInfringment[] infringments
        {
            get
            {
                return this.infringmentsField;
            }
            set
            {
                this.infringmentsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.TimelineInsertionExtraction[] insertedExtrated
        {
            get
            {
                return this.insertedExtratedField;
            }
            set
            {
                this.insertedExtratedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.TimelineKmDay[] kmDays
        {
            get
            {
                return this.kmDaysField;
            }
            set
            {
                this.kmDaysField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.ActivityPositionDay[] nationsRealtime
        {
            get
            {
                return this.nationsRealtimeField;
            }
            set
            {
                this.nationsRealtimeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.ActivityOverwrited[] overwrited
        {
            get
            {
                return this.overwritedField;
            }
            set
            {
                this.overwritedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool success
        {
            get
            {
                return this.successField;
            }
            set
            {
                this.successField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.TimelineSummary[] summaries
        {
            get
            {
                return this.summariesField;
            }
            set
            {
                this.summariesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.TimelineSummary[] summariesDay
        {
            get
            {
                return this.summariesDayField;
            }
            set
            {
                this.summariesDayField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.TimelineSummary[] summariesNight
        {
            get
            {
                return this.summariesNightField;
            }
            set
            {
                this.summariesNightField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.ActivityTachoFiles[] tachoFiles
        {
            get
            {
                return this.tachoFilesField;
            }
            set
            {
                this.tachoFilesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.Vehicle[] vehicles
        {
            get
            {
                return this.vehiclesField;
            }
            set
            {
                this.vehiclesField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ActivityAbsence", Namespace="https://www.golia.goliaweb.it/")]
    public partial class ActivityAbsence : object
    {
        
        private int companyIdField;
        
        private string cssField;
        
        private string descriptionField;
        
        private int driverIdField;
        
        private string iconField;
        
        private System.DateTime periodEndField;
        
        private System.DateTime periodStartField;
        
        private int secondsField;
        
        private int typeField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int companyId
        {
            get
            {
                return this.companyIdField;
            }
            set
            {
                this.companyIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string css
        {
            get
            {
                return this.cssField;
            }
            set
            {
                this.cssField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int driverId
        {
            get
            {
                return this.driverIdField;
            }
            set
            {
                this.driverIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string icon
        {
            get
            {
                return this.iconField;
            }
            set
            {
                this.iconField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime periodEnd
        {
            get
            {
                return this.periodEndField;
            }
            set
            {
                this.periodEndField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime periodStart
        {
            get
            {
                return this.periodStartField;
            }
            set
            {
                this.periodStartField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int seconds
        {
            get
            {
                return this.secondsField;
            }
            set
            {
                this.secondsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TimelineActivity", Namespace="https://www.golia.goliaweb.it/")]
    public partial class TimelineActivity : object
    {
        
        private int activityField;
        
        private int condSpecificField;
        
        private int crewField;
        
        private int driverIdField;
        
        private long durationField;
        
        private int extractedField;
        
        private System.DateTime periodField;
        
        private string provenienceField;
        
        private string provenienceDescriptionField;
        
        private int provenienceIdField;
        
        private int slotField;
        
        private string tachoCountryDescriptionField;
        
        private int tachoCountryIdField;
        
        private decimal tachoFileTypeField;
        
        private int vehicleIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int activity
        {
            get
            {
                return this.activityField;
            }
            set
            {
                this.activityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int condSpecific
        {
            get
            {
                return this.condSpecificField;
            }
            set
            {
                this.condSpecificField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int crew
        {
            get
            {
                return this.crewField;
            }
            set
            {
                this.crewField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int driverId
        {
            get
            {
                return this.driverIdField;
            }
            set
            {
                this.driverIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long duration
        {
            get
            {
                return this.durationField;
            }
            set
            {
                this.durationField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int extracted
        {
            get
            {
                return this.extractedField;
            }
            set
            {
                this.extractedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime period
        {
            get
            {
                return this.periodField;
            }
            set
            {
                this.periodField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string provenience
        {
            get
            {
                return this.provenienceField;
            }
            set
            {
                this.provenienceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string provenienceDescription
        {
            get
            {
                return this.provenienceDescriptionField;
            }
            set
            {
                this.provenienceDescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int provenienceId
        {
            get
            {
                return this.provenienceIdField;
            }
            set
            {
                this.provenienceIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int slot
        {
            get
            {
                return this.slotField;
            }
            set
            {
                this.slotField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string tachoCountryDescription
        {
            get
            {
                return this.tachoCountryDescriptionField;
            }
            set
            {
                this.tachoCountryDescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int tachoCountryId
        {
            get
            {
                return this.tachoCountryIdField;
            }
            set
            {
                this.tachoCountryIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal tachoFileType
        {
            get
            {
                return this.tachoFileTypeField;
            }
            set
            {
                this.tachoFileTypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int vehicleId
        {
            get
            {
                return this.vehicleIdField;
            }
            set
            {
                this.vehicleIdField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ActivityAttachments", Namespace="https://www.golia.goliaweb.it/")]
    public partial class ActivityAttachments : object
    {
        
        private GoliaService.ActivityAttachmentsDetail[] activityAttachmentsDetailField;
        
        private System.DateTime referPeriodField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.ActivityAttachmentsDetail[] activityAttachmentsDetail
        {
            get
            {
                return this.activityAttachmentsDetailField;
            }
            set
            {
                this.activityAttachmentsDetailField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime referPeriod
        {
            get
            {
                return this.referPeriodField;
            }
            set
            {
                this.referPeriodField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ActivityAttachmentsDetail", Namespace="https://www.golia.goliaweb.it/")]
    public partial class ActivityAttachmentsDetail : object
    {
        
        private string categoryField;
        
        private int companyIDField;
        
        private string descriptionField;
        
        private int documentIDField;
        
        private string driverCardField;
        
        private int driverIDField;
        
        private string fileNameField;
        
        private System.DateTime insertPeriodField;
        
        private string nameField;
        
        private string plateField;
        
        private System.DateTime referPeriodField;
        
        private string surnameField;
        
        private int vehicleIDField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string category
        {
            get
            {
                return this.categoryField;
            }
            set
            {
                this.categoryField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int companyID
        {
            get
            {
                return this.companyIDField;
            }
            set
            {
                this.companyIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int documentID
        {
            get
            {
                return this.documentIDField;
            }
            set
            {
                this.documentIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string driverCard
        {
            get
            {
                return this.driverCardField;
            }
            set
            {
                this.driverCardField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int driverID
        {
            get
            {
                return this.driverIDField;
            }
            set
            {
                this.driverIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string fileName
        {
            get
            {
                return this.fileNameField;
            }
            set
            {
                this.fileNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime insertPeriod
        {
            get
            {
                return this.insertPeriodField;
            }
            set
            {
                this.insertPeriodField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string plate
        {
            get
            {
                return this.plateField;
            }
            set
            {
                this.plateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime referPeriod
        {
            get
            {
                return this.referPeriodField;
            }
            set
            {
                this.referPeriodField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string surname
        {
            get
            {
                return this.surnameField;
            }
            set
            {
                this.surnameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int vehicleID
        {
            get
            {
                return this.vehicleIDField;
            }
            set
            {
                this.vehicleIDField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ActivityComments", Namespace="https://www.golia.goliaweb.it/")]
    public partial class ActivityComments : object
    {
        
        private GoliaService.ActivityCommentsDetail[] activityCommentsDetailField;
        
        private System.DateTime dayCommentPeriodField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.ActivityCommentsDetail[] activityCommentsDetail
        {
            get
            {
                return this.activityCommentsDetailField;
            }
            set
            {
                this.activityCommentsDetailField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime dayCommentPeriod
        {
            get
            {
                return this.dayCommentPeriodField;
            }
            set
            {
                this.dayCommentPeriodField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ActivityCommentsDetail", Namespace="https://www.golia.goliaweb.it/")]
    public partial class ActivityCommentsDetail : object
    {
        
        private int companyIDField;
        
        private System.DateTime dayCommentPeriodField;
        
        private string descriptionField;
        
        private int driverIDField;
        
        private int idMainDescriptionField;
        
        private int idSubDescriptionField;
        
        private System.DateTime insertPeriodField;
        
        private string rawDataField;
        
        private int vehicleIDField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int companyID
        {
            get
            {
                return this.companyIDField;
            }
            set
            {
                this.companyIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime dayCommentPeriod
        {
            get
            {
                return this.dayCommentPeriodField;
            }
            set
            {
                this.dayCommentPeriodField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int driverID
        {
            get
            {
                return this.driverIDField;
            }
            set
            {
                this.driverIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int idMainDescription
        {
            get
            {
                return this.idMainDescriptionField;
            }
            set
            {
                this.idMainDescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int idSubDescription
        {
            get
            {
                return this.idSubDescriptionField;
            }
            set
            {
                this.idSubDescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime insertPeriod
        {
            get
            {
                return this.insertPeriodField;
            }
            set
            {
                this.insertPeriodField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string rawData
        {
            get
            {
                return this.rawDataField;
            }
            set
            {
                this.rawDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int vehicleID
        {
            get
            {
                return this.vehicleIDField;
            }
            set
            {
                this.vehicleIDField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ActivityEvents", Namespace="https://www.golia.goliaweb.it/")]
    public partial class ActivityEvents : object
    {
        
        private string descriptionField;
        
        private string descriptionPurposeField;
        
        private int driverIDField;
        
        private System.DateTime endPeriodField;
        
        private int eventIDField;
        
        private System.DateTime referPeriodField;
        
        private System.DateTime referPeriod2Field;
        
        private string typeField;
        
        private int value1Field;
        
        private int value2Field;
        
        private int value3Field;
        
        private int vehicleIDField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string descriptionPurpose
        {
            get
            {
                return this.descriptionPurposeField;
            }
            set
            {
                this.descriptionPurposeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int driverID
        {
            get
            {
                return this.driverIDField;
            }
            set
            {
                this.driverIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime endPeriod
        {
            get
            {
                return this.endPeriodField;
            }
            set
            {
                this.endPeriodField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int eventID
        {
            get
            {
                return this.eventIDField;
            }
            set
            {
                this.eventIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime referPeriod
        {
            get
            {
                return this.referPeriodField;
            }
            set
            {
                this.referPeriodField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime referPeriod2
        {
            get
            {
                return this.referPeriod2Field;
            }
            set
            {
                this.referPeriod2Field = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int value1
        {
            get
            {
                return this.value1Field;
            }
            set
            {
                this.value1Field = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int value2
        {
            get
            {
                return this.value2Field;
            }
            set
            {
                this.value2Field = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int value3
        {
            get
            {
                return this.value3Field;
            }
            set
            {
                this.value3Field = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int vehicleID
        {
            get
            {
                return this.vehicleIDField;
            }
            set
            {
                this.vehicleIDField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TimelineInfringment", Namespace="https://www.golia.goliaweb.it/")]
    public partial class TimelineInfringment : object
    {
        
        private string articleField;
        
        private int driverIdField;
        
        private int gravityField;
        
        private int infringmentIdField;
        
        private string infringmentTextField;
        
        private System.DateTime periodField;
        
        private int regulationIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string article
        {
            get
            {
                return this.articleField;
            }
            set
            {
                this.articleField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int driverId
        {
            get
            {
                return this.driverIdField;
            }
            set
            {
                this.driverIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int gravity
        {
            get
            {
                return this.gravityField;
            }
            set
            {
                this.gravityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int infringmentId
        {
            get
            {
                return this.infringmentIdField;
            }
            set
            {
                this.infringmentIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string infringmentText
        {
            get
            {
                return this.infringmentTextField;
            }
            set
            {
                this.infringmentTextField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime period
        {
            get
            {
                return this.periodField;
            }
            set
            {
                this.periodField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int regulationId
        {
            get
            {
                return this.regulationIdField;
            }
            set
            {
                this.regulationIdField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TimelineInsertionExtraction", Namespace="https://www.golia.goliaweb.it/")]
    public partial class TimelineInsertionExtraction : object
    {
        
        private int driverIdField;
        
        private int extractedField;
        
        private System.DateTime periodField;
        
        private int slotField;
        
        private int vehicleIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int driverId
        {
            get
            {
                return this.driverIdField;
            }
            set
            {
                this.driverIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int extracted
        {
            get
            {
                return this.extractedField;
            }
            set
            {
                this.extractedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime period
        {
            get
            {
                return this.periodField;
            }
            set
            {
                this.periodField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int slot
        {
            get
            {
                return this.slotField;
            }
            set
            {
                this.slotField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int vehicleId
        {
            get
            {
                return this.vehicleIdField;
            }
            set
            {
                this.vehicleIdField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TimelineKmDay", Namespace="https://www.golia.goliaweb.it/")]
    public partial class TimelineKmDay : object
    {
        
        private GoliaService.VehicleDriverKm[] driversKmField;
        
        private int kmField;
        
        private System.DateTime periodEndField;
        
        private System.DateTime periodStartField;
        
        private GoliaService.VehicleDriverKm[] vehiclesKmField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.VehicleDriverKm[] driversKm
        {
            get
            {
                return this.driversKmField;
            }
            set
            {
                this.driversKmField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int km
        {
            get
            {
                return this.kmField;
            }
            set
            {
                this.kmField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime periodEnd
        {
            get
            {
                return this.periodEndField;
            }
            set
            {
                this.periodEndField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime periodStart
        {
            get
            {
                return this.periodStartField;
            }
            set
            {
                this.periodStartField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.VehicleDriverKm[] vehiclesKm
        {
            get
            {
                return this.vehiclesKmField;
            }
            set
            {
                this.vehiclesKmField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="VehicleDriverKm", Namespace="https://www.golia.goliaweb.it/")]
    public partial class VehicleDriverKm : object
    {
        
        private int drivenKmField;
        
        private int idField;
        
        private GoliaService.OdometerDate[] odometerDatesField;
        
        private int traveledKmField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int drivenKm
        {
            get
            {
                return this.drivenKmField;
            }
            set
            {
                this.drivenKmField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.OdometerDate[] odometerDates
        {
            get
            {
                return this.odometerDatesField;
            }
            set
            {
                this.odometerDatesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int traveledKm
        {
            get
            {
                return this.traveledKmField;
            }
            set
            {
                this.traveledKmField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="OdometerDate", Namespace="https://www.golia.goliaweb.it/")]
    public partial class OdometerDate : object
    {
        
        private int odometerField;
        
        private System.DateTime odometerDateField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int odometer
        {
            get
            {
                return this.odometerField;
            }
            set
            {
                this.odometerField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime odometerDate
        {
            get
            {
                return this.odometerDateField;
            }
            set
            {
                this.odometerDateField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ActivityPositionDay", Namespace="https://www.golia.goliaweb.it/")]
    public partial class ActivityPositionDay : object
    {
        
        private System.DateTime dateField;
        
        private GoliaService.ActivityPositionNation[] nationsField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.DateTime date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.ActivityPositionNation[] nations
        {
            get
            {
                return this.nationsField;
            }
            set
            {
                this.nationsField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ActivityPositionNation", Namespace="https://www.golia.goliaweb.it/")]
    public partial class ActivityPositionNation : object
    {
        
        private long availabilityField;
        
        private string codeField;
        
        private GoliaService.ActivityPositionNationPeriod[] datesField;
        
        private long driveField;
        
        private string nameField;
        
        private long restField;
        
        private long workField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public long availability
        {
            get
            {
                return this.availabilityField;
            }
            set
            {
                this.availabilityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.ActivityPositionNationPeriod[] dates
        {
            get
            {
                return this.datesField;
            }
            set
            {
                this.datesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public long drive
        {
            get
            {
                return this.driveField;
            }
            set
            {
                this.driveField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public long rest
        {
            get
            {
                return this.restField;
            }
            set
            {
                this.restField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public long work
        {
            get
            {
                return this.workField;
            }
            set
            {
                this.workField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ActivityPositionNationPeriod", Namespace="https://www.golia.goliaweb.it/")]
    public partial class ActivityPositionNationPeriod : object
    {
        
        private System.DateTime endField;
        
        private System.DateTime startField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.DateTime end
        {
            get
            {
                return this.endField;
            }
            set
            {
                this.endField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.DateTime start
        {
            get
            {
                return this.startField;
            }
            set
            {
                this.startField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ActivityOverwrited", Namespace="https://www.golia.goliaweb.it/")]
    public partial class ActivityOverwrited : object
    {
        
        private int activityField;
        
        private int condSpecificField;
        
        private int crewField;
        
        private int driverIDField;
        
        private long durationField;
        
        private int extractedField;
        
        private string motivationField;
        
        private int overwritedField;
        
        private System.DateTime overwriterDateField;
        
        private int overwriterIDField;
        
        private string overwriterNameField;
        
        private System.DateTime periodField;
        
        private string provenienceField;
        
        private string provenienceDescriptionField;
        
        private int slotField;
        
        private string tachoFileTypeField;
        
        private int vehicleIDField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int activity
        {
            get
            {
                return this.activityField;
            }
            set
            {
                this.activityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int condSpecific
        {
            get
            {
                return this.condSpecificField;
            }
            set
            {
                this.condSpecificField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int crew
        {
            get
            {
                return this.crewField;
            }
            set
            {
                this.crewField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int driverID
        {
            get
            {
                return this.driverIDField;
            }
            set
            {
                this.driverIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long duration
        {
            get
            {
                return this.durationField;
            }
            set
            {
                this.durationField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int extracted
        {
            get
            {
                return this.extractedField;
            }
            set
            {
                this.extractedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string motivation
        {
            get
            {
                return this.motivationField;
            }
            set
            {
                this.motivationField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int overwrited
        {
            get
            {
                return this.overwritedField;
            }
            set
            {
                this.overwritedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime overwriterDate
        {
            get
            {
                return this.overwriterDateField;
            }
            set
            {
                this.overwriterDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int overwriterID
        {
            get
            {
                return this.overwriterIDField;
            }
            set
            {
                this.overwriterIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string overwriterName
        {
            get
            {
                return this.overwriterNameField;
            }
            set
            {
                this.overwriterNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime period
        {
            get
            {
                return this.periodField;
            }
            set
            {
                this.periodField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string provenience
        {
            get
            {
                return this.provenienceField;
            }
            set
            {
                this.provenienceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string provenienceDescription
        {
            get
            {
                return this.provenienceDescriptionField;
            }
            set
            {
                this.provenienceDescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int slot
        {
            get
            {
                return this.slotField;
            }
            set
            {
                this.slotField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string tachoFileType
        {
            get
            {
                return this.tachoFileTypeField;
            }
            set
            {
                this.tachoFileTypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int vehicleID
        {
            get
            {
                return this.vehicleIDField;
            }
            set
            {
                this.vehicleIDField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TimelineSummary", Namespace="https://www.golia.goliaweb.it/")]
    public partial class TimelineSummary : object
    {
        
        private int driveBonusField;
        
        private int driverIdField;
        
        private GoliaService.ActivityGeofencing geofencingEndField;
        
        private GoliaService.ActivityGeofencing geofencingStartField;
        
        private System.DateTime periodEndField;
        
        private System.DateTime periodStartField;
        
        private int restBonusField;
        
        private long t00TotalRestField;
        
        private long t01AvailabilityField;
        
        private long t02WorkField;
        
        private long t03RoadDriveField;
        
        private long t04OutDriveField;
        
        private long t05DailyOrWeeklyRestField;
        
        private GoliaService.TimelineSummaryRestType t05DailyOrWeeklyRestTypeField;
        
        private long t06RestBreakTotalField;
        
        private long t07RestBreakTill15minutesField;
        
        private long t08RestBreakOver15minutesField;
        
        private long t09DailyWorkAsAvailabilityPlusWorkPlusDriveField;
        
        private long t10DailyWorkAsWorkingDayMinusRestDailyWeeklyField;
        
        private long t11ActivitySummaryAsWorkPlusDrivePlusOutDriveField;
        
        private long t12ActivitySummaryRoundedField;
        
        private long t13ActivitySummaryWithAvailabilityField;
        
        private long t14ActivitySummaryDRoundedField;
        
        private long t15ActivitySummaryInTrasfertField;
        
        private long t16ActivitySummaryInTrasfertWithAvailabilityField;
        
        private long t17RestCardInsertedField;
        
        private int usedDriveBonusField;
        
        private System.DateTime[] usedDriveBonusDateTimesField;
        
        private int usedRestBonusField;
        
        private System.DateTime[] usedRestBonusDateTimesField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int driveBonus
        {
            get
            {
                return this.driveBonusField;
            }
            set
            {
                this.driveBonusField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int driverId
        {
            get
            {
                return this.driverIdField;
            }
            set
            {
                this.driverIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.ActivityGeofencing geofencingEnd
        {
            get
            {
                return this.geofencingEndField;
            }
            set
            {
                this.geofencingEndField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.ActivityGeofencing geofencingStart
        {
            get
            {
                return this.geofencingStartField;
            }
            set
            {
                this.geofencingStartField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime periodEnd
        {
            get
            {
                return this.periodEndField;
            }
            set
            {
                this.periodEndField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime periodStart
        {
            get
            {
                return this.periodStartField;
            }
            set
            {
                this.periodStartField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int restBonus
        {
            get
            {
                return this.restBonusField;
            }
            set
            {
                this.restBonusField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long t00TotalRest
        {
            get
            {
                return this.t00TotalRestField;
            }
            set
            {
                this.t00TotalRestField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long t01Availability
        {
            get
            {
                return this.t01AvailabilityField;
            }
            set
            {
                this.t01AvailabilityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long t02Work
        {
            get
            {
                return this.t02WorkField;
            }
            set
            {
                this.t02WorkField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long t03RoadDrive
        {
            get
            {
                return this.t03RoadDriveField;
            }
            set
            {
                this.t03RoadDriveField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long t04OutDrive
        {
            get
            {
                return this.t04OutDriveField;
            }
            set
            {
                this.t04OutDriveField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long t05DailyOrWeeklyRest
        {
            get
            {
                return this.t05DailyOrWeeklyRestField;
            }
            set
            {
                this.t05DailyOrWeeklyRestField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.TimelineSummaryRestType t05DailyOrWeeklyRestType
        {
            get
            {
                return this.t05DailyOrWeeklyRestTypeField;
            }
            set
            {
                this.t05DailyOrWeeklyRestTypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long t06RestBreakTotal
        {
            get
            {
                return this.t06RestBreakTotalField;
            }
            set
            {
                this.t06RestBreakTotalField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long t07RestBreakTill15minutes
        {
            get
            {
                return this.t07RestBreakTill15minutesField;
            }
            set
            {
                this.t07RestBreakTill15minutesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long t08RestBreakOver15minutes
        {
            get
            {
                return this.t08RestBreakOver15minutesField;
            }
            set
            {
                this.t08RestBreakOver15minutesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long t09DailyWorkAsAvailabilityPlusWorkPlusDrive
        {
            get
            {
                return this.t09DailyWorkAsAvailabilityPlusWorkPlusDriveField;
            }
            set
            {
                this.t09DailyWorkAsAvailabilityPlusWorkPlusDriveField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long t10DailyWorkAsWorkingDayMinusRestDailyWeekly
        {
            get
            {
                return this.t10DailyWorkAsWorkingDayMinusRestDailyWeeklyField;
            }
            set
            {
                this.t10DailyWorkAsWorkingDayMinusRestDailyWeeklyField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long t11ActivitySummaryAsWorkPlusDrivePlusOutDrive
        {
            get
            {
                return this.t11ActivitySummaryAsWorkPlusDrivePlusOutDriveField;
            }
            set
            {
                this.t11ActivitySummaryAsWorkPlusDrivePlusOutDriveField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long t12ActivitySummaryRounded
        {
            get
            {
                return this.t12ActivitySummaryRoundedField;
            }
            set
            {
                this.t12ActivitySummaryRoundedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long t13ActivitySummaryWithAvailability
        {
            get
            {
                return this.t13ActivitySummaryWithAvailabilityField;
            }
            set
            {
                this.t13ActivitySummaryWithAvailabilityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long t14ActivitySummaryDRounded
        {
            get
            {
                return this.t14ActivitySummaryDRoundedField;
            }
            set
            {
                this.t14ActivitySummaryDRoundedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long t15ActivitySummaryInTrasfert
        {
            get
            {
                return this.t15ActivitySummaryInTrasfertField;
            }
            set
            {
                this.t15ActivitySummaryInTrasfertField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long t16ActivitySummaryInTrasfertWithAvailability
        {
            get
            {
                return this.t16ActivitySummaryInTrasfertWithAvailabilityField;
            }
            set
            {
                this.t16ActivitySummaryInTrasfertWithAvailabilityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long t17RestCardInserted
        {
            get
            {
                return this.t17RestCardInsertedField;
            }
            set
            {
                this.t17RestCardInsertedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int usedDriveBonus
        {
            get
            {
                return this.usedDriveBonusField;
            }
            set
            {
                this.usedDriveBonusField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime[] usedDriveBonusDateTimes
        {
            get
            {
                return this.usedDriveBonusDateTimesField;
            }
            set
            {
                this.usedDriveBonusDateTimesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int usedRestBonus
        {
            get
            {
                return this.usedRestBonusField;
            }
            set
            {
                this.usedRestBonusField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime[] usedRestBonusDateTimes
        {
            get
            {
                return this.usedRestBonusDateTimesField;
            }
            set
            {
                this.usedRestBonusDateTimesField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ActivityGeofencing", Namespace="https://www.golia.goliaweb.it/")]
    public partial class ActivityGeofencing : object
    {
        
        private bool inOfficeField;
        
        private double latitudeField;
        
        private double longitudeField;
        
        private double officeDistanceField;
        
        private int officeIdField;
        
        private double officeLatField;
        
        private double officeLongField;
        
        private string officeNameField;
        
        private System.DateTime periodField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool inOffice
        {
            get
            {
                return this.inOfficeField;
            }
            set
            {
                this.inOfficeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double latitude
        {
            get
            {
                return this.latitudeField;
            }
            set
            {
                this.latitudeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double longitude
        {
            get
            {
                return this.longitudeField;
            }
            set
            {
                this.longitudeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double officeDistance
        {
            get
            {
                return this.officeDistanceField;
            }
            set
            {
                this.officeDistanceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int officeId
        {
            get
            {
                return this.officeIdField;
            }
            set
            {
                this.officeIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double officeLat
        {
            get
            {
                return this.officeLatField;
            }
            set
            {
                this.officeLatField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double officeLong
        {
            get
            {
                return this.officeLongField;
            }
            set
            {
                this.officeLongField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string officeName
        {
            get
            {
                return this.officeNameField;
            }
            set
            {
                this.officeNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime period
        {
            get
            {
                return this.periodField;
            }
            set
            {
                this.periodField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TimelineSummaryRestType", Namespace="https://www.golia.goliaweb.it/")]
    public enum TimelineSummaryRestType : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        RESERVED = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        DAILY_REDUCED_9 = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        DAILY_REGULAR_11 = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        DAILY_3_PLUS_9 = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        WEEKLY_REGULAR_45 = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        WEEKLY_REDUCED_24 = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        MINIMUM_DAILY_BREAK_7 = 6,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        WEEKLY_REDUCED_TO_DAILY = 7,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ActivityTachoFiles", Namespace="https://www.golia.goliaweb.it/")]
    public partial class ActivityTachoFiles : object
    {
        
        private string descriptionField;
        
        private int driverIDField;
        
        private string filenameField;
        
        private System.DateTime periodEndField;
        
        private System.DateTime periodLocalEndField;
        
        private System.DateTime periodLocalStartField;
        
        private System.DateTime periodStartField;
        
        private int tachoIDField;
        
        private System.DateTime uploadField;
        
        private int vehicleIDField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int driverID
        {
            get
            {
                return this.driverIDField;
            }
            set
            {
                this.driverIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string filename
        {
            get
            {
                return this.filenameField;
            }
            set
            {
                this.filenameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime periodEnd
        {
            get
            {
                return this.periodEndField;
            }
            set
            {
                this.periodEndField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime periodLocalEnd
        {
            get
            {
                return this.periodLocalEndField;
            }
            set
            {
                this.periodLocalEndField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime periodLocalStart
        {
            get
            {
                return this.periodLocalStartField;
            }
            set
            {
                this.periodLocalStartField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime periodStart
        {
            get
            {
                return this.periodStartField;
            }
            set
            {
                this.periodStartField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int tachoID
        {
            get
            {
                return this.tachoIDField;
            }
            set
            {
                this.tachoIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime upload
        {
            get
            {
                return this.uploadField;
            }
            set
            {
                this.uploadField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int vehicleID
        {
            get
            {
                return this.vehicleIDField;
            }
            set
            {
                this.vehicleIDField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetDriverActivityRequest", Namespace="https://www.golia.goliaweb.it/")]
    public partial class GetDriverActivityRequest : object
    {
        
        private int driverIdField;
        
        private GoliaService.LoginCompanyCultureRequest loginCompanyRequestField;
        
        private bool onlyRealtimeField;
        
        private System.DateTime periodEndField;
        
        private System.DateTime periodStartField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int driverId
        {
            get
            {
                return this.driverIdField;
            }
            set
            {
                this.driverIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.LoginCompanyCultureRequest loginCompanyRequest
        {
            get
            {
                return this.loginCompanyRequestField;
            }
            set
            {
                this.loginCompanyRequestField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool onlyRealtime
        {
            get
            {
                return this.onlyRealtimeField;
            }
            set
            {
                this.onlyRealtimeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.DateTime periodEnd
        {
            get
            {
                return this.periodEndField;
            }
            set
            {
                this.periodEndField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.DateTime periodStart
        {
            get
            {
                return this.periodStartField;
            }
            set
            {
                this.periodStartField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetDriverActivityResult", Namespace="https://www.golia.goliaweb.it/")]
    public partial class GetDriverActivityResult : object
    {
        
        private GoliaService.DriverIdentityActivity[] driverActivityResultField;
        
        private GoliaService.LoginResult loginResultField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.DriverIdentityActivity[] driverActivityResult
        {
            get
            {
                return this.driverActivityResultField;
            }
            set
            {
                this.driverActivityResultField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.LoginResult loginResult
        {
            get
            {
                return this.loginResultField;
            }
            set
            {
                this.loginResultField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DriverIdentityActivity", Namespace="https://www.golia.goliaweb.it/")]
    public partial class DriverIdentityActivity : object
    {
        
        private GoliaService.DriverActivity[] activityField;
        
        private GoliaService.Driver driverField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.DriverActivity[] activity
        {
            get
            {
                return this.activityField;
            }
            set
            {
                this.activityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.Driver driver
        {
            get
            {
                return this.driverField;
            }
            set
            {
                this.driverField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DriverActivity", Namespace="https://www.golia.goliaweb.it/")]
    public partial class DriverActivity : object
    {
        
        private System.TimeSpan activityTotalTimeField;
        
        private System.TimeSpan availabilityField;
        
        private System.TimeSpan consecutiveDriveField;
        
        private System.TimeSpan driveField;
        
        private int driverDrivenKmField;
        
        private System.DateTime endActivityField;
        
        private bool proportionalAlgorithmField;
        
        private System.TimeSpan restField;
        
        private System.DateTime startActivityField;
        
        private GoliaService.DriverActivityVehicle[] vehiclesField;
        
        private System.TimeSpan workField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.TimeSpan activityTotalTime
        {
            get
            {
                return this.activityTotalTimeField;
            }
            set
            {
                this.activityTotalTimeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.TimeSpan availability
        {
            get
            {
                return this.availabilityField;
            }
            set
            {
                this.availabilityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.TimeSpan consecutiveDrive
        {
            get
            {
                return this.consecutiveDriveField;
            }
            set
            {
                this.consecutiveDriveField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.TimeSpan drive
        {
            get
            {
                return this.driveField;
            }
            set
            {
                this.driveField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int driverDrivenKm
        {
            get
            {
                return this.driverDrivenKmField;
            }
            set
            {
                this.driverDrivenKmField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime endActivity
        {
            get
            {
                return this.endActivityField;
            }
            set
            {
                this.endActivityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool proportionalAlgorithm
        {
            get
            {
                return this.proportionalAlgorithmField;
            }
            set
            {
                this.proportionalAlgorithmField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.TimeSpan rest
        {
            get
            {
                return this.restField;
            }
            set
            {
                this.restField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime startActivity
        {
            get
            {
                return this.startActivityField;
            }
            set
            {
                this.startActivityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.DriverActivityVehicle[] vehicles
        {
            get
            {
                return this.vehiclesField;
            }
            set
            {
                this.vehiclesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.TimeSpan work
        {
            get
            {
                return this.workField;
            }
            set
            {
                this.workField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DriverActivityVehicle", Namespace="https://www.golia.goliaweb.it/")]
    public partial class DriverActivityVehicle : object
    {
        
        private int endKmField;
        
        private string plateField;
        
        private int startKmField;
        
        private bool usedField;
        
        private int vehicleIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int endKm
        {
            get
            {
                return this.endKmField;
            }
            set
            {
                this.endKmField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string plate
        {
            get
            {
                return this.plateField;
            }
            set
            {
                this.plateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int startKm
        {
            get
            {
                return this.startKmField;
            }
            set
            {
                this.startKmField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool used
        {
            get
            {
                return this.usedField;
            }
            set
            {
                this.usedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int vehicleId
        {
            get
            {
                return this.vehicleIdField;
            }
            set
            {
                this.vehicleIdField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetMissingTachoFilePeriodsRequest", Namespace="https://www.golia.goliaweb.it/")]
    public partial class GetMissingTachoFilePeriodsRequest : object
    {
        
        private int driverIdField;
        
        private GoliaService.LoginCompanyCultureRequest loginCompanyRequestField;
        
        private bool showDetailField;
        
        private int vehicleIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int driverId
        {
            get
            {
                return this.driverIdField;
            }
            set
            {
                this.driverIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.LoginCompanyCultureRequest loginCompanyRequest
        {
            get
            {
                return this.loginCompanyRequestField;
            }
            set
            {
                this.loginCompanyRequestField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool showDetail
        {
            get
            {
                return this.showDetailField;
            }
            set
            {
                this.showDetailField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int vehicleId
        {
            get
            {
                return this.vehicleIdField;
            }
            set
            {
                this.vehicleIdField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetMissingTachoFilePeriodsResult", Namespace="https://www.golia.goliaweb.it/")]
    public partial class GetMissingTachoFilePeriodsResult : object
    {
        
        private GoliaService.LoginResult loginResultField;
        
        private GoliaService.MissingTachoFile[] missingTachoFileDriversField;
        
        private GoliaService.MissingTachoFile[] missingTachoFileVehiclesField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.LoginResult loginResult
        {
            get
            {
                return this.loginResultField;
            }
            set
            {
                this.loginResultField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.MissingTachoFile[] missingTachoFileDrivers
        {
            get
            {
                return this.missingTachoFileDriversField;
            }
            set
            {
                this.missingTachoFileDriversField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.MissingTachoFile[] missingTachoFileVehicles
        {
            get
            {
                return this.missingTachoFileVehiclesField;
            }
            set
            {
                this.missingTachoFileVehiclesField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MissingTachoFile", Namespace="https://www.golia.goliaweb.it/")]
    public partial class MissingTachoFile : object
    {
        
        private GoliaService.DetailTachoFilePeriod[] detailTachoFilePeriodsField;
        
        private string driverCardField;
        
        private int driverIdField;
        
        private string driverNameField;
        
        private GoliaService.TachoFile firstFileField;
        
        private GoliaService.TachoFile lastFileField;
        
        private GoliaService.MissingTachoFilePeriod[] missingTachoFilePeriodsField;
        
        private int tachoFilesNumberField;
        
        private string vechileChassisField;
        
        private int vehicleIdField;
        
        private string vehiclePlateField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.DetailTachoFilePeriod[] detailTachoFilePeriods
        {
            get
            {
                return this.detailTachoFilePeriodsField;
            }
            set
            {
                this.detailTachoFilePeriodsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string driverCard
        {
            get
            {
                return this.driverCardField;
            }
            set
            {
                this.driverCardField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int driverId
        {
            get
            {
                return this.driverIdField;
            }
            set
            {
                this.driverIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string driverName
        {
            get
            {
                return this.driverNameField;
            }
            set
            {
                this.driverNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.TachoFile firstFile
        {
            get
            {
                return this.firstFileField;
            }
            set
            {
                this.firstFileField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.TachoFile lastFile
        {
            get
            {
                return this.lastFileField;
            }
            set
            {
                this.lastFileField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.MissingTachoFilePeriod[] missingTachoFilePeriods
        {
            get
            {
                return this.missingTachoFilePeriodsField;
            }
            set
            {
                this.missingTachoFilePeriodsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int tachoFilesNumber
        {
            get
            {
                return this.tachoFilesNumberField;
            }
            set
            {
                this.tachoFilesNumberField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string vechileChassis
        {
            get
            {
                return this.vechileChassisField;
            }
            set
            {
                this.vechileChassisField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int vehicleId
        {
            get
            {
                return this.vehicleIdField;
            }
            set
            {
                this.vehicleIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string vehiclePlate
        {
            get
            {
                return this.vehiclePlateField;
            }
            set
            {
                this.vehiclePlateField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DetailTachoFilePeriod", Namespace="https://www.golia.goliaweb.it/")]
    public partial class DetailTachoFilePeriod : object
    {
        
        private string colorField;
        
        private string driverCardField;
        
        private string fileNameField;
        
        private bool isMissingTachoFilePeriodField;
        
        private System.DateTime periodEndField;
        
        private System.DateTime periodStartField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string color
        {
            get
            {
                return this.colorField;
            }
            set
            {
                this.colorField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string driverCard
        {
            get
            {
                return this.driverCardField;
            }
            set
            {
                this.driverCardField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string fileName
        {
            get
            {
                return this.fileNameField;
            }
            set
            {
                this.fileNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool isMissingTachoFilePeriod
        {
            get
            {
                return this.isMissingTachoFilePeriodField;
            }
            set
            {
                this.isMissingTachoFilePeriodField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime periodEnd
        {
            get
            {
                return this.periodEndField;
            }
            set
            {
                this.periodEndField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime periodStart
        {
            get
            {
                return this.periodStartField;
            }
            set
            {
                this.periodStartField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TachoFile", Namespace="https://www.golia.goliaweb.it/")]
    public partial class TachoFile : object
    {
        
        private string cardIdField;
        
        private bool checkDigitalSignField;
        
        private int driverIdField;
        
        private string errorField;
        
        private byte[] fileContentField;
        
        private string fileNameField;
        
        private string nameField;
        
        private System.Nullable<System.DateTime> periodEndField;
        
        private System.Nullable<System.DateTime> periodStartField;
        
        private int provenienceField;
        
        private string surnameField;
        
        private System.Nullable<System.DateTime> uploadDateField;
        
        private int vehicleIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cardId
        {
            get
            {
                return this.cardIdField;
            }
            set
            {
                this.cardIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool checkDigitalSign
        {
            get
            {
                return this.checkDigitalSignField;
            }
            set
            {
                this.checkDigitalSignField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int driverId
        {
            get
            {
                return this.driverIdField;
            }
            set
            {
                this.driverIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string error
        {
            get
            {
                return this.errorField;
            }
            set
            {
                this.errorField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] fileContent
        {
            get
            {
                return this.fileContentField;
            }
            set
            {
                this.fileContentField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string fileName
        {
            get
            {
                return this.fileNameField;
            }
            set
            {
                this.fileNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> periodEnd
        {
            get
            {
                return this.periodEndField;
            }
            set
            {
                this.periodEndField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> periodStart
        {
            get
            {
                return this.periodStartField;
            }
            set
            {
                this.periodStartField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int provenience
        {
            get
            {
                return this.provenienceField;
            }
            set
            {
                this.provenienceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string surname
        {
            get
            {
                return this.surnameField;
            }
            set
            {
                this.surnameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> uploadDate
        {
            get
            {
                return this.uploadDateField;
            }
            set
            {
                this.uploadDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int vehicleId
        {
            get
            {
                return this.vehicleIdField;
            }
            set
            {
                this.vehicleIdField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MissingTachoFilePeriod", Namespace="https://www.golia.goliaweb.it/")]
    public partial class MissingTachoFilePeriod : object
    {
        
        private System.DateTime periodEndField;
        
        private System.DateTime periodStartField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime periodEnd
        {
            get
            {
                return this.periodEndField;
            }
            set
            {
                this.periodEndField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime periodStart
        {
            get
            {
                return this.periodStartField;
            }
            set
            {
                this.periodStartField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SetVehicleRequest", Namespace="https://www.golia.goliaweb.it/")]
    public partial class SetVehicleRequest : object
    {
        
        private GoliaService.LoginCompanyCultureRequest loginCompanyRequestField;
        
        private GoliaService.Vehicle vehicleField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.LoginCompanyCultureRequest loginCompanyRequest
        {
            get
            {
                return this.loginCompanyRequestField;
            }
            set
            {
                this.loginCompanyRequestField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.Vehicle vehicle
        {
            get
            {
                return this.vehicleField;
            }
            set
            {
                this.vehicleField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SetVehicleResult", Namespace="https://www.golia.goliaweb.it/")]
    public partial class SetVehicleResult : object
    {
        
        private GoliaService.LoginResult loginResultField;
        
        private bool vehicleUpdatedField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.LoginResult loginResult
        {
            get
            {
                return this.loginResultField;
            }
            set
            {
                this.loginResultField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool vehicleUpdated
        {
            get
            {
                return this.vehicleUpdatedField;
            }
            set
            {
                this.vehicleUpdatedField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SetDriverRequest", Namespace="https://www.golia.goliaweb.it/")]
    public partial class SetDriverRequest : object
    {
        
        private GoliaService.Driver driverField;
        
        private GoliaService.LoginCompanyCultureRequest loginCompanyRequestField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.Driver driver
        {
            get
            {
                return this.driverField;
            }
            set
            {
                this.driverField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.LoginCompanyCultureRequest loginCompanyRequest
        {
            get
            {
                return this.loginCompanyRequestField;
            }
            set
            {
                this.loginCompanyRequestField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SetDriverResult", Namespace="https://www.golia.goliaweb.it/")]
    public partial class SetDriverResult : object
    {
        
        private bool driverUpdatedField;
        
        private GoliaService.LoginResult loginResultField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool driverUpdated
        {
            get
            {
                return this.driverUpdatedField;
            }
            set
            {
                this.driverUpdatedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.LoginResult loginResult
        {
            get
            {
                return this.loginResultField;
            }
            set
            {
                this.loginResultField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="InsertCompanyUserRequest", Namespace="https://www.golia.goliaweb.it/")]
    public partial class InsertCompanyUserRequest : object
    {
        
        private GoliaService.Company companyField;
        
        private GoliaService.LoginRequest loginCredentialsField;
        
        private GoliaService.User userField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.Company company
        {
            get
            {
                return this.companyField;
            }
            set
            {
                this.companyField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.LoginRequest loginCredentials
        {
            get
            {
                return this.loginCredentialsField;
            }
            set
            {
                this.loginCredentialsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.User user
        {
            get
            {
                return this.userField;
            }
            set
            {
                this.userField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="https://www.golia.goliaweb.it/")]
    public partial class User : object
    {
        
        private bool activeField;
        
        private bool autoLoginUserField;
        
        private string descriptionField;
        
        private System.Nullable<System.DateTime> expireDateField;
        
        private string loginField;
        
        private string passwordField;
        
        private System.Nullable<System.DateTime> passwordExpireDateField;
        
        private string remoteIdField;
        
        private int userIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public bool active
        {
            get
            {
                return this.activeField;
            }
            set
            {
                this.activeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool autoLoginUser
        {
            get
            {
                return this.autoLoginUserField;
            }
            set
            {
                this.autoLoginUserField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> expireDate
        {
            get
            {
                return this.expireDateField;
            }
            set
            {
                this.expireDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string login
        {
            get
            {
                return this.loginField;
            }
            set
            {
                this.loginField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string password
        {
            get
            {
                return this.passwordField;
            }
            set
            {
                this.passwordField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> passwordExpireDate
        {
            get
            {
                return this.passwordExpireDateField;
            }
            set
            {
                this.passwordExpireDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string remoteId
        {
            get
            {
                return this.remoteIdField;
            }
            set
            {
                this.remoteIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int userId
        {
            get
            {
                return this.userIdField;
            }
            set
            {
                this.userIdField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="InsertCompanyUserResult", Namespace="https://www.golia.goliaweb.it/")]
    public partial class InsertCompanyUserResult : object
    {
        
        private bool companyCreatedField;
        
        private GoliaService.LoginResult loginResultField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool companyCreated
        {
            get
            {
                return this.companyCreatedField;
            }
            set
            {
                this.companyCreatedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.LoginResult loginResult
        {
            get
            {
                return this.loginResultField;
            }
            set
            {
                this.loginResultField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetTachoFileRequest", Namespace="https://www.golia.goliaweb.it/")]
    public partial class GetTachoFileRequest : object
    {
        
        private GoliaService.LoginCompanyCultureRequest loginCompanyRequestField;
        
        private int tachoFileIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.LoginCompanyCultureRequest loginCompanyRequest
        {
            get
            {
                return this.loginCompanyRequestField;
            }
            set
            {
                this.loginCompanyRequestField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int tachoFileId
        {
            get
            {
                return this.tachoFileIdField;
            }
            set
            {
                this.tachoFileIdField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetTachoFileResult", Namespace="https://www.golia.goliaweb.it/")]
    public partial class GetTachoFileResult : object
    {
        
        private GoliaService.LoginResult loginResultField;
        
        private GoliaService.TachoFile tachoFileField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.LoginResult loginResult
        {
            get
            {
                return this.loginResultField;
            }
            set
            {
                this.loginResultField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.TachoFile tachoFile
        {
            get
            {
                return this.tachoFileField;
            }
            set
            {
                this.tachoFileField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetDiskFileRequest", Namespace="https://www.golia.goliaweb.it/")]
    public partial class GetDiskFileRequest : object
    {
        
        private int diskFileIdField;
        
        private GoliaService.LoginCompanyCultureRequest loginCompanyRequestField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int diskFileId
        {
            get
            {
                return this.diskFileIdField;
            }
            set
            {
                this.diskFileIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.LoginCompanyCultureRequest loginCompanyRequest
        {
            get
            {
                return this.loginCompanyRequestField;
            }
            set
            {
                this.loginCompanyRequestField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetDiskFileResult", Namespace="https://www.golia.goliaweb.it/")]
    public partial class GetDiskFileResult : object
    {
        
        private GoliaService.DiskFile diskFileField;
        
        private GoliaService.LoginResult loginResultField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.DiskFile diskFile
        {
            get
            {
                return this.diskFileField;
            }
            set
            {
                this.diskFileField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.LoginResult loginResult
        {
            get
            {
                return this.loginResultField;
            }
            set
            {
                this.loginResultField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DiskFile", Namespace="https://www.golia.goliaweb.it/")]
    public partial class DiskFile : object
    {
        
        private int driverIdField;
        
        private string errorField;
        
        private byte[] fileContentField;
        
        private string fileNameField;
        
        private string nameField;
        
        private System.Nullable<System.DateTime> periodEndField;
        
        private System.Nullable<System.DateTime> periodStartField;
        
        private int provenienceField;
        
        private string surnameField;
        
        private System.Nullable<System.DateTime> uploadDateField;
        
        private int vehicleIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int driverId
        {
            get
            {
                return this.driverIdField;
            }
            set
            {
                this.driverIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string error
        {
            get
            {
                return this.errorField;
            }
            set
            {
                this.errorField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] fileContent
        {
            get
            {
                return this.fileContentField;
            }
            set
            {
                this.fileContentField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string fileName
        {
            get
            {
                return this.fileNameField;
            }
            set
            {
                this.fileNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> periodEnd
        {
            get
            {
                return this.periodEndField;
            }
            set
            {
                this.periodEndField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> periodStart
        {
            get
            {
                return this.periodStartField;
            }
            set
            {
                this.periodStartField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int provenience
        {
            get
            {
                return this.provenienceField;
            }
            set
            {
                this.provenienceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string surname
        {
            get
            {
                return this.surnameField;
            }
            set
            {
                this.surnameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> uploadDate
        {
            get
            {
                return this.uploadDateField;
            }
            set
            {
                this.uploadDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int vehicleId
        {
            get
            {
                return this.vehicleIdField;
            }
            set
            {
                this.vehicleIdField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetTachoFileTextExplainResult", Namespace="https://www.golia.goliaweb.it/")]
    public partial class GetTachoFileTextExplainResult : object
    {
        
        private GoliaService.LoginResult loginResultField;
        
        private string textExplainField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.LoginResult loginResult
        {
            get
            {
                return this.loginResultField;
            }
            set
            {
                this.loginResultField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string textExplain
        {
            get
            {
                return this.textExplainField;
            }
            set
            {
                this.textExplainField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetInfringmentsReportRequest", Namespace="https://www.golia.goliaweb.it/")]
    public partial class GetInfringmentsReportRequest : object
    {
        
        private int driversField;
        
        private string fileTypeField;
        
        private bool graphicField;
        
        private int[] infringmentsListField;
        
        private GoliaService.LoginCompanyCultureRequest loginCompanyRequestField;
        
        private byte[] logoField;
        
        private bool orderByInfringmentsField;
        
        private System.DateTime periodEndField;
        
        private System.DateTime periodStartField;
        
        private string reportOrderField;
        
        private string reportTypeField;
        
        private bool solarDayField;
        
        private int vehiclesField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int drivers
        {
            get
            {
                return this.driversField;
            }
            set
            {
                this.driversField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string fileType
        {
            get
            {
                return this.fileTypeField;
            }
            set
            {
                this.fileTypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public bool graphic
        {
            get
            {
                return this.graphicField;
            }
            set
            {
                this.graphicField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int[] infringmentsList
        {
            get
            {
                return this.infringmentsListField;
            }
            set
            {
                this.infringmentsListField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.LoginCompanyCultureRequest loginCompanyRequest
        {
            get
            {
                return this.loginCompanyRequestField;
            }
            set
            {
                this.loginCompanyRequestField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public byte[] logo
        {
            get
            {
                return this.logoField;
            }
            set
            {
                this.logoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public bool orderByInfringments
        {
            get
            {
                return this.orderByInfringmentsField;
            }
            set
            {
                this.orderByInfringmentsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.DateTime periodEnd
        {
            get
            {
                return this.periodEndField;
            }
            set
            {
                this.periodEndField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.DateTime periodStart
        {
            get
            {
                return this.periodStartField;
            }
            set
            {
                this.periodStartField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string reportOrder
        {
            get
            {
                return this.reportOrderField;
            }
            set
            {
                this.reportOrderField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string reportType
        {
            get
            {
                return this.reportTypeField;
            }
            set
            {
                this.reportTypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public bool solarDay
        {
            get
            {
                return this.solarDayField;
            }
            set
            {
                this.solarDayField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int vehicles
        {
            get
            {
                return this.vehiclesField;
            }
            set
            {
                this.vehiclesField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetInfringmentsReportResult", Namespace="https://www.golia.goliaweb.it/")]
    public partial class GetInfringmentsReportResult : object
    {
        
        private GoliaService.Infringment[] InfringmentsField;
        
        private byte[] fileResultField;
        
        private string fileTypeField;
        
        private GoliaService.LoginResult loginResultField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.Infringment[] Infringments
        {
            get
            {
                return this.InfringmentsField;
            }
            set
            {
                this.InfringmentsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] fileResult
        {
            get
            {
                return this.fileResultField;
            }
            set
            {
                this.fileResultField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string fileType
        {
            get
            {
                return this.fileTypeField;
            }
            set
            {
                this.fileTypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.LoginResult loginResult
        {
            get
            {
                return this.loginResultField;
            }
            set
            {
                this.loginResultField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SendPositionsRequest", Namespace="https://www.golia.goliaweb.it/")]
    public partial class SendPositionsRequest : object
    {
        
        private string ProvenienceCodeField;
        
        private GoliaService.LoginCompanyCultureRequest loginCredentialsField;
        
        private GoliaService.SendPositionsPosition[] positionsField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string ProvenienceCode
        {
            get
            {
                return this.ProvenienceCodeField;
            }
            set
            {
                this.ProvenienceCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.LoginCompanyCultureRequest loginCredentials
        {
            get
            {
                return this.loginCredentialsField;
            }
            set
            {
                this.loginCredentialsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.SendPositionsPosition[] positions
        {
            get
            {
                return this.positionsField;
            }
            set
            {
                this.positionsField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SendPositionsPosition", Namespace="https://www.golia.goliaweb.it/")]
    public partial class SendPositionsPosition : object
    {
        
        private double altitudeField;
        
        private GoliaService.driverRequest driverField;
        
        private GoliaService.driverRequest driver2Field;
        
        private double headingField;
        
        private double latitudeField;
        
        private double longitudeField;
        
        private System.DateTime movementDateField;
        
        private int odometerField;
        
        private double speedField;
        
        private GoliaService.vehicleRequest vehicleField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double altitude
        {
            get
            {
                return this.altitudeField;
            }
            set
            {
                this.altitudeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.driverRequest driver
        {
            get
            {
                return this.driverField;
            }
            set
            {
                this.driverField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.driverRequest driver2
        {
            get
            {
                return this.driver2Field;
            }
            set
            {
                this.driver2Field = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double heading
        {
            get
            {
                return this.headingField;
            }
            set
            {
                this.headingField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public double latitude
        {
            get
            {
                return this.latitudeField;
            }
            set
            {
                this.latitudeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public double longitude
        {
            get
            {
                return this.longitudeField;
            }
            set
            {
                this.longitudeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.DateTime movementDate
        {
            get
            {
                return this.movementDateField;
            }
            set
            {
                this.movementDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int odometer
        {
            get
            {
                return this.odometerField;
            }
            set
            {
                this.odometerField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double speed
        {
            get
            {
                return this.speedField;
            }
            set
            {
                this.speedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.vehicleRequest vehicle
        {
            get
            {
                return this.vehicleField;
            }
            set
            {
                this.vehicleField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SendPositionsResult", Namespace="https://www.golia.goliaweb.it/")]
    public partial class SendPositionsResult : object
    {
        
        private GoliaService.LoginResult loginResultField;
        
        private GoliaService.SendPositionsStatus sendPositionsStatusField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.LoginResult loginResult
        {
            get
            {
                return this.loginResultField;
            }
            set
            {
                this.loginResultField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.SendPositionsStatus sendPositionsStatus
        {
            get
            {
                return this.sendPositionsStatusField;
            }
            set
            {
                this.sendPositionsStatusField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SendPositionsStatus", Namespace="https://www.golia.goliaweb.it/")]
    public partial class SendPositionsStatus : object
    {
        
        private GoliaService.SendPositionsError[] errorsField;
        
        private int numPositionsFailedField;
        
        private int numPositionsInsertedField;
        
        private int numPositionsSentField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.SendPositionsError[] errors
        {
            get
            {
                return this.errorsField;
            }
            set
            {
                this.errorsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int numPositionsFailed
        {
            get
            {
                return this.numPositionsFailedField;
            }
            set
            {
                this.numPositionsFailedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int numPositionsInserted
        {
            get
            {
                return this.numPositionsInsertedField;
            }
            set
            {
                this.numPositionsInsertedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int numPositionsSent
        {
            get
            {
                return this.numPositionsSentField;
            }
            set
            {
                this.numPositionsSentField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SendPositionsError", Namespace="https://www.golia.goliaweb.it/")]
    public partial class SendPositionsError : object
    {
        
        private string errorFoundField;
        
        private int movementIndexField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string errorFound
        {
            get
            {
                return this.errorFoundField;
            }
            set
            {
                this.errorFoundField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int movementIndex
        {
            get
            {
                return this.movementIndexField;
            }
            set
            {
                this.movementIndexField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AuthTokenRequest", Namespace="https://www.golia.goliaweb.it/")]
    public partial class AuthTokenRequest : object
    {
        
        private GoliaService.LoginCompanyCultureRequest loginCredentialsField;
        
        private string logoutRedirectField;
        
        private string redirectClientField;
        
        private string redirectSecretField;
        
        private string redirectURIField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.LoginCompanyCultureRequest loginCredentials
        {
            get
            {
                return this.loginCredentialsField;
            }
            set
            {
                this.loginCredentialsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string logoutRedirect
        {
            get
            {
                return this.logoutRedirectField;
            }
            set
            {
                this.logoutRedirectField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string redirectClient
        {
            get
            {
                return this.redirectClientField;
            }
            set
            {
                this.redirectClientField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string redirectSecret
        {
            get
            {
                return this.redirectSecretField;
            }
            set
            {
                this.redirectSecretField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string redirectURI
        {
            get
            {
                return this.redirectURIField;
            }
            set
            {
                this.redirectURIField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AuthTokenResult", Namespace="https://www.golia.goliaweb.it/")]
    public partial class AuthTokenResult : object
    {
        
        private System.DateTime expireField;
        
        private GoliaService.LoginResult loginResultField;
        
        private string tokenField;
        
        private string urlField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.DateTime expire
        {
            get
            {
                return this.expireField;
            }
            set
            {
                this.expireField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.LoginResult loginResult
        {
            get
            {
                return this.loginResultField;
            }
            set
            {
                this.loginResultField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string token
        {
            get
            {
                return this.tokenField;
            }
            set
            {
                this.tokenField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string url
        {
            get
            {
                return this.urlField;
            }
            set
            {
                this.urlField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetVehiclesLastPositionRequest", Namespace="https://www.golia.goliaweb.it/")]
    public partial class GetVehiclesLastPositionRequest : object
    {
        
        private GoliaService.LoginCompanyCultureRequest loginCredentialsField;
        
        private GoliaService.vehicleRequest vehicleRequestField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.LoginCompanyCultureRequest loginCredentials
        {
            get
            {
                return this.loginCredentialsField;
            }
            set
            {
                this.loginCredentialsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.vehicleRequest vehicleRequest
        {
            get
            {
                return this.vehicleRequestField;
            }
            set
            {
                this.vehicleRequestField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetVehiclesLastPositionResult", Namespace="https://www.golia.goliaweb.it/")]
    public partial class GetVehiclesLastPositionResult : object
    {
        
        private GoliaService.LoginResult loginResultField;
        
        private int numVehiclesField;
        
        private GoliaService.vehiclePosition[] vehiclesLastPositionField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.LoginResult loginResult
        {
            get
            {
                return this.loginResultField;
            }
            set
            {
                this.loginResultField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int numVehicles
        {
            get
            {
                return this.numVehiclesField;
            }
            set
            {
                this.numVehiclesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.vehiclePosition[] vehiclesLastPosition
        {
            get
            {
                return this.vehiclesLastPositionField;
            }
            set
            {
                this.vehiclesLastPositionField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="vehiclePosition", Namespace="https://www.golia.goliaweb.it/")]
    public partial class vehiclePosition : object
    {
        
        private double altitudeField;
        
        private System.DateTime dateField;
        
        private System.DateTime dateDeviceField;
        
        private int driverIdField;
        
        private int driverId2Field;
        
        private int engineSpeedField;
        
        private int fuelLevelField;
        
        private int fuelTotalField;
        
        private double headingField;
        
        private int ignitionField;
        
        private double latitudeField;
        
        private double longitudeField;
        
        private double odometerField;
        
        private string plateField;
        
        private string provenienceField;
        
        private double speedField;
        
        private int tachoActivityField;
        
        private int tachoSpeedField;
        
        private double totalOdometerField;
        
        private string trailerIdField;
        
        private string trailerPlateField;
        
        private int vehicleIdField;
        
        private int weightField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double altitude
        {
            get
            {
                return this.altitudeField;
            }
            set
            {
                this.altitudeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime dateDevice
        {
            get
            {
                return this.dateDeviceField;
            }
            set
            {
                this.dateDeviceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int driverId
        {
            get
            {
                return this.driverIdField;
            }
            set
            {
                this.driverIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int driverId2
        {
            get
            {
                return this.driverId2Field;
            }
            set
            {
                this.driverId2Field = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int engineSpeed
        {
            get
            {
                return this.engineSpeedField;
            }
            set
            {
                this.engineSpeedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int fuelLevel
        {
            get
            {
                return this.fuelLevelField;
            }
            set
            {
                this.fuelLevelField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int fuelTotal
        {
            get
            {
                return this.fuelTotalField;
            }
            set
            {
                this.fuelTotalField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double heading
        {
            get
            {
                return this.headingField;
            }
            set
            {
                this.headingField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ignition
        {
            get
            {
                return this.ignitionField;
            }
            set
            {
                this.ignitionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double latitude
        {
            get
            {
                return this.latitudeField;
            }
            set
            {
                this.latitudeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double longitude
        {
            get
            {
                return this.longitudeField;
            }
            set
            {
                this.longitudeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double odometer
        {
            get
            {
                return this.odometerField;
            }
            set
            {
                this.odometerField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string plate
        {
            get
            {
                return this.plateField;
            }
            set
            {
                this.plateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string provenience
        {
            get
            {
                return this.provenienceField;
            }
            set
            {
                this.provenienceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double speed
        {
            get
            {
                return this.speedField;
            }
            set
            {
                this.speedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int tachoActivity
        {
            get
            {
                return this.tachoActivityField;
            }
            set
            {
                this.tachoActivityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int tachoSpeed
        {
            get
            {
                return this.tachoSpeedField;
            }
            set
            {
                this.tachoSpeedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double totalOdometer
        {
            get
            {
                return this.totalOdometerField;
            }
            set
            {
                this.totalOdometerField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string trailerId
        {
            get
            {
                return this.trailerIdField;
            }
            set
            {
                this.trailerIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string trailerPlate
        {
            get
            {
                return this.trailerPlateField;
            }
            set
            {
                this.trailerPlateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int vehicleId
        {
            get
            {
                return this.vehicleIdField;
            }
            set
            {
                this.vehicleIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int weight
        {
            get
            {
                return this.weightField;
            }
            set
            {
                this.weightField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetVehiclePositionsRequest", Namespace="https://www.golia.goliaweb.it/")]
    public partial class GetVehiclePositionsRequest : object
    {
        
        private GoliaService.LoginCompanyCultureRequest loginCredentialsField;
        
        private System.DateTime periodEndField;
        
        private System.DateTime periodStartField;
        
        private GoliaService.vehicleRequest vehicleRequestField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.LoginCompanyCultureRequest loginCredentials
        {
            get
            {
                return this.loginCredentialsField;
            }
            set
            {
                this.loginCredentialsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.DateTime periodEnd
        {
            get
            {
                return this.periodEndField;
            }
            set
            {
                this.periodEndField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.DateTime periodStart
        {
            get
            {
                return this.periodStartField;
            }
            set
            {
                this.periodStartField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.vehicleRequest vehicleRequest
        {
            get
            {
                return this.vehicleRequestField;
            }
            set
            {
                this.vehicleRequestField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetVehiclePositionsResult", Namespace="https://www.golia.goliaweb.it/")]
    public partial class GetVehiclePositionsResult : object
    {
        
        private GoliaService.LoginResult loginResultField;
        
        private int numPositionsField;
        
        private GoliaService.vehiclePosition[] vehiclePositionsField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.LoginResult loginResult
        {
            get
            {
                return this.loginResultField;
            }
            set
            {
                this.loginResultField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int numPositions
        {
            get
            {
                return this.numPositionsField;
            }
            set
            {
                this.numPositionsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.vehiclePosition[] vehiclePositions
        {
            get
            {
                return this.vehiclePositionsField;
            }
            set
            {
                this.vehiclePositionsField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetNormalizedVehicleParametersRequest", Namespace="https://www.golia.goliaweb.it/")]
    public partial class GetNormalizedVehicleParametersRequest : object
    {
        
        private GoliaService.GMCulture gmCultureField;
        
        private GoliaService.LoginRequest loginCredentialsField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.GMCulture gmCulture
        {
            get
            {
                return this.gmCultureField;
            }
            set
            {
                this.gmCultureField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.LoginRequest loginCredentials
        {
            get
            {
                return this.loginCredentialsField;
            }
            set
            {
                this.loginCredentialsField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetNormalizedVehicleParametersResult", Namespace="https://www.golia.goliaweb.it/")]
    public partial class GetNormalizedVehicleParametersResult : object
    {
        
        private GoliaService.LoginResult loginResultField;
        
        private GoliaService.VehicleParameter[] vehicleParametersField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.LoginResult loginResult
        {
            get
            {
                return this.loginResultField;
            }
            set
            {
                this.loginResultField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.VehicleParameter[] vehicleParameters
        {
            get
            {
                return this.vehicleParametersField;
            }
            set
            {
                this.vehicleParametersField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="VehicleParameter", Namespace="https://www.golia.goliaweb.it/")]
    public partial class VehicleParameter : object
    {
        
        private string categoryField;
        
        private string descriptionField;
        
        private string documentationField;
        
        private int idField;
        
        private string muField;
        
        private string nameField;
        
        private string[] usedByField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string category
        {
            get
            {
                return this.categoryField;
            }
            set
            {
                this.categoryField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string documentation
        {
            get
            {
                return this.documentationField;
            }
            set
            {
                this.documentationField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string mu
        {
            get
            {
                return this.muField;
            }
            set
            {
                this.muField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string[] usedBy
        {
            get
            {
                return this.usedByField;
            }
            set
            {
                this.usedByField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetVehiclesDataRequest", Namespace="https://www.golia.goliaweb.it/")]
    public partial class GetVehiclesDataRequest : object
    {
        
        private GoliaService.LoginCompanyCultureRequest loginCredentialsField;
        
        private GoliaService.GetVehiclesDataOptions optionsField;
        
        private System.DateTime periodEndField;
        
        private System.DateTime periodStartField;
        
        private GoliaService.vehicleRequest vehicleField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.LoginCompanyCultureRequest loginCredentials
        {
            get
            {
                return this.loginCredentialsField;
            }
            set
            {
                this.loginCredentialsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.GetVehiclesDataOptions options
        {
            get
            {
                return this.optionsField;
            }
            set
            {
                this.optionsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.DateTime periodEnd
        {
            get
            {
                return this.periodEndField;
            }
            set
            {
                this.periodEndField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.DateTime periodStart
        {
            get
            {
                return this.periodStartField;
            }
            set
            {
                this.periodStartField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.vehicleRequest vehicle
        {
            get
            {
                return this.vehicleField;
            }
            set
            {
                this.vehicleField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetVehiclesDataOptions", Namespace="https://www.golia.goliaweb.it/")]
    public partial class GetVehiclesDataOptions : object
    {
        
        private bool normalizedDataField;
        
        private int[] parametersField;
        
        private bool rawDataField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public bool normalizedData
        {
            get
            {
                return this.normalizedDataField;
            }
            set
            {
                this.normalizedDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int[] parameters
        {
            get
            {
                return this.parametersField;
            }
            set
            {
                this.parametersField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public bool rawData
        {
            get
            {
                return this.rawDataField;
            }
            set
            {
                this.rawDataField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetVehiclesDataResult", Namespace="https://www.golia.goliaweb.it/")]
    public partial class GetVehiclesDataResult : object
    {
        
        private GoliaService.LoginResult loginResultField;
        
        private GoliaService.NormalizedData[] normalizedDataField;
        
        private GoliaService.RawData[] rawDataField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.LoginResult loginResult
        {
            get
            {
                return this.loginResultField;
            }
            set
            {
                this.loginResultField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.NormalizedData[] normalizedData
        {
            get
            {
                return this.normalizedDataField;
            }
            set
            {
                this.normalizedDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.RawData[] rawData
        {
            get
            {
                return this.rawDataField;
            }
            set
            {
                this.rawDataField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="NormalizedData", Namespace="https://www.golia.goliaweb.it/")]
    public partial class NormalizedData : object
    {
        
        private int driverIdField;
        
        private string driverNameField;
        
        private GoliaService.NormalizedDataParameter[] normalizedDataParametersField;
        
        private System.DateTime periodEndField;
        
        private System.DateTime periodStartField;
        
        private string plateField;
        
        private int vehicleIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int driverId
        {
            get
            {
                return this.driverIdField;
            }
            set
            {
                this.driverIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string driverName
        {
            get
            {
                return this.driverNameField;
            }
            set
            {
                this.driverNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.NormalizedDataParameter[] normalizedDataParameters
        {
            get
            {
                return this.normalizedDataParametersField;
            }
            set
            {
                this.normalizedDataParametersField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.DateTime periodEnd
        {
            get
            {
                return this.periodEndField;
            }
            set
            {
                this.periodEndField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.DateTime periodStart
        {
            get
            {
                return this.periodStartField;
            }
            set
            {
                this.periodStartField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string plate
        {
            get
            {
                return this.plateField;
            }
            set
            {
                this.plateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int vehicleId
        {
            get
            {
                return this.vehicleIdField;
            }
            set
            {
                this.vehicleIdField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="NormalizedDataParameter", Namespace="https://www.golia.goliaweb.it/")]
    public partial class NormalizedDataParameter : object
    {
        
        private int parameterField;
        
        private string valueField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int parameter
        {
            get
            {
                return this.parameterField;
            }
            set
            {
                this.parameterField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RawData", Namespace="https://www.golia.goliaweb.it/")]
    public partial class RawData : object
    {
        
        private string dataRawField;
        
        private int driverIdField;
        
        private string driverNameField;
        
        private System.DateTime periodEndField;
        
        private System.DateTime periodStartField;
        
        private string plateField;
        
        private int vehicleIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string dataRaw
        {
            get
            {
                return this.dataRawField;
            }
            set
            {
                this.dataRawField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int driverId
        {
            get
            {
                return this.driverIdField;
            }
            set
            {
                this.driverIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string driverName
        {
            get
            {
                return this.driverNameField;
            }
            set
            {
                this.driverNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.DateTime periodEnd
        {
            get
            {
                return this.periodEndField;
            }
            set
            {
                this.periodEndField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.DateTime periodStart
        {
            get
            {
                return this.periodStartField;
            }
            set
            {
                this.periodStartField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string plate
        {
            get
            {
                return this.plateField;
            }
            set
            {
                this.plateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int vehicleId
        {
            get
            {
                return this.vehicleIdField;
            }
            set
            {
                this.vehicleIdField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SendDocumentRequest", Namespace="https://www.golia.goliaweb.it/")]
    public partial class SendDocumentRequest : object
    {
        
        private string attributesField;
        
        private int[] categoriesField;
        
        private System.Nullable<System.DateTime> dateField;
        
        private string descriptionField;
        
        private byte[] fileDataField;
        
        private string fileNameField;
        
        private string fileTypeField;
        
        private int helpdeskOnlyField;
        
        private GoliaService.LoginCompanyCultureRequest loginCompanyRequestField;
        
        private string tagsField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string attributes
        {
            get
            {
                return this.attributesField;
            }
            set
            {
                this.attributesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int[] categories
        {
            get
            {
                return this.categoriesField;
            }
            set
            {
                this.categoriesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public byte[] fileData
        {
            get
            {
                return this.fileDataField;
            }
            set
            {
                this.fileDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string fileName
        {
            get
            {
                return this.fileNameField;
            }
            set
            {
                this.fileNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string fileType
        {
            get
            {
                return this.fileTypeField;
            }
            set
            {
                this.fileTypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int helpdeskOnly
        {
            get
            {
                return this.helpdeskOnlyField;
            }
            set
            {
                this.helpdeskOnlyField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.LoginCompanyCultureRequest loginCompanyRequest
        {
            get
            {
                return this.loginCompanyRequestField;
            }
            set
            {
                this.loginCompanyRequestField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string tags
        {
            get
            {
                return this.tagsField;
            }
            set
            {
                this.tagsField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SendDocumentResult", Namespace="https://www.golia.goliaweb.it/")]
    public partial class SendDocumentResult : object
    {
        
        private int documentIdField;
        
        private string[] errorsField;
        
        private GoliaService.LoginResult loginResultField;
        
        private bool uploadResultField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int documentId
        {
            get
            {
                return this.documentIdField;
            }
            set
            {
                this.documentIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string[] errors
        {
            get
            {
                return this.errorsField;
            }
            set
            {
                this.errorsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.LoginResult loginResult
        {
            get
            {
                return this.loginResultField;
            }
            set
            {
                this.loginResultField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public bool uploadResult
        {
            get
            {
                return this.uploadResultField;
            }
            set
            {
                this.uploadResultField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DownloadDocumentRequest", Namespace="https://www.golia.goliaweb.it/")]
    public partial class DownloadDocumentRequest : object
    {
        
        private int documentIdField;
        
        private GoliaService.LoginCompanyCultureRequest loginCompanyRequestField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int documentId
        {
            get
            {
                return this.documentIdField;
            }
            set
            {
                this.documentIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.LoginCompanyCultureRequest loginCompanyRequest
        {
            get
            {
                return this.loginCompanyRequestField;
            }
            set
            {
                this.loginCompanyRequestField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DownloadDocumentResult", Namespace="https://www.golia.goliaweb.it/")]
    public partial class DownloadDocumentResult : object
    {
        
        private bool downloadResultField;
        
        private string[] errorsField;
        
        private byte[] fileDataField;
        
        private GoliaService.LoginResult loginResultField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public bool downloadResult
        {
            get
            {
                return this.downloadResultField;
            }
            set
            {
                this.downloadResultField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string[] errors
        {
            get
            {
                return this.errorsField;
            }
            set
            {
                this.errorsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public byte[] fileData
        {
            get
            {
                return this.fileDataField;
            }
            set
            {
                this.fileDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.LoginResult loginResult
        {
            get
            {
                return this.loginResultField;
            }
            set
            {
                this.loginResultField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DeleteDocumentRequest", Namespace="https://www.golia.goliaweb.it/")]
    public partial class DeleteDocumentRequest : object
    {
        
        private int documentIdField;
        
        private GoliaService.LoginCompanyCultureRequest loginCompanyRequestField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int documentId
        {
            get
            {
                return this.documentIdField;
            }
            set
            {
                this.documentIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.LoginCompanyCultureRequest loginCompanyRequest
        {
            get
            {
                return this.loginCompanyRequestField;
            }
            set
            {
                this.loginCompanyRequestField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DeleteDocumentResult", Namespace="https://www.golia.goliaweb.it/")]
    public partial class DeleteDocumentResult : object
    {
        
        private bool deleteResultField;
        
        private string[] errorsField;
        
        private GoliaService.LoginResult loginResultField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public bool deleteResult
        {
            get
            {
                return this.deleteResultField;
            }
            set
            {
                this.deleteResultField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string[] errors
        {
            get
            {
                return this.errorsField;
            }
            set
            {
                this.errorsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.LoginResult loginResult
        {
            get
            {
                return this.loginResultField;
            }
            set
            {
                this.loginResultField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetReportsRequest", Namespace="https://www.golia.goliaweb.it/")]
    public partial class GetReportsRequest : object
    {
        
        private GoliaService.LoginCompanyCultureRequest loginCompanyRequestField;
        
        private int reportIdField;
        
        private int userIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.LoginCompanyCultureRequest loginCompanyRequest
        {
            get
            {
                return this.loginCompanyRequestField;
            }
            set
            {
                this.loginCompanyRequestField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int reportId
        {
            get
            {
                return this.reportIdField;
            }
            set
            {
                this.reportIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int userId
        {
            get
            {
                return this.userIdField;
            }
            set
            {
                this.userIdField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetReportsResult", Namespace="https://www.golia.goliaweb.it/")]
    public partial class GetReportsResult : object
    {
        
        private string[] errorsField;
        
        private GoliaService.LoginResult loginResultField;
        
        private GoliaService.reportDetail[] reportsPreferiteField;
        
        private GoliaService.reportCategory[] reportsResultField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string[] errors
        {
            get
            {
                return this.errorsField;
            }
            set
            {
                this.errorsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.LoginResult loginResult
        {
            get
            {
                return this.loginResultField;
            }
            set
            {
                this.loginResultField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.reportDetail[] reportsPreferite
        {
            get
            {
                return this.reportsPreferiteField;
            }
            set
            {
                this.reportsPreferiteField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.reportCategory[] reportsResult
        {
            get
            {
                return this.reportsResultField;
            }
            set
            {
                this.reportsResultField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="reportDetail", Namespace="https://www.golia.goliaweb.it/")]
    public partial class reportDetail : object
    {
        
        private bool activeField;
        
        private bool automaticField;
        
        private string descriptionReportField;
        
        private string filenameField;
        
        private int idCategoryField;
        
        private int idReportField;
        
        private string nameCategoryField;
        
        private string nameReportField;
        
        private GoliaService.reportParameter[] parametersReportField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public bool active
        {
            get
            {
                return this.activeField;
            }
            set
            {
                this.activeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public bool automatic
        {
            get
            {
                return this.automaticField;
            }
            set
            {
                this.automaticField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string descriptionReport
        {
            get
            {
                return this.descriptionReportField;
            }
            set
            {
                this.descriptionReportField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string filename
        {
            get
            {
                return this.filenameField;
            }
            set
            {
                this.filenameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int idCategory
        {
            get
            {
                return this.idCategoryField;
            }
            set
            {
                this.idCategoryField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int idReport
        {
            get
            {
                return this.idReportField;
            }
            set
            {
                this.idReportField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string nameCategory
        {
            get
            {
                return this.nameCategoryField;
            }
            set
            {
                this.nameCategoryField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string nameReport
        {
            get
            {
                return this.nameReportField;
            }
            set
            {
                this.nameReportField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.reportParameter[] parametersReport
        {
            get
            {
                return this.parametersReportField;
            }
            set
            {
                this.parametersReportField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="reportParameter", Namespace="https://www.golia.goliaweb.it/")]
    public partial class reportParameter : object
    {
        
        private string colbootstrapField;
        
        private string descriptionField;
        
        private string enumValueField;
        
        private int idField;
        
        private string maxValueField;
        
        private string minValueField;
        
        private string nameField;
        
        private int orderField;
        
        private string placeholderField;
        
        private int requiredField;
        
        private string typeParameterField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string colbootstrap
        {
            get
            {
                return this.colbootstrapField;
            }
            set
            {
                this.colbootstrapField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string enumValue
        {
            get
            {
                return this.enumValueField;
            }
            set
            {
                this.enumValueField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string maxValue
        {
            get
            {
                return this.maxValueField;
            }
            set
            {
                this.maxValueField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string minValue
        {
            get
            {
                return this.minValueField;
            }
            set
            {
                this.minValueField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int order
        {
            get
            {
                return this.orderField;
            }
            set
            {
                this.orderField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string placeholder
        {
            get
            {
                return this.placeholderField;
            }
            set
            {
                this.placeholderField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int required
        {
            get
            {
                return this.requiredField;
            }
            set
            {
                this.requiredField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string typeParameter
        {
            get
            {
                return this.typeParameterField;
            }
            set
            {
                this.typeParameterField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="reportCategory", Namespace="https://www.golia.goliaweb.it/")]
    public partial class reportCategory : object
    {
        
        private int categoryIdField;
        
        private string categoryNameField;
        
        private GoliaService.reportDetail[] reportDetailField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int categoryId
        {
            get
            {
                return this.categoryIdField;
            }
            set
            {
                this.categoryIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string categoryName
        {
            get
            {
                return this.categoryNameField;
            }
            set
            {
                this.categoryNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.reportDetail[] reportDetail
        {
            get
            {
                return this.reportDetailField;
            }
            set
            {
                this.reportDetailField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ExecReportRequest", Namespace="https://www.golia.goliaweb.it/")]
    public partial class ExecReportRequest : object
    {
        
        private int affiliateIdField;
        
        private GoliaService.driverRequest driverField;
        
        private int limitField;
        
        private GoliaService.LoginCompanyCultureRequest loginCompanyRequestField;
        
        private GoliaService.ExecReportParameter[] parametersReportField;
        
        private int reportIdField;
        
        private int startField;
        
        private int userIdField;
        
        private GoliaService.vehicleRequest vehicleField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int affiliateId
        {
            get
            {
                return this.affiliateIdField;
            }
            set
            {
                this.affiliateIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.driverRequest driver
        {
            get
            {
                return this.driverField;
            }
            set
            {
                this.driverField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int limit
        {
            get
            {
                return this.limitField;
            }
            set
            {
                this.limitField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.LoginCompanyCultureRequest loginCompanyRequest
        {
            get
            {
                return this.loginCompanyRequestField;
            }
            set
            {
                this.loginCompanyRequestField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.ExecReportParameter[] parametersReport
        {
            get
            {
                return this.parametersReportField;
            }
            set
            {
                this.parametersReportField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int reportId
        {
            get
            {
                return this.reportIdField;
            }
            set
            {
                this.reportIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int start
        {
            get
            {
                return this.startField;
            }
            set
            {
                this.startField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int userId
        {
            get
            {
                return this.userIdField;
            }
            set
            {
                this.userIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.vehicleRequest vehicle
        {
            get
            {
                return this.vehicleField;
            }
            set
            {
                this.vehicleField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ExecReportParameter", Namespace="https://www.golia.goliaweb.it/")]
    public partial class ExecReportParameter : object
    {
        
        private int idParameterField;
        
        private string valueField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int idParameter
        {
            get
            {
                return this.idParameterField;
            }
            set
            {
                this.idParameterField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ExecReportResult", Namespace="https://www.golia.goliaweb.it/")]
    public partial class ExecReportResult : object
    {
        
        private string[] errorsField;
        
        private GoliaService.LoginResult loginResultField;
        
        private string reportResultField;
        
        private int returnRowsField;
        
        private int totalRowsField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string[] errors
        {
            get
            {
                return this.errorsField;
            }
            set
            {
                this.errorsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.LoginResult loginResult
        {
            get
            {
                return this.loginResultField;
            }
            set
            {
                this.loginResultField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string reportResult
        {
            get
            {
                return this.reportResultField;
            }
            set
            {
                this.reportResultField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int returnRows
        {
            get
            {
                return this.returnRowsField;
            }
            set
            {
                this.returnRowsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int totalRows
        {
            get
            {
                return this.totalRowsField;
            }
            set
            {
                this.totalRowsField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SendSanificationDataRequest", Namespace="https://www.golia.goliaweb.it/")]
    public partial class SendSanificationDataRequest : object
    {
        
        private int companyIdField;
        
        private string countryField;
        
        private GoliaService.GMCulture gmCultureField;
        
        private string jsonDataField;
        
        private GoliaService.LoginRequest loginCredentialsField;
        
        private string vatField;
        
        private GoliaService.vehicleRequest vehicleRequestField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int companyId
        {
            get
            {
                return this.companyIdField;
            }
            set
            {
                this.companyIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.GMCulture gmCulture
        {
            get
            {
                return this.gmCultureField;
            }
            set
            {
                this.gmCultureField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string jsonData
        {
            get
            {
                return this.jsonDataField;
            }
            set
            {
                this.jsonDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.LoginRequest loginCredentials
        {
            get
            {
                return this.loginCredentialsField;
            }
            set
            {
                this.loginCredentialsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string vat
        {
            get
            {
                return this.vatField;
            }
            set
            {
                this.vatField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.vehicleRequest vehicleRequest
        {
            get
            {
                return this.vehicleRequestField;
            }
            set
            {
                this.vehicleRequestField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SendSanificationDataResult", Namespace="https://www.golia.goliaweb.it/")]
    public partial class SendSanificationDataResult : object
    {
        
        private GoliaService.LoginResult loginResultField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.LoginResult loginResult
        {
            get
            {
                return this.loginResultField;
            }
            set
            {
                this.loginResultField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetVehicleLastSanificationRequest", Namespace="https://www.golia.goliaweb.it/")]
    public partial class GetVehicleLastSanificationRequest : object
    {
        
        private int companyIdField;
        
        private string countryField;
        
        private GoliaService.GMCulture gmCultureField;
        
        private GoliaService.LoginRequest loginCredentialsField;
        
        private string vatField;
        
        private GoliaService.vehicleRequest vehicleRequestField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int companyId
        {
            get
            {
                return this.companyIdField;
            }
            set
            {
                this.companyIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.GMCulture gmCulture
        {
            get
            {
                return this.gmCultureField;
            }
            set
            {
                this.gmCultureField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.LoginRequest loginCredentials
        {
            get
            {
                return this.loginCredentialsField;
            }
            set
            {
                this.loginCredentialsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string vat
        {
            get
            {
                return this.vatField;
            }
            set
            {
                this.vatField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.vehicleRequest vehicleRequest
        {
            get
            {
                return this.vehicleRequestField;
            }
            set
            {
                this.vehicleRequestField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetVehicleLastSanificationResult", Namespace="https://www.golia.goliaweb.it/")]
    public partial class GetVehicleLastSanificationResult : object
    {
        
        private GoliaService.sanification lastSanificationField;
        
        private GoliaService.LoginResult loginResultField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.sanification lastSanification
        {
            get
            {
                return this.lastSanificationField;
            }
            set
            {
                this.lastSanificationField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.LoginResult loginResult
        {
            get
            {
                return this.loginResultField;
            }
            set
            {
                this.loginResultField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="sanification", Namespace="https://www.golia.goliaweb.it/")]
    public partial class sanification : object
    {
        
        private int companyIdField;
        
        private System.DateTime dateUploadField;
        
        private string jsonDataField;
        
        private GoliaService.vehicleRequest vehicleRequestField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int companyId
        {
            get
            {
                return this.companyIdField;
            }
            set
            {
                this.companyIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.DateTime dateUpload
        {
            get
            {
                return this.dateUploadField;
            }
            set
            {
                this.dateUploadField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string jsonData
        {
            get
            {
                return this.jsonDataField;
            }
            set
            {
                this.jsonDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.vehicleRequest vehicleRequest
        {
            get
            {
                return this.vehicleRequestField;
            }
            set
            {
                this.vehicleRequestField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ExecReportDriversWorkingDayRequest", Namespace="https://www.golia.goliaweb.it/")]
    public partial class ExecReportDriversWorkingDayRequest : object
    {
        
        private System.DateTime dateFromField;
        
        private System.DateTime dateToField;
        
        private GoliaService.driverRequest driverField;
        
        private GoliaService.LoginCompanyCultureRequest loginCompanyRequestField;
        
        private int userIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.DateTime dateFrom
        {
            get
            {
                return this.dateFromField;
            }
            set
            {
                this.dateFromField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.DateTime dateTo
        {
            get
            {
                return this.dateToField;
            }
            set
            {
                this.dateToField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.driverRequest driver
        {
            get
            {
                return this.driverField;
            }
            set
            {
                this.driverField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.LoginCompanyCultureRequest loginCompanyRequest
        {
            get
            {
                return this.loginCompanyRequestField;
            }
            set
            {
                this.loginCompanyRequestField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int userId
        {
            get
            {
                return this.userIdField;
            }
            set
            {
                this.userIdField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ExecReportDriversWorkingDayResult", Namespace="https://www.golia.goliaweb.it/")]
    public partial class ExecReportDriversWorkingDayResult : object
    {
        
        private string[] errorsField;
        
        private GoliaService.LoginResult loginResultField;
        
        private string reportResultField;
        
        private int returnRowsField;
        
        private int subRowsField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string[] errors
        {
            get
            {
                return this.errorsField;
            }
            set
            {
                this.errorsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.LoginResult loginResult
        {
            get
            {
                return this.loginResultField;
            }
            set
            {
                this.loginResultField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string reportResult
        {
            get
            {
                return this.reportResultField;
            }
            set
            {
                this.reportResultField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int returnRows
        {
            get
            {
                return this.returnRowsField;
            }
            set
            {
                this.returnRowsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int subRows
        {
            get
            {
                return this.subRowsField;
            }
            set
            {
                this.subRowsField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ExecReportDriversRestWeekRequest", Namespace="https://www.golia.goliaweb.it/")]
    public partial class ExecReportDriversRestWeekRequest : object
    {
        
        private GoliaService.driverRequest driverField;
        
        private GoliaService.LoginCompanyCultureRequest loginCompanyRequestField;
        
        private int userIdField;
        
        private int weeksField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.driverRequest driver
        {
            get
            {
                return this.driverField;
            }
            set
            {
                this.driverField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.LoginCompanyCultureRequest loginCompanyRequest
        {
            get
            {
                return this.loginCompanyRequestField;
            }
            set
            {
                this.loginCompanyRequestField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int userId
        {
            get
            {
                return this.userIdField;
            }
            set
            {
                this.userIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int weeks
        {
            get
            {
                return this.weeksField;
            }
            set
            {
                this.weeksField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ExecReportDriversRestWeekResult", Namespace="https://www.golia.goliaweb.it/")]
    public partial class ExecReportDriversRestWeekResult : object
    {
        
        private string[] errorsField;
        
        private GoliaService.LoginResult loginResultField;
        
        private GoliaService.ReportDriversRestWeekResult[] reportResultField;
        
        private int returnRowsField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string[] errors
        {
            get
            {
                return this.errorsField;
            }
            set
            {
                this.errorsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.LoginResult loginResult
        {
            get
            {
                return this.loginResultField;
            }
            set
            {
                this.loginResultField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.ReportDriversRestWeekResult[] reportResult
        {
            get
            {
                return this.reportResultField;
            }
            set
            {
                this.reportResultField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int returnRows
        {
            get
            {
                return this.returnRowsField;
            }
            set
            {
                this.returnRowsField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ReportDriversRestWeekResult", Namespace="https://www.golia.goliaweb.it/")]
    public partial class ReportDriversRestWeekResult : object
    {
        
        private int driverField;
        
        private System.TimeSpan durationField;
        
        private bool flagReducedRestField;
        
        private string levelField;
        
        private System.DateTime maxStartNextRestField;
        
        private System.DateTime periodEndField;
        
        private System.DateTime periodStartField;
        
        private System.DateTime recoverRestBeforeThisDateField;
        
        private System.TimeSpan secondsToRecoverField;
        
        private GoliaService.ReportArrayWeek weekField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int driver
        {
            get
            {
                return this.driverField;
            }
            set
            {
                this.driverField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.TimeSpan duration
        {
            get
            {
                return this.durationField;
            }
            set
            {
                this.durationField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool flagReducedRest
        {
            get
            {
                return this.flagReducedRestField;
            }
            set
            {
                this.flagReducedRestField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string level
        {
            get
            {
                return this.levelField;
            }
            set
            {
                this.levelField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime maxStartNextRest
        {
            get
            {
                return this.maxStartNextRestField;
            }
            set
            {
                this.maxStartNextRestField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime periodEnd
        {
            get
            {
                return this.periodEndField;
            }
            set
            {
                this.periodEndField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime periodStart
        {
            get
            {
                return this.periodStartField;
            }
            set
            {
                this.periodStartField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime recoverRestBeforeThisDate
        {
            get
            {
                return this.recoverRestBeforeThisDateField;
            }
            set
            {
                this.recoverRestBeforeThisDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.TimeSpan secondsToRecover
        {
            get
            {
                return this.secondsToRecoverField;
            }
            set
            {
                this.secondsToRecoverField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.ReportArrayWeek week
        {
            get
            {
                return this.weekField;
            }
            set
            {
                this.weekField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ReportArrayWeek", Namespace="https://www.golia.goliaweb.it/")]
    public partial class ReportArrayWeek : object
    {
        
        private System.DateTime firstField;
        
        private System.DateTime lastField;
        
        private long ywField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime first
        {
            get
            {
                return this.firstField;
            }
            set
            {
                this.firstField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime last
        {
            get
            {
                return this.lastField;
            }
            set
            {
                this.lastField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long yw
        {
            get
            {
                return this.ywField;
            }
            set
            {
                this.ywField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetNationsFromPositionRequest", Namespace="https://www.golia.goliaweb.it/")]
    public partial class GetNationsFromPositionRequest : object
    {
        
        private GoliaService.driverRequest driverField;
        
        private GoliaService.LoginCompanyCultureRequest loginCompanyRequestField;
        
        private System.DateTime periodEndField;
        
        private System.DateTime periodStartField;
        
        private GoliaService.vehicleRequest vehicleField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.driverRequest driver
        {
            get
            {
                return this.driverField;
            }
            set
            {
                this.driverField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.LoginCompanyCultureRequest loginCompanyRequest
        {
            get
            {
                return this.loginCompanyRequestField;
            }
            set
            {
                this.loginCompanyRequestField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.DateTime periodEnd
        {
            get
            {
                return this.periodEndField;
            }
            set
            {
                this.periodEndField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.DateTime periodStart
        {
            get
            {
                return this.periodStartField;
            }
            set
            {
                this.periodStartField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.vehicleRequest vehicle
        {
            get
            {
                return this.vehicleField;
            }
            set
            {
                this.vehicleField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetNationsFromPositionResult", Namespace="https://www.golia.goliaweb.it/")]
    public partial class GetNationsFromPositionResult : object
    {
        
        private string[] errorsField;
        
        private GoliaService.LoginResult loginResultField;
        
        private GoliaService.ActivityPosition reportResultField;
        
        private int returnRowsField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string[] errors
        {
            get
            {
                return this.errorsField;
            }
            set
            {
                this.errorsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.LoginResult loginResult
        {
            get
            {
                return this.loginResultField;
            }
            set
            {
                this.loginResultField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.ActivityPosition reportResult
        {
            get
            {
                return this.reportResultField;
            }
            set
            {
                this.reportResultField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int returnRows
        {
            get
            {
                return this.returnRowsField;
            }
            set
            {
                this.returnRowsField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ActivityPosition", Namespace="https://www.golia.goliaweb.it/")]
    public partial class ActivityPosition : object
    {
        
        private GoliaService.ActivityPositionDay[] daysField;
        
        private System.DateTime endField;
        
        private System.DateTime startField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.ActivityPositionDay[] days
        {
            get
            {
                return this.daysField;
            }
            set
            {
                this.daysField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.DateTime end
        {
            get
            {
                return this.endField;
            }
            set
            {
                this.endField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.DateTime start
        {
            get
            {
                return this.startField;
            }
            set
            {
                this.startField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetTachoFilesRequest", Namespace="https://www.golia.goliaweb.it/")]
    public partial class GetTachoFilesRequest : object
    {
        
        private GoliaService.driverRequest driverField;
        
        private GoliaService.LoginCompanyCultureRequest loginCompanyRequestField;
        
        private System.DateTime periodStartField;
        
        private GoliaService.vehicleRequest vehicleField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.driverRequest driver
        {
            get
            {
                return this.driverField;
            }
            set
            {
                this.driverField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.LoginCompanyCultureRequest loginCompanyRequest
        {
            get
            {
                return this.loginCompanyRequestField;
            }
            set
            {
                this.loginCompanyRequestField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.DateTime periodStart
        {
            get
            {
                return this.periodStartField;
            }
            set
            {
                this.periodStartField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.vehicleRequest vehicle
        {
            get
            {
                return this.vehicleField;
            }
            set
            {
                this.vehicleField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetTachoFilesResult", Namespace="https://www.golia.goliaweb.it/")]
    public partial class GetTachoFilesResult : object
    {
        
        private string[] errorsField;
        
        private GoliaService.LoginResult loginResultField;
        
        private GoliaService.TachoFile[] tachoFilesField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string[] errors
        {
            get
            {
                return this.errorsField;
            }
            set
            {
                this.errorsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.LoginResult loginResult
        {
            get
            {
                return this.loginResultField;
            }
            set
            {
                this.loginResultField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.TachoFile[] tachoFiles
        {
            get
            {
                return this.tachoFilesField;
            }
            set
            {
                this.tachoFilesField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetAutistiCamionsPlaceRequest", Namespace="https://www.golia.goliaweb.it/")]
    public partial class GetAutistiCamionsPlaceRequest : object
    {
        
        private GoliaService.driverRequest driverField;
        
        private GoliaService.LoginCompanyCultureRequest loginCompanyRequestField;
        
        private System.DateTime periodEndField;
        
        private System.DateTime periodStartField;
        
        private GoliaService.vehicleRequest vehicleField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.driverRequest driver
        {
            get
            {
                return this.driverField;
            }
            set
            {
                this.driverField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.LoginCompanyCultureRequest loginCompanyRequest
        {
            get
            {
                return this.loginCompanyRequestField;
            }
            set
            {
                this.loginCompanyRequestField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.DateTime periodEnd
        {
            get
            {
                return this.periodEndField;
            }
            set
            {
                this.periodEndField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.DateTime periodStart
        {
            get
            {
                return this.periodStartField;
            }
            set
            {
                this.periodStartField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.vehicleRequest vehicle
        {
            get
            {
                return this.vehicleField;
            }
            set
            {
                this.vehicleField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetAutistiCamionsPlaceResult", Namespace="https://www.golia.goliaweb.it/")]
    public partial class GetAutistiCamionsPlaceResult : object
    {
        
        private GoliaService.AutistiCamionsPlace[] autistiVehiclePlaceField;
        
        private GoliaService.LoginResult loginResultField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.AutistiCamionsPlace[] autistiVehiclePlace
        {
            get
            {
                return this.autistiVehiclePlaceField;
            }
            set
            {
                this.autistiVehiclePlaceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.LoginResult loginResult
        {
            get
            {
                return this.loginResultField;
            }
            set
            {
                this.loginResultField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetLockVehicleRequest", Namespace="https://www.golia.goliaweb.it/")]
    public partial class GetLockVehicleRequest : object
    {
        
        private GoliaService.LoginCompanyCultureRequest loginCompanyRequestField;
        
        private System.DateTime periodStartField;
        
        private GoliaService.vehicleRequest vehicleField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.LoginCompanyCultureRequest loginCompanyRequest
        {
            get
            {
                return this.loginCompanyRequestField;
            }
            set
            {
                this.loginCompanyRequestField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.DateTime periodStart
        {
            get
            {
                return this.periodStartField;
            }
            set
            {
                this.periodStartField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.vehicleRequest vehicle
        {
            get
            {
                return this.vehicleField;
            }
            set
            {
                this.vehicleField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetLockVehicleResult", Namespace="https://www.golia.goliaweb.it/")]
    public partial class GetLockVehicleResult : object
    {
        
        private string[] errorsField;
        
        private GoliaService.Lock[] locksInfoField;
        
        private GoliaService.LoginResult loginResultField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string[] errors
        {
            get
            {
                return this.errorsField;
            }
            set
            {
                this.errorsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.Lock[] locksInfo
        {
            get
            {
                return this.locksInfoField;
            }
            set
            {
                this.locksInfoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.LoginResult loginResult
        {
            get
            {
                return this.loginResultField;
            }
            set
            {
                this.loginResultField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetFaultEventRequest", Namespace="https://www.golia.goliaweb.it/")]
    public partial class GetFaultEventRequest : object
    {
        
        private GoliaService.driverRequest driverField;
        
        private GoliaService.LoginCompanyCultureRequest loginCompanyRequestField;
        
        private System.DateTime periodEndField;
        
        private System.DateTime periodStartField;
        
        private GoliaService.vehicleRequest vehicleField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.driverRequest driver
        {
            get
            {
                return this.driverField;
            }
            set
            {
                this.driverField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.LoginCompanyCultureRequest loginCompanyRequest
        {
            get
            {
                return this.loginCompanyRequestField;
            }
            set
            {
                this.loginCompanyRequestField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.DateTime periodEnd
        {
            get
            {
                return this.periodEndField;
            }
            set
            {
                this.periodEndField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.DateTime periodStart
        {
            get
            {
                return this.periodStartField;
            }
            set
            {
                this.periodStartField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.vehicleRequest vehicle
        {
            get
            {
                return this.vehicleField;
            }
            set
            {
                this.vehicleField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetFaultEventResult", Namespace="https://www.golia.goliaweb.it/")]
    public partial class GetFaultEventResult : object
    {
        
        private string[] errorsField;
        
        private GoliaService.FaultEvent[] faultEventsField;
        
        private GoliaService.LoginResult loginResultField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string[] errors
        {
            get
            {
                return this.errorsField;
            }
            set
            {
                this.errorsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.FaultEvent[] faultEvents
        {
            get
            {
                return this.faultEventsField;
            }
            set
            {
                this.faultEventsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.LoginResult loginResult
        {
            get
            {
                return this.loginResultField;
            }
            set
            {
                this.loginResultField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RestoreAnagraficaRequest", Namespace="https://www.golia.goliaweb.it/")]
    public partial class RestoreAnagraficaRequest : object
    {
        
        private GoliaService.LoginCompanyCultureRequest loginCompanyRequestField;
        
        private GoliaService.vehicleRequest vehicleRequestField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.LoginCompanyCultureRequest loginCompanyRequest
        {
            get
            {
                return this.loginCompanyRequestField;
            }
            set
            {
                this.loginCompanyRequestField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.vehicleRequest vehicleRequest
        {
            get
            {
                return this.vehicleRequestField;
            }
            set
            {
                this.vehicleRequestField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DeleteAnagraficaRequest", Namespace="https://www.golia.goliaweb.it/")]
    public partial class DeleteAnagraficaRequest : object
    {
        
        private GoliaService.LoginCompanyCultureRequest loginCompanyRequestField;
        
        private GoliaService.vehicleRequest vehicleRequestField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.LoginCompanyCultureRequest loginCompanyRequest
        {
            get
            {
                return this.loginCompanyRequestField;
            }
            set
            {
                this.loginCompanyRequestField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public GoliaService.vehicleRequest vehicleRequest
        {
            get
            {
                return this.vehicleRequestField;
            }
            set
            {
                this.vehicleRequestField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AutistiCamionsPlace", Namespace="http://schemas.datacontract.org/2004/07/DbGoliaModel")]
    public partial class AutistiCamionsPlace : object
    {
        
        private int AutistaField;
        
        private int AziendaField;
        
        private int CamionField;
        
        private System.Nullable<int> CountryField;
        
        private System.Nullable<int> Entry_TypeField;
        
        private string ExtraField;
        
        private System.Nullable<double> LatitudeField;
        
        private System.Nullable<double> LongitudeField;
        
        private System.Nullable<int> OdometerField;
        
        private System.DateTime Refer_PeriodField;
        
        private System.DateTime Refer_Period_GpsField;
        
        private System.Nullable<int> RegionField;
        
        private string coutry_descriptionField;
        
        private string driver_cardField;
        
        private string first_nameField;
        
        private string plateField;
        
        private string surnameField;
        
        private string title_entry_typeField;
        
        private string translation_code_entry_typeField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Autista
        {
            get
            {
                return this.AutistaField;
            }
            set
            {
                this.AutistaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Azienda
        {
            get
            {
                return this.AziendaField;
            }
            set
            {
                this.AziendaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Camion
        {
            get
            {
                return this.CamionField;
            }
            set
            {
                this.CamionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Country
        {
            get
            {
                return this.CountryField;
            }
            set
            {
                this.CountryField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Entry_Type
        {
            get
            {
                return this.Entry_TypeField;
            }
            set
            {
                this.Entry_TypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Extra
        {
            get
            {
                return this.ExtraField;
            }
            set
            {
                this.ExtraField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<double> Latitude
        {
            get
            {
                return this.LatitudeField;
            }
            set
            {
                this.LatitudeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<double> Longitude
        {
            get
            {
                return this.LongitudeField;
            }
            set
            {
                this.LongitudeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Odometer
        {
            get
            {
                return this.OdometerField;
            }
            set
            {
                this.OdometerField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Refer_Period
        {
            get
            {
                return this.Refer_PeriodField;
            }
            set
            {
                this.Refer_PeriodField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Refer_Period_Gps
        {
            get
            {
                return this.Refer_Period_GpsField;
            }
            set
            {
                this.Refer_Period_GpsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Region
        {
            get
            {
                return this.RegionField;
            }
            set
            {
                this.RegionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string coutry_description
        {
            get
            {
                return this.coutry_descriptionField;
            }
            set
            {
                this.coutry_descriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string driver_card
        {
            get
            {
                return this.driver_cardField;
            }
            set
            {
                this.driver_cardField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string first_name
        {
            get
            {
                return this.first_nameField;
            }
            set
            {
                this.first_nameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string plate
        {
            get
            {
                return this.plateField;
            }
            set
            {
                this.plateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string surname
        {
            get
            {
                return this.surnameField;
            }
            set
            {
                this.surnameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string title_entry_type
        {
            get
            {
                return this.title_entry_typeField;
            }
            set
            {
                this.title_entry_typeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string translation_code_entry_type
        {
            get
            {
                return this.translation_code_entry_typeField;
            }
            set
            {
                this.translation_code_entry_typeField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Lock", Namespace="http://schemas.datacontract.org/2004/07/DbGoliaModel")]
    public partial class Lock : object
    {
        
        private int camionField;
        
        private string card_numberField;
        
        private string company_addressField;
        
        private string company_ragsocField;
        
        private System.DateTime period_endField;
        
        private System.DateTime period_startField;
        
        private string targaField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int camion
        {
            get
            {
                return this.camionField;
            }
            set
            {
                this.camionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string card_number
        {
            get
            {
                return this.card_numberField;
            }
            set
            {
                this.card_numberField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string company_address
        {
            get
            {
                return this.company_addressField;
            }
            set
            {
                this.company_addressField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string company_ragsoc
        {
            get
            {
                return this.company_ragsocField;
            }
            set
            {
                this.company_ragsocField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime period_end
        {
            get
            {
                return this.period_endField;
            }
            set
            {
                this.period_endField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime period_start
        {
            get
            {
                return this.period_startField;
            }
            set
            {
                this.period_startField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string targa
        {
            get
            {
                return this.targaField;
            }
            set
            {
                this.targaField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FaultEvent", Namespace="http://schemas.datacontract.org/2004/07/DbGoliaModel")]
    public partial class FaultEvent : object
    {
        
        private System.Nullable<int> AutistaField;
        
        private int AziendaField;
        
        private System.Nullable<int> CamionField;
        
        private string CartaField;
        
        private string CognomeNomeField;
        
        private string RagSocField;
        
        private string TargaField;
        
        private string VU_MANUFACTURER_NAMEField;
        
        private string VU_PART_NUMBERField;
        
        private string VU_SERIAL_NUMBERField;
        
        private string VU_SOFTWARE_VERSIONField;
        
        private int Valore1Field;
        
        private int Valore2Field;
        
        private int Valore3Field;
        
        private int codeIdField;
        
        private int codePurposeField;
        
        private string descriptionField;
        
        private string descriptionCauseField;
        
        private string descriptionInformationField;
        
        private string descriptionMeansField;
        
        private string descriptionPurposeField;
        
        private string descriptionSuggestionField;
        
        private int displayCodeIdField;
        
        private GoliaService.AnomalyType eventIdField;
        
        private System.DateTime periodEndField;
        
        private System.DateTime periodStartField;
        
        private string tachoNameField;
        
        private string tachoVersionField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Autista
        {
            get
            {
                return this.AutistaField;
            }
            set
            {
                this.AutistaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Azienda
        {
            get
            {
                return this.AziendaField;
            }
            set
            {
                this.AziendaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Camion
        {
            get
            {
                return this.CamionField;
            }
            set
            {
                this.CamionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Carta
        {
            get
            {
                return this.CartaField;
            }
            set
            {
                this.CartaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CognomeNome
        {
            get
            {
                return this.CognomeNomeField;
            }
            set
            {
                this.CognomeNomeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RagSoc
        {
            get
            {
                return this.RagSocField;
            }
            set
            {
                this.RagSocField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Targa
        {
            get
            {
                return this.TargaField;
            }
            set
            {
                this.TargaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string VU_MANUFACTURER_NAME
        {
            get
            {
                return this.VU_MANUFACTURER_NAMEField;
            }
            set
            {
                this.VU_MANUFACTURER_NAMEField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string VU_PART_NUMBER
        {
            get
            {
                return this.VU_PART_NUMBERField;
            }
            set
            {
                this.VU_PART_NUMBERField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string VU_SERIAL_NUMBER
        {
            get
            {
                return this.VU_SERIAL_NUMBERField;
            }
            set
            {
                this.VU_SERIAL_NUMBERField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string VU_SOFTWARE_VERSION
        {
            get
            {
                return this.VU_SOFTWARE_VERSIONField;
            }
            set
            {
                this.VU_SOFTWARE_VERSIONField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Valore1
        {
            get
            {
                return this.Valore1Field;
            }
            set
            {
                this.Valore1Field = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Valore2
        {
            get
            {
                return this.Valore2Field;
            }
            set
            {
                this.Valore2Field = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Valore3
        {
            get
            {
                return this.Valore3Field;
            }
            set
            {
                this.Valore3Field = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int codeId
        {
            get
            {
                return this.codeIdField;
            }
            set
            {
                this.codeIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int codePurpose
        {
            get
            {
                return this.codePurposeField;
            }
            set
            {
                this.codePurposeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string descriptionCause
        {
            get
            {
                return this.descriptionCauseField;
            }
            set
            {
                this.descriptionCauseField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string descriptionInformation
        {
            get
            {
                return this.descriptionInformationField;
            }
            set
            {
                this.descriptionInformationField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string descriptionMeans
        {
            get
            {
                return this.descriptionMeansField;
            }
            set
            {
                this.descriptionMeansField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string descriptionPurpose
        {
            get
            {
                return this.descriptionPurposeField;
            }
            set
            {
                this.descriptionPurposeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string descriptionSuggestion
        {
            get
            {
                return this.descriptionSuggestionField;
            }
            set
            {
                this.descriptionSuggestionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int displayCodeId
        {
            get
            {
                return this.displayCodeIdField;
            }
            set
            {
                this.displayCodeIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GoliaService.AnomalyType eventId
        {
            get
            {
                return this.eventIdField;
            }
            set
            {
                this.eventIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime periodEnd
        {
            get
            {
                return this.periodEndField;
            }
            set
            {
                this.periodEndField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime periodStart
        {
            get
            {
                return this.periodStartField;
            }
            set
            {
                this.periodStartField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string tachoName
        {
            get
            {
                return this.tachoNameField;
            }
            set
            {
                this.tachoNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string tachoVersion
        {
            get
            {
                return this.tachoVersionField;
            }
            set
            {
                this.tachoVersionField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AnomalyType", Namespace="http://schemas.datacontract.org/2004/07/DbGoliaModel")]
    public enum AnomalyType : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        None = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        DDD_Fault = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        DDD_Event = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        DDD_Overspeed = 3,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="https://www.golia.goliaweb.it/", ConfigurationName="GoliaService.IGoliaManagerSOAP")]
    public interface IGoliaManagerSOAP
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="https://www.golia.goliaweb.it/IGoliaManagerSOAP/TimeZoneList", ReplyAction="https://www.golia.goliaweb.it/IGoliaManagerSOAP/TimeZoneListResponse")]
        System.Threading.Tasks.Task<GoliaService.TimeZoneListResult> TimeZoneListAsync(GoliaService.LoginRequest loginCredentials);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://www.golia.goliaweb.it/IGoliaManagerSOAP/GetCompanies", ReplyAction="https://www.golia.goliaweb.it/IGoliaManagerSOAP/GetCompaniesResponse")]
        System.Threading.Tasks.Task<GoliaService.GetCompaniesResult> GetCompaniesAsync(GoliaService.LoginRequest loginCredentials);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://www.golia.goliaweb.it/IGoliaManagerSOAP/GetDrivers", ReplyAction="https://www.golia.goliaweb.it/IGoliaManagerSOAP/GetDriversResponse")]
        System.Threading.Tasks.Task<GoliaService.GetDriversResult> GetDriversAsync(GoliaService.LoginCompanyCultureRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://www.golia.goliaweb.it/IGoliaManagerSOAP/GetVehicles", ReplyAction="https://www.golia.goliaweb.it/IGoliaManagerSOAP/GetVehiclesResponse")]
        System.Threading.Tasks.Task<GoliaService.GetVehiclesResult> GetVehiclesAsync(GoliaService.LoginCompanyCultureRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://www.golia.goliaweb.it/IGoliaManagerSOAP/SendTachoFile", ReplyAction="https://www.golia.goliaweb.it/IGoliaManagerSOAP/SendTachoFileResponse")]
        System.Threading.Tasks.Task<GoliaService.SendTachoFileResult> SendTachoFileAsync(GoliaService.SendTachoFileRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://www.golia.goliaweb.it/IGoliaManagerSOAP/SendTachoRealtime", ReplyAction="https://www.golia.goliaweb.it/IGoliaManagerSOAP/SendTachoRealtimeResponse")]
        System.Threading.Tasks.Task<GoliaService.SendTachoRealtimeResult> SendTachoRealtimeAsync(GoliaService.SendTachoRealtimeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://www.golia.goliaweb.it/IGoliaManagerSOAP/GetInfringments", ReplyAction="https://www.golia.goliaweb.it/IGoliaManagerSOAP/GetInfringmentsResponse")]
        System.Threading.Tasks.Task<GoliaService.GetInfringmentsResult> GetInfringmentsAsync(GoliaService.GetInfringmentsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://www.golia.goliaweb.it/IGoliaManagerSOAP/GetDriverPlafond", ReplyAction="https://www.golia.goliaweb.it/IGoliaManagerSOAP/GetDriverPlafondResponse")]
        System.Threading.Tasks.Task<GoliaService.GetDriverPlafondResult> GetDriverPlafondAsync(GoliaService.GetDriverPlafondRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://www.golia.goliaweb.it/IGoliaManagerSOAP/GetActivities", ReplyAction="https://www.golia.goliaweb.it/IGoliaManagerSOAP/GetActivitiesResponse")]
        System.Threading.Tasks.Task<GoliaService.GetActivitiesResult> GetActivitiesAsync(GoliaService.GetActivitiesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://www.golia.goliaweb.it/IGoliaManagerSOAP/GetTimeline", ReplyAction="https://www.golia.goliaweb.it/IGoliaManagerSOAP/GetTimelineResponse")]
        System.Threading.Tasks.Task<GoliaService.GetTimelineResult> GetTimelineAsync(GoliaService.GetTimelineRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://www.golia.goliaweb.it/IGoliaManagerSOAP/GetDriverActivity", ReplyAction="https://www.golia.goliaweb.it/IGoliaManagerSOAP/GetDriverActivityResponse")]
        System.Threading.Tasks.Task<GoliaService.GetDriverActivityResult> GetDriverActivityAsync(GoliaService.GetDriverActivityRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://www.golia.goliaweb.it/IGoliaManagerSOAP/GetMissingTachoFilePeriods", ReplyAction="https://www.golia.goliaweb.it/IGoliaManagerSOAP/GetMissingTachoFilePeriodsRespons" +
            "e")]
        System.Threading.Tasks.Task<GoliaService.GetMissingTachoFilePeriodsResult> GetMissingTachoFilePeriodsAsync(GoliaService.GetMissingTachoFilePeriodsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://www.golia.goliaweb.it/IGoliaManagerSOAP/SetVehicle", ReplyAction="https://www.golia.goliaweb.it/IGoliaManagerSOAP/SetVehicleResponse")]
        System.Threading.Tasks.Task<GoliaService.SetVehicleResult> SetVehicleAsync(GoliaService.SetVehicleRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://www.golia.goliaweb.it/IGoliaManagerSOAP/SetDriver", ReplyAction="https://www.golia.goliaweb.it/IGoliaManagerSOAP/SetDriverResponse")]
        System.Threading.Tasks.Task<GoliaService.SetDriverResult> SetDriverAsync(GoliaService.SetDriverRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://www.golia.goliaweb.it/IGoliaManagerSOAP/InsertCompanyUser", ReplyAction="https://www.golia.goliaweb.it/IGoliaManagerSOAP/InsertCompanyUserResponse")]
        System.Threading.Tasks.Task<GoliaService.InsertCompanyUserResult> InsertCompanyUserAsync(GoliaService.InsertCompanyUserRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://www.golia.goliaweb.it/IGoliaManagerSOAP/GetTachoFile", ReplyAction="https://www.golia.goliaweb.it/IGoliaManagerSOAP/GetTachoFileResponse")]
        System.Threading.Tasks.Task<GoliaService.GetTachoFileResult> GetTachoFileAsync(GoliaService.GetTachoFileRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://www.golia.goliaweb.it/IGoliaManagerSOAP/GetDiskFile", ReplyAction="https://www.golia.goliaweb.it/IGoliaManagerSOAP/GetDiskFileResponse")]
        System.Threading.Tasks.Task<GoliaService.GetDiskFileResult> GetDiskFileAsync(GoliaService.GetDiskFileRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://www.golia.goliaweb.it/IGoliaManagerSOAP/GetTachoFileTextExplain", ReplyAction="https://www.golia.goliaweb.it/IGoliaManagerSOAP/GetTachoFileTextExplainResponse")]
        System.Threading.Tasks.Task<GoliaService.GetTachoFileTextExplainResult> GetTachoFileTextExplainAsync(GoliaService.GetTachoFileRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://www.golia.goliaweb.it/IGoliaManagerSOAP/GetInfringmentsReport", ReplyAction="https://www.golia.goliaweb.it/IGoliaManagerSOAP/GetInfringmentsReportResponse")]
        System.Threading.Tasks.Task<GoliaService.GetInfringmentsReportResult> GetInfringmentsReportAsync(GoliaService.GetInfringmentsReportRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://www.golia.goliaweb.it/IGoliaManagerSOAP/SendPositions", ReplyAction="https://www.golia.goliaweb.it/IGoliaManagerSOAP/SendPositionsResponse")]
        System.Threading.Tasks.Task<GoliaService.SendPositionsResult> SendPositionsAsync(GoliaService.SendPositionsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://www.golia.goliaweb.it/IGoliaManagerSOAP/AuthToken", ReplyAction="https://www.golia.goliaweb.it/IGoliaManagerSOAP/AuthTokenResponse")]
        System.Threading.Tasks.Task<GoliaService.AuthTokenResult> AuthTokenAsync(GoliaService.AuthTokenRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://www.golia.goliaweb.it/IGoliaManagerSOAP/GetVehiclesLastPosition", ReplyAction="https://www.golia.goliaweb.it/IGoliaManagerSOAP/GetVehiclesLastPositionResponse")]
        System.Threading.Tasks.Task<GoliaService.GetVehiclesLastPositionResult> GetVehiclesLastPositionAsync(GoliaService.GetVehiclesLastPositionRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://www.golia.goliaweb.it/IGoliaManagerSOAP/GetVehiclePositions", ReplyAction="https://www.golia.goliaweb.it/IGoliaManagerSOAP/GetVehiclePositionsResponse")]
        System.Threading.Tasks.Task<GoliaService.GetVehiclePositionsResult> GetVehiclePositionsAsync(GoliaService.GetVehiclePositionsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://www.golia.goliaweb.it/IGoliaManagerSOAP/GetNormalizedVehicleParameters", ReplyAction="https://www.golia.goliaweb.it/IGoliaManagerSOAP/GetNormalizedVehicleParametersRes" +
            "ponse")]
        System.Threading.Tasks.Task<GoliaService.GetNormalizedVehicleParametersResult> GetNormalizedVehicleParametersAsync(GoliaService.GetNormalizedVehicleParametersRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://www.golia.goliaweb.it/IGoliaManagerSOAP/GetVehiclesData", ReplyAction="https://www.golia.goliaweb.it/IGoliaManagerSOAP/GetVehiclesDataResponse")]
        System.Threading.Tasks.Task<GoliaService.GetVehiclesDataResult> GetVehiclesDataAsync(GoliaService.GetVehiclesDataRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://www.golia.goliaweb.it/IGoliaManagerSOAP/SendDocument", ReplyAction="https://www.golia.goliaweb.it/IGoliaManagerSOAP/SendDocumentResponse")]
        System.Threading.Tasks.Task<GoliaService.SendDocumentResult> SendDocumentAsync(GoliaService.SendDocumentRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://www.golia.goliaweb.it/IGoliaManagerSOAP/DownloadDocument", ReplyAction="https://www.golia.goliaweb.it/IGoliaManagerSOAP/DownloadDocumentResponse")]
        System.Threading.Tasks.Task<GoliaService.DownloadDocumentResult> DownloadDocumentAsync(GoliaService.DownloadDocumentRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://www.golia.goliaweb.it/IGoliaManagerSOAP/DeleteDocument", ReplyAction="https://www.golia.goliaweb.it/IGoliaManagerSOAP/DeleteDocumentResponse")]
        System.Threading.Tasks.Task<GoliaService.DeleteDocumentResult> DeleteDocumentAsync(GoliaService.DeleteDocumentRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://www.golia.goliaweb.it/IGoliaManagerSOAP/GetReports", ReplyAction="https://www.golia.goliaweb.it/IGoliaManagerSOAP/GetReportsResponse")]
        System.Threading.Tasks.Task<GoliaService.GetReportsResult> GetReportsAsync(GoliaService.GetReportsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://www.golia.goliaweb.it/IGoliaManagerSOAP/ExecReport", ReplyAction="https://www.golia.goliaweb.it/IGoliaManagerSOAP/ExecReportResponse")]
        System.Threading.Tasks.Task<GoliaService.ExecReportResult> ExecReportAsync(GoliaService.ExecReportRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://www.golia.goliaweb.it/IGoliaManagerSOAP/SendSanificationData", ReplyAction="https://www.golia.goliaweb.it/IGoliaManagerSOAP/SendSanificationDataResponse")]
        System.Threading.Tasks.Task<GoliaService.SendSanificationDataResult> SendSanificationDataAsync(GoliaService.SendSanificationDataRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://www.golia.goliaweb.it/IGoliaManagerSOAP/GetVehicleLastSanification", ReplyAction="https://www.golia.goliaweb.it/IGoliaManagerSOAP/GetVehicleLastSanificationRespons" +
            "e")]
        System.Threading.Tasks.Task<GoliaService.GetVehicleLastSanificationResult> GetVehicleLastSanificationAsync(GoliaService.GetVehicleLastSanificationRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://www.golia.goliaweb.it/IGoliaManagerSOAP/ExecReportDriversWorkingDay", ReplyAction="https://www.golia.goliaweb.it/IGoliaManagerSOAP/ExecReportDriversWorkingDayRespon" +
            "se")]
        System.Threading.Tasks.Task<GoliaService.ExecReportDriversWorkingDayResult> ExecReportDriversWorkingDayAsync(GoliaService.ExecReportDriversWorkingDayRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://www.golia.goliaweb.it/IGoliaManagerSOAP/ExecReportDriversRestWeek", ReplyAction="https://www.golia.goliaweb.it/IGoliaManagerSOAP/ExecReportDriversRestWeekResponse" +
            "")]
        System.Threading.Tasks.Task<GoliaService.ExecReportDriversRestWeekResult> ExecReportDriversRestWeekAsync(GoliaService.ExecReportDriversRestWeekRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://www.golia.goliaweb.it/IGoliaManagerSOAP/GetNationsFromPosition", ReplyAction="https://www.golia.goliaweb.it/IGoliaManagerSOAP/GetNationsFromPositionResponse")]
        System.Threading.Tasks.Task<GoliaService.GetNationsFromPositionResult> GetNationsFromPositionAsync(GoliaService.GetNationsFromPositionRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://www.golia.goliaweb.it/IGoliaManagerSOAP/GetTachoFiles", ReplyAction="https://www.golia.goliaweb.it/IGoliaManagerSOAP/GetTachoFilesResponse")]
        System.Threading.Tasks.Task<GoliaService.GetTachoFilesResult> GetTachoFilesAsync(GoliaService.GetTachoFilesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://www.golia.goliaweb.it/IGoliaManagerSOAP/GetAutistiCamionsPlace", ReplyAction="https://www.golia.goliaweb.it/IGoliaManagerSOAP/GetAutistiCamionsPlaceResponse")]
        System.Threading.Tasks.Task<GoliaService.GetAutistiCamionsPlaceResult> GetAutistiCamionsPlaceAsync(GoliaService.GetAutistiCamionsPlaceRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://www.golia.goliaweb.it/IGoliaManagerSOAP/GetLockVehicle", ReplyAction="https://www.golia.goliaweb.it/IGoliaManagerSOAP/GetLockVehicleResponse")]
        System.Threading.Tasks.Task<GoliaService.GetLockVehicleResult> GetLockVehicleAsync(GoliaService.GetLockVehicleRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://www.golia.goliaweb.it/IGoliaManagerSOAP/GetEventFault", ReplyAction="https://www.golia.goliaweb.it/IGoliaManagerSOAP/GetEventFaultResponse")]
        System.Threading.Tasks.Task<GoliaService.GetFaultEventResult> GetEventFaultAsync(GoliaService.GetFaultEventRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://www.golia.goliaweb.it/IGoliaManagerSOAP/RestoreAnagrafica", ReplyAction="https://www.golia.goliaweb.it/IGoliaManagerSOAP/RestoreAnagraficaResponse")]
        System.Threading.Tasks.Task<GoliaService.RestoreAnagraficaResult> RestoreAnagraficaAsync(GoliaService.RestoreAnagraficaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://www.golia.goliaweb.it/IGoliaManagerSOAP/DeleteAnagrafica", ReplyAction="https://www.golia.goliaweb.it/IGoliaManagerSOAP/DeleteAnagraficaResponse")]
        System.Threading.Tasks.Task<GoliaService.DeleteAnagraficaResult> DeleteAnagraficaAsync(GoliaService.DeleteAnagraficaRequest request);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    public interface IGoliaManagerSOAPChannel : GoliaService.IGoliaManagerSOAP, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    public partial class GoliaManagerSOAPClient : System.ServiceModel.ClientBase<GoliaService.IGoliaManagerSOAP>, GoliaService.IGoliaManagerSOAP
    {
        
        /// <summary>
        /// Implementare questo metodo parziale per configurare l'endpoint servizio.
        /// </summary>
        /// <param name="serviceEndpoint">Endpoint da configurare</param>
        /// <param name="clientCredentials">Credenziali del client</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public GoliaManagerSOAPClient() : 
                base(GoliaManagerSOAPClient.GetDefaultBinding(), GoliaManagerSOAPClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IGoliaManagerSOAP.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public GoliaManagerSOAPClient(EndpointConfiguration endpointConfiguration) : 
                base(GoliaManagerSOAPClient.GetBindingForEndpoint(endpointConfiguration), GoliaManagerSOAPClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public GoliaManagerSOAPClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(GoliaManagerSOAPClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public GoliaManagerSOAPClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(GoliaManagerSOAPClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public GoliaManagerSOAPClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<GoliaService.TimeZoneListResult> TimeZoneListAsync(GoliaService.LoginRequest loginCredentials)
        {
            return base.Channel.TimeZoneListAsync(loginCredentials);
        }
        
        public System.Threading.Tasks.Task<GoliaService.GetCompaniesResult> GetCompaniesAsync(GoliaService.LoginRequest loginCredentials)
        {
            return base.Channel.GetCompaniesAsync(loginCredentials);
        }
        
        public System.Threading.Tasks.Task<GoliaService.GetDriversResult> GetDriversAsync(GoliaService.LoginCompanyCultureRequest request)
        {
            return base.Channel.GetDriversAsync(request);
        }
        
        public System.Threading.Tasks.Task<GoliaService.GetVehiclesResult> GetVehiclesAsync(GoliaService.LoginCompanyCultureRequest request)
        {
            return base.Channel.GetVehiclesAsync(request);
        }
        
        public System.Threading.Tasks.Task<GoliaService.SendTachoFileResult> SendTachoFileAsync(GoliaService.SendTachoFileRequest request)
        {
            return base.Channel.SendTachoFileAsync(request);
        }
        
        public System.Threading.Tasks.Task<GoliaService.SendTachoRealtimeResult> SendTachoRealtimeAsync(GoliaService.SendTachoRealtimeRequest request)
        {
            return base.Channel.SendTachoRealtimeAsync(request);
        }
        
        public System.Threading.Tasks.Task<GoliaService.GetInfringmentsResult> GetInfringmentsAsync(GoliaService.GetInfringmentsRequest request)
        {
            return base.Channel.GetInfringmentsAsync(request);
        }
        
        public System.Threading.Tasks.Task<GoliaService.GetDriverPlafondResult> GetDriverPlafondAsync(GoliaService.GetDriverPlafondRequest request)
        {
            return base.Channel.GetDriverPlafondAsync(request);
        }
        
        public System.Threading.Tasks.Task<GoliaService.GetActivitiesResult> GetActivitiesAsync(GoliaService.GetActivitiesRequest request)
        {
            return base.Channel.GetActivitiesAsync(request);
        }
        
        public System.Threading.Tasks.Task<GoliaService.GetTimelineResult> GetTimelineAsync(GoliaService.GetTimelineRequest request)
        {
            return base.Channel.GetTimelineAsync(request);
        }
        
        public System.Threading.Tasks.Task<GoliaService.GetDriverActivityResult> GetDriverActivityAsync(GoliaService.GetDriverActivityRequest request)
        {
            return base.Channel.GetDriverActivityAsync(request);
        }
        
        public System.Threading.Tasks.Task<GoliaService.GetMissingTachoFilePeriodsResult> GetMissingTachoFilePeriodsAsync(GoliaService.GetMissingTachoFilePeriodsRequest request)
        {
            return base.Channel.GetMissingTachoFilePeriodsAsync(request);
        }
        
        public System.Threading.Tasks.Task<GoliaService.SetVehicleResult> SetVehicleAsync(GoliaService.SetVehicleRequest request)
        {
            return base.Channel.SetVehicleAsync(request);
        }
        
        public System.Threading.Tasks.Task<GoliaService.SetDriverResult> SetDriverAsync(GoliaService.SetDriverRequest request)
        {
            return base.Channel.SetDriverAsync(request);
        }
        
        public System.Threading.Tasks.Task<GoliaService.InsertCompanyUserResult> InsertCompanyUserAsync(GoliaService.InsertCompanyUserRequest request)
        {
            return base.Channel.InsertCompanyUserAsync(request);
        }
        
        public System.Threading.Tasks.Task<GoliaService.GetTachoFileResult> GetTachoFileAsync(GoliaService.GetTachoFileRequest request)
        {
            return base.Channel.GetTachoFileAsync(request);
        }
        
        public System.Threading.Tasks.Task<GoliaService.GetDiskFileResult> GetDiskFileAsync(GoliaService.GetDiskFileRequest request)
        {
            return base.Channel.GetDiskFileAsync(request);
        }
        
        public System.Threading.Tasks.Task<GoliaService.GetTachoFileTextExplainResult> GetTachoFileTextExplainAsync(GoliaService.GetTachoFileRequest request)
        {
            return base.Channel.GetTachoFileTextExplainAsync(request);
        }
        
        public System.Threading.Tasks.Task<GoliaService.GetInfringmentsReportResult> GetInfringmentsReportAsync(GoliaService.GetInfringmentsReportRequest request)
        {
            return base.Channel.GetInfringmentsReportAsync(request);
        }
        
        public System.Threading.Tasks.Task<GoliaService.SendPositionsResult> SendPositionsAsync(GoliaService.SendPositionsRequest request)
        {
            return base.Channel.SendPositionsAsync(request);
        }
        
        public System.Threading.Tasks.Task<GoliaService.AuthTokenResult> AuthTokenAsync(GoliaService.AuthTokenRequest request)
        {
            return base.Channel.AuthTokenAsync(request);
        }
        
        public System.Threading.Tasks.Task<GoliaService.GetVehiclesLastPositionResult> GetVehiclesLastPositionAsync(GoliaService.GetVehiclesLastPositionRequest request)
        {
            return base.Channel.GetVehiclesLastPositionAsync(request);
        }
        
        public System.Threading.Tasks.Task<GoliaService.GetVehiclePositionsResult> GetVehiclePositionsAsync(GoliaService.GetVehiclePositionsRequest request)
        {
            return base.Channel.GetVehiclePositionsAsync(request);
        }
        
        public System.Threading.Tasks.Task<GoliaService.GetNormalizedVehicleParametersResult> GetNormalizedVehicleParametersAsync(GoliaService.GetNormalizedVehicleParametersRequest request)
        {
            return base.Channel.GetNormalizedVehicleParametersAsync(request);
        }
        
        public System.Threading.Tasks.Task<GoliaService.GetVehiclesDataResult> GetVehiclesDataAsync(GoliaService.GetVehiclesDataRequest request)
        {
            return base.Channel.GetVehiclesDataAsync(request);
        }
        
        public System.Threading.Tasks.Task<GoliaService.SendDocumentResult> SendDocumentAsync(GoliaService.SendDocumentRequest request)
        {
            return base.Channel.SendDocumentAsync(request);
        }
        
        public System.Threading.Tasks.Task<GoliaService.DownloadDocumentResult> DownloadDocumentAsync(GoliaService.DownloadDocumentRequest request)
        {
            return base.Channel.DownloadDocumentAsync(request);
        }
        
        public System.Threading.Tasks.Task<GoliaService.DeleteDocumentResult> DeleteDocumentAsync(GoliaService.DeleteDocumentRequest request)
        {
            return base.Channel.DeleteDocumentAsync(request);
        }
        
        public System.Threading.Tasks.Task<GoliaService.GetReportsResult> GetReportsAsync(GoliaService.GetReportsRequest request)
        {
            return base.Channel.GetReportsAsync(request);
        }
        
        public System.Threading.Tasks.Task<GoliaService.ExecReportResult> ExecReportAsync(GoliaService.ExecReportRequest request)
        {
            return base.Channel.ExecReportAsync(request);
        }
        
        public System.Threading.Tasks.Task<GoliaService.SendSanificationDataResult> SendSanificationDataAsync(GoliaService.SendSanificationDataRequest request)
        {
            return base.Channel.SendSanificationDataAsync(request);
        }
        
        public System.Threading.Tasks.Task<GoliaService.GetVehicleLastSanificationResult> GetVehicleLastSanificationAsync(GoliaService.GetVehicleLastSanificationRequest request)
        {
            return base.Channel.GetVehicleLastSanificationAsync(request);
        }
        
        public System.Threading.Tasks.Task<GoliaService.ExecReportDriversWorkingDayResult> ExecReportDriversWorkingDayAsync(GoliaService.ExecReportDriversWorkingDayRequest request)
        {
            return base.Channel.ExecReportDriversWorkingDayAsync(request);
        }
        
        public System.Threading.Tasks.Task<GoliaService.ExecReportDriversRestWeekResult> ExecReportDriversRestWeekAsync(GoliaService.ExecReportDriversRestWeekRequest request)
        {
            return base.Channel.ExecReportDriversRestWeekAsync(request);
        }
        
        public System.Threading.Tasks.Task<GoliaService.GetNationsFromPositionResult> GetNationsFromPositionAsync(GoliaService.GetNationsFromPositionRequest request)
        {
            return base.Channel.GetNationsFromPositionAsync(request);
        }
        
        public System.Threading.Tasks.Task<GoliaService.GetTachoFilesResult> GetTachoFilesAsync(GoliaService.GetTachoFilesRequest request)
        {
            return base.Channel.GetTachoFilesAsync(request);
        }
        
        public System.Threading.Tasks.Task<GoliaService.GetAutistiCamionsPlaceResult> GetAutistiCamionsPlaceAsync(GoliaService.GetAutistiCamionsPlaceRequest request)
        {
            return base.Channel.GetAutistiCamionsPlaceAsync(request);
        }
        
        public System.Threading.Tasks.Task<GoliaService.GetLockVehicleResult> GetLockVehicleAsync(GoliaService.GetLockVehicleRequest request)
        {
            return base.Channel.GetLockVehicleAsync(request);
        }
        
        public System.Threading.Tasks.Task<GoliaService.GetFaultEventResult> GetEventFaultAsync(GoliaService.GetFaultEventRequest request)
        {
            return base.Channel.GetEventFaultAsync(request);
        }
        
        public System.Threading.Tasks.Task<GoliaService.RestoreAnagraficaResult> RestoreAnagraficaAsync(GoliaService.RestoreAnagraficaRequest request)
        {
            return base.Channel.RestoreAnagraficaAsync(request);
        }
        
        public System.Threading.Tasks.Task<GoliaService.DeleteAnagraficaResult> DeleteAnagraficaAsync(GoliaService.DeleteAnagraficaRequest request)
        {
            return base.Channel.DeleteAnagraficaAsync(request);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        #if !NET6_0_OR_GREATER
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        #endif
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IGoliaManagerSOAP))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("L\'endpoint denominato \'{0}\' non è stato trovato.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IGoliaManagerSOAP))
            {
                return new System.ServiceModel.EndpointAddress("http://manager.golia.goliaweb.it/services/GoliaManagerSOAP");
            }
            throw new System.InvalidOperationException(string.Format("L\'endpoint denominato \'{0}\' non è stato trovato.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return GoliaManagerSOAPClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IGoliaManagerSOAP);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return GoliaManagerSOAPClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IGoliaManagerSOAP);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IGoliaManagerSOAP,
        }
    }
}
