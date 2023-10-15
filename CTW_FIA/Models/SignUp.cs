using System.ComponentModel.DataAnnotations;
namespace IdentityProject.Models
{
    public class SignUp
    {
        [Required(ErrorMessage ="Please Enter Your Email")]
        [Display(Name="Email Address")]
        [EmailAddress(ErrorMessage ="Please Enter a Valid Email Address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Enter Your Password")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please Confirm Your Password")]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Password Doesn't Match")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
