namespace CTW_FIA.Models.DatabaseModels
{
    public class CityList
    {
        public string strURN { get; set; }
        public string strCityCode { get; set; }
        public string strCity { get; set; }
        public string DistrictListstrURN { get; set; }
        public int intID { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public string textSearch { get; set; }
    }

}
