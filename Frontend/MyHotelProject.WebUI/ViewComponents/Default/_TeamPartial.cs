using Microsoft.AspNetCore.Mvc;

namespace MyHotelProject.WebUI.ViewComponents.Default
{
    public class _TeamPartial : ViewComponent
    {
        public IViewComponentResult Invoke() 
        { 
            return View(); 
        }
    }
}
