using System.ComponentModel.DataAnnotations;

namespace CTW_FIA.Models.DatabaseModels
{
    public class ReportingAgency
    {
        [Key]
        public int ReportingAgencyID { get; set; }
        public string? strURN { get; set; }
        public string? ReportingAgencyTitle { get; set; }
        public Nullable<DateTime> CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public Nullable<DateTime> UpdatedOn { get; set; }
        public string? UpdatedBy { get; set; }
        public int? IsDeleted { get; set; }
    }

}
