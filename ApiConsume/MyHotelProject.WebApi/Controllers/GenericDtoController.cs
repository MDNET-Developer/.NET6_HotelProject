using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyHotelProject.BusinessLayer.Abstract;
using MyHotelProject.DtoLayer.StaffDto;

namespace MyHotelProject.WebApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="ListDto"></typeparam> 
    /// <typeparam name="UpdateDto"></typeparam>
    /// <typeparam name="AddDto"></typeparam>
    public class GenericDtoController<T,ListDto,UpdateDto,AddDto> : ControllerBase where T : class
    {
        private readonly IGenericService<T> _genericService;
        private readonly IMapper _mapper;
        public GenericDtoController(IGenericService<T> genericService, IMapper mapper)
        {
            _genericService = genericService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> ListData()
        {
            var data = await _genericService.TGetAllAsync();
            var mappingData = _mapper.Map<List<ListDto>>(data);
            return Ok(mappingData);
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
