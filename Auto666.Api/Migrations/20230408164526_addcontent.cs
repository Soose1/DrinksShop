using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Auto666.Api.Migrations
{
    /// <inheritdoc />
    public partial class addcontent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "City", "Description", "FuelType", "Horses", "ImageURL", "Mark", "Model", "Name", "Price", "Range", "Transmission", "Volume", "Year" },
                values: new object[,]
                {
                    { 7, 2, "Кривий Рiг", "Автомобіль в ідеальному зовнішньому та технічному стані.\r\nСвоєчасне обслуговування автомобіля, все ТО згідно з регламентом.\r\nПеред продажем автомобіль пройшов комплексну діагностику у GOSHA TURBO TECH!\r\nОригінальний пробіг.\r\nДодаткові доробки:\r\n- STAGE 1\r\n- Вихлопна система GREDDY\r\n- Аудіосистема Bose", "Бензин", 530, "/Images/Cars/NissanGTR/NissanGTR1.jpg", "GTR", "Nissan", "Nissan GTR", 60000, 84000, "Механічна", 3.7999999999999998, 2011 },
                    { 8, 3, "Полтава", "А/м привезений із Німеччини. Без пробігу Україною.\r\nВ Україні Ви будете першим власником.\r\nШикарний колір темно-сірий Софісто металік на чорній шкірі.\r\nРідкісна набірна ТОП комплектація :М пакет зовнішній та внутрішній, панорама, пневмо підвіска, фари Adaptive LED, акустика HI-END BOWERS & WILKINS (дорога рідкість), мертві зони, навігація, цифрова панель приладів, читання знаків, кругові камери 360, салону і тд.\r\nУсі ТО пройдено вчасно у Німеччині біля оф. дилер.", "Дизель", 320, "/Images/Cars/BMW5/BMW51.jpg", "5", "BMW", "BMW 5", 61000, 62000, "Автоматична", 3.0, 2019 },
                    { 9, 3, "Київ", "Ексклюзив! Єдиний CLA AMG 45S у кузові ShootingBrake!\r\nМашина «гармата» - 421 к.с., розгін до 100 км/год - 4 сек!!!\r\nНайпотужніший серійний 2-літровий мотор у світі!\r\nМашина в наявності у Києві, НОВА без пробігу. ЕПТС готовий (виписка є на фото)! На облік не ставилася. Ціна вказана в оголошенні!\r\nТехнічні характеристики: двигун 2.0 потужністю 421 л.\r\nРозгін до 100 км/год – 4 с.!\r\nМаксимальна швидкість – 270 км/год\r\nПовний привід", "Бензин", 421, "/Images/Cars/Mercedes-BenzCLA/Mercedes-BenzCLA1.jpg", "CLA AMG", "Mercedes-Benz", "Mercedes-Benz CLA AMG", 85000, 0, "Автоматична", 3.0, 2022 },
                    { 10, 3, "Київ", "Audi A6 40 TDI Avant у гарній комплектації!\r\nНемає жодного битого/фарбованого елемента !!!\r\nБез пробігу РФ (з Німеччини) в наявності в Москві, повністю розмитнений. Придбаний у офіційного дилера Audi у Німеччині.\r\nБудь-які перевірки вітаються (офіційний дилер, професійний підбір автомобілів).\r\nМожливий торг під час огляду автомобіля, продаж автомобіля в кредит, лізинг, з ПДВ, а також обмін.", "Дизель", 204, "/Images/Cars/AudiA6/AudiA61.jpg", "A6", "Audi", "Audi A6", 85000, 196000, "Автоматична", 2.0, 2019 },
                    { 11, 4, "Харків", "Два комплекти гуми R 21\r\nСигналізація Starline\r\nПередпусковий обігрівач Webasto\r\nПовна шумоізоляція салону\r\nБензобак 138 літрів\r\nКІТ Гальмів Brembo 6POT/4POT", "Бензин", 367, "/Images/Cars/LexusLX500/LexusLX5001.jpg", "LX500", "Lexus", "Lexus LX500", 101000, 77000, "Автоматична", 5.7000000000000002, 2017 },
                    { 12, 4, "Дніпро", "Спецпропозиція!\r\nCadillac Escalade\r\nДилерська а/м\r\nЧиста автотека\r\nЧудовий зовнішній вигляд", "Бензин", 426, "/Images/Cars/CadillacEscalade/CadillacEscalade1.jpg", "Escalade", "Cadillac", "Cadillac Escalade", 78000, 116000, "Автоматична", 6.2000000000000002, 2019 },
                    { 13, 4, "Суми", "1 власник! Ідеальний стан!\r\nОбслуговується у Porsche-Центрі.\r\nНабір нових зимових коліс на штатних оригінальних дисках.\r\nЗ самої покупки був замовлений та встановлений комплект оригінального аеродинамічного комплекту TECHART:\r\n- спойлер переднього бампера включаючи спліттер;\r\n- спойлер заднього бампера включаючи центральний дифузор;\r\n- спойлер на кришку багажника (середній);\r\n- Спойлер даху (верхній).", "Бензин", 340, "/Images/Cars/PorscheCayenne/PorscheCayenne1.jpg", "Cayenne", "Porsche", "Porsche Cayenne", 99000, 49000, "Автоматична", 3.0, 2018 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Icon",
                value: "fas fa-champagne-glasses");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Icon",
                value: "fas fa-wine-bottle");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Icon",
                value: "fas fa-champagne-glasses");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Icon",
                value: "fas fa-wine-bottle");
        }
    }
}
