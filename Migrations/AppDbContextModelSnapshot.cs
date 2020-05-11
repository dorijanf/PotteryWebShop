﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PotteryWebShop.Models;

namespace PotteryWebShop.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PotteryWebShop.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Tea cups"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Tea pots"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Plates"
                        });
                });

            modelBuilder.Entity("PotteryWebShop.Models.PotteryProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsProductOfTheWeek")
                        .HasColumnType("bit");

                    b.Property<string>("LongDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("PotteryProducts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            ImageThumbnailUrl = "~/images/products/turqouise_tea_cup_small.jpg",
                            ImageUrl = "~/images/products/turqoise_tea_cup.jpg",
                            IsProductOfTheWeek = true,
                            LongDescription = "A beautiful turqouise handmade tea cup is going to fit right into rustic homes..",
                            Name = "Turqouise Tea Cup",
                            Price = 15.95m,
                            ShortDescription = "A beautiful turqoise handmade tea cup"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            ImageThumbnailUrl = "~/images/products/turqouise_tea_pot_small.jpg",
                            ImageUrl = "~/images/products/turqouise_tea_pot.jpg",
                            IsProductOfTheWeek = true,
                            LongDescription = "A beautiful turqouise handmade tea pot is going to fit right in with the handmade tea cups also available in our store!",
                            Name = "Turqouise Tea Pot",
                            Price = 24.95m,
                            ShortDescription = "A beautiful turqoise handmade tea pot"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            ImageThumbnailUrl = "~/images/products/gray_tea_pot_small.jpg",
                            ImageUrl = "~/images/products/gray_tea_pot.jpg",
                            IsProductOfTheWeek = true,
                            LongDescription = "A beautiful gray handmade tea pot is for those who like elegance while drinking their first cup of tea in the morning.",
                            Name = "Gray Tea Pot",
                            Price = 24.95m,
                            ShortDescription = "A beautiful Gray handmade tea pot"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 3,
                            ImageThumbnailUrl = "~/images/products/ceramic_plates_small.jpg",
                            ImageUrl = "~/images/products/ceramic_plates_small.jpg",
                            IsProductOfTheWeek = true,
                            LongDescription = "A beautiful ceramic handmade plate set of 6. Bring these out when you're hosting a family or friend gathering and amaze your friends!",
                            Name = "Ceramic Plate Set Of 6",
                            Price = 15.95m,
                            ShortDescription = "Beautiful ceramic handmade plates"
                        });
                });

            modelBuilder.Entity("PotteryWebShop.Models.PotteryProduct", b =>
                {
                    b.HasOne("PotteryWebShop.Models.Category", "Category")
                        .WithMany("PotteryProducts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
