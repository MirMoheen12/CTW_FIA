namespace CTW_FIA.Models
{
    public class MacAddress
	{
		public int Id { get; set; }
		public long? SerialNo { get; set; }
        public string strURN { get; set; }
        public int? DepartmentID { get; set; }
        public int? OfficeID { get; set; }
        public string ComputerName { get; set; }
        public string MAC_Address { get; set; }
        public string CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string DepartmentName { get; set; }
        public string OfficeName { get; set; }
    }
}
