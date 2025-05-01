using Microsoft.AspNetCore.Mvc;

namespace HotelWebsite.WebUI.ViewComponents.Default
{
    public class _HeadPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }


    }
}
