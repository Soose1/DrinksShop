// <auto-generated />
using DrinksShop.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DrinksShop.Api.Migrations
{
    [DbContext(typeof(DrinksShopDbContext))]
    [Migration("20230108222622_AddDrinks")]
    partial class AddDrinks
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DrinksShop.Api.Entities.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Carts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            UserId = 2
                        });
                });

            modelBuilder.Entity("DrinksShop.Api.Entities.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("DrinksShop.Api.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 2,
                            Description = "Имеет истонченный вкус, нравится детям\n1.25l",
                            ImageURL = "/Images/Drinks/KlavaCoca.jpg",
                            Name = "Клава Кока",
                            Price = 40m,
                            Qty = 50
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "Виски, рекомендован самим Тарасом Григорьевичем. Отлично подойдет на большую компанию.\n40%\n0.7l",
                            ImageURL = "/Images/Drinks/JekaJihar.jpg",
                            Name = "Жека Жихарь",
                            Price = 500m,
                            Qty = 30
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            Description = "Укрпеляет здоровье, за счет большого количества витамина С\n0.5l",
                            ImageURL = "/Images/Drinks/Ablepiha.jpg",
                            Name = "АБЛЕПИХА",
                            Price = 34m,
                            Qty = 250
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Description = "Идеально подходит для продавцов возле школы.\n8.5%\n0.5l",
                            ImageURL = "/Images/Drinks/Vika.jpg",
                            Name = "Пьяная Вика",
                            Price = 46m,
                            Qty = 950
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            Description = "Лучший напиток под пиццу из <<Буфета>>, лимончик чувствуется\n0.5l",
                            ImageURL = "/Images/Drinks/Svejiy.jpg",
                            Name = "СВЕЖИЙ",
                            Price = 35m,
                            Qty = 150
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 1,
                            Description = "На большую компанию, по началу неплохо, но, все же, лучше не покупать более 5 раз.\n37.5%\n0.7l",
                            ImageURL = "/Images/Drinks/NicolayMorgan.jpg",
                            Name = "Николай Морган",
                            Price = 205m,
                            Qty = 40
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 1,
                            Description = "Лучше не показывать девочкам, подойдет для посиделок в общаге.\n38%\n0.7l",
                            ImageURL = "/Images/Drinks/MahaMary.jpg",
                            Name = "MAHAMARY",
                            Price = 140m,
                            Qty = 60
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 1,
                            Description = "Более дорогая водка, для тех, кто хочет опробовать себя в роли статусного человека.\n40%\n0.7l",
                            ImageURL = "/Images/Drinks/JekaBounty.jpg",
                            Name = "Жека Баунти",
                            Price = 340m,
                            Qty = 20
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 1,
                            Description = "Коктейль-отвертка, но с изюминкой. Подойдет для девушек и летнего отдыха, для пляжей.\n7%\n0.5l",
                            ImageURL = "/Images/Drinks/Katerok.jpg",
                            Name = "Катерок <<Sexx в гармошке>>",
                            Price = 38m,
                            Qty = 220
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 1,
                            Description = "Престижный крепкий алкоголь, желательно иметь всегда, схож на сироп от кашля.\n35%\n0.7l",
                            ImageURL = "/Images/Drinks/Panch.jpg",
                            Name = "Панченёнок",
                            Price = 400m,
                            Qty = 305
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 2,
                            Description = "Холодный чай с достаточно приятным вкусом. Зачастую нравится девушкам.\n0.5l",
                            ImageURL = "/Images/Drinks/Kettle.jpg",
                            Name = "Чайник",
                            Price = 38m,
                            Qty = 75
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 2,
                            Description = "Альтернатива свежему, все так же хорош под пиццу.\n0.5l",
                            ImageURL = "/Images/Drinks/Oops.jpg",
                            Name = "УПС!",
                            Price = 38m,
                            Qty = 70
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 2,
                            Description = "Энергетический напиток за 2 гривны. Не рекомендуется к употреблению до 18 лет.\n0.5l",
                            ImageURL = "/Images/Drinks/Black.jpg",
                            Name = "ЧЕРНЫЙ",
                            Price = 10m,
                            Qty = 100
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 2,
                            Description = "Субисидия. Народный, 3х литровый стандарт для людей на мели.\n3l",
                            ImageURL = "/Images/Drinks/Maloi.jpg",
                            Name = "Малой",
                            Price = 7m,
                            Qty = 25
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 1,
                            Description = "Крепкий стандарт для людей, у которых нечувствителен язык.\n9%\n1l",
                            ImageURL = "/Images/Drinks/Petushara.jpg",
                            Name = "Петушара",
                            Price = 30m,
                            Qty = 30
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 1,
                            Description = "Пивко для любителей побаловаться.\n4.6%\n0.5ml",
                            ImageURL = "/Images/Drinks/Budka.jpg",
                            Name = "Будка",
                            Price = 42m,
                            Qty = 50
                        },
                        new
                        {
                            Id = 17,
                            CategoryId = 2,
                            Description = "Входит в набор 8-ми классницы. Довольно приятный энергетик за вменяемую цену.\n250ml",
                            ImageURL = "/Images/Drinks/Chert.jpg",
                            Name = "Чёрт",
                            Price = 40m,
                            Qty = 50
                        });
                });

            modelBuilder.Entity("DrinksShop.Api.Entities.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("IconCSS")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IconCSS = "fas fa-champagne-glasses",
                            Name = "Алкоголь"
                        },
                        new
                        {
                            Id = 2,
                            IconCSS = "fas fa-wine-bottle",
                            Name = "Лимонады"
                        });
                });

            modelBuilder.Entity("DrinksShop.Api.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            UserName = "Kyrylo"
                        },
                        new
                        {
                            Id = 2,
                            UserName = "Dmytro"
                        });
                });

            modelBuilder.Entity("DrinksShop.Api.Entities.Product", b =>
                {
                    b.HasOne("DrinksShop.Api.Entities.ProductCategory", "ProductCategory")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductCategory");
                });
#pragma warning restore 612, 618
        }
    }
}
