﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMyShop.DTO
{
    public class DetailOrder
    {
        public int OrderID { get; set; }
        public Phone Phone { get; set; }
        public int Quantity { get; set; }
    }
}
