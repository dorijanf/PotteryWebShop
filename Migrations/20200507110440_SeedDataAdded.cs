using Microsoft.EntityFrameworkCore.Migrations;

namespace PotteryWebShop.Migrations
{
    public partial class SeedDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 1, "Tea cups", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 2, "Tea pots", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 3, "Plates", null });

            migrationBuilder.InsertData(
                table: "PotteryProducts",
                columns: new[] { "Id", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "IsProductOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 1, 1, "~/images/products/turqouise_tea_cup_small.jpg", "~/images/products/turqoise_tea_cup.jpg", true, "A beautiful turqouise handmade tea cup is going to fit right into rustic homes..", "Turqouise Tea Cup", 15.95m, "A beautiful turqoise handmade tea cup" },
                    { 2, 2, "~/images/products/turqouise_tea_pot_small.jpg", "~/images/products/turqouise_tea_pot.jpg", true, "A beautiful turqouise handmade tea pot is going to fit right in with the handmade tea cups also available in our store!", "Turqouise Tea Pot", 24.95m, "A beautiful turqoise handmade tea pot" },
                    { 3, 2, "~/images/products/gray_tea_pot_small.jpg", "~/images/products/gray_tea_pot.jpg", true, "A beautiful gray handmade tea pot is for those who like elegance while drinking their first cup of tea in the morning.", "Gray Tea Pot", 24.95m, "A beautiful Gray handmade tea pot" },
                    { 4, 3, "~/images/products/ceramic_plates_small.jpg", "~/images/products/ceramic_plates_small.jpg", true, "A beautiful ceramic handmade plate set of 6. Bring these out when you're hosting a family or friend gathering and amaze your friends!", "Ceramic Plate Set Of 6", 15.95m, "Beautiful ceramic handmade plates" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PotteryProducts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PotteryProducts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PotteryProducts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PotteryProducts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);
        }
    }
}
