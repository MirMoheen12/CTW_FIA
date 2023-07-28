using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CTW_FIA.Models.DatabaseModels
{
    public class Incident
    {
        [Key]
        public string strURN { get; set; }
        public string strOperationName { get; set; }
        public string FirNo { get; set; }
        public string INC_FirNo { get; set; }
        public int RegYear { get; set; }
        public string US { get; set; }
        public string Country { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string PostalZip { get; set; }
        public string PoliceStation { get; set; }
        public string Address { get; set; }
        public DateTime IncidentDate { get; set; }
        public TimeSpan IncidentTime { get; set; }
        public TimeSpan IncidentTimeEnd { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int NumberKilled { get; set; }
        public int NumberInjured { get; set; }
        public string InjuredName { get; set; }
        public string CasualtiesNames { get; set; }
        public bool SuicideBomb { get; set; }
        public string CTWRemarks { get; set; }
        public string Target { get; set; }
        public string Motive { get; set; }
        public string Recoveries { get; set; }
        public string CrimeSceneRecoveries { get; set; }
        public string CaseStatus { get; set; }
        public string strCaseProgress { get; set; }
        public string Weapon { get; set; }
        public string ModusofOperand { get; set; }
        public DateTime dteSent { get; set; }
        [NotMapped]
        public int intID { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public string textSearch { get; set; }
        public int NumberArrested { get; set; }
        public string PreIncidentThread { get; set; }
        public string Reportedby { get; set; }
        public string Status { get; set; }
        public DateTime ApprovedOn { get; set; }
        public string ApprovedBy { get; set; }
    }

}
