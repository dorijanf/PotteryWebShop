using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PotteryWebShop.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    { 
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<PotteryProduct> PotteryProducts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Tea cups" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Tea pots" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Plates" });

            // seed products
            modelBuilder.Entity<PotteryProduct>().HasData(new PotteryProduct
            {
                Id = 1,
                Name = "Turqouise Tea Cup",
                Price = 15.95M,
                ShortDescription = "A beautiful turqoise handmade tea cup",
                LongDescription = "A beautiful turqouise handmade tea cup is going to fit right into rustic homes..",
                ImageUrl = "~/images/products/turqoise_tea_cup.jpg",
                ImageThumbnailUrl = "~/images/products/turqouise_tea_cup_small.jpg",
                IsProductOfTheWeek = true,
                CategoryId = 1
            });

            modelBuilder.Entity<PotteryProduct>().HasData(new PotteryProduct
            {
                Id = 2,
                Name = "Turqouise Tea Pot",
                Price = 24.95M,
                ShortDescription = "A beautiful turqoise handmade tea pot",
                LongDescription = "A beautiful turqouise handmade tea pot is going to fit right in with the handmade tea cups also available in our store!",
                ImageUrl = "~/images/products/turqouise_tea_pot.jpg",
                ImageThumbnailUrl = "~/images/products/turqouise_tea_pot_small.jpg",
                IsProductOfTheWeek = true,
                CategoryId = 2
            });

            modelBuilder.Entity<PotteryProduct>().HasData(new PotteryProduct
            {
                Id = 3,
                Name = "Gray Tea Pot",
                Price = 24.95M,
                ShortDescription = "A beautiful Gray handmade tea pot",
                LongDescription = "A beautiful gray handmade tea pot is for those who like elegance while drinking their first cup of tea in the morning.",
                ImageUrl = "~/images/products/gray_tea_pot.jpg",
                ImageThumbnailUrl = "~/images/products/gray_tea_pot_small.jpg",
                IsProductOfTheWeek = true,
                CategoryId = 2
            });

            modelBuilder.Entity<PotteryProduct>().HasData(new PotteryProduct
            {
                Id = 4,
                Name = "Ceramic Plate Set Of 6",
                Price = 15.95M,
                ShortDescription = "Beautiful ceramic handmade plates",
                LongDescription = "A beautiful ceramic handmade plate set of 6. Bring these out when you're hosting a family or friend gathering and amaze your friends!",
                ImageUrl = "~/images/products/ceramic_plates_small.jpg",
                ImageThumbnailUrl = "~/images/products/ceramic_plates_small.jpg",
                IsProductOfTheWeek = true,
                CategoryId = 3
            });
        }
    }
}
