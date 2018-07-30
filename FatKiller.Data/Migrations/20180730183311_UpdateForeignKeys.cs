using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FatKiller.Data.Migrations
{
    public partial class UpdateForeignKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DailyFoodDiary_DailyFoodDiaryData_DailyFoodDiaryDataId",
                table: "DailyFoodDiary");

            migrationBuilder.DropForeignKey(
                name: "FK_DailyFoodDiary_Product_ProductId",
                table: "DailyFoodDiary");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Macronutrients_MacronutrientsId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_User_DailyFoodDiary_DailyFoodDiaryId",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_UserData_UserDataId",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_UserType_UserTypeId",
                table: "User");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserTypeId",
                table: "User",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "User",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<Guid>(
                name: "UserDataId",
                table: "User",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "User",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<Guid>(
                name: "DailyFoodDiaryId",
                table: "User",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<Guid>(
                name: "MacronutrientsId",
                table: "Product",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<Guid>(
                name: "ProductId",
                table: "DailyFoodDiary",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<Guid>(
                name: "DailyFoodDiaryDataId",
                table: "DailyFoodDiary",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddForeignKey(
                name: "FK_DailyFoodDiary_DailyFoodDiaryData_DailyFoodDiaryDataId",
                table: "DailyFoodDiary",
                column: "DailyFoodDiaryDataId",
                principalTable: "DailyFoodDiaryData",
                principalColumn: "DailyFoodDiaryDataId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DailyFoodDiary_Product_ProductId",
                table: "DailyFoodDiary",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Macronutrients_MacronutrientsId",
                table: "Product",
                column: "MacronutrientsId",
                principalTable: "Macronutrients",
                principalColumn: "MacronutrientsId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_DailyFoodDiary_DailyFoodDiaryId",
                table: "User",
                column: "DailyFoodDiaryId",
                principalTable: "DailyFoodDiary",
                principalColumn: "DailyFoodDiaryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_UserData_UserDataId",
                table: "User",
                column: "UserDataId",
                principalTable: "UserData",
                principalColumn: "UserdDataId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_UserType_UserTypeId",
                table: "User",
                column: "UserTypeId",
                principalTable: "UserType",
                principalColumn: "UserTypeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DailyFoodDiary_DailyFoodDiaryData_DailyFoodDiaryDataId",
                table: "DailyFoodDiary");

            migrationBuilder.DropForeignKey(
                name: "FK_DailyFoodDiary_Product_ProductId",
                table: "DailyFoodDiary");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Macronutrients_MacronutrientsId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_User_DailyFoodDiary_DailyFoodDiaryId",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_UserData_UserDataId",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_UserType_UserTypeId",
                table: "User");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserTypeId",
                table: "User",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "User",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UserDataId",
                table: "User",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "User",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "DailyFoodDiaryId",
                table: "User",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "MacronutrientsId",
                table: "Product",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ProductId",
                table: "DailyFoodDiary",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "DailyFoodDiaryDataId",
                table: "DailyFoodDiary",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DailyFoodDiary_DailyFoodDiaryData_DailyFoodDiaryDataId",
                table: "DailyFoodDiary",
                column: "DailyFoodDiaryDataId",
                principalTable: "DailyFoodDiaryData",
                principalColumn: "DailyFoodDiaryDataId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DailyFoodDiary_Product_ProductId",
                table: "DailyFoodDiary",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Macronutrients_MacronutrientsId",
                table: "Product",
                column: "MacronutrientsId",
                principalTable: "Macronutrients",
                principalColumn: "MacronutrientsId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_DailyFoodDiary_DailyFoodDiaryId",
                table: "User",
                column: "DailyFoodDiaryId",
                principalTable: "DailyFoodDiary",
                principalColumn: "DailyFoodDiaryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_UserData_UserDataId",
                table: "User",
                column: "UserDataId",
                principalTable: "UserData",
                principalColumn: "UserdDataId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_UserType_UserTypeId",
                table: "User",
                column: "UserTypeId",
                principalTable: "UserType",
                principalColumn: "UserTypeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
