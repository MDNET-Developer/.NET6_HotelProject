﻿using Microsoft.AspNetCore.Mvc;
using MyHotelProject.WebUI.Models;
using MyHotelProject.WebUI.Models.About;
using Newtonsoft.Json;

namespace MyHotelProject.WebUI.ViewComponents.Default
{
    public class _AboutPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _AboutPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var responseMessage = await _httpClientFactory.CreateClient().GetAsync("http://localhost:5188/api/About");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<AboutViewModel>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
