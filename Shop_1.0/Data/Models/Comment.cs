using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_1._0.Data.Models
{
    public class Comment
    {
        public int ID { get; set; }
        public string TextComment { get; set; }
        public User User { get; set; }
        public Book Book { get; set; }
    }
}
