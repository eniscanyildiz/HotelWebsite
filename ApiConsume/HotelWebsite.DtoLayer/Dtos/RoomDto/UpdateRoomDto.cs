using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelWebsite.DtoLayer.Dtos.RoomDto
{
    public class UpdateRoomDto
    {
        public int RoomID { get; set; }
        [Required(ErrorMessage = "Please enter room number.")]
        public string RoomNumber { get; set; }
        [Required(ErrorMessage = "Please enter image.")]
        public string RoomCoverImage { get; set; }
        [Required(ErrorMessage = "Please enter room price.")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Please enter room title.")]
        [StringLength(100, ErrorMessage = "Title cannot be longer than 100 characters.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter bed count.")] 
        public string BedCount { get; set; }
        [Required(ErrorMessage = "Please enter bath count.")]
        public string BathCount { get; set; }
        public string Wifi { get; set; }
        [Required(ErrorMessage = "Please enter description.")]
        public string Description { get; set; }
    }
}
