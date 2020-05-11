using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PotteryWebShop.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category {CategoryId = 1, CategoryName = "Tea cups", Description = "Handmade tea cups" },
                new Category {CategoryId = 2, CategoryName = "Tea pots", Description = "Handmade tea pots" },
                new Category {CategoryId = 3, CategoryName = "Plates", Description = "Handmade plates" },
            };
    }
}
