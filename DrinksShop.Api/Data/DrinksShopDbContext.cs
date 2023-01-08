using DrinksShop.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace DrinksShop.Api.Data
{
    public class DrinksShopDbContext : DbContext
    {
        public DrinksShopDbContext(DbContextOptions<DrinksShopDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Products
            //Beauty Category
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                Name = "Клава Кока",
                Description = "Имеет истонченный вкус, нравится детям. 1.25l",
                ImageURL = "/Images/Drinks/KlavaCoca.jpg",
                Price = 40,
                Qty = 50,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Жека Жихарь",
                Description = "Виски, рекомендован самим Тарасом Григорьевичем. Отлично подойдет на большую компанию. 40%. 0.5l",
                ImageURL = "/Images/Drinks/JekaJihar.jpg",
                Price = 500,
                Qty = 30,
                CategoryId = 1
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "АБЛЕПИХА",
                Description = "Укрпеляет здоровье, за счет большого количества витамина С. 1l",
                ImageURL = "/Images/Drinks/Ablepiha.jpg",
                Price = 34,
                Qty = 250,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Пьяная Вика",
                Description = "Идеально подходит для продавцов возле школы. 8.5%. 0.5l",
                ImageURL = "/Images/Drinks/Vika.jpg",
                Price = 46,
                Qty = 950,
                CategoryId = 1
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "СВЕЖИЙ",
                Description = "Лучший напиток под пиццу из <<Буфета>>, лимончик чувствуется. 0.5l",
                ImageURL = "/Images/Drinks/Svejiy.jpg",
                Price = 35,
                Qty = 150,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "Николай Морган",
                Description = "На большую компанию, по началу неплохо, но, все же, лучше не покупать более 5 раз. 37.5%. 0.7l",
                ImageURL = "/Images/Drinks/NicolayMorgan.jpg",
                Price = 205,
                Qty = 40,
                CategoryId = 1
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 7,
                Name = "MAHAMARY",
                Description = "Лучше не показывать девочкам, подойдет для посиделок в общаге. 38%. 0.7l",
                ImageURL = "/Images/Drinks/MahaMary.jpg",
                Price = 140,
                Qty = 60,
                CategoryId = 1
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 8,
                Name = "Жека Баунти",
                Description = "Более дорогая водка, для тех, кто хочет опробовать себя в роли статусного человека. 40%. 0.7l",
                ImageURL = "/Images/Drinks/JekaBounty.jpg",
                Price = 340,
                Qty = 20,
                CategoryId = 1
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 9,
                Name = "Катерок <<Sexx в гармошке>>",
                Description = "Коктейль-отвертка, но с изюминкой. Подойдет для девушек и летнего отдыха, для пляжей. 7%. 0.5l",
                ImageURL = "/Images/Drinks/Katerok.jpg",
                Price = 38,
                Qty = 220,
                CategoryId = 1
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 10,
                Name = "Панченёнок",
                Description = "Престижный крепкий алкоголь, желательно иметь всегда, схож на сироп от кашля. 35%. 0.5l",
                ImageURL = "/Images/Drinks/Panch.jpg",  
                Price = 400,
                Qty = 305,
                CategoryId = 1
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 11,
                Name = "Чайник",
                Description = "Холодный чай с достаточно приятным вкусом. Зачастую нравится девушкам. 1l",
                ImageURL = "/Images/Drinks/Kettle.jpg",
                Price = 38,
                Qty = 75,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 12,
                Name = "УПС!",
                Description = "Альтернатива свежему, все так же хорош под пиццу. 0.33l",
                ImageURL = "/Images/Drinks/Oops.jpg",
                Price = 38,
                Qty = 70,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 13,
                Name = "ЧЕРНЫЙ",
                Description = "Энергетический напиток за 2 гривны. Не рекомендуется к употреблению до 18 лет. 1l",
                ImageURL = "/Images/Drinks/Black.jpg",
                Price = 10,
                Qty = 100,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 14,
                Name = "Малой",
                Description = "Субисидия. Народный, 3х литровый стандарт для людей на мели. 3l",
                ImageURL = "/Images/Drinks/Maloi.jpg",
                Price = 7,
                Qty = 25,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 15,
                Name = "Петушара",
                Description = "Крепкий стандарт для людей, у которых нечувствителен язык. 9%. 1.25l",
                ImageURL = "/Images/Drinks/Petushara.jpg",
                Price = 30,
                Qty = 30,
                CategoryId = 1
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 16,
                Name = "Будка",
                Description = "Пивко для любителей побаловаться. 4.6% 0.5ml",
                ImageURL = "/Images/Drinks/Budka.jpg",
                Price = 42,
                Qty = 50,
                CategoryId = 1
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 17,
                Name = "Чёрт",
                Description = "Входит в набор 8-ми классницы. Довольно приятный энергетик за вменяемую цену. 0.25l",
                ImageURL = "/Images/Drinks/Chert.jpg",
                Price = 40,
                Qty = 50,
                CategoryId = 2
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

            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 1,
                UserId = 1

            });
            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 2,
                UserId = 2

            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 1,
                Name = "Алкоголь",
                IconCSS = "fas fa-champagne-glasses"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 2,
                Name = "Лимонады",
                IconCSS = "fas fa-wine-bottle"
            });
        }

        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
