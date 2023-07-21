using Microsoft.AspNetCore.Mvc;
using MyHotelProject.WebUI.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace MyHotelProject.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DefaultController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult SubscribePartial()
        {
            return PartialView();
        }

        [HttpPost]
        public async Task<IActionResult> SubscribePartial(SubscribeViewModel viewModel)
        {
            var jsonData = JsonConvert.SerializeObject(viewModel);
            StringContent stringContent = new(jsonData, Encoding.UTF8, "application/json");
           await _httpClientFactory.CreateClient().PostAsync("http://localhost:5188/api/Subcribe", stringContent);
             return RedirectToAction("Index", "Default");
        }
    }
}
