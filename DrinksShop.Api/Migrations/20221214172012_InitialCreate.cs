using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DrinksShop.Api.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Volume = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Алкогольный напиток" },
                    { 2, "Безалкогольный напиток" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageURL", "Name", "Price", "Qty", "Volume" },
                values: new object[,]
                {
                    { 1, 2, "Имеет истонченный вкус, нравится детям", "/Images/Drinks/KlavaCoca.jpg", "Клава Кока", 40m, 50, 1.25 },
                    { 2, 1, "Виски, рекомендован самим Тарасом Григорьевичем. Отлично подойдет на большую компанию, 40%", "/Images/Drinks/JekaJihar.jpg", "Жека Жихарь", 500m, 30, 0.69999999999999996 },
                    { 3, 2, "Укрпеляет здоровье, за счет большого количества витамина С", "/Images/Drinks/Ablepiha.jpg", "АБЛЕПИХА", 34m, 250, 0.5 },
                    { 4, 1, "Идеально подходит для продавцов возле школы, 8.5%", "/Images/Drinks/Vika.jpg", "Пьяная Вика", 46m, 950, 0.5 },
                    { 5, 2, "Лучший напиток под пиццу из <<Буфета>>, лимончик чувствуется", "/Images/Drinks/Svejiy.jpg", "СВЕЖИЙ", 35m, 150, 0.5 },
                    { 6, 1, "На большую компанию, по началу неплохо, но, все же, лучше не покупать более 5 раз, 37.5%", "/Images/Drinks/NicolayMorgan.jpg", "Николай Морган", 205m, 40, 0.69999999999999996 },
                    { 7, 1, "Лучше не показывать девочкам, подойдет для посиделок в общаге, 38%", "/Images/Drinks/MahaMary.jpg", "MAHAMARY", 140m, 60, 0.69999999999999996 },
                    { 8, 1, "Более дорогая водка, для тех, кто хочет опробовать себя в роли статусного человека, 40%", "/Images/Drinks/JekaBounty.jpg", "Жека Баунти", 340m, 20, 0.69999999999999996 },
                    { 9, 1, "Коктейль-отвертка, но с изюминкой. Подойдет для девушек и летнего отдыха, для пляжей, 7%", "/Images/Drinks/Katerok.jpg", "Катерок <<Sexx в гармошке>>", 38m, 220, 0.5 },
                    { 10, 1, "Престижный крепкий алкоголь, желательно иметь всегда, схож на сироп от кашля, 35%", "/Images/Drinks/Panch.jpg", "Панченёнок", 400m, 305, 0.5 },
                    { 11, 2, "Холодный чай с достаточно приятным вкусом. Зачастую нравится девушкам", "/Images/Drinks/Kettle.jpg", "Чайник", 38m, 75, 0.5 },
                    { 12, 2, "Альтернатива свежему, все так же хорош под пиццу", "/Images/Drinks/Oops.jpg", "УПС!", 38m, 70, 0.5 },
                    { 13, 2, "Энергетический напиток за 2 гривны. Не рекомендуется к употреблению до 18 лет", "/Images/Drinks/Black.jpg", "ЧЕРНЫЙ", 10m, 100, 0.5 },
                    { 14, 2, "Субисидия. Народный, 3х литровый стандарт для людей на мели", "/Images/Drinks/Maloi.jpg", "Малой", 7m, 25, 3.0 },
                    { 15, 1, "Крепкий стандарт для людей, у которых нечувствителен язык, 9%", "/Images/Drinks/Petushara.jpg", "Петушара", 30m, 30, 1.0 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "UserName" },
                values: new object[,]
                {
                    { 1, "Kyrylo" },
                    { 2, "Dmytro" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
