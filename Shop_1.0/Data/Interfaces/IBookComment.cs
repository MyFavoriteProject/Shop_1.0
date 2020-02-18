using Shop_1._0.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_1._0.Data.Interfaces
{
    public interface IBookComment
    {
        IEnumerable<Comment> Comments { get; }
    }
}
