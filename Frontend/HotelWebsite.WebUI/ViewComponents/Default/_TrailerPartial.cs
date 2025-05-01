using Microsoft.AspNetCore.Mvc;

namespace HotelWebsite.WebUI.ViewComponents.Default
{
    public class _TrailerPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
