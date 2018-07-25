using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FatKiller.Data.Migrations
{
    public partial class ProductDailyFoodDiaryRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ProductId",
                table: "DailyFoodDiary",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_DailyFoodDiary_ProductId",
                table: "DailyFoodDiary",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_DailyFoodDiary_Product_ProductId",
                table: "DailyFoodDiary",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DailyFoodDiary_Product_ProductId",
                table: "DailyFoodDiary");

            migrationBuilder.DropIndex(
                name: "IX_DailyFoodDiary_ProductId",
                table: "DailyFoodDiary");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "DailyFoodDiary");
        }
    }
}
