using Auto666.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Auto666.Api.Data
{
    public class Auto666DbContext : DbContext
    {
        public Auto666DbContext(DbContextOptions<Auto666DbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                Name = "Toyota Supra",
                Model = "Toyota",
                Mark = "Supra",
                Description = "Улюблена машина, але хочеться щось комфортніше. Стік, механіка w58, блокування. Є недоліки по кузову, розмова у капота, торг можливий",
                ImageURL = "/Images/Cars/ToyotaSupra/ToyotaSupra1.jpg",
                Price = 29000,
                Year = 1993,
                Transmission = "Механiчна",
                Range = 175000,
                City = "Харкiв",
                Volume = 3.0,
                Horses = 225,
                FuelType = "Бензин",
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Subaru WRX",
                Model = "Subaru",
                Mark = "WRX",
                Description = "Автомобіль із Канади! Без пробігу Україною.\r\nМашина у відмінному стані. Обслуговувалась у офіційного дилера. Рідний пробіг!\r\nПовністю розмитнений. Ви будете першим власником!\r\nАвтомобіль вкладень не вимагає. Будь-які перевірки лише вітаються.",
                ImageURL = "/Images/Cars/SubaruWRX/SubaruWRX1.jpg",
                Price = 29000,
                Year = 2018,
                Transmission = "Механiчна",
                Range = 56000,
                City = "Полтава",
                Volume = 2.0,
                Horses = 268,
                FuelType = "Бензин",
                CategoryId = 1
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Infiniti G37",
                Model = "Infiniti",
                Mark = "G37",
                Description = "Автомобіль пройшов повну технічну діагностику, дітейлінг салону/кузова та готовий до подальшої експлуатації\r\nАбсолютно кожен автомобіль проходить ретельну перевірку ",
                ImageURL = "/Images/Cars/InfinitiG37/InfinitiG371.jpg",
                Price = 13000,
                Year = 2008,
                Transmission = "Автоматична",
                Range = 239000,
                City = "Київ",
                Volume = 2.0,
                Horses = 333,
                FuelType = "Бензин",
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Mercedes-Benz S-клас 350d Long",
                Model = "Mercedes-Benz",
                Mark = "S-клас 350d Long",
                Description = "Стайлінг AMG: передній спойлер, накладки порогів\r\nОббивка зі шкіри наппа\r\nАкустична система об'ємного звучання Burmester? 3D\r\nМультимедійна система MBUX High-End для задніх пасажирів\r\nЦентральний OLED-дисплей\r\nHANDS-FREE ACCESS\r\nСерводівник\r\nОкреме блокування кришки багажника\r\nСистема KEYLESS-GO із вбудованими заподлицо ручками дверей",
                ImageURL = "/Images/Cars/MercedesS350d/MercedesS350d1.jpg",
                Price = 130000,
                Year = 2020,
                Transmission = "Автоматична",
                Range = 59000,
                City = "Київ",
                Volume = 2.9,
                Horses = 249,
                FuelType = "Дизель",
                CategoryId = 1
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Toyota Mark 2",
                Model = "Toyota",
                Mark = "Mark 2",
                Description = "Пишу для тих хто не розуміє. Птс 150лс, за фактом 180лс (маленький податок)\r\nДвигун 1jz-об'єм 2.5-потужність 150 л. с. за фактом 180 л. с (ввезений із заниженням сил розмитнення)\r\nПроблем з урахуванням ні яких немає\r\n(можу бути присутнім у гібдд)\r\nМашина робилася собі. так що можна не перейматися володінням все відмінно (відновлював більше року)\r\nПродаж від власника",
                ImageURL = "/Images/Cars/ToyotaMark2/ToyotaMark1.jpg",
                Price = 6100,
                Year = 1995,
                Transmission = "Автоматична",
                Range = 230000,
                City = "Одеса",
                Volume = 2.5,
                Horses = 180,
                FuelType = "Бензин",
                CategoryId = 1
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "Mazda 6",
                Model = "Mazda",
                Mark = "6",
                Description = "Шукаєте Mazda 6 із пробігом на особливих умовах? Офіційному дилеру РОЛЬФ Львів | Авто з пробігом є, що Вам запропонувати!\r\nОфіційний дилер РОЛЬФ Львів | Автомобілі з пробігом пропонує Вам Mazda 6 з проведеною технічною та юридичною перевіркою. Ми гарантуємо індивідуальні умови при купівлі та/або обміні на Ваш автомобіль.\r\nМи гарантуємо індивідуальні умови при купівлі та/або обміні на Ваш автомобіль.\r\nТакож цілих 2 роки гарантії РОЛЬФ *",
                ImageURL = "/Images/Cars/Mazda6/Mazda61.jpg",
                Price = 30000,
                Year = 2019,
                Transmission = "Автоматична",
                Range = 84000,
                City = "Лвiв",
                Volume = 2.2,
                Horses = 184,
                FuelType = "Дизель",
                CategoryId = 3
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 7,
                Name = "Nissan GTR",
                Model = "Nissan",
                Mark = "GTR",
                Description = "Автомобіль в ідеальному зовнішньому та технічному стані.\r\nСвоєчасне обслуговування автомобіля, все ТО згідно з регламентом.\r\nПеред продажем автомобіль пройшов комплексну діагностику у GOSHA TURBO TECH!\r\nОригінальний пробіг.\r\nДодаткові доробки:\r\n- STAGE 1\r\n- Вихлопна система GREDDY\r\n- Аудіосистема Bose",
                ImageURL = "/Images/Cars/NissanGTR/NissanGTR1.jpg",
                Price = 60000,
                Year = 2011,
                Transmission = "Механічна",
                Range = 84000,
                City = "Кривий Рiг",
                Volume = 3.8,
                Horses = 530,
                FuelType = "Бензин",
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 8,
                Name = "BMW 5",
                Model = "BMW",
                Mark = "5",
                Description = "А/м привезений із Німеччини. Без пробігу Україною.\r\nВ Україні Ви будете першим власником.\r\nШикарний колір темно-сірий Софісто металік на чорній шкірі.\r\nРідкісна набірна ТОП комплектація :М пакет зовнішній та внутрішній, панорама, пневмо підвіска, фари Adaptive LED, акустика HI-END BOWERS & WILKINS (дорога рідкість), мертві зони, навігація, цифрова панель приладів, читання знаків, кругові камери 360, салону і тд.\r\nУсі ТО пройдено вчасно у Німеччині біля оф. дилер.",
                ImageURL = "/Images/Cars/BMW5/BMW51.jpg",
                Price = 61000,
                Year = 2019,
                Transmission = "Автоматична",
                Range = 62000,
                City = "Полтава",
                Volume = 3.0,
                Horses = 320,
                FuelType = "Дизель",
                CategoryId = 3
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 9,
                Name = "Mercedes-Benz CLA AMG",
                Model = "Mercedes-Benz",
                Mark = "CLA AMG",
                Description = "Ексклюзив! Єдиний CLA AMG 45S у кузові ShootingBrake!\r\nМашина «гармата» - 421 к.с., розгін до 100 км/год - 4 сек!!!\r\nНайпотужніший серійний 2-літровий мотор у світі!\r\nМашина в наявності у Києві, НОВА без пробігу. ЕПТС готовий (виписка є на фото)! На облік не ставилася. Ціна вказана в оголошенні!\r\nТехнічні характеристики: двигун 2.0 потужністю 421 л.\r\nРозгін до 100 км/год – 4 с.!\r\nМаксимальна швидкість – 270 км/год\r\nПовний привід",
                ImageURL = "/Images/Cars/Mercedes-BenzCLA/Mercedes-BenzCLA1.jpg",
                Price = 85000,
                Year = 2022,
                Transmission = "Автоматична",
                Range = 0,
                City = "Київ",
                Volume = 2.0,
                Horses = 421,
                FuelType = "Бензин",
                CategoryId = 3
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 10,
                Name = "Audi A6",
                Model = "Audi",
                Mark = "A6",
                Description = "Audi A6 40 TDI Avant у гарній комплектації!\r\nНемає жодного битого/фарбованого елемента !!!\r\nБез пробігу РФ (з Німеччини) в наявності в Москві, повністю розмитнений. Придбаний у офіційного дилера Audi у Німеччині.\r\nБудь-які перевірки вітаються (офіційний дилер, професійний підбір автомобілів).\r\nМожливий торг під час огляду автомобіля, продаж автомобіля в кредит, лізинг, з ПДВ, а також обмін.",
                ImageURL = "/Images/Cars/AudiA6/AudiA61.jpg",
                Price = 85000,
                Year = 2019,
                Transmission = "Автоматична",
                Range = 196000,
                City = "Київ",
                Volume = 2.0,
                Horses = 204,
                FuelType = "Дизель",
                CategoryId = 3
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 11,
                Name = "Lexus LX500",
                Model = "Lexus",
                Mark = "LX500",
                Description = "Два комплекти гуми R 21\r\nСигналізація Starline\r\nПередпусковий обігрівач Webasto\r\nПовна шумоізоляція салону\r\nБензобак 138 літрів\r\nКІТ Гальмів Brembo 6POT/4POT",
                ImageURL = "/Images/Cars/LexusLX/LexusLX1.jpg",
                Price = 101000,
                Year = 2017,
                Transmission = "Автоматична",
                Range = 77000,
                City = "Харків",
                Volume = 5.7,
                Horses = 367,
                FuelType = "Бензин",
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 12,
                Name = "Cadillac Escalade",
                Model = "Cadillac",
                Mark = "Escalade",
                Description = "Спецпропозиція!\r\nCadillac Escalade\r\nДилерська а/м\r\nЧиста автотека\r\nЧудовий зовнішній вигляд",
                ImageURL = "/Images/Cars/CadillacEscalade/CadillacEscalade1.jpg",
                Price = 78000,
                Year = 2019,
                Transmission = "Автоматична",
                Range = 116000,
                City = "Дніпро",
                Volume = 6.2,
                Horses = 426,
                FuelType = "Бензин",
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 13,
                Name = "Porsche Cayenne",
                Model = "Porsche",
                Mark = "Cayenne",
                Description = "1 власник! Ідеальний стан!\r\nОбслуговується у Porsche-Центрі.\r\nНабір нових зимових коліс на штатних оригінальних дисках.\r\nЗ самої покупки був замовлений та встановлений комплект оригінального аеродинамічного комплекту TECHART:\r\n- спойлер переднього бампера включаючи спліттер;\r\n- спойлер заднього бампера включаючи центральний дифузор;\r\n- спойлер на кришку багажника (середній);\r\n- Спойлер даху (верхній).",
                ImageURL = "/Images/Cars/PorscheCayenne/PorscheCayenne1.jpg",
                Price = 99000,
                Year = 2018,
                Transmission = "Автоматична",
                Range = 49000,
                City = "Суми",
                Volume = 3.0,
                Horses = 340,
                FuelType = "Бензин",
                CategoryId = 4
            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 1,
                UserName = "Kyrylo"

            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 2,
                UserName = "Dmytro"

            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 1,
                Name = "Седан",
                Icon = "/Images/ProdNavIcons/sedan.ico"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 2,
                Name = "Купе",
                Icon = "/Images/ProdNavIcons/coupe.ico"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 3,
                Name = "Унiверсал",
                Icon = "/Images/ProdNavIcons/universal.ico"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 4,
                Name = "Кросовер",
                Icon = "/Images/ProdNavIcons/crossover.ico"
            });

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
