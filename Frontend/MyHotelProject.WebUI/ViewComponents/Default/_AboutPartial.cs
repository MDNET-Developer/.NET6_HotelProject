using Microsoft.AspNetCore.Mvc;

namespace MyHotelProject.WebUI.ViewComponents.Default
{
    public class _AboutPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
