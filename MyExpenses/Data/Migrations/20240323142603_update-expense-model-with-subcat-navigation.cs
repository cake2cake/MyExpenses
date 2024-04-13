using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyExpenses.Migrations
{
    /// <inheritdoc />
    public partial class updateexpensemodelwithsubcatnavigation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Expenses_SubCatId",
                table: "Expenses",
                column: "SubCatId");

            migrationBuilder.AddForeignKey(
                name: "FK_Expenses_SubCats_SubCatId",
                table: "Expenses",
                column: "SubCatId",
                principalTable: "SubCats",
                principalColumn: "SubCatId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expenses_SubCats_SubCatId",
                table: "Expenses");

            migrationBuilder.DropIndex(
                name: "IX_Expenses_SubCatId",
                table: "Expenses");
        }
    }
}
