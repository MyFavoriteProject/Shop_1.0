using Microsoft.AspNetCore.Mvc;
using Shop_1._0.Data.Interfaces;
using Shop_1._0.Data.Models;
using Shop_1._0.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_1._0.Controllers
{
    public class BooksController:Controller
    {
        private readonly IAllBooks _allBooks;
        private readonly IBooksCategory _allCategory;
        private readonly IBookComment _allComment;

        public BooksController(IAllBooks allBooks, IBooksCategory booksCategory, IBookComment allComment)
        {
            _allBooks = allBooks;
            _allCategory = booksCategory;
            _allComment = allComment;
        }

        [Route("Books/List")]
        [Route("Books/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Book> books=null;
            string currCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                books = _allBooks.Books.OrderBy(i => i.ID);
            }
            else
            {
                if(string.Equals("science", category, StringComparison.OrdinalIgnoreCase))
                {
                    books = _allBooks.Books.Where(i => i.Category.CategoryName.Equals("Наука")).OrderBy(i=>i.ID);
                }
                else if (string.Equals("fiction", category, StringComparison.OrdinalIgnoreCase))
                {
                    books = _allBooks.Books.Where(i => i.Category.CategoryName.Equals("Художественная литература")).OrderBy(i => i.ID);
                }
                else if (string.Equals("detective", category, StringComparison.OrdinalIgnoreCase))
                {
                    books = _allBooks.Books.Where(i => i.Category.CategoryName.Equals("Детектив")).OrderBy(i => i.ID);
                }
                else if (string.Equals("fantasy", category, StringComparison.OrdinalIgnoreCase))
                {
                    books = _allBooks.Books.Where(i => i.Category.CategoryName.Equals("Фантастика")).OrderBy(i => i.ID);
                }
                else if (string.Equals("programming", category, StringComparison.OrdinalIgnoreCase))
                {
                    books = _allBooks.Books.Where(i => i.Category.CategoryName.Equals("Программирование")).OrderBy(i => i.ID);
                }
            }

            currCategory = _category;

            var bookObj = new BooksListViewModel
            {
                AllBooks = books,
                CurrCategory = currCategory
            };

            ViewBag.Title = "Страница с книгами";

            return View(bookObj);
        }

        public ViewResult Comment(Book book)
        {
            IEnumerable<Comment> comments = null;
            Book _book = book;

            comments = _allComment.Comments.Where(i => i.Book.ID == i.ID).OrderBy(i => i.ID);

            var commObj = new CommentListViewModel
            {
                Comments = comments,
                Book = _book
            };

            return View(commObj);
        }
    }
}
