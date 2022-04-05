using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMyShop.DTO
{
    public class Category
    {
        public int ID { get; set; }
        public string CatName { get; set; }
        public BindingList<Phone>? Phones { get; set; }
    }
}
