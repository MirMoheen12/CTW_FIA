using System.ComponentModel.DataAnnotations;

namespace CTW_FIA.Models.Dto
{
    public class Communications_sel
    {
        [Display(Name = "Serial No")]
        public string? SerialNo { get; set; }

        [Display(Name = "Str URN")]
        public string? strURN { get; set; }

        [Display(Name = "ID")]
        public string? intID { get; set; }

        [Display(Name = "Communication Type")]
        public string? CommType { get; set; }

        [Display(Name = "Communication Description")]
        public string? CommDescription { get; set; }

        [Display(Name = "Communication Name")]
        public string? CommName { get; set; }

        [Display(Name = "Other")]
        public string? Other { get; set; }

        [Display(Name = "Web Value")]
        public string? WebValue { get; set; }

        [Display(Name = "Number")]
        public string? Number { get; set; }

        [Display(Name = "Service Provider")]
        public string? ServiceProvider { get; set; }

        [Display(Name = "Country of Origin")]
        public string? CountryOrigin { get; set; }

        [Display(Name = "Remarks")]
        public string? memRemarks { get; set; }

        [Display(Name = "Created On")]
        public string? CreatedOn { get; set; }

        [Display(Name = "Date Sent")]
        public string? DateSent { get; set; }

        [Display(Name = "Is Deleted")]
        public string? IsDeleted { get; set; }
    }
}
