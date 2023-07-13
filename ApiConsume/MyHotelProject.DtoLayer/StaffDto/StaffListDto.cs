using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHotelProject.DtoLayer.StaffDto
{
    public class StaffListDto
    {
        public int StaffID { get; set; }
        public string? FullName { get; set; }
        public string? Title { get; set; }
        public string? SocialMedia1 { get; set; }
        public string? SocialMedia2 { get; set; }
        public string? SocialMedia3 { get; set; }
    }
}
