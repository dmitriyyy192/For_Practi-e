using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.ViewModels;

namespace Shop.Controllers
{
    public class CarsController : Controller
    //класс унаследует все от класса Controller
    //при подчеркивании нужно выбрать using Microsoft.AspNetCor.Mvc;
    {
        // это результат который идет в виде html странички
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;
        //конструктор
        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCat)
        {
            _allCars = iAllCars;
            _allCategories = iCarsCat;

        }

        public ViewResult List()
        {
            ViewBag.Title = "Страница с автомобилями";
            CarsListViewModel obj = new CarsListViewModel();
            obj.allCars = _allCars.Cars;
            obj.currCategory = "Автомобили";
            return View(obj);


        }
    }
}
