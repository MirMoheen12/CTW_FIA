using System.ComponentModel.DataAnnotations;

namespace CTW_FIA.Models.Dto
{
    public class DetonatorDetails_sel_Result
    {
        [Display(Name = "Serial No")]
        public string? SerialNo { get; set; }

        [Display(Name = "ID")]
        public string? intID { get; set; }

        [Display(Name = "URN")]
        public string? strURN { get; set; }

        [Display(Name = "Category")]
        public string? Category { get; set; }

        [Display(Name = "Type")]
        public string? Type { get; set; }

        [Display(Name = "Created On")]
        public string? CreatedOn { get; set; }

        [Display(Name = "Created By")]
        public string? CreatedBy { get; set; }

        [Display(Name = "Updated On")]
        public string? UpdatedOn { get; set; }

        [Display(Name = "Updated By")]
        public string? UpdatedBy { get; set; }

        [Display(Name = "Is Deleted")]
        public string? IsDeleted { get; set; }
    }
}
