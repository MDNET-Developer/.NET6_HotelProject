﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHotelProject.EntityLayer.Concrete
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string? Name { get; set; }
        public string? Mail { get; set; }
        public string? Message { get; set; }
       
        public DateTime Date { get; set; } = DateTime.Now;
        public int MessageCategoryID { get; set; }
        public MessageCategory MessageCategory { get; set; }
    }
}