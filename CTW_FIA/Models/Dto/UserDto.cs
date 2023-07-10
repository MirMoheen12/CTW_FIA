namespace CTW_FIA.Models.Dto
{
    public class UserDto
    {
		public int UserID { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
		public int DepartmentID { get; set; }
		public int OfficeID { get; set; }
		public string Designation { get; set; }
		public bool ActiveUser { get; set; }
		public bool AccountLock { get; set; }
		public string UserRole { get; set; }

	}
}
