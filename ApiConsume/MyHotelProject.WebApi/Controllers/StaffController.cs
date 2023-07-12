using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyHotelProject.BusinessLayer.Abstract;
using MyHotelProject.EntityLayer.Concrete;

namespace MyHotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly IStaffService _staffService;

        public StaffController(IStaffService staffService)
        {
            _staffService = staffService;
        }

        [HttpGet]
        public async Task<IActionResult> StaffList()
        {
            var data = await _staffService.TGetAllAsync();
            return Ok(data);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetStaffById(int id)
        {
            var data = await _staffService.TGetByIdAsync(id);
            return Ok(data);
        }

        [HttpPost]
        public async Task<IActionResult> AddStaff(Staff staff)
        {
            await _staffService.TInsertAsync(staff);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStaff(int id)
        {
            var data = await _staffService.TGetByIdAsync(id);
            await _staffService.TDeleteAsync(data);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateStaff(Staff staff)
        {
            await _staffService.TUpdateAsync(staff);
            return Ok();
        }
    }
}
