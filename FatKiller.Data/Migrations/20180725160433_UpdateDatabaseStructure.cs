using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FatKiller.Data.Migrations
{
    public partial class UpdateDatabaseStructure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CarboSum",
                table: "DailyFoodDiaryData");

            migrationBuilder.DropColumn(
                name: "FatSum",
                table: "DailyFoodDiaryData");

            migrationBuilder.DropColumn(
                name: "ProteinSum",
                table: "DailyFoodDiaryData");

            migrationBuilder.DropColumn(
                name: "OwnerUserId",
                table: "DailyFoodDiary");

            migrationBuilder.AddColumn<Guid>(
                name: "DailyFoodDiaryId",
                table: "User",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_User_DailyFoodDiaryId",
                table: "User",
                column: "DailyFoodDiaryId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_DailyFoodDiary_DailyFoodDiaryId",
                table: "User",
                column: "DailyFoodDiaryId",
                principalTable: "DailyFoodDiary",
                principalColumn: "DailyFoodDiaryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_DailyFoodDiary_DailyFoodDiaryId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_DailyFoodDiaryId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "DailyFoodDiaryId",
                table: "User");

            migrationBuilder.AddColumn<double>(
                name: "CarboSum",
                table: "DailyFoodDiaryData",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "FatSum",
                table: "DailyFoodDiaryData",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ProteinSum",
                table: "DailyFoodDiaryData",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<Guid>(
                name: "OwnerUserId",
                table: "DailyFoodDiary",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
