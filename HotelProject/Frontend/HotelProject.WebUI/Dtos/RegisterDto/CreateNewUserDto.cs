using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.RegisterDto
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage = "Please enter Name information")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter Surname information")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Please enter Username information")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Please enter Mail information")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Please enter Password information")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Please confirm password")]
        [Compare("Password",ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; }
    }
}
