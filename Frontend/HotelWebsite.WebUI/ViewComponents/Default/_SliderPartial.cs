using Microsoft.AspNetCore.Mvc;

namespace HotelWebsite.WebUI.ViewComponents.Default
{
    public class _SliderPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
