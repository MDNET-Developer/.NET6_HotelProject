using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyHotelProject.BusinessLayer.Abstract;
using MyHotelProject.EntityLayer.Concrete;

namespace MyHotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceService _ServiceService;

        public ServiceController(IServiceService ServiceService)
        {
            _ServiceService = ServiceService;
        }

        [HttpGet]
        public async Task<IActionResult> ServiceList()
        {
            var data = await _ServiceService.TGetAllAsync();
            return Ok(data);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetServiceById(int id)
        {
            var data = await _ServiceService.TGetByIdAsync(id);
            return Ok(data);
        }

        [HttpPost]
        public async Task<IActionResult> AddService(Service Service)
        {
            await _ServiceService.TInsertAsync(Service);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteService(int id)
        {
            var data = await _ServiceService.TGetByIdAsync(id);
            await _ServiceService.TDeleteAsync(data);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateService(Service Service)
        {
            await _ServiceService.TUpdateAsync(Service);
            return Ok();
        }
    }
}
