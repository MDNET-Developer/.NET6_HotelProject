using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHotelProject.DtoLayer.RoomDto
{
    public class RoomUpdateDto
    {
        [Required (ErrorMessage = "Daxil et Id-ni")]
        public int RoomId { get; set; }
        [Required(ErrorMessage = "Daxil et Otaq nömrəsini")]
        public string? RoomNumber { get; set; }
        public string? RoomCoverImage { get; set; }
        public int Star { get; set; }
        public int Price { get; set; }
        public string? Title { get; set; }
        public string? BathCount { get; set; }
        public string? Wifi { get; set; }
        public string? Description { get; set; }
    }
}
