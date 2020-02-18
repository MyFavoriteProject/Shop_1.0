using Shop_1._0.Data.Interfaces;
using Shop_1._0.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_1._0.Data.Repository
{
    public class OrdersRepository : IAllOrders
    {
        private readonly AppDBContent _appDBContent;
        private readonly ShopCart _shopCart;

        public OrdersRepository(AppDBContent appDBContent, ShopCart shopCart)
        {
            _appDBContent = appDBContent;
            _shopCart = shopCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderTime = DateTime.Now;
            _appDBContent.Order.Add(order);

            _appDBContent.SaveChanges();

            var items = _shopCart.ListShopItems;

            foreach(var el in items)
            {
                var orderDetail = new OrderDetail()
                {
                    BookID = el.Book.ID,
                    OrderID = order.ID,
                    Price = el.Book.Price
                };
                _appDBContent.OrderDetail.Add(orderDetail);
            }
            
            _appDBContent.SaveChanges();
        }
    }
}
