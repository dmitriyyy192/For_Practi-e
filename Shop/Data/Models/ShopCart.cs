using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Shop.Data.Models
{
    public class ShopCart
    {// необходимо для работы с базой данных
        private readonly AppDBContent appDBContent;
        public ShopCart(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public string ShopCartId { get; set; }
        public List<ShopCartItem> listShopItems { get; set; }
        public static ShopCart GetCart(IServiceProvider services)
        //проверяем добавлялся ли ранее товар
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDBContent>();
            string shopCartid = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", shopCartid);
            return new ShopCart(context)
            {
                ShopCartId = shopCartid
            };
        }
        public void AddToCart(Car car)
        //функция добавляет товары в корзину
        {
            appDBContent.ShopCartItem.Add(new ShopCartItem
            {
                ShopCartId = ShopCartId,
                car = car,
                price = car.price
            });
            appDBContent.SaveChanges();
        }
        public List<ShopCartItem> getShopItems()
        { // отображает все данные в корзине
            return appDBContent.ShopCartItem.Where(c => c.ShopCartId == ShopCartId).Include(s => s.car).ToList();
        }
    }
}