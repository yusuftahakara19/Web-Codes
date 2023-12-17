using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class CreateServiceDto
    {
        [Required(ErrorMessage ="Please enter the service icon information")]
        public string ServiceIcon { get; set; }
        [Required(ErrorMessage = "Please enter the service title information")]
        [StringLength(100,ErrorMessage ="Service title can be up to maxium 100 characters")]
        public string Title { get; set; }
        public string Description { get; set; }

    }
}
