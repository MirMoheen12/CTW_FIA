namespace CTW_FIA.Models.DatabaseModels
{
    public class MotiveList
    {
        public int intID { get; set; }
        public int Motive_ID { get; set; }
        public string Motive_Name { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
    }

}
