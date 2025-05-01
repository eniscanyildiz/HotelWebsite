using Microsoft.AspNetCore.Mvc;

namespace HotelWebsite.WebUI.ViewComponents.Default
{
    public class _ReservationPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
