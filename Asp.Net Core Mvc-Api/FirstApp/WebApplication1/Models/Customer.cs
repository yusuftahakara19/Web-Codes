using System.ComponentModel.DataAnnotations;

namespace FirstApp.Models
{
    public class Customer
    {
        [Required(ErrorMessage ="Id required")]
        public int Id { get; set; }
    
        [Required(ErrorMessage ="Firstname required")]
        [MaxLength(30, ErrorMessage = "Max 30 charachter for Firstname")]
        public string firstName { get; set; }
     
        [Required(ErrorMessage ="Lastname required")]
        [MinLength(3, ErrorMessage = "Min 3 charachter for Firstname")]
        public string lastName { get; set; }

        [Range(18,40,ErrorMessage ="Age must be between 18-40")]
        public int age { get; set; }
    }
}
