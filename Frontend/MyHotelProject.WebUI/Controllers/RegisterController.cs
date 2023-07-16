using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyHotelProject.EntityLayer.Concrete;
using MyHotelProject.WebUI.Models;

namespace MyHotelProject.WebUI.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(RegisterViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            AppUser appUser = new()
            {
                Name = viewModel.Name,
                Surname = viewModel.Surname,
                UserName = viewModel.UserName,
                Email=  viewModel.Mail,
            };

            var result = await _userManager.CreateAsync(appUser,password:viewModel.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("Index","Login");
            }
            return View();
        }
    }
}
