namespace CTW_FIA.Models.DatabaseModels
{
    public class Office
    {
        public string strURN { get; set; }
        public int intID { get; set; }
        public string OfficeName { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public int DepID { get; set; }
    }

}
