using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyHotelProject.BusinessLayer.Abstract;
using MyHotelProject.EntityLayer.Concrete;

namespace MyHotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenericController<T> : ControllerBase where T : class
    {
        private readonly IGenericService<T> _genericService;

        public GenericController(IGenericService<T> genericService)
        {
            _genericService = genericService;
        }

        [HttpGet]
        public async Task<IActionResult> ListData()
        {
            var data = await _genericService.TGetAllAsync();
            return Ok(data);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDataById(int id)
        {
            var data = await _genericService.TGetByIdAsync(id);
            return Ok(data);
        }

        [HttpPost]
        public async Task<IActionResult> AddStaff(T t)
        {
            await _genericService.TInsertAsync(t);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteData(int id)
        {
            var data = await _genericService.TGetByIdAsync(id);
            await _genericService.TDeleteAsync(data);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateData(T t)
        {
            await _genericService.TUpdateAsync(t);
            return Ok();
        }
    }
}
