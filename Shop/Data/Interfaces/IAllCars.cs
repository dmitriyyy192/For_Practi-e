using Shop.Data.Models;
using System.Collections.Generic;

namespace Shop.Data.Interfaces
{
    //функция, которая будет возвращать товар по его ID
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get; }//возвращает список
        IEnumerable<Car> getFavCars { get; }
        Car getobjectCar(int carId);
        //возвращает один обьект на основе класса Car
    }
}
