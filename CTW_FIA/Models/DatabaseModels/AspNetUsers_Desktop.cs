namespace CTW_FIA.Models.DatabaseModels
{
    public class AspNetUsers_Desktop
    {
        public string strURN { get; set; }
        public string UserID { get; set; }
        public int DepartmentID { get; set; }
        public int OfficeID { get; set; }
        public string Designation { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool ActiveUser { get; set; }
        public bool AccountLock { get; set; }
        public string UserRole { get; set; }
        public string ReferenceNo { get; set; }
        public DateTime ReferenceDate { get; set; }
        public string CNIC { get; set; }
        public string CellNumber { get; set; }
        public string OfficeNumber { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime LoggedIn { get; set; }
        public DateTime LoggedOut { get; set; }
    }

}
