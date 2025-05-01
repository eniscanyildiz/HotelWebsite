using Microsoft.AspNetCore.Mvc;

namespace HotelWebsite.WebUI.ViewComponents.Default
{
    public class _ScriptsPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
