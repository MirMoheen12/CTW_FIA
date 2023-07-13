namespace CTW_FIA.Models.DatabaseModels
{
    public class AccusationStatus
    {
        public int IntID { get; set; }
        public int AccusationStatusID { get; set; }
        public string AccusationStatusName { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
    }

}
