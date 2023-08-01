using Microsoft.AspNetCore.Mvc;
using MyHotelProject.WebUI.Models;
using Newtonsoft.Json;
using System.Text;

namespace MyHotelProject.WebUI.Controllers
{
    public class BookingAdminController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BookingAdminController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public async Task<IActionResult> DetailsBooking(int id)
        {
            var responseMessage = await _httpClientFactory.CreateClient().GetAsync($"http://localhost:5188/api/Booking/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<BookingAdminViewModel>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> DetailsBooking(BookingAdminViewModel viewModel)
        {
            var jsonData = JsonConvert.SerializeObject(viewModel);
            StringContent stringContent = new(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await _httpClientFactory.CreateClient().PutAsync("http://localhost:5188/api/Booking", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "BookingAdmin");
            }
            return View(jsonData);
        }
        public async Task<IActionResult> Index()
        {
            var responseMessage = await _httpClientFactory.CreateClient().GetAsync("http://localhost:5188/api/Booking");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<BookingAdminViewModel>>(jsonData);
                return View(values);
            }
            return View();
        }
        
    }
}
