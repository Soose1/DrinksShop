using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DrinksShop.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddDrinks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Имеет истонченный вкус, нравится детям\n1.25l");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Виски, рекомендован самим Тарасом Григорьевичем. Отлично подойдет на большую компанию.\n40%\n0.7l");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Укрпеляет здоровье, за счет большого количества витамина С\n0.5l");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "Идеально подходит для продавцов возле школы.\n8.5%\n0.5l");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "Лучший напиток под пиццу из <<Буфета>>, лимончик чувствуется\n0.5l");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "На большую компанию, по началу неплохо, но, все же, лучше не покупать более 5 раз.\n37.5%\n0.7l");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "Description",
                value: "Лучше не показывать девочкам, подойдет для посиделок в общаге.\n38%\n0.7l");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "Description",
                value: "Более дорогая водка, для тех, кто хочет опробовать себя в роли статусного человека.\n40%\n0.7l");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "Description",
                value: "Коктейль-отвертка, но с изюминкой. Подойдет для девушек и летнего отдыха, для пляжей.\n7%\n0.5l");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "Description",
                value: "Престижный крепкий алкоголь, желательно иметь всегда, схож на сироп от кашля.\n35%\n0.7l");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "Description",
                value: "Холодный чай с достаточно приятным вкусом. Зачастую нравится девушкам.\n0.5l");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "Description",
                value: "Альтернатива свежему, все так же хорош под пиццу.\n0.5l");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "Description",
                value: "Энергетический напиток за 2 гривны. Не рекомендуется к употреблению до 18 лет.\n0.5l");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "Description",
                value: "Субисидия. Народный, 3х литровый стандарт для людей на мели.\n3l");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "Description",
                value: "Крепкий стандарт для людей, у которых нечувствителен язык.\n9%\n1l");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageURL", "Name", "Price", "Qty" },
                values: new object[,]
                {
                    { 16, 1, "Пивко для любителей побаловаться.\n4.6%\n0.5ml", "/Images/Drinks/Budka.jpg", "Будка", 42m, 50 },
                    { 17, 2, "Входит в набор 8-ми классницы. Довольно приятный энергетик за вменяемую цену.\n250ml", "/Images/Drinks/Chert.jpg", "Чёрт", 40m, 50 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

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
        }
    }
}
