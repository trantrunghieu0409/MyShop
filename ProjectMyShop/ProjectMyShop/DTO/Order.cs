using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMyShop.DTO
{
    public class Order
    {
        public int ID { get; set; }
        public string CustomerName { get; set; }
        public DateOnly OrderDate { get; set; }
        public int Status { get; set; }
        public string Address { get; set; }
        public int OrderMethod { get; set; }
        Voucher Voucher { get; set; }
    }
}
