﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHotelProject.DtoLayer.AboutDto
{
    public class AboutAddDto
    {
        public string? Title { get; set; }
        public string? Title2 { get; set; }
        public string? Content { get; set; }
        public int RoomCount { get; set; }
        public int CustomerCount { get; set; }
    }
}