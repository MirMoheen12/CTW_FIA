namespace CTW_FIA.Models.DatabaseModels
{
    public class BaseLogs
    {
        public int Id { get; set; }
        public string strURN { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public string textSearch { get; set; }
    }

}
