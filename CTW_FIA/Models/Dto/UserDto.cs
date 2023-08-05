using System.ComponentModel.DataAnnotations;

namespace CTW_FIA.Models.Dto
{
    public class UserDto
    {
        [Display(Name = "User ID")]
        public string? UserID { get; set; }

        [Display(Name = "User Name")]
        public string? UserName { get; set; }

        [Display(Name = "Password")]
        public string? Password { get; set; }

        [Display(Name = "Department ID")]
        public string? DepartmentID { get; set; }

        [Display(Name = "Office ID")]
        public string? OfficeID { get; set; }

        [Display(Name = "Designation")]
        public string? Designation { get; set; }

        [Display(Name = "Active User")]
        public string? ActiveUser { get; set; }

        [Display(Name = "Account Lock")]
        public string? AccountLock { get; set; }

        [Display(Name = "User Role")]
        public string? UserRole { get; set; }
    }
}
