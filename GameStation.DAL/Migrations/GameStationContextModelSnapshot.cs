﻿// <auto-generated />
using System;
using GameStation.DAL.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GameStation.DAL.Migrations
{
    [DbContext(typeof(GameStationContext))]
    partial class GameStationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GameStation.Entity.Concrete.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasMaxLength(50);

                    b.Property<string>("Description")
                        .HasMaxLength(250);

                    b.Property<bool>("IsActive");

                    b.Property<string>("Picture1")
                        .HasMaxLength(400);

                    b.Property<string>("Picture2")
                        .HasMaxLength(400);

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new { CategoryID = 1, CategoryName = "FPS", Description = "First Person Shooter games", IsActive = true },
                        new { CategoryID = 2, CategoryName = "TPS", Description = "Third Person Shooter games", IsActive = true },
                        new { CategoryID = 3, CategoryName = "RPG", Description = "Role Playing Game", IsActive = true },
                        new { CategoryID = 4, CategoryName = "Strategy", Description = "Strategy Game", IsActive = true }
                    );
                });

            modelBuilder.Entity("GameStation.Entity.Concrete.Customer", b =>
                {
                    b.Property<string>("CustomerID");

                    b.Property<string>("Address")
                        .HasMaxLength(200);

                    b.Property<string>("AltEmail")
                        .HasMaxLength(40);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("date");

                    b.Property<string>("City")
                        .HasMaxLength(20);

                    b.Property<string>("Country")
                        .HasMaxLength(20);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Email")
                        .HasMaxLength(40);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<bool>("Gender");

                    b.Property<DateTime>("LastLogin")
                        .HasColumnType("date");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Mobile1")
                        .HasMaxLength(20);

                    b.Property<string>("Mobile2")
                        .HasMaxLength(20);

                    b.Property<string>("Notes")
                        .HasMaxLength(250);

                    b.Property<string>("Organization")
                        .HasMaxLength(50);

                    b.Property<string>("Password");

                    b.Property<string>("Phone1")
                        .HasMaxLength(20);

                    b.Property<string>("Phone2");

                    b.Property<string>("Picture")
                        .HasMaxLength(400);

                    b.Property<string>("PostalCode")
                        .HasMaxLength(20);

                    b.Property<string>("State")
                        .HasMaxLength(20);

                    b.Property<string>("Status")
                        .HasMaxLength(20);

                    b.Property<string>("UserName");

                    b.HasKey("CustomerID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("GameStation.Entity.Concrete.CustomIdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("GameStation.Entity.Concrete.CustomIdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("GameStation.Entity.Concrete.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("CancelOrder");

                    b.Property<bool>("Deliver");

                    b.Property<DateTime>("DeliveryDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Discount");

                    b.Property<DateTime>("DispatchDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Dispatched");

                    b.Property<bool>("IsCompleted");

                    b.Property<string>("Notes")
                        .HasMaxLength(150);

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderDetailID");

                    b.Property<int>("PaymentID");

                    b.Property<bool>("Shipped");

                    b.Property<DateTime>("ShippedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ShippingDetailID");

                    b.Property<decimal?>("Taxes");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("money");

                    b.HasKey("OrderID");

                    b.HasIndex("OrderDetailID");

                    b.HasIndex("PaymentID");

                    b.HasIndex("ShippingDetailID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("GameStation.Entity.Concrete.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerID")
                        .IsRequired();

                    b.Property<decimal>("Discount");

                    b.Property<bool>("IsCompleted");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductID");

                    b.Property<int>("Quantity");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("money");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("money");

                    b.HasKey("OrderDetailID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("ProductID");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("GameStation.Entity.Concrete.Payment", b =>
                {
                    b.Property<int>("PaymentID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Balance")
                        .HasColumnType("money");

                    b.Property<decimal>("CreditAmount")
                        .HasColumnType("money");

                    b.Property<decimal>("DebitAmount")
                        .HasColumnType("money");

                    b.Property<DateTime>("PaymentDatetime")
                        .HasColumnType("datetime2");

                    b.Property<int>("PaymentTypeID");

                    b.HasKey("PaymentID");

                    b.HasIndex("PaymentTypeID");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("GameStation.Entity.Concrete.PaymentType", b =>
                {
                    b.Property<int>("PaymentTypeID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasMaxLength(150);

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("PaymentTypeID");

                    b.ToTable("PaymentTypes");
                });

            modelBuilder.Entity("GameStation.Entity.Concrete.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AltText")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<int>("CategoryID");

                    b.Property<decimal>("Discount");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("LongDescription")
                        .IsRequired()
                        .HasMaxLength(1500);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Notes")
                        .HasMaxLength(250);

                    b.Property<decimal?>("OldPrice")
                        .HasColumnType("money");

                    b.Property<string>("Picture1")
                        .HasMaxLength(500);

                    b.Property<string>("Picture2")
                        .HasMaxLength(500);

                    b.Property<string>("Picture3")
                        .HasMaxLength(500);

                    b.Property<string>("Picture4")
                        .HasMaxLength(500);

                    b.Property<bool?>("ProductAvailable");

                    b.Property<string>("QuantityPerUnit")
                        .HasMaxLength(50);

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("Size")
                        .HasMaxLength(30);

                    b.Property<int>("SupplierID");

                    b.Property<int?>("UnitOnOrder");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("money");

                    b.Property<string>("UnitWeight")
                        .HasMaxLength(30);

                    b.Property<int>("UnitsInStock");

                    b.HasKey("ProductID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("SupplierID");

                    b.ToTable("Products");

                    b.HasData(
                        new { ProductID = 1, AltText = "Rimworld", CategoryID = 4, Discount = 0m, ImageUrl = "C:\\Users\\semih\\source\\repos/Pictures//Pictures/ProductPictures/Steam/rimworld_logo.png", LongDescription = "The futuristic plot originally revolved around three characters being stranded on a planet located in the frontiers of known space (a 'rim world'), where their space liner crashed. The game is set in a universe where faster-than-light travel and superluminal communication are, so far, impossible, making large galactic empires inherently unfeasible. With its release on Steam the game came with the addition, among other things, of a scenario editor, allowing users to choose and modify different starting plots, with different numbers of characters, starting items and map effects available; however, the location of these plots still remained the same, that is, still on a 'rim world'", Name = "RimWorld", ShortDescription = "RimWorld is a top-down construction and management simulation video game by Montreal-based developer Ludeon Studios. Originally called Eclipse Colony, it was initially released as a Kickstarter crowdfunding project in early access for Microsoft Windows, macOS, and Linux in November 2013, and was officially released on October 17, 2018.", SupplierID = 1, UnitPrice = 50m, UnitsInStock = 0 },
                        new { ProductID = 2, AltText = "Mount & Blade II: Bannerlord", CategoryID = 1, Discount = 0m, ImageUrl = "C:\\Users\\semih\\source\\repos/Pictures//Pictures/ProductPictures/Steam/bannerlord_logo.png", LongDescription = "27 Eylül 2012'de bir Türk şirketi olan TaleWords tarafından duyurulmuştur. Oyunun Grafikleri daha iyi gölgeleme ve daha yüksek detaylı modellerle önceki oyun olan Mount & Blade: Warband'a göre belirgin bir şekilde daha iyi hâle getirilmiştir. Karakter animasyonları hareket yakalama (motion capture) teknolojisi kullanılarak oluşturulmuş ve yüz animasyonları da canlandırılan duygularla iyileştirilerek güncelleneceği söylendi.", Name = "Bannerlord", ShortDescription = "Mount & Blade II: Bannerlord, Orta Çağ temalı bir rol yapma oyunu olan Mount & Blade serisinin bir oyunudur. Oyun, Türk firması TaleWorlds tarafından geliştiştirilmektedir. Oyun Steam'de Ekim 2016'da çıkmıştır. Fakat oyun için bir indirme imkanı sunulmamıştır. Gamescom 2019'da oyunun erken erişim tarihi verilmiş. Ayrıca bu çıkış tarihi Mount & Blade:Warband'ın 10. yılına denk gelmiş olacak.", SupplierID = 2, UnitPrice = 160m, UnitsInStock = 0 }
                    );
                });

            modelBuilder.Entity("GameStation.Entity.Concrete.RecentlyView", b =>
                {
                    b.Property<int>("RecentlyViewID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerID")
                        .IsRequired();

                    b.Property<string>("Notes")
                        .HasMaxLength(150);

                    b.Property<int>("ProductID");

                    b.Property<DateTime>("ViewDate")
                        .HasColumnType("datetime2");

                    b.HasKey("RecentlyViewID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("ProductID");

                    b.ToTable("RecentlyViews");
                });

            modelBuilder.Entity("GameStation.Entity.Concrete.Review", b =>
                {
                    b.Property<int>("ReviewID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasMaxLength(5000);

                    b.Property<string>("CustomerID")
                        .IsRequired();

                    b.Property<DateTime>("Datetime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(50);

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name")
                        .HasMaxLength(100);

                    b.Property<int>("ProductID");

                    b.Property<int>("Rate");

                    b.HasKey("ReviewID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("ProductID");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("GameStation.Entity.Concrete.ShippingDetail", b =>
                {
                    b.Property<int>("ShippingDetailID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Email")
                        .HasMaxLength(50);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Mobile")
                        .HasMaxLength(30);

                    b.Property<string>("PostalCode")
                        .HasMaxLength(25);

                    b.Property<string>("Province")
                        .HasMaxLength(30);

                    b.HasKey("ShippingDetailID");

                    b.ToTable("ShippingDetails");
                });

            modelBuilder.Entity("GameStation.Entity.Concrete.Supplier", b =>
                {
                    b.Property<int>("SupplierID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(150);

                    b.Property<string>("City")
                        .HasMaxLength(50);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("ContactName")
                        .HasMaxLength(50);

                    b.Property<string>("ContactTitle")
                        .HasMaxLength(50);

                    b.Property<string>("Country")
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .HasMaxLength(50);

                    b.Property<string>("Fax")
                        .HasMaxLength(20);

                    b.Property<string>("Mobile")
                        .HasMaxLength(20);

                    b.Property<string>("Phone")
                        .HasMaxLength(20);

                    b.HasKey("SupplierID");

                    b.ToTable("Suppliers");

                    b.HasData(
                        new { SupplierID = 1, CompanyName = "Steam", ContactName = "Gabe Newell", ContactTitle = "Founder" },
                        new { SupplierID = 2, CompanyName = "Electronic Arts", ContactName = "Trip Hawkins", ContactTitle = "Founder" }
                    );
                });

            modelBuilder.Entity("GameStation.Entity.Concrete.WishList", b =>
                {
                    b.Property<int>("WishListID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerID")
                        .IsRequired();

                    b.Property<bool>("IsActive");

                    b.Property<int>("ProductID");

                    b.HasKey("WishListID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("ProductID");

                    b.ToTable("Wishlists");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("GameStation.Entity.Concrete.Customer", b =>
                {
                    b.HasOne("GameStation.Entity.Concrete.CustomIdentityUser", "CustomIdentityUser")
                        .WithOne("Customer")
                        .HasForeignKey("GameStation.Entity.Concrete.Customer", "CustomerID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GameStation.Entity.Concrete.Order", b =>
                {
                    b.HasOne("GameStation.Entity.Concrete.OrderDetail", "OrderDetail")
                        .WithMany("Orders")
                        .HasForeignKey("OrderDetailID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GameStation.Entity.Concrete.Payment", "Payment")
                        .WithMany("Orders")
                        .HasForeignKey("PaymentID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GameStation.Entity.Concrete.ShippingDetail", "ShippingDetail")
                        .WithMany("Orders")
                        .HasForeignKey("ShippingDetailID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GameStation.Entity.Concrete.OrderDetail", b =>
                {
                    b.HasOne("GameStation.Entity.Concrete.Customer", "Customer")
                        .WithMany("OrderDetails")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GameStation.Entity.Concrete.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GameStation.Entity.Concrete.Payment", b =>
                {
                    b.HasOne("GameStation.Entity.Concrete.PaymentType", "PaymentType")
                        .WithMany("Payments")
                        .HasForeignKey("PaymentTypeID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GameStation.Entity.Concrete.Product", b =>
                {
                    b.HasOne("GameStation.Entity.Concrete.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GameStation.Entity.Concrete.Supplier", "Supplier")
                        .WithMany("Products")
                        .HasForeignKey("SupplierID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GameStation.Entity.Concrete.RecentlyView", b =>
                {
                    b.HasOne("GameStation.Entity.Concrete.Customer", "Customer")
                        .WithMany("RecentlyViews")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GameStation.Entity.Concrete.Product", "Product")
                        .WithMany("RecentlyViews")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GameStation.Entity.Concrete.Review", b =>
                {
                    b.HasOne("GameStation.Entity.Concrete.Customer", "Customer")
                        .WithMany("Reviews")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GameStation.Entity.Concrete.Product", "Product")
                        .WithMany("Reviews")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GameStation.Entity.Concrete.WishList", b =>
                {
                    b.HasOne("GameStation.Entity.Concrete.Customer", "Customer")
                        .WithMany("WishLists")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GameStation.Entity.Concrete.Product", "Product")
                        .WithMany("WishLists")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("GameStation.Entity.Concrete.CustomIdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("GameStation.Entity.Concrete.CustomIdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("GameStation.Entity.Concrete.CustomIdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("GameStation.Entity.Concrete.CustomIdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GameStation.Entity.Concrete.CustomIdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("GameStation.Entity.Concrete.CustomIdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
