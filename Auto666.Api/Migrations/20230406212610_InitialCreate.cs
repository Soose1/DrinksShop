using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Auto666.Api.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Id);
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

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mark = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Transmission = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Range = table.Column<int>(type: "int", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Volume = table.Column<double>(type: "float", nullable: false),
                    Horses = table.Column<int>(type: "int", nullable: false),
                    FuelType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_ProductCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "ProductCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "Icon", "Name" },
                values: new object[,]
                {
                    { 1, "fas fa-champagne-glasses", "Седан" },
                    { 2, "fas fa-wine-bottle", "Купе" },
                    { 3, "fas fa-champagne-glasses", "Унiверсал" },
                    { 4, "fas fa-wine-bottle", "Кросовер" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "UserName" },
                values: new object[,]
                {
                    { 1, "Kyrylo" },
                    { 2, "Dmytro" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "City", "Description", "FuelType", "Horses", "ImageURL", "Mark", "Model", "Name", "Price", "Range", "Transmission", "Volume", "Year" },
                values: new object[,]
                {
                    { 1, 2, "Харкiв", "Улюблена машина, але хочеться щось комфортніше. Стік, механіка w58, блокування. Є недоліки по кузову, розмова у капота, торг можливий", "Бензин", 225, "/Images/Cars/ToyotaSupra/ToyotaSupra1.jpg", "Supra", "Toyota", "Toyota Supra", 29000, 175000, "Механiчна", 3.0, 1993 },
                    { 2, 1, "Полтава", "Автомобіль із Канади! Без пробігу Україною.\r\nМашина у відмінному стані. Обслуговувалась у офіційного дилера. Рідний пробіг!\r\nПовністю розмитнений. Ви будете першим власником!\r\nАвтомобіль вкладень не вимагає. Будь-які перевірки лише вітаються.", "Бензин", 268, "/Images/Cars/SubaruWRX/SubaruWRX1.jpg", "WRX", "Subaru", "Subaru WRX", 29000, 56000, "Механiчна", 2.0, 2018 },
                    { 3, 2, "Київ", "Автомобіль пройшов повну технічну діагностику, дітейлінг салону/кузова та готовий до подальшої експлуатації\r\nАбсолютно кожен автомобіль проходить ретельну перевірку ", "Бензин", 333, "/Images/Cars/InfinitiG37/InfinitiG371.jpg", "G37", "Infiniti", "Infiniti G37", 13000, 239000, "Автоматична", 2.0, 2008 },
                    { 4, 1, "Київ", "Стайлінг AMG: передній спойлер, накладки порогів\r\nОббивка зі шкіри наппа\r\nАкустична система об'ємного звучання Burmester? 3D\r\nМультимедійна система MBUX High-End для задніх пасажирів\r\nЦентральний OLED-дисплей\r\nHANDS-FREE ACCESS\r\nСерводівник\r\nОкреме блокування кришки багажника\r\nСистема KEYLESS-GO із вбудованими заподлицо ручками дверей", "Дизель", 249, "/Images/Cars/MercedesS350d/MercedesS350d1.jpg", "S-клас 350d Long", "Mercedes-Benz", "Mercedes-Benz S-клас 350d Long", 130000, 59000, "Автоматична", 2.8999999999999999, 2020 },
                    { 5, 1, "Одеса", "Пишу для тих хто не розуміє. Птс 150лс, за фактом 180лс (маленький податок)\r\nДвигун 1jz-об'єм 2.5-потужність 150 л. с. за фактом 180 л. с (ввезений із заниженням сил розмитнення)\r\nПроблем з урахуванням ні яких немає\r\n(можу бути присутнім у гібдд)\r\nМашина робилася собі. так що можна не перейматися володінням все відмінно (відновлював більше року)\r\nПродаж від власника", "Бензин", 180, "/Images/Cars/ToyotaMark2/ToyotaMark1.jpg", "Mark 2", "Toyota", "Toyota Mark 2", 6100, 230000, "Автоматична", 2.5, 1995 },
                    { 6, 3, "Лвiв", "Шукаєте Mazda 6 із пробігом на особливих умовах? Офіційному дилеру РОЛЬФ Львів | Авто з пробігом є, що Вам запропонувати!\r\nОфіційний дилер РОЛЬФ Львів | Автомобілі з пробігом пропонує Вам Mazda 6 з проведеною технічною та юридичною перевіркою. Ми гарантуємо індивідуальні умови при купівлі та/або обміні на Ваш автомобіль.\r\nМи гарантуємо індивідуальні умови при купівлі та/або обміні на Ваш автомобіль.\r\nТакож цілих 2 роки гарантії РОЛЬФ *", "Дизель", 184, "/Images/Cars/Mazda6/Mazda61.jpg", "6", "Mazda", "Mazda 6", 30000, 84000, "Автоматична", 2.2000000000000002, 2019 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "ProductCategories");
        }
    }
}
