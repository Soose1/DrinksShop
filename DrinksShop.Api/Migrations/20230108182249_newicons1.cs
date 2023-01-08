using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DrinksShop.Api.Migrations
{
    /// <inheritdoc />
    public partial class newicons1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IconCSS", "Name" },
                values: new object[] { "fas fa-champagne-glasses", "Алкогольное" });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IconCSS", "Name" },
                values: new object[] { "fas fa-cup-straw", "Безалкогольное" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IconCSS", "Name" },
                values: new object[] { "fa-duotone fa-champagne-glasses", "Alcohol" });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IconCSS", "Name" },
                values: new object[] { "fa-solid fa-cup-straw", "Non-Alcohol" });
        }
    }
}
