using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
    public class RoomUpdateDto
    {
        [Required(ErrorMessage = "Please enter the room ID information")]
        public int RoomID { get; set; }
        [Required(ErrorMessage = "Please enter the room number information")]
        public string RoomNumber { get; set; }
        public string RoomCoverImage { get; set; }
        [Required(ErrorMessage = "Please enter the price information")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Please enter the room title information")]
        [StringLength(100,ErrorMessage = "Please enter maximum 100 characters")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter the bed count information")]
        public string BedCount { get; set; }
        [Required(ErrorMessage = "Please enter the bath count information")]
        public string BathCount { get; set; }
        public string Wifi { get; set; }
        [Required(ErrorMessage = "Please write the description")]
        public string Description { get; set; }
    }
}
