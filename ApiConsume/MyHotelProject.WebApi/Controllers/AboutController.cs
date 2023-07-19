using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyHotelProject.BusinessLayer.Abstract;
using MyHotelProject.DtoLayer.AboutDto;
using MyHotelProject.EntityLayer.Concrete;

namespace MyHotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : GenericDtoController<About, AboutListDto, AboutUpdateDto, AboutAddDto>
    {
        public AboutController(IGenericService<About> genericService, IMapper mapper) : base(genericService, mapper)
        {
        }
    }
}
