namespace CTW_FIA.Models.Dto
{
    public class UserDto
    {
        public String UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int? departmentID { get; set; }
        public int? officeID { get; set; }

    }
}
