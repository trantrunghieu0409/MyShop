using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMyShop.Models
{
    internal class DetailOrder
    {
        public Order Order { get; set; }
        public Phone Phone { get; set; }
        public int Quantity { get; set; }
    }
}
