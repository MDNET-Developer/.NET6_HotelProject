using System.ComponentModel.DataAnnotations;

namespace MyHotelProject.WebUI.Models
{
    public class RegisterViewModel
    {
        [Required]
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? UserName { get; set; }
        public string? Mail { get; set; }
        public string? Password { get; set; }
        [Compare("Password",ErrorMessage =" Təkrar şifrə doğru deyil ")]
        public string? ConfirmPassword { get; set; }
    }
}
