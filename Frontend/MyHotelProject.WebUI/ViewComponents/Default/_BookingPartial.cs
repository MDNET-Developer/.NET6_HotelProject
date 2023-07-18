using Microsoft.AspNetCore.Mvc;

namespace MyHotelProject.WebUI.ViewComponents.Default
{
    public class _BookingPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
