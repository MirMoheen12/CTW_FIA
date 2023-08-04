using System.ComponentModel.DataAnnotations;

namespace CTW_FIA.Models.Dto
{
    public class PreviewIncidentByStrUrn
    {
        [Display(Name = "Int ID")]
        public string? intid { get; set; }

        [Display(Name = "Serial Number")]
        public string? SerialNo { get; set; }

        [Display(Name = "String URN")]
        public string? strURN { get; set; }

        [Display(Name = "Operation Name")]
        public string? strOperationName { get; set; }

        [Display(Name = "FIR Number")]
        public string? FirNo { get; set; }

        [Display(Name = "Number Killed")]
        public string? NumberKilled { get; set; }

        [Display(Name = "Number Injured")]
        public string? NumberInjured { get; set; }

        [Display(Name = "Incident Date")]
        public string? Inc_Date { get; set; }

        [Display(Name = "Registration Year")]
        public string? RegYear { get; set; }

        [Display(Name = "United States")]
        public string? US { get; set; }

        [Display(Name = "Country")]
        public string? Country { get; set; }

        [Display(Name = "Province")]
        public string? Province { get; set; }

        [Display(Name = "City")]
        public string? City { get; set; }

        [Display(Name = "District")]
        public string? District { get; set; }

        [Display(Name = "Postal Zip")]
        public string? PostalZip { get; set; }

        [Display(Name = "Police Station")]
        public string? PoliceStation { get; set; }

        [Display(Name = "Address")]
        public string? Address { get; set; }

        [Display(Name = "Incident Date")]
        public string? IncidentDate { get; set; }

        [Display(Name = "Incident Time")]
        public string? IncidentTime { get; set; }

        [Display(Name = "Incident End Time")]
        public string? IncidentTimeEnd { get; set; }

        [Display(Name = "Latitude")]
        public string? Latitude { get; set; }

        [Display(Name = "Longitude")]
        public string? Longitude { get; set; }

        [Display(Name = "Injured Name")]
        public string? InjuredName { get; set; }

        [Display(Name = "Casualties Names")]
        public string? CasualtiesNames { get; set; }

        [Display(Name = "Suicide Bomb")]
        public string? SuicideBomb { get; set; }

        [Display(Name = "CTW Remarks")]
        public string? CTWRemarks { get; set; }

        [Display(Name = "Target")]
        public string? Target { get; set; }

        [Display(Name = "Motive")]
        public string? Motive { get; set; }

        [Display(Name = "Recoveries")]
        public string? Recoveries { get; set; }

        [Display(Name = "Crime Scene Recoveries")]
        public string? CrimeSceneRecoveries { get; set; }

        [Display(Name = "Case Status")]
        public string? CaseStatus { get; set; }

        [Display(Name = "Case Progress")]
        public string? strCaseProgress { get; set; }

        [Display(Name = "Weapon")]
        public string? Weapon { get; set; }

        [Display(Name = "Modus Operandi")]
        public string? ModusofOperandi { get; set; }

        [Display(Name = "Date Sent")]
        public string? dteSent { get; set; }

        [Display(Name = "Number Arrested")]
        public string? NumberArrested { get; set; }

        [Display(Name = "Pre-Incident Threat")]
        public string? PreIncidentThread { get; set; }

        [Display(Name = "Reported by")]
        public string? Reportedby { get; set; }

        [Display(Name = "Flag")]
        public string? flag { get; set; }

        [Display(Name = "Table Name")]
        public string? tableName { get; set; }

        [Display(Name = "Text Search")]
        public string? textSearch { get; set; }

        [Display(Name = "INC FIR Number")]
        public string? INC_FirNo { get; set; }
    }

}
