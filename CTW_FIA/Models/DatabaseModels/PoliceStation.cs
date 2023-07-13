namespace CTW_FIA.Models.DatabaseModels
{
    public class PoliceStation
    {
        public string strURN { get; set; }
        public string strPoliceStation { get; set; }
        public string CityListstrURN { get; set; }
        public int intID { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public string textSearch { get; set; }
        public int DistrictListintID { get; set; }
    }

}
