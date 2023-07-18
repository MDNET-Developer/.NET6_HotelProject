using Microsoft.AspNetCore.Mvc;

namespace MyHotelProject.WebUI.ViewComponents.Default
{
    public class _RoomPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
