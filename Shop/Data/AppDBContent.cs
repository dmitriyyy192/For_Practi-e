using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Shop.Data.Models;

namespace Shop.Data
{//класс для работы с базами данных
    public class AppDBContent : DbContext
    {
        //конструктор по умолчанию вызывает базовый конструктор
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {
        }
        //первая функция получает все товары в магазине, вторая все категории
        public DbSet<Car> Car { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<ShopCartItem> ShopCartItem { get; set; }
    }

}
