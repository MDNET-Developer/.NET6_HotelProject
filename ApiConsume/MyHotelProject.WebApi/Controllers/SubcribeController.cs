using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyHotelProject.BusinessLayer.Abstract;
using MyHotelProject.EntityLayer.Concrete;

namespace MyHotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubcribeController : GenericController<Subscribe>
    {
        public SubcribeController(IGenericService<Subscribe> genericService) : base(genericService)
        {
        }
    }
}
