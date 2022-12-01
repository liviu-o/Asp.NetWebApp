using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetEmpty.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories => 
            new List<Category>
            {
                new Category{CateGoryId=1, CategoryName="Fruit pies", Description="All-fruit pies"},
                new Category{CateGoryId=2, CategoryName="Chesse cakes", Description="All-fruit pies"},
                new Category{CateGoryId=3, CategoryName="Seasonal pies", Description="All-fruit pies"},
            };
    }
}