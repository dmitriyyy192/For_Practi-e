using Shop.Data.Models;
using System.Collections.Generic;

namespace Shop.Data.Interfaces
{
    public interface ICarsCategory
    {
        //отвечает за получение всех категорий из модели Category
        //реализация в другом классе
        IEnumerable<Category> AllCategories { get; }
    }
}
