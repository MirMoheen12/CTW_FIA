namespace CTW_FIA.Models.DatabaseModels
{
    public class ProvinceList
    {
        public int ProvinceID { get; set; }
        public string ProvinceName { get; set; }
        public string ProvinceCode { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public int? IsDeleted { get; set; }
    }

}
