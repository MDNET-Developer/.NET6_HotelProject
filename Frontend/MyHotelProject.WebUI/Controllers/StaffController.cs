using Microsoft.AspNetCore.Mvc;

namespace MyHotelProject.WebUI.Controllers
{
    public class StaffController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
