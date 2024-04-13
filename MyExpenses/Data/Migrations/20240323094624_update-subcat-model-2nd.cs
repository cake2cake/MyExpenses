using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyExpenses.Migrations
{
    /// <inheritdoc />
    public partial class updatesubcatmodel2nd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubCats_Categories_CategoryCatId",
                table: "SubCats");

            migrationBuilder.DropIndex(
                name: "IX_SubCats_CategoryCatId",
                table: "SubCats");

            migrationBuilder.DropColumn(
                name: "CategoryCatId",
                table: "SubCats");

            migrationBuilder.CreateIndex(
                name: "IX_SubCats_CatId",
                table: "SubCats",
                column: "CatId");

            migrationBuilder.AddForeignKey(
                name: "FK_SubCats_Categories_CatId",
                table: "SubCats",
                column: "CatId",
                principalTable: "Categories",
                principalColumn: "CatId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubCats_Categories_CatId",
                table: "SubCats");

            migrationBuilder.DropIndex(
                name: "IX_SubCats_CatId",
                table: "SubCats");

            migrationBuilder.AddColumn<int>(
                name: "CategoryCatId",
                table: "SubCats",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 1,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 2,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 3,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 4,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 5,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 6,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 7,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 8,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 9,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 10,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 11,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 12,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 13,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 14,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 15,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 16,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 17,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 18,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 19,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 20,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 21,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 22,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 23,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 24,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 25,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 26,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 27,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 28,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 29,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 30,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 31,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 33,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 34,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 35,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 36,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 37,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 38,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 39,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 40,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 41,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 42,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 43,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 45,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 46,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 47,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 48,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 49,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 50,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 51,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 52,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 53,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 54,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 55,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 56,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 60,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 61,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 62,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 70,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 80,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 81,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 103,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 110,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 120,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 130,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 135,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 140,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubCats",
                keyColumn: "SubCatId",
                keyValue: 144,
                column: "CategoryCatId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_SubCats_CategoryCatId",
                table: "SubCats",
                column: "CategoryCatId");

            migrationBuilder.AddForeignKey(
                name: "FK_SubCats_Categories_CategoryCatId",
                table: "SubCats",
                column: "CategoryCatId",
                principalTable: "Categories",
                principalColumn: "CatId");
        }
    }
}
