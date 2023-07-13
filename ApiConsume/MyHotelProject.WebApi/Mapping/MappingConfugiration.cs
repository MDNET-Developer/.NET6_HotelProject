using AutoMapper;
using MyHotelProject.DtoLayer.StaffDto;
using MyHotelProject.EntityLayer.Concrete;

namespace MyHotelProject.WebApi.Mapping
{
    public class MappingConfugiration:Profile
    {
        public MappingConfugiration()
        {
            CreateMap<StaffListDto, Staff>().ReverseMap();
            CreateMap<StaffUpdateDto, Staff>().ReverseMap();
            CreateMap<StaffAddDto, Staff>().ReverseMap();
           
        }
    }
}
