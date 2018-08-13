using Microsoft.EntityFrameworkCore.Migrations;

namespace FatKiller.Data.Migrations
{
    public partial class UpdateProductTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductWeight",
                table: "Product");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "ProductWeight",
                table: "Product",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
