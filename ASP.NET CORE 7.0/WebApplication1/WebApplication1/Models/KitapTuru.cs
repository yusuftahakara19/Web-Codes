using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class KitapTuru
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Ad { get; set; }
    }
}
