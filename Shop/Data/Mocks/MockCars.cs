using Shop.Data.Interfaces;
using Shop.Data.Mocks;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

public class MockCars : IAllCars
{
    private readonly ICarsCategory _categoryCars = new MockCategory();
    public IEnumerable<Car> Cars
    {
        get
        {//создание проектов в коде а не в базе
            return new List<Car>
                {//создаем  объект
                    new Car
                    {
                        name="Tesla Model S",
                        shortDesc="Быстрый автомобиль",
                        longDesc="Красивый, быстрый и очень тихий автомобиль компании Tesla",
                        img="/img/Tesla.jpg",
                        price=45000,
                        isFavourite=true,
                        available=true,
                        Category=_categoryCars.AllCategories.First()
                    },
                    new Car
                    {
                        name="Ford Fiesta",
                        shortDesc="Тихий и спокойный",
                        longDesc="Удобный автомобиль для городской жизни",
                        img="/img/Ford.jpg",
                        price=11000,
                        isFavourite=false,
                        available=true,
                        Category=_categoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        name="BMW MЗ",
                        shortDesc="Дерзкий и стильный",
                        longDesc="Красивый, быстрый и очень тихий автомобиль компании Tesla",
                        img="/img/BMW.jpg",
                        price=65000,
                        isFavourite=true,
                        available=true,
                        Category=_categoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        name="Mercedes c class",
                        shortDesc="Уютный и большой",
                        longDesc="Удобный автомобиль для городской жизни",
                        img="/img/Mercedes.jpg",
                        price=40000,
                        isFavourite=false,
                        available=false,
                        Category=_categoryCars.AllCategories.First()
                    },
                    new Car
                    {
                        name="Nissan Leaf",
                        shortDesc="Бесшумный и экономный",
                        longDesc="Удобный автомобиль для городской жизни",
                        img="/img/Nissan.jpg",
                        price=14000,
                        isFavourite=true,
                        available=true,
                        Category=_categoryCars.AllCategories.First()
                    }
                    };
        }
    }
    public IEnumerable<Car> getFavCars { get; set; }

    public Car getobjectCar(int carId)
    {
        throw new NotImplementedException();
    }
}
