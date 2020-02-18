using Microsoft.AspNetCore.Mvc;
using Shop_1._0.Data.Interfaces;
using Shop_1._0.Data.Models;
using Shop_1._0.ViewModels;
using System.Linq;

namespace Shop_1._0.Controllers
{
    public class ShopCartController :Controller
    {
        private IAllBooks _bookRepository;
        private readonly ShopCart _shopCart;

        public ShopCartController(IAllBooks bookRepository, ShopCart shopCart)
        {
            _bookRepository = bookRepository;
            _shopCart = shopCart;
        }

        public ViewResult Index()
        {
            var item = _shopCart.GetShopItems();
            _shopCart.ListShopItems = item;

            var obj = new ShopCartViewModel
            {
                ShopCart = _shopCart
            };

            return View(obj);
        }

        public RedirectToActionResult AddToCart(int id)
        {
            var item = _bookRepository.Books.FirstOrDefault(i=>i.ID==id);
            if (item != null)
            {
                _shopCart.AddToCar(item);
            }
            return RedirectToAction("Index");
        }
    }
}
