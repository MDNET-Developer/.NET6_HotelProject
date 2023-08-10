using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyHotelProject.BusinessLayer.Abstract;
using MyHotelProject.EntityLayer.Concrete;

namespace MyHotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : GenericController<Contact>
    {
        private readonly IContactService _contactService;
        public ContactController(IGenericService<Contact> genericService, IContactService contactService) : base(genericService)
        {
            _contactService = contactService;
        }

        [HttpGet("[Action]")]
        public async Task<IActionResult> GetContactWithCategory(Contact contact)
        {
            await _contactService.GetContactWithCategory(contact);
            return Ok();
        }
    }
}
