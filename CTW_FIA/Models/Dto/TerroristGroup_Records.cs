using System.ComponentModel.DataAnnotations;

namespace CTW_FIA.Models.Dto
{
    public class TerroristGroup_Records
    {
        [Display(Name = "Serial No")]
        public string? SerialNo { get; set; }

        [Display(Name = "Group Name")]
        public string? dgvGroupName { get; set; }

        [Display(Name = "Country Origin")]
        public string? dgvCountryOrigin { get; set; }

        [Display(Name = "Country")]
        public string? dgvCountry { get; set; }

        [Display(Name = "Province")]
        public string? dgvProvince { get; set; }

        [Display(Name = "URN")]
        public string? strURN { get; set; }

        [Display(Name = "Group To")]
        public string? GroupTo { get; set; }

        [Display(Name = "Head Name")]
        public string? HeadName { get; set; }

        [Display(Name = "Member Goals")]
        public string? MemGoals { get; set; }

        [Display(Name = "Declared By")]
        public string? strDeclaredByWhom { get; set; }

        [Display(Name = "Strength")]
        public string? Strength { get; set; }

        [Display(Name = "Area")]
        public string? Area { get; set; }

        [Display(Name = "City")]
        public string? City { get; set; }

        [Display(Name = "Postal/ZIP Code")]
        public string? PostalZip { get; set; }

        [Display(Name = "Address")]
        public string? Address { get; set; }

        [Display(Name = "Member Remarks")]
        public string? MemRemarks { get; set; }

        [Display(Name = "Date Established")]
        public string? DateEstablished { get; set; }

        [Display(Name = "ID")]
        public string? intID { get; set; }

        [Display(Name = "Created On")]
        public string? CreatedOn { get; set; }

        [Display(Name = "Created By")]
        public string? CreatedBy { get; set; }

        [Display(Name = "Deleted Record")]
        public string? DeletedRecord { get; set; }

        [Display(Name = "Is Deleted")]
        public string? IsDeleted { get; set; }

        [Display(Name = "Group Reporting Agency")]
        public string? GroupReportingAgency { get; set; }

        [Display(Name = "District")]
        public string? District { get; set; }

        [Display(Name = "Sub Category")]
        public string? SubCategory { get; set; }
    }
}
