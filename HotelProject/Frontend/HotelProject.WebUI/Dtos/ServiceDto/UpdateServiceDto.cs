using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class UpdateServiceDto
    {
        public int ServiceID { get; set; }

        [Required(ErrorMessage = "Please enter the service icon information")]
        public string ServiceIcon { get; set; }
        [Required(ErrorMessage = "Please enter the service title information")]
        [StringLength(100, ErrorMessage = "Service title can be up to maxium 100 characters")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter the service description")]
        [StringLength(500, ErrorMessage = "Service description can be up to maxium 500 characters")]

        public string Description { get; set; }

    }
}
