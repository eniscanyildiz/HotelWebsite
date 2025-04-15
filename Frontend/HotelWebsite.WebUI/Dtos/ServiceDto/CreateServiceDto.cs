using System.ComponentModel.DataAnnotations;

namespace HotelWebsite.WebUI.Dtos.ServiceDto
{
    public class CreateServiceDto
    {
        [Required(ErrorMessage = "Enter a service icon link.")]
        public string ServiceIcon { get; set; }
        [Required(ErrorMessage = "Enter a service title.")]
        [StringLength(100, ErrorMessage = "Title must be at most 100 characters long.")]
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
