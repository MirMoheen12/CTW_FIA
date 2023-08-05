using System.ComponentModel.DataAnnotations;

namespace CTW_FIA.Models.Dto
{
    public partial class QuickSearchGroups_sel_Result
    {
        [Display(Name = "Serial No")]
        public string? SerialNo { get; set; }

        [Display(Name = "DGV Group Name")]
        public string? dgvGroupName { get; set; }

        [Display(Name = "DGV Country Origin")]
        public string? dgvCountryOrigin { get; set; }

        [Display(Name = "DGV Country")]
        public string? dgvCountry { get; set; }

        [Display(Name = "DGV Province")]
        public string? dgvProvince { get; set; }

        [Display(Name = "Str URN")]
        public string? strURN { get; set; }

        [Display(Name = "Int ID")]
        public string? intID { get; set; }

        [Display(Name = "Group To")]
        public string? GroupTo { get; set; }

        [Display(Name = "Head Name")]
        public string? HeadName { get; set; }

        [Display(Name = "Mem Goals")]
        public string? MemGoals { get; set; }

        [Display(Name = "Str Declared By Whom")]
        public string? strDeclaredByWhom { get; set; }

        [Display(Name = "Strength")]
        public string? Strength { get; set; }

        [Display(Name = "Area")]
        public string? Area { get; set; }

        [Display(Name = "City")]
        public string? City { get; set; }

        [Display(Name = "Postal Zip")]
        public string? PostalZip { get; set; }

        [Display(Name = "Address")]
        public string? Address { get; set; }

        [Display(Name = "Mem Remarks")]
        public string? MemRemarks { get; set; }

        [Display(Name = "Date Established")]
        public string? DateEstablished { get; set; }

        [Display(Name = "Created On")]
        public string? CreatedOn { get; set; }

        [Display(Name = "Created By")]
        public string? CreatedBy { get; set; }

        [Display(Name = "Deleted Record")]
        public string? DeletedRecord { get; set; }

        [Display(Name = "Is Deleted")]
        public string? IsDeleted { get; set; }

        [Display(Name = "Text Search")]
        public string? textSearch { get; set; }

        [Display(Name = "Group Reporting Agency")]
        public string? GroupReportingAgency { get; set; }

        [Display(Name = "District")]
        public string? District { get; set; }

        [Display(Name = "Sub Category")]
        public string? SubCategory { get; set; }

        [Display(Name = "Flag")]
        public string? flag { get; set; }

        [Display(Name = "Table Name")]
        public string? tableName { get; set; }
    }
}
