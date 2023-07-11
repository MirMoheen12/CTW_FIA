namespace CTW_FIA.Models.Dto
{
    public class PreviewIncident
    {
        public int intid { get; set; }
        public Nullable<long> SerialNo { get; set; }
        public string strOperationName { get; set; }
        public string FirNo { get; set; }
        public Nullable<int> NumberKilled { get; set; }
        public Nullable<int> NumberInjured { get; set; }
        public string Inc_Date { get; set; }
        public Nullable<int> RegYear { get; set; }
        public string US { get; set; }
        public string Country { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string PostalZip { get; set; }
        public string PoliceStation { get; set; }
        public string Address { get; set; }
        public Nullable<System.DateTime> IncidentDate { get; set; }
        public Nullable<System.DateTime> IncidentTime { get; set; }
        public Nullable<System.DateTime> IncidentTimeEnd { get; set; }
        public Nullable<float> Latitude { get; set; }
        public Nullable<float> Longitude { get; set; }
        public string InjuredName { get; set; }
        public string CasualtiesNames { get; set; }
        public Nullable<int> SuicideBomb { get; set; }
        public string CTWRemarks { get; set; }
        public string Target { get; set; }
        public string Motive { get; set; }
        public string Recoveries { get; set; }
        public string CrimeSceneRecoveries { get; set; }
        public string CaseStatus { get; set; }
        public string strCaseProgress { get; set; }
        public string Weapon { get; set; }
        public string ModusofOperandi { get; set; }
        public Nullable<System.DateTime> dteSent { get; set; }
        public Nullable<int> NumberArrested { get; set; }
        public string PreIncidentThread { get; set; }
        public string Reportedby { get; set; }
        public string strURN { get; set; }
        public int INC_FirNo { get; set; }
    }
}
