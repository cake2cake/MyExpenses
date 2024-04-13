using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyExpenses.Migrations
{
    /// <inheritdoc />
    public partial class seedcategorydata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SubCatName",
                table: "SubCats",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ItemDetails",
                table: "Expenses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Item",
                table: "Expenses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Currency",
                table: "Expenses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CatName",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CatId", "CatName", "CatOrder" },
                values: new object[,]
                {
                    { 10, "Food", 1000 },
                    { 20, "Transport", 2000 },
                    { 30, "Home", 3000 },
                    { 40, "Utilities", 4000 },
                    { 50, "Clothing", 5000 },
                    { 60, "Leisure", 6000 },
                    { 70, "Studies", 7000 },
                    { 80, "Vacation", 8000 },
                    { 90, "Medical", 9000 },
                    { 100, "Occasions", 10000 },
                    { 110, "Loan", 11000 },
                    { 120, "Parents", 12000 },
                    { 130, "Pet", 13000 },
                    { 140, "Wife", 14000 },
                    { 150, "Work", 15000 },
                    { 160, "Social", 16000 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CatId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CatId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CatId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CatId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CatId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CatId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CatId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CatId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CatId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CatId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CatId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CatId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CatId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CatId",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CatId",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CatId",
                keyValue: 160);

            migrationBuilder.AlterColumn<string>(
                name: "SubCatName",
                table: "SubCats",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ItemDetails",
                table: "Expenses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Item",
                table: "Expenses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Currency",
                table: "Expenses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CatName",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
