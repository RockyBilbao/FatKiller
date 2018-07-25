using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FatKiller.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DailyFoodDiaryData",
                columns: table => new
                {
                    CreateUserId = table.Column<Guid>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    ModifyUserId = table.Column<Guid>(nullable: true),
                    ModifyDate = table.Column<DateTime>(nullable: true),
                    DailyFoodDiaryDataId = table.Column<Guid>(nullable: false),
                    Day = table.Column<DateTime>(nullable: false),
                    CarboSum = table.Column<double>(nullable: false),
                    ProteinSum = table.Column<double>(nullable: false),
                    FatSum = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyFoodDiaryData", x => x.DailyFoodDiaryDataId);
                });

            migrationBuilder.CreateTable(
                name: "Macronutrients",
                columns: table => new
                {
                    CreateUserId = table.Column<Guid>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    ModifyUserId = table.Column<Guid>(nullable: true),
                    ModifyDate = table.Column<DateTime>(nullable: true),
                    MacronutrientsId = table.Column<Guid>(nullable: false),
                    Carbohydrates = table.Column<double>(nullable: false),
                    Protein = table.Column<double>(nullable: false),
                    Fat = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Macronutrients", x => x.MacronutrientsId);
                });

            migrationBuilder.CreateTable(
                name: "UserData",
                columns: table => new
                {
                    CreateUserId = table.Column<Guid>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    ModifyUserId = table.Column<Guid>(nullable: true),
                    ModifyDate = table.Column<DateTime>(nullable: true),
                    UserdDataId = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserData", x => x.UserdDataId);
                });

            migrationBuilder.CreateTable(
                name: "DailyFoodDiary",
                columns: table => new
                {
                    CreateUserId = table.Column<Guid>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    ModifyUserId = table.Column<Guid>(nullable: true),
                    ModifyDate = table.Column<DateTime>(nullable: true),
                    DailyFoodDiaryId = table.Column<Guid>(nullable: false),
                    OwnerUserId = table.Column<Guid>(nullable: false),
                    DailyFoodDiaryDataId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyFoodDiary", x => x.DailyFoodDiaryId);
                    table.ForeignKey(
                        name: "FK_DailyFoodDiary_DailyFoodDiaryData_DailyFoodDiaryDataId",
                        column: x => x.DailyFoodDiaryDataId,
                        principalTable: "DailyFoodDiaryData",
                        principalColumn: "DailyFoodDiaryDataId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    CreateUserId = table.Column<Guid>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    ModifyUserId = table.Column<Guid>(nullable: true),
                    ModifyDate = table.Column<DateTime>(nullable: true),
                    ProductId = table.Column<Guid>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    ProductCategory = table.Column<int>(nullable: false),
                    ProductWeight = table.Column<double>(nullable: false),
                    ProductPrice = table.Column<double>(nullable: false),
                    MacronutrientsId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Product_Macronutrients_MacronutrientsId",
                        column: x => x.MacronutrientsId,
                        principalTable: "Macronutrients",
                        principalColumn: "MacronutrientsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    CreateUserId = table.Column<Guid>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    ModifyUserId = table.Column<Guid>(nullable: true),
                    ModifyDate = table.Column<DateTime>(nullable: true),
                    UserId = table.Column<Guid>(nullable: false),
                    UserName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    UserDataId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_User_UserData_UserDataId",
                        column: x => x.UserDataId,
                        principalTable: "UserData",
                        principalColumn: "UserdDataId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DailyFoodDiary_DailyFoodDiaryDataId",
                table: "DailyFoodDiary",
                column: "DailyFoodDiaryDataId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_MacronutrientsId",
                table: "Product",
                column: "MacronutrientsId");

            migrationBuilder.CreateIndex(
                name: "IX_User_UserDataId",
                table: "User",
                column: "UserDataId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DailyFoodDiary");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "DailyFoodDiaryData");

            migrationBuilder.DropTable(
                name: "Macronutrients");

            migrationBuilder.DropTable(
                name: "UserData");
        }
    }
}
