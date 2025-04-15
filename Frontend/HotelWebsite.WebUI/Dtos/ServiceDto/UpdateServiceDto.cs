using System.ComponentModel.DataAnnotations;

namespace HotelWebsite.WebUI.Dtos.ServiceDto
{
    public class UpdateServiceDto
    {
        public int ServiceID { get; set; }
        [Required(ErrorMessage = "Enter a service icon link.")]
        public string ServiceIcon { get; set; }
        [Required(ErrorMessage = "Enter a service title.")]
        [StringLength(100, ErrorMessage = "Title must be at most 100 characters long.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Enter a service description.")]
        [StringLength(500, ErrorMessage = "Title must be at most 500 characters long.")]
        public string Description { get; set; }
    }
}
