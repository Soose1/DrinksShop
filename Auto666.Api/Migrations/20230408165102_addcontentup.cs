using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Auto666.Api.Migrations
{
    /// <inheritdoc />
    public partial class addcontentup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "Volume",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageURL",
                value: "/Images/Cars/LexusLX/LexusLX1.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "Volume",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageURL",
                value: "/Images/Cars/LexusLX500/LexusLX5001.jpg");
        }
    }
}
