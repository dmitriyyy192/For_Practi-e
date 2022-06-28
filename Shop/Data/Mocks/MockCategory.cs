using Shop.Data.Interfaces;
using Shop.Data.Models;
using System.Collections.Generic;

namespace Shop.Data.Mocks
{
    public class MockCategory : ICarsCategory
    {
        //реализует интерфейс ICarsCategory
        public IEnumerable<Category> AllCategories
        // если подчеркивает AllCategories, нужно на него навести и выбрать реализовать интерфейс. Затем его меняем.
        {
            get
            {//создание проектов в коде а не в базе
                return new List<Category>
                {//создаем два объекта
                    new Category {categoryName="Электромобили", desc="Современный вид транспорта"},
                    new Category {categoryName="Классические автомобили", desc="Машины с двигателем внутреннего сгорания"}
                };
            }
        }
    }
}
