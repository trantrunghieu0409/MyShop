using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMyShop.Models
{
    internal class Phone
    {
        public int ID { get; set; }
        public string PhoneName { get; set; }
        public string Manufacturer { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }
        public double BoughtPrice { get; set; }
        public double SoldPrice { get; set; }
        public Category Category { get; set; }
        public DateOnly UploadDate { get; set; }
        public string Avatar { get; set; }

    }
}
