using Shop_1._0.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_1._0.ViewModels
{
    public class BooksListViewModel
    {
        public IEnumerable<Book> AllBooks { get; set; }
        public string CurrCategory { get; set; }
    }
}
