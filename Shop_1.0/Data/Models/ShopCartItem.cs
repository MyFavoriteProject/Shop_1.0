using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_1._0.Data.Models
{
    public class ShopCartItem
    {
        public int ID { get; set; }
        public Book Book { get; set; }
        public int Price { get; set; }

        public string ShopCartID { get; set; }

    }
}
