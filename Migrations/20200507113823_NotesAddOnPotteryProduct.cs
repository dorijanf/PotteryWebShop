using Microsoft.EntityFrameworkCore.Migrations;

namespace PotteryWebShop.Migrations
{
    public partial class NotesAddOnPotteryProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "PotteryProducts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Notes",
                table: "PotteryProducts");
        }
    }
}
