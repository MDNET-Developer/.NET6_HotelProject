using Microsoft.AspNetCore.Mvc;
using MyHotelProject.WebUI.Models;
using Newtonsoft.Json;

namespace MyHotelProject.WebUI.ViewComponents.Default
{

    public class _RoomPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _RoomPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var responseMessage = await _httpClientFactory.CreateClient().GetAsync("http://localhost:5188/api/Room");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<RoomListViewModel>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
