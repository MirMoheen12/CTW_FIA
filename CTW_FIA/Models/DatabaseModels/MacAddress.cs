namespace CTW_FIA.Models.DatabaseModels
{
    public class MacAddress
    {
        public int intID { get; set; }
        public string strURN { get; set; }
        public string MAC_Address { get; set; }
        public int DepartmentID { get; set; }
        public int OfficeID { get; set; }
        public string ComputerName { get; set; }
        public string UserID { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
    }

}
