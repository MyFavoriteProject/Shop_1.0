using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_1._0.Data.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string BookAuthor { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string Img { get; set; }
        public ushort Price { get; set; }
        public bool IsFavorite { get; set; }
        public bool Available { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
        public virtual List<Comment> Comments { get; set; }
    }
}
