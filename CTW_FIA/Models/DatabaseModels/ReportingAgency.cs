namespace CTW_FIA.Models.DatabaseModels
{
    public class ReportingAgency
    {
        public int ReportingAgencyID { get; set; }
        public string strURN { get; set; }
        public string ReportingAgencyTitle { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public int? IsDeleted { get; set; }
    }

}
