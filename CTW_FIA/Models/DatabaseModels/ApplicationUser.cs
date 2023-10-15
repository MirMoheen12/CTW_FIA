using Microsoft.AspNetCore.Identity;

namespace CTW_FIA.Models
{
    public class ApplicationUser : IdentityUser
    {
        // Add any additional properties you need here
        public string OfficeId { get; set; }
        public string DepartmentId { get; set; }
    }
}

