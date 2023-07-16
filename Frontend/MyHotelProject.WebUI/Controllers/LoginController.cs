using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyHotelProject.EntityLayer.Concrete;
using MyHotelProject.WebUI.Models;

namespace MyHotelProject.WebUI.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> userManager)
        {
            _signInManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(viewModel.UserName, viewModel.Password,false,false);
                if (result.Succeeded)
                {
                    return  RedirectToAction("Index","Staff");
                }

            }
            return View();
        }
    }
}
