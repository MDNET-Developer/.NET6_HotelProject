using Microsoft.AspNetCore.Mvc;
using MyHotelProject.WebUI.Models;
using Newtonsoft.Json;
using System.Net.Http;

namespace MyHotelProject.WebUI.ViewComponents.Default
{
    public class _AboutStaffCountPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _AboutStaffCountPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var responseMessage = await _httpClientFactory.CreateClient().GetAsync("http://localhost:5188/api/Staff/dataCount");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<GetStaffCountViewModel>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
