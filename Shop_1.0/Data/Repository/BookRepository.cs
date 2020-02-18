using Microsoft.EntityFrameworkCore;
using Shop_1._0.Data.Interfaces;
using Shop_1._0.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_1._0.Data.Repository
{
    public class BookRepository : IAllBooks
    {
        private readonly AppDBContent _appDBContent;

        public BookRepository(AppDBContent appDBContent)
        {
            _appDBContent = appDBContent;
        }

        public IEnumerable<Book> Books => _appDBContent.Book.Include(c=>c.Category);

        public IEnumerable<Book> GetFavBooks => _appDBContent.Book.Where(p => p.IsFavorite).Include(c=>c.Category);

        public Book GetObjctBook(int bookID) => _appDBContent.Book.FirstOrDefault(p => p.ID == bookID);
    }
}
