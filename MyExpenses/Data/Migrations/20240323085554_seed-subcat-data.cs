using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyExpenses.Migrations
{
    /// <inheritdoc />
    public partial class seedsubcatdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SubCats",
                columns: new[] { "SubCatId", "CatId", "SubCatName", "SubCatOrder" },
                values: new object[,]
                {
                    { 1, 10, "Breakfast", 100 },
                    { 2, 10, "Lunch", 200 },
                    { 3, 10, "Dinner", 300 },
                    { 4, 10, "Snack", 400 },
                    { 5, 10, "Cook", 500 },
                    { 6, 20, "Car Park", 600 },
                    { 7, 20, "Car Gas", 700 },
                    { 8, 20, "Car Fines", 800 },
                    { 9, 20, "Car Tax", 900 },
                    { 10, 20, "Car Maintenance", 1000 },
                    { 11, 20, "Car Insurance", 1100 },
                    { 12, 20, "Car Wash", 1200 },
                    { 13, 20, "Bus", 1300 },
                    { 14, 20, "Taxi", 1400 },
                    { 15, 120, "Monthly", 1500 },
                    { 16, 120, "Travel", 1600 },
                    { 17, 120, "House maintenance", 1700 },
                    { 18, 120, "Others", 1800 },
                    { 19, 130, "Food", 1900 },
                    { 20, 130, "Pet care", 2000 },
                    { 21, 130, "Vet", 2100 },
                    { 22, 130, "Accessories", 2200 },
                    { 23, 130, "Pet Toilet", 2300 },
                    { 24, 30, "Groceries", 2400 },
                    { 25, 30, "Home Maintenance", 2700 },
                    { 26, 30, "Management Fee", 2600 },
                    { 27, 30, "Maid", 2500 },
                    { 28, 110, "Car Loan", 2800 },
                    { 29, 110, "House Loan", 2900 },
                    { 30, 110, "Loan charges", 3000 },
                    { 31, 30, "House Tax", 3100 },
                    { 33, 40, "CEM", 3300 },
                    { 34, 40, "SAAM", 3400 },
                    { 35, 40, "Gas", 3500 },
                    { 36, 40, "Fixed line", 3600 },
                    { 37, 40, "Mobile(CTM)", 3700 },
                    { 38, 40, "Internet", 3800 },
                    { 39, 40, "Internet(Mom)", 3900 },
                    { 40, 40, "Mobile(China Telecom)", 4000 },
                    { 41, 60, "Magazines", 4100 },
                    { 42, 60, "Toys", 4200 },
                    { 43, 60, "Sports", 4300 },
                    { 45, 140, "Parking Rent", 4500 },
                    { 46, 140, "Insurance", 4600 },
                    { 47, 140, "Others", 4700 },
                    { 48, 50, "Personal - Clothing", 4800 },
                    { 49, 90, "Medicine", 4900 },
                    { 50, 90, "Insurance", 5000 },
                    { 51, 140, "Irene - Shop Expenses", 5100 },
                    { 52, 100, "Personal - Occasions", 5200 },
                    { 53, 50, "Hair cut", 5300 },
                    { 54, 60, "Audio Visual", 5400 },
                    { 55, 100, "Personal - CNY", 5500 },
                    { 56, 10, "Fruit", 550 },
                    { 60, 60, "Games", 6000 },
                    { 61, 80, "Expenses", 6100 },
                    { 62, 80, "Transportation", 6200 },
                    { 70, 40, "Irene dad China Mobile(since Jun / 18)", 4050 },
                    { 80, 70, "Online course", 8000 },
                    { 81, 70, "Classroom course", 8100 },
                    { 103, 20, "Car Purchase", 1250 },
                    { 110, 30, "Furniture", 2710 },
                    { 120, 50, "Shoes", 4850 },
                    { 130, 80, "Hotels", 6250 },
                    { 135, 80, "Misc", 6260 },
                    { 140, 150, "Social expenses", 14000 },
                    { 144, 150, "Computers", 14400 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 144);
        }
    }
}
