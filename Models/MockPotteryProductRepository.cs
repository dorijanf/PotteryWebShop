using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PotteryWebShop.Models
{
    public class MockPotteryProductRepository : IPotteryProductRepository
    {
        private readonly ICategoryRepository _categories = new MockCategoryRepository();
        public IEnumerable<PotteryProduct> AllPotteryProducts =>
            new List<PotteryProduct>
            {
                new PotteryProduct
                {
                    Id = 1,
                    Name = "Turqouise Tea Cup",
                    Price = 15.95M,
                    ShortDescription = "A beautiful turqoise handmade tea cup",
                    LongDescription = "A beautiful turqouise handmade tea cup is going to fit right into rustic homes..",
                    ImageUrl = "~/images/products/turqoise_tea_cup.jpg",
                    ImageThumbnailUrl = "~/images/products/turqouise_tea_cup_small.jpg",
                    IsProductOfTheWeek = true,
                    Category = _categories.AllCategories.ToList()[0]
                },

                new PotteryProduct
                {
                    Id = 2,
                    Name = "Turqouise Tea Pot",
                    Price = 24.95M,
                    ShortDescription = "A beautiful turqoise handmade tea pot",
                    LongDescription = "A beautiful turqouise handmade tea pot is going to fit right in with the handmade tea cups also available in our store!",
                    ImageUrl = "~/images/products/turqouise_tea_pot.jpg",
                    ImageThumbnailUrl = "~/images/products/turqouise_tea_pot_small.jpg",
                    IsProductOfTheWeek = true,
                    Category = _categories.AllCategories.ToList()[1]
                },

                new PotteryProduct
                {
                    Id = 3,
                    Name = "Gray Tea Pot",
                    Price = 24.95M,
                    ShortDescription = "A beautiful Gray handmade tea pot",
                    LongDescription = "A beautiful gray handmade tea pot is for those who like elegance while drinking their first cup of tea in the morning.",
                    ImageUrl = "~/images/products/gray_tea_pot.jpg",
                    ImageThumbnailUrl = "~/images/products/gray_tea_pot_small.jpg",
                    IsProductOfTheWeek = true,
                    Category = _categories.AllCategories.ToList()[1]
                },

                new PotteryProduct
                {
                    Id = 4,
                    Name = "Ceramic Plate Set Of 6",
                    Price = 15.95M,
                    ShortDescription = "Beautiful ceramic handmade plates",
                    LongDescription = "A beautiful ceramic handmade plate set of 6. Bring these out when you're hosting a family or friend gathering and amaze your friends!",
                    ImageUrl = "~/images/products/ceramic_plates_small.jpg",
                    ImageThumbnailUrl = "~/images/products/ceramic_plates_small.jpg",
                    IsProductOfTheWeek = true,
                    Category = _categories.AllCategories.ToList()[2]
                }
            };

        public IEnumerable<PotteryProduct> PotteryProductsOfTheWeek { get; }

        public PotteryProduct GetPotteryProductById(int potteryProductId)
        {
            return AllPotteryProducts.FirstOrDefault(p => p.Id == potteryProductId);
        }
    }
}
