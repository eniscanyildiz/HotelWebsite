using Microsoft.AspNetCore.Mvc;

namespace HotelWebsite.WebUI.ViewComponents.Default
{
    public class _FooterPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
