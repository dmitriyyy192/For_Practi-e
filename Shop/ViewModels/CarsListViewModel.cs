using Shop.Data.Models;
using System.Collections.Generic;

namespace Shop.ViewModels
{
    public class CarsListViewModel
    {
        public IEnumerable<Car> allCars { get; set; }//получает все товары
        public string currCategory { get; set; }//переменная, в нее помещаем категорию с которой сейчас работаем

    }
}
