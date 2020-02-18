using Shop_1._0.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_1._0.ViewModels
{
    public class CommentListViewModel
    {
        public IEnumerable<Comment> Comments { get; set; }
        public Book Book { get; set; }
    }
}
