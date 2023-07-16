using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyHotelProject.BusinessLayer.Abstract;
using MyHotelProject.DtoLayer.RoomDto;
using MyHotelProject.EntityLayer.Concrete;

namespace MyHotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : GenericDtoController<Room, RoomListDto, RoomUpdateDto, RoomAddDto>
    {
        public RoomController(IGenericService<Room> genericService, IMapper mapper) : base(genericService, mapper)
        {
        }
    }
}

