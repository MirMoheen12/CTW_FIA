using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace CTW_FIA.Models
{
    public class Login
    {

        [Required(ErrorMessage = "Please Enter UserName")]
        [Display(Name = "User Name")]
        
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please Enter Password")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }

        
        [NotMapped]
		public string InvalidCredentials { get; set; }
	}
}
