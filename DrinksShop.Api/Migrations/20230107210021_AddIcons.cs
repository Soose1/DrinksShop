using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DrinksShop.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddIcons : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Volume",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "IconCSS",
                table: "ProductCategories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IconCSS", "Name" },
                values: new object[] { "fas fa-spa", "Alcohol" });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IconCSS", "Name" },
                values: new object[] { "fas fa-couch", "Non-Alcohol" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Имеет истонченный вкус, нравится детям. 1.25l");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Виски, рекомендован самим Тарасом Григорьевичем. Отлично подойдет на большую компанию, 40%. 0.7l");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Укрпеляет здоровье, за счет большого количества витамина С. 0.5l");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "Идеально подходит для продавцов возле школы, 8.5%. 0.5l");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "Лучший напиток под пиццу из <<Буфета>>, лимончик чувствуется. 0.5l");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "На большую компанию, по началу неплохо, но, все же, лучше не покупать более 5 раз, 37.5%. 0.7l");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "Description",
                value: "Лучше не показывать девочкам, подойдет для посиделок в общаге, 38%. 0.7l");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "Description",
                value: "Более дорогая водка, для тех, кто хочет опробовать себя в роли статусного человека, 40%. 0.7l");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "Description",
                value: "Коктейль-отвертка, но с изюминкой. Подойдет для девушек и летнего отдыха, для пляжей, 7%. 0.5l");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "Description",
                value: "Престижный крепкий алкоголь, желательно иметь всегда, схож на сироп от кашля, 35%. 0.7l");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "Description",
                value: "Холодный чай с достаточно приятным вкусом. Зачастую нравится девушкам. 0.5l");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "Description",
                value: "Альтернатива свежему, все так же хорош под пиццу. 0.5l");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "Description",
                value: "Энергетический напиток за 2 гривны. Не рекомендуется к употреблению до 18 лет. 0.5l");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "Description",
                value: "Субисидия. Народный, 3х литровый стандарт для людей на мели. 3l");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "Description",
                value: "Крепкий стандарт для людей, у которых нечувствителен язык, 9%. 1l");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductCategories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "ProductCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductCategories_CategoryId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IconCSS",
                table: "ProductCategories");

            migrationBuilder.AddColumn<double>(
                name: "Volume",
                table: "Products",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Алкогольный напиток");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Безалкогольный напиток");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Volume" },
                values: new object[] { "Имеет истонченный вкус, нравится детям", 1.25 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Volume" },
                values: new object[] { "Виски, рекомендован самим Тарасом Григорьевичем. Отлично подойдет на большую компанию, 40%", 0.69999999999999996 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Volume" },
                values: new object[] { "Укрпеляет здоровье, за счет большого количества витамина С", 0.5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Volume" },
                values: new object[] { "Идеально подходит для продавцов возле школы, 8.5%", 0.5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Volume" },
                values: new object[] { "Лучший напиток под пиццу из <<Буфета>>, лимончик чувствуется", 0.5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Volume" },
                values: new object[] { "На большую компанию, по началу неплохо, но, все же, лучше не покупать более 5 раз, 37.5%", 0.69999999999999996 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Volume" },
                values: new object[] { "Лучше не показывать девочкам, подойдет для посиделок в общаге, 38%", 0.69999999999999996 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Volume" },
                values: new object[] { "Более дорогая водка, для тех, кто хочет опробовать себя в роли статусного человека, 40%", 0.69999999999999996 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Volume" },
                values: new object[] { "Коктейль-отвертка, но с изюминкой. Подойдет для девушек и летнего отдыха, для пляжей, 7%", 0.5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Volume" },
                values: new object[] { "Престижный крепкий алкоголь, желательно иметь всегда, схож на сироп от кашля, 35%", 0.5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "Volume" },
                values: new object[] { "Холодный чай с достаточно приятным вкусом. Зачастую нравится девушкам", 0.5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "Volume" },
                values: new object[] { "Альтернатива свежему, все так же хорош под пиццу", 0.5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "Volume" },
                values: new object[] { "Энергетический напиток за 2 гривны. Не рекомендуется к употреблению до 18 лет", 0.5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "Volume" },
                values: new object[] { "Субисидия. Народный, 3х литровый стандарт для людей на мели", 3.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "Volume" },
                values: new object[] { "Крепкий стандарт для людей, у которых нечувствителен язык, 9%", 1.0 });
        }
    }
}
