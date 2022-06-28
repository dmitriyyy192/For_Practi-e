using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class DBobjects
    {//все функции будут статические, что бы к ним можно было обращаться просто по имени функции из 
        // других классов
        public static void Initial(AppDBContent content)
        {

            //AppDBContent content;

            //using (var scope = app.ApplicationServices.CreateScope())
            //{

            //    content = scope.ServiceProvider.GetRequiredService<AppDBContent>();
            //}
            // подключились к базе данных(ниже)
            //    AppDBContent content = app.ApplicationServices.GetRequiredService<AppDBContent>();
            //если нет объектов, будем их добавлять
            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));
            //добавляем все необходимые объекты товаров
            if (!content.Car.Any())
            {
                content.AddRange(
                     new Car
                     {
                         name = "Tesla Model S",
                         shortDesc = "Быстрый автомобиль",
                         longDesc = "Красивый, быстрый и очень тихий автомобиль компании Tesla",
                         img = "/img/Tesla.jpg",
                         price = 45000,
                         isFavourite = true,
                         available = true,
                         Category = Categories["Электромобили"]
                     },
                    new Car
                    {
                        name = "Ford Fiesta",
                        shortDesc = "Тихий и спокойный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "/img/Ford.jpg",
                        price = 11000,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car
                    {
                        name = "BMW MЗ",
                        shortDesc = "Дерзкий и стильный",
                        longDesc = "Красивый, быстрый и очень тихий автомобиль компании Tesla",
                        img = "/img/BMW.jpg",
                        price = 65000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Электромобили"]
                    },
                    new Car
                    {
                        name = "Mercedes c class",
                        shortDesc = "Уютный и большой",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "/img/Mercedes.jpg",
                        price = 40000,
                        isFavourite = false,
                        available = false,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car
                    {
                        name = "Nissan Leaf",
                        shortDesc = "Бесшумный и экономный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "/img/Nissan.jpg",
                        price = 14000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Электромобили"]
                    }
                    );

            }
            content.SaveChanges();
        }

        //переменная
        private static Dictionary<string, Category> category;
        //ключи с типом данных , второй параметр тип данных для значений переменных
        public static Dictionary<string, Category> Categories
        // метод
        {
            get
            {
                if (category == null)
                //внутри переменной ничего не записано
                {
                    var list = new Category[]
                    {
                        new Category { categoryName = "Электромобили", desc = "Современный вид транспорта" },
                        new Category { categoryName = "Классические автомобили", desc = "Машины с двигателем внутреннего сгорания" }
                    };
                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.categoryName, el);
                    //создаем переменную el(за каждую иттерацию добавляем элемент)
                }
                return category;
            }
        }
    }
}
