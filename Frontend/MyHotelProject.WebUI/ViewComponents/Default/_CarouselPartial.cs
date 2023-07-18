using Microsoft.AspNetCore.Mvc;

namespace MyHotelProject.WebUI.ViewComponents.Default
{
    public class _CarouselPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
