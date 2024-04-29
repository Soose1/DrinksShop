using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Auto666.Api.Migrations
{
    /// <inheritdoc />
    public partial class addic : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Icon",
                value: "/Images/ProdNavIcons/sedan.ico");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Icon",
                value: "/Images/ProdNavIcons/coupe.ico");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Icon",
                value: "/Images/ProdNavIcons/universal.ico");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Icon",
                value: "/Images/ProdNavIcons/crossover.ico");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Icon",
                value: "sedan.ico");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Icon",
                value: "coupe.ico");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Icon",
                value: "universal.ico");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Icon",
                value: "crossover.ico");
        }
    }
}
