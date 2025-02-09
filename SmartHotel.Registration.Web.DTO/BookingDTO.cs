﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHotel.Registration.Web.DTO
{
    class BookingDTO
    {
        public int Id { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Passport { get; set; }
        public string Address { get; set; }
        public int Amount { get; set; }
        public int Total { get; set; }
    }
}
