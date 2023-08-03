using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query;
using MyHotelProject.BusinessLayer.Abstract;
using MyHotelProject.DtoLayer.BookingDto;
using MyHotelProject.EntityLayer.Concrete;

namespace MyHotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : GenericDtoController<Booking, BookingListDto, BookingUpdateDto, BookingAddDto>
    {
        private readonly IBookingService _bookingService;
        public BookingController(IGenericService<Booking> genericService, IMapper mapper, IBookingService bookingService) : base(genericService, mapper)
        {
            _bookingService = bookingService;
        }

        [HttpGet("AcceptBooking/{id}")]
        public async Task<IActionResult> AcceptBooking(int id)
        {
           await _bookingService.AcceptBookingAsync(id);
            return Ok();
        }
       
    }
}
