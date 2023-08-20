using System;
using System.ComponentModel.DataAnnotations;

namespace FIA_Business.FIA_Models
{
    public partial class QuickSearchEvidence_sel_Result
    {
        [Display(Name = "Serial Number")]
        public string? SerialNo { get; set; }

        [Display(Name = "URN")]
        public string? strURN { get; set; }

        [Display(Name = "ID")]
        public string? intID { get; set; }

        [Display(Name = "Item")]
        public string? Item { get; set; }

        [Display(Name = "Quantity")]
        public string? Quantity { get; set; }

        [Display(Name = "Date")]
        public string? Date { get; set; }

        [Display(Name = "Time")]
        public string? Time { get; set; }

        [Display(Name = "Collected By")]
        public string? CollectedBy { get; set; }

        [Display(Name = "Location")]
        public string? Location { get; set; }

        [Display(Name = "Remarks")]
        public string? memRemarks { get; set; }

        [Display(Name = "Created On")]
        public string? CreatedOn { get; set; }

        [Display(Name = "Date Sent")]
        public string? DateSent { get; set; }

        [Display(Name = "Is Deleted")]
        public string? IsDeleted { get; set; }

        [Display(Name = "Text Search")]
        public string? textSearch { get; set; }

        [Display(Name = "Flag")]
        public string? flag { get; set; }

        [Display(Name = "Table Name")]
        public string? tableName { get; set; }

        [Display(Name = "Created By")]
        public string? CreatedBy { get; set; }

        [Display(Name = "Updated On")]
        public string? UpdatedOn { get; set; }

        [Display(Name = "Updated By")]
        public string? UpdatedBy { get; set; }
    }
}
