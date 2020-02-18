using Microsoft.AspNetCore.Mvc;
using Shop_1._0.Data.Interfaces;
using Shop_1._0.ViewModels;

namespace Shop_1._0.Controllers
{
    public class HomeController :Controller
    {
        private IAllBooks _bookRepository;

        public HomeController(IAllBooks bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public ViewResult Index()
        {
            var homeBooks = new HomeViewModel
            {
                FavBooks = _bookRepository.GetFavBooks
            };
            return View(homeBooks);
        }
    }
}
