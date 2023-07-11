namespace CTW_FIA.Models.DatabaseModels
{
    public class CurrentStatusList
    {
        public int intID { get; set; }
        public int CurrentStatus_ID { get; set; }
        public string CurrentStatus_Name { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
    }

}
