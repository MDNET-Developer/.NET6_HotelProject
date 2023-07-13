using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyHotelProject.BusinessLayer.Abstract;
using MyHotelProject.DtoLayer.StaffDto;
using MyHotelProject.EntityLayer.Concrete;

namespace MyHotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Staff2Controller : GenericDtoController<Staff, StaffListDto, StaffUpdateDto, StaffAddDto>
    {
        public Staff2Controller(IGenericService<Staff> genericService, IMapper mapper) : base(genericService, mapper)
        {
        }
    }
}
