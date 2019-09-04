using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GameStation.DAL.Migrations
{
    public partial class GameStationDbCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryName = table.Column<string>(maxLength: 50, nullable: true),
                    Description = table.Column<string>(maxLength: 250, nullable: true),
                    Picture1 = table.Column<string>(maxLength: 400, nullable: true),
                    Picture2 = table.Column<string>(maxLength: 400, nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "PaymentTypes",
                columns: table => new
                {
                    PaymentTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TypeName = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentTypes", x => x.PaymentTypeID);
                });

            migrationBuilder.CreateTable(
                name: "ShippingDetails",
                columns: table => new
                {
                    ShippingDetailID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: true),
                    Mobile = table.Column<string>(maxLength: 30, nullable: true),
                    Address = table.Column<string>(maxLength: 150, nullable: false),
                    Province = table.Column<string>(maxLength: 30, nullable: true),
                    City = table.Column<string>(maxLength: 30, nullable: false),
                    PostalCode = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShippingDetails", x => x.ShippingDetailID);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    SupplierID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompanyName = table.Column<string>(maxLength: 50, nullable: false),
                    ContactName = table.Column<string>(maxLength: 50, nullable: true),
                    ContactTitle = table.Column<string>(maxLength: 50, nullable: true),
                    Address = table.Column<string>(maxLength: 150, nullable: true),
                    Mobile = table.Column<string>(maxLength: 20, nullable: true),
                    Phone = table.Column<string>(maxLength: 20, nullable: true),
                    Fax = table.Column<string>(maxLength: 20, nullable: true),
                    Email = table.Column<string>(maxLength: 50, nullable: true),
                    City = table.Column<string>(maxLength: 50, nullable: true),
                    Country = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.SupplierID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerID = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Gender = table.Column<bool>(nullable: false),
                    BirthDate = table.Column<DateTime>(type: "date", nullable: false),
                    Organization = table.Column<string>(maxLength: 50, nullable: true),
                    Country = table.Column<string>(maxLength: 20, nullable: true),
                    State = table.Column<string>(maxLength: 20, nullable: true),
                    City = table.Column<string>(maxLength: 20, nullable: true),
                    PostalCode = table.Column<string>(maxLength: 20, nullable: true),
                    Email = table.Column<string>(maxLength: 40, nullable: true),
                    AltEmail = table.Column<string>(maxLength: 40, nullable: true),
                    Phone1 = table.Column<string>(maxLength: 20, nullable: true),
                    Phone2 = table.Column<string>(nullable: true),
                    Mobile1 = table.Column<string>(maxLength: 20, nullable: true),
                    Mobile2 = table.Column<string>(maxLength: 20, nullable: true),
                    Address = table.Column<string>(maxLength: 200, nullable: true),
                    Picture = table.Column<string>(maxLength: 400, nullable: true),
                    Status = table.Column<string>(maxLength: 20, nullable: true),
                    LastLogin = table.Column<DateTime>(type: "date", nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    Notes = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                    table.ForeignKey(
                        name: "FK_Customers_AspNetUsers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    PaymentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PaymentTypeID = table.Column<int>(nullable: false),
                    CreditAmount = table.Column<decimal>(type: "money", nullable: false),
                    DebitAmount = table.Column<decimal>(type: "money", nullable: false),
                    Balance = table.Column<decimal>(type: "money", nullable: false),
                    PaymentDatetime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.PaymentID);
                    table.ForeignKey(
                        name: "FK_Payments_PaymentTypes_PaymentTypeID",
                        column: x => x.PaymentTypeID,
                        principalTable: "PaymentTypes",
                        principalColumn: "PaymentTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    SupplierID = table.Column<int>(nullable: false),
                    CategoryID = table.Column<int>(nullable: false),
                    QuantityPerUnit = table.Column<string>(maxLength: 50, nullable: true),
                    UnitPrice = table.Column<decimal>(type: "money", nullable: false),
                    OldPrice = table.Column<decimal>(type: "money", nullable: true),
                    UnitWeight = table.Column<string>(maxLength: 30, nullable: true),
                    Size = table.Column<string>(maxLength: 30, nullable: true),
                    Discount = table.Column<decimal>(nullable: false),
                    UnitsInStock = table.Column<int>(nullable: false),
                    UnitOnOrder = table.Column<int>(nullable: true),
                    ProductAvailable = table.Column<bool>(nullable: true),
                    ImageUrl = table.Column<string>(maxLength: 500, nullable: false),
                    AltText = table.Column<string>(maxLength: 200, nullable: false),
                    ShortDescription = table.Column<string>(maxLength: 500, nullable: false),
                    LongDescription = table.Column<string>(maxLength: 1500, nullable: false),
                    Picture1 = table.Column<string>(maxLength: 500, nullable: true),
                    Picture2 = table.Column<string>(maxLength: 500, nullable: true),
                    Picture3 = table.Column<string>(maxLength: 500, nullable: true),
                    Picture4 = table.Column<string>(maxLength: 500, nullable: true),
                    Notes = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Suppliers_SupplierID",
                        column: x => x.SupplierID,
                        principalTable: "Suppliers",
                        principalColumn: "SupplierID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProductID = table.Column<int>(nullable: false),
                    CustomerID = table.Column<string>(nullable: false),
                    IsCompleted = table.Column<bool>(nullable: false),
                    UnitPrice = table.Column<decimal>(type: "money", nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Discount = table.Column<decimal>(nullable: false),
                    TotalAmount = table.Column<decimal>(type: "money", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailID);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RecentlyViews",
                columns: table => new
                {
                    RecentlyViewID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustomerID = table.Column<string>(nullable: false),
                    ProductID = table.Column<int>(nullable: false),
                    ViewDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Notes = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecentlyViews", x => x.RecentlyViewID);
                    table.ForeignKey(
                        name: "FK_RecentlyViews_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecentlyViews_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustomerID = table.Column<string>(nullable: false),
                    ProductID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Email = table.Column<string>(maxLength: 50, nullable: true),
                    Comment = table.Column<string>(maxLength: 5000, nullable: false),
                    Rate = table.Column<int>(nullable: false),
                    Datetime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewID);
                    table.ForeignKey(
                        name: "FK_Reviews_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Wishlists",
                columns: table => new
                {
                    WishListID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustomerID = table.Column<string>(nullable: false),
                    ProductID = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wishlists", x => x.WishListID);
                    table.ForeignKey(
                        name: "FK_Wishlists_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Wishlists_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OrderDetailID = table.Column<int>(nullable: false),
                    PaymentID = table.Column<int>(nullable: false),
                    ShippingDetailID = table.Column<int>(nullable: false),
                    Discount = table.Column<decimal>(nullable: false),
                    Taxes = table.Column<decimal>(nullable: true),
                    TotalAmount = table.Column<decimal>(type: "money", nullable: false),
                    IsCompleted = table.Column<bool>(nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Dispatched = table.Column<bool>(nullable: false),
                    DispatchDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Shipped = table.Column<bool>(nullable: false),
                    ShippedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deliver = table.Column<bool>(nullable: false),
                    DeliveryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Notes = table.Column<string>(maxLength: 150, nullable: true),
                    CancelOrder = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Orders_OrderDetails_OrderDetailID",
                        column: x => x.OrderDetailID,
                        principalTable: "OrderDetails",
                        principalColumn: "OrderDetailID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Payments_PaymentID",
                        column: x => x.PaymentID,
                        principalTable: "Payments",
                        principalColumn: "PaymentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_ShippingDetails_ShippingDetailID",
                        column: x => x.ShippingDetailID,
                        principalTable: "ShippingDetails",
                        principalColumn: "ShippingDetailID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7070420c-bc5c-45d9-9f05-4d68c97f6378", "3b5e6169-c79d-449f-a690-8acb6596e3e7", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7b469759-6282-4de1-85ad-d1156c480a49", 0, "1b298b62-6b5d-4074-9d7b-e3fd9f8d0e56", "admin@admin.com", true, false, null, "admin@admin.com", "admin", "AQAAAAEAACcQAAAAEHekYWCwijhgIg/3FlFWmHdO/3Ukc6uLs6AvFgJ9QlOhhqts6kv6ePKqqGBynBa8tA==", null, false, "", false, "admin" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName", "Description", "IsActive", "Picture1", "Picture2" },
                values: new object[,]
                {
                    { 1, "FPS", "Birinci şahıs nişancı oyunları.", true, null, null },
                    { 2, "TPS", "Üçüncü şahıs nişancı oyunları.", true, null, null },
                    { 3, "RPG", "Rol yapma oyunları", true, null, null },
                    { 4, "Strategy", "Strateji oyunları", true, null, null },
                    { 5, "Simülasyon", "Simülasyon oyunları", true, null, null },
                    { 6, "Aksiyon", "Aksiyon oyunları", true, null, null }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "SupplierID", "Address", "City", "CompanyName", "ContactName", "ContactTitle", "Country", "Email", "Fax", "Mobile", "Phone" },
                values: new object[,]
                {
                    { 1, null, null, "Steam", "Gabe Newell", "Founder", null, null, null, null, null },
                    { 2, null, null, "Electronic Arts", "Trip Hawkins", "Founder", null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "7b469759-6282-4de1-85ad-d1156c480a49", "7070420c-bc5c-45d9-9f05-4d68c97f6378" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "AltText", "CategoryID", "Discount", "ImageUrl", "LongDescription", "Name", "Notes", "OldPrice", "Picture1", "Picture2", "Picture3", "Picture4", "ProductAvailable", "QuantityPerUnit", "ShortDescription", "Size", "SupplierID", "UnitOnOrder", "UnitPrice", "UnitWeight", "UnitsInStock" },
                values: new object[,]
                {
                    { 18, "Dragon Age: Origins", 3, 0m, "C:\\Users\\semih\\source\\repos/GameStation/Pictures/ProductPictures/Steam/da-origins_logo.png", "Kurgusal Ferelden krallığında, sivil sürtüşmelerin yaşandığı bir dönemde kurgulanmış oyunda oyuncular; bir elf, insan ve cüce geçmişinden gelen bir savaşçı, büyücü veya bir hırsız rolünde; krallığa yaklaşmakta olan ve 'Darkspawn' (Zebâni) olarak bilinen şeytani güçlerin istilasına karşı krallığı bir araya getirmekle görevlidirler. Oyuncunun karakteri, eskilerden beri var olan 'Grey Warden' tertibinde silâh altına alınır. Gri Muhafızlar, Zebâni olarak bilinen şeytani güçlere karşı gelip, 'Yıkım' (Blight) olarak bilinen, zebânileri komuta eden Şahlanmış Şeytan'ı (Archdemon) yenmekle görevlendirilmişlerdir. Oyun, kuş bakışı perspektife değiştirilebilen üçüncü şahıs perspektifi ile oynanır. Oyun boyunca oyuncular, oyunun ana hikâyesinde ve ilerlenmesinde önemli rol oynayan ve maceraları boyunca eşlik edecek çeşitli karakterler ile karşılaşırlar.", "Dragon Age: Origins", null, null, null, null, null, null, null, null, "Dragon Age: Origins (Türkçesi: Ejderha Çağı: Başlangıçlar), BioWare tarafından geliştirilen ve Electronic Arts tarafından dağıtılan tek oyunculu rol yapma video oyunudur. Dragon Age serisinin ilk oyunu olup Kasım 2009'da Microsoft Windows, PlayStation 3 ve Xbox 360; 21 Aralık 2009'da ise OS X için satışa sunulmuştur.", null, 2, null, 54m, null, 0 },
                    { 17, "Mass Effect", 6, 0m, "C:\\Users\\semih\\source\\repos/GameStation/Pictures/ProductPictures/Steam/masseffect_logo.png", "Mass Effect'in devamı olan Mass Effect 2, 26 ocak 2010 tarihinde piyasaya sürülmüştür. Mass Effect 2'de birinci oyundan kalan kayıt dosyalarını aktarabilirsiniz ki bu sizin oyun boyunca yapacağınız şeyleride değiştirecektir.Mass Effect serisi Mass Effect 2 ile beraber IGN ve EA Games Entertainment açıklamasıyla tüm platformlarda 34.5 milyon satarak iyi bir başarı elde etmiştir.Aynı zamanda EA Games in en çok kazandıran ilk 5 oyunu arasında yer almaktadır.", "Mass Effect", null, null, null, null, null, null, null, null, "Oyun gelecekte 2183 yılında geçmektedir. Oyuncu Commander Shepard isimli bir karakteri canlandirir ve bu karakter galaksiyi gemisi SSV Normandy ile araştırma altinda tutmaktadir.", null, 2, null, 100m, null, 0 },
                    { 16, "Command & Conquer Red Alert 3", 4, 0m, "C:\\Users\\semih\\source\\repos/GameStation/Pictures/ProductPictures/Steam/cc-redalert_logo.png", "Sovyetler ile Müttefikler arasındaki savaşta müttefikler üstünlüğü sağlamak ve Sovyetler savaşı kaybetmek üzereydi. Bunun üzerine Premier Cherdenko, gizli yürüttüğü bir zaman makinesi projesini hayata geçirmeye karar vermişti.Zaman makinesi tam olarak hazır değildi ve bu makineyi icat eden doktor Zelisnsky Cherdenko'yu durdumayı çalışmıştı ama Cherkenko yanına General Krukov'u da alıp geçmişe gitmeye kararlıydı.", "Command & Conquer Red Alert 3", null, null, null, null, null, null, null, null, "Command & Conquer: Red Alert 3 (Kısaca C&C:RA3) EA Los Angeles tarafından geliştirilip, Electronic Arts tarafından 2008'de yayınlanan bir gerçek zamanlı strateji oyunu. 14 Şubat 2008'de EA LA tarafından geliştirildiği duyuruldu ve 28 Ekim 2008'de Windows tabanlı bilgisayarlar için; 11 Kasım'da Xbox 360 konsolu için yayınlandı.", null, 2, null, 200m, null, 0 },
                    { 15, "Dead Space 3", 2, 0m, "C:\\Users\\semih\\source\\repos/GameStation/Pictures/ProductPictures/Steam/deadspace3_logo.png", "In Dead Space 3, Isaac Clarke teams up with EarthGov Sergeant John Carver as they travel to Tau Volantis, an ice-covered planet, to end the Marker and Necromorph threat for good. Development of the game began after the completion of Dead Space 2.It is the only game in the Dead Space series to feature online co - op. The game received positive reviews from game critics upon release; reviewers praised the game's rewarding action gameplay, although criticism was directed at the focus on action over horror, as well as a weak and unfocused story compared to its predecessors. Despite poor sales, EA and Visceral expressed interest in a sequel. However, Visceral Games was shut down in 2017, and no confirmation that a new installment in the series is being developed by another studio.", "Dead Space 3", null, null, null, null, null, null, null, null, "Dead Space 3 is a survival horror action-adventure video game developed by Visceral Games and published by Electronic Arts. Announced at E3 2012 and released internationally in February 2013, it is the sequel to Dead Space 2 and the third main entry in the Dead Space series.", null, 2, null, 200m, null, 0 },
                    { 14, "A Way Out", 6, 0m, "C:\\Users\\semih\\source\\repos/GameStation/Pictures/ProductPictures/Steam/awayout_logo.png", "A Way Out is an action-adventure game played from a third-person perspective. It is specifically designed for split-screen cooperative multiplayer, which means that it must be played with another player through either local or online play. In the game, players control Leo and Vincent, two convicted prisoners who must break out of prison and stay on the run from authorities. As the story of both protagonists is told simultaneously, their progress may not be synchronized, which may result in one player being able to control their character, while another is watching a cutscene. Players need to cooperate with each other in order to progress, and each situation can be approached differently, with both characters taking different roles.", "A Way Out", null, null, null, null, null, null, null, null, "A Way Out is an action-adventure game developed by Hazelight Studios and published by Electronic Arts under their EA Originals program. It is the second video game to be directed by Josef Fares after Brothers: A Tale of Two Sons. The game has no single-player option: it is only playable in either online or local split screen co-op between two players.", null, 2, null, 155m, null, 0 },
                    { 13, "FIFA 19", 1, 0m, "C:\\Users\\semih\\source\\repos/GameStation/Pictures/ProductPictures/Steam/fifa19_logo.png", "FIFA serisinin 26. oyunudur. FIFA 18 oyununda da olduğu gibi oyunun standart sürümünün kapağında Cristiano Ronaldo yer almıştır. Ancak, İspanyol kulübü Real Madrid'den İtalyan ekibi Juventus'a beklenmedik transferi sonrası kapak resmi yenilenmiştir. Ayrıca Şampiyonlar sürümünün kapağında Neymar yer almıştır. Şubat 2019'da düzenlenen standart sürümün kapağında Neymar, Kevin De Bruyne ve Paulo Dybala'ya yer verilmiştir.", "FIFA 19", null, null, null, null, null, null, null, null, "FIFA 19, EA Vancouver tarafından geliştirilen ve Electronic Arts şirketinin yayımcılığını yaptığı spor simülasyon video oyunu olarak sunulan FIFA serisi. 6 Haziran 2018 tarihinde yapılan E3 2018 basın konferansında, oyunun 28 Eylül 2018 tarihinde PlayStation 3, PlayStation 4, Xbox 360, Xbox One, Nintendo Switch ve Microsoft Windows platformlarında çıkmış olacağı açıklanmıştır.", null, 2, null, 245m, null, 0 },
                    { 12, "Battlefield 4", 1, 0m, "C:\\Users\\semih\\source\\repos/GameStation/Pictures/ProductPictures/Steam/battlefield4_logo.png", "Oyunun çerçeveleri Battlefield 3’e göre genel olarak aynı kaldı. Çerçevenin sol altında harita ve pusula, ve görevle ilgili hedefler; sağ altında ise silah bilgileri yer almaktadır. Mini harita ve oyunun ana menüsü, 3 önemli şeyi belirtmektedir. Bunlar, dostların mavi ile gösterilmesi, ekip arkadaşlarının yeşil ile gösterilmesi, düşmanların ise turuncu ya da kırmızı ile gösterilmesidir. Oyunda Battlefield 3’te olduğu gibi bazı silahların iki çeşit atış modu vardır; bunlardan biri tekli atışken, diğeri de çoklu atış modudur.", "Battlefield 4", null, null, null, null, null, null, null, null, "Battlefield 4 bir birinci şahıs nişancı video oyunudur ve İsveç’teki EA Digital Illusions CE (DICE) tarafından yapılıp Electronic Arts tarafından yayınlanmıştır. Oyun 2011’de çıkan Battlefield 3’ün devamıdır.", null, 2, null, 100m, null, 0 },
                    { 11, "The Sims 4", 5, 0m, "C:\\Users\\semih\\source\\repos/GameStation/Pictures/ProductPictures/Steam/sims4_logo.png", "The Sims 4, serinin önceki oyunları gibi yaşam simülasyonu oyunudur. Oyuncular bir Sim karakteri yaratırlar ve oyunda farklı Sim kişiliklerini keşfederek oyuna yön verirler. Simler daha önceki oyunlardan farklı olarak aynı anda iki fiziksel eylemi gerçekleştirebilir. Ayrıca Simlerin modları da oyun akışını değiştirebilir. Örneğin kızgın ya da heyecanlı bir Sim, verilen bir görevi daha hızlı yapar.", "The Sims 4", null, null, null, null, null, null, null, null, "The Sims 4, Maxis ve The Sims Studio tarafından geliştirilen ve Electronic Arts tarafından yayınlanan 2014 tarihli yaşam simülasyonu oyunudur. Electronic Arts, 6 Mayıs 2013 tarihinde bir duyuru yaparak oyunu 2014 yılında piyasaya süreceğini ve Microsoft Windows, Mac OS X platformlarında oynanacağını bildirdi.", null, 2, null, 200m, null, 0 },
                    { 19, "Crysis 3", 1, 0m, "C:\\Users\\semih\\source\\repos/GameStation/Pictures/ProductPictures/Steam/crysis3_logo.png", "Crysis 3, Crysis 2'den 24 yıl sonrasında yani 2047 yılında ve bir kez daha New York şehrinde geçiyor. İkinci oyunda gerçekleşen büyük savaşın ardından Prophet, Crynet tarafından hapse atılır ve Cephler (uzaylılar) tarafından dünya üzerinde o ana kadar görülmemiş en büyük işgal gerçekleştirilir. Ayrıca New York, Crysis 2'nin sonundaki büyük patlamadan sonra sular altında kalır ve şehir ormanımsı bir hal alır. Bu olaylardan sonra şehrin bir kısmı Cell Corporation tarafından Nanodome adı verilen dev bir fanusun içine alınır. Nanodome içerisindeki alana ise 'New York City Liberty Dome' adı verilir. Cell Corporation bu fanusun amacının karantina bölgesi oluşturmak ve insanları uzaylılardan korumak olduğunu söylese de, Prophet, Cell Corporation'ın Nanodome içerisinde dünyayı ele geçirmek için teknoloji geliştirdiğini öngörür. Crysis 3'te ana karakter Prophet olacak. Prophet bu defa intikam için savaşacak.", "Crysis 3", null, null, null, null, null, null, null, null, "Crysis 3, Crytek tarafından geliştirilmiş, Electronic Arts tarafından ise yayımcılığı yapılmış olan bilim kurgu türü video oyunudur. Crysis 3 serinin diğer oyunları gibi Türkçe alt yazı ve seslendirme içermektedir.", null, 2, null, 54m, null, 0 },
                    { 10, "Half-Life", 1, 0m, "C:\\Users\\semih\\source\\repos/GameStation/Pictures/ProductPictures/Steam/half-life_logo.png", "Oyuncu, bir ışınlanma deneyinin ters gitmesi sonucu Xen olarak bilinen başka bir boyuttan Black Mesa Araştırma Tesisine ışınlanan uzaylılardan savaşarak ve bulmacaları çözerek tesisden kaçmaya çalışan Dr. Gordon Freeman rolünü üstleniyor. Zamanın diğer oyunlarına göre Half-Life'da ara sahneler yoktur. Oyuncu her zaman Freeman'nı kontrol ediyor. Her zaman onun gözünden görüyor. Valve'nin kurucularından olan Gabe Newell ''ekip olarak oyunun sadece ateş etmeye meyilli bir oyundan çok daha fazla olmasını istedik.'' demiştir.", "Half-Life", null, null, null, null, null, null, null, null, "Half-Life, 1998 yılında Sierra Studios tarafından yayımlanan ve Valve tarafında üretilen birinci şahıs nişancı bilim-kurgu video oyunudur. Oyun, serinin ilk oyunu olmakla beraber aynı zamanda Valve'nin ürettiği ilk oyundur.", null, 1, null, 18m, null, 0 },
                    { 8, "Fallout 4", 3, 0m, "C:\\Users\\semih\\source\\repos/GameStation/Pictures/ProductPictures/Steam/fallout4_logo.png", "Fallout 4, oynanış olarak Fallout 3'e benzer olacak, önceki oyunda olduğu gibi birinci görüş şahısı ya da üçüncü görüş şahısı ile oynanabilecek. Yeni özellik olarak ayrı parçalardan oluşabilecek zırh, ayrıntılı crafting sistemi, dinamik konuşma sistemi sayılabilir. Yeni crafting sistemiyle oyundaki bütün eşyalar belli bir parça için istenilen olabilecek. Dogmeat bu oyunda ölümsüz olacak. Oyuncular haritada isteği zaman istediği yere gidebilecek.Oyunda 50 temel silah çeşidi bulunacak ve çeşitli modifikasyonlar yapılarak 700'ün üzerinde farklı tarz silah oluşturabilecek. Power Armor, jetpack gibi çeşitli eşyalarla güçlendirilebilecek. Oyuna gelen yeni bir özellik ise kendi evini baştan aşağıya yenileyip değiştirebilmektir. Oyuncu, oyundaki eşyaları evi için kullanabilecek. Tüccarlar, şehrin birçok yerinde olup ev için malzeme satacak. Oyuncular, kendi evleri için taret ve tuzak gibi çeşitli savunma araçları inşa edebilecek.", "Fallout 4", null, null, null, null, null, null, null, null, "Fallout 4, Bethesda Game Studios'un geliştiriciliğini yaptığı ve Bethesda Softworks'ün yayımcılığını yaptığı açık dünya Aksiyon rol yapma oyunudur. Fallout serisinin beşinci büyük oyunudur ve Microsoft Windows, PlayStation 4 ve Xbox One için 10 Kasım 2015'te yayımlanmıştır.", null, 1, null, 133m, null, 0 },
                    { 7, "The Elder Scrolls V: Skyrim", 3, 0m, "C:\\Users\\semih\\source\\repos/GameStation/Pictures/ProductPictures/Steam/skyrim_logo.png", "Elder Scrolls serisinin geleneksel açık uçlu oynanış özelliği Skyrim'de de devam ettirildi. Oyuncu at üstünde veya yürüyerek ülkeyi dolaşabilir ve şehir, kasaba, zindan gibi yerler bir kez keşfedildikten sonra bu bölgelere hızlı seyahat edebilir. Görevler oyuncuya NPC'ler tarafından ya da Radyant Hikâye sistemi aracılığıyla verilir. Radyant Hikâye sistemi bir nevi oyuncunun yaptığı tüm seçimleri kaydeder ve oyundaki bazı görevlerin akışını değiştirir. Bu sistem, görev olarak, keşfedilmemiş yeni zindanlar oluşturur ve oyuncunun ülkeyle olan etkileşiminde değişiklikler yapar.", "The Elder Scrolls V: Skyrim", null, null, null, null, null, null, null, null, "The Elder Scrolls V: Skyrim (yaygın olarak bilinen ismi Skyrim), Bethesda Game Studios tarafından geliştirilip Bethesda Softworks tarafından piyasaya sürülen serbest dünya tipi aksiyon RPG video oyunudur. The Elder Scrolls serisinin The Elder Scrolls IV: Oblivion'dan sonra gelen toplamda beşinci uyarlamasıdır.", null, 1, null, 30m, null, 0 },
                    { 6, "Hearts Of Iron 4", 4, 0m, "C:\\Users\\semih\\source\\repos/GameStation/Pictures/ProductPictures/Steam/hoi4_logo.png", "Oyuncular 1936 ve 1939 olmak üzere iki başlangıç tarihinden birini seçip ülkeleriyle savaşta zafer almaya çalışabilir. Oyun 2014 Ocak ayında duyuruldu. 2015 senesinin ilk çeyreğinde çıkması planlanıyordu ancak sonradan 2015'in ikinci çeyreğine ertelendi.[1] Johan Andersson oyunun istenilen seviyede olmadığını belirtip daha ileri bir tarihte çıkacağını açıkladı. 15 Mart 2016'da oyunun 6 Haziran tarihinde çıkacağı duyuruldu ve o tarihte çıktı.", "Hearts Of Iron 4", null, null, null, null, null, null, null, null, "Hearts of Iron IV Paradox Development Studio tarafından geliştirilen ve Paradox Interactive tarafından yayımlanan strateji oyunu. Hearts of Iron III'ün devam oyunudur, diğer Hearts of Iron serisi oyunları gibi II. Dünya Savaşı'na odaklanır.", null, 1, null, 60m, null, 0 },
                    { 5, "Europa Universalis 4", 4, 0m, "C:\\Users\\semih\\source\\repos/GameStation/Pictures/ProductPictures/Steam/eu4_logo.png", "Oyunun temel ilkeleri dizinin daha önceki oyunlarına benzer. Oyuncu tek oyuncu olarak yapay zekaya karşı, çok oyuncu olarak diğer insanlara veya beraber yapay zekâya karşı oynayabilir. Bir devletin denetimini ele alarak diplomasi, politika ve askeri olanakları kullanmak ve diğer devletlere karşı galip olmak hedeflenir. Oyuncu birçok alternatif araç ile büyümeye çalışır. Oyunun zaman dilimi 1444 ila 1821 arasındadır, bu tarihler içerisinde oyuna oyunda yer alan istendiği ülkeyle, istendiği tarihte başlanabilir.", "Europa Universalis 4", null, null, null, null, null, null, null, null, "Europa Universalis IV, Paradox Development Studio tarafından geliştirilmiş ve Paradox Interactive tarafından yayımlanmış strateji oyunu. Europa Universalis serisinin 4. üyesidir.EUIV ya da EU4 olarak da bilinir.", null, 1, null, 60m, null, 0 },
                    { 4, "Crusader Kings 2", 4, 0m, "C:\\Users\\semih\\source\\repos/GameStation/Pictures/ProductPictures/Steam/ck2_logo.png", "The game is a dynasty simulator where the player controls a Medieval dynasty from 1066 to 1453, though the DLC The Old Gods and Charlemagne allow for earlier start dates of 867 and 769, respectively. Through the strategic use of war, marriages and assassinations among many other things, the player works to achieve success for their dynasty.", "Crusader Kings 2", null, null, null, null, null, null, null, null, "Crusader Kings II is a grand strategy game set in the Middle Ages, developed by Paradox Development Studio and published by Paradox Interactive as a sequel to Crusader Kings.", null, 1, null, 28m, null, 0 },
                    { 3, "Grand Theft Auto V", 3, 0m, "C:\\Users\\semih\\source\\repos/GameStation/Pictures/ProductPictures/Steam/gtav_logo.png", "Oyunda Michael, Franklin ve Trevor isminde üç farklı karakter mevcuttur. Oyundaki üç karakterden her birinin farklı alanlarda farklı yetenekleri ve güçleri vardır. Örneğin, Trevor eski bir savaş pilotu olduğu için uçak, jet, helikopter ve diğer hava araçlarını kullanma konusunda diğer karakterlerden daha iyidir. Michael ise eski bir banka soyguncusu olduğundan silah kullanma konusunda diğerlerinden daha iyidir. Franklin ise araç hırsızı olduğundan otomobil ve motosiklet sürme konusunda diğerlerine göre çok daha ustadır. Oyuncular karakterler arasında geçiş yapabilme imkanına sahiplerdir.", "Grand Theft Auto V", null, null, null, null, null, null, null, null, "Grand Theft Auto V (kısaca GTA V veya GTA 5), Rockstar North tarafından geliştirilen ve Rockstar Games tarafından yayımlanan açık uçlu aksiyon-macera tarzı video oyunu. Grand Theft Auto serisinin beşinci oyunudur. 17 Eylül 2013 tarihinde PlayStation 3 ve Xbox 360 için piyasaya çıkmıştır.", null, 1, null, 160m, null, 0 },
                    { 2, "Mount & Blade II: Bannerlord", 1, 0m, "C:\\Users\\semih\\source\\repos/GameStation/Pictures/ProductPictures/Steam/bannerlord_logo.png", "27 Eylül 2012'de bir Türk şirketi olan TaleWords tarafından duyurulmuştur. Oyunun Grafikleri daha iyi gölgeleme ve daha yüksek detaylı modellerle önceki oyun olan Mount & Blade: Warband'a göre belirgin bir şekilde daha iyi hâle getirilmiştir. Karakter animasyonları hareket yakalama (motion capture) teknolojisi kullanılarak oluşturulmuş ve yüz animasyonları da canlandırılan duygularla iyileştirilerek güncelleneceği söylendi.", "Bannerlord", null, null, null, null, null, null, null, null, "Mount & Blade II: Bannerlord, Orta Çağ temalı bir rol yapma oyunu olan Mount & Blade serisinin bir oyunudur. Oyun, Türk firması TaleWorlds tarafından geliştiştirilmektedir. Oyun Steam'de Ekim 2016'da çıkmıştır. Fakat oyun için bir indirme imkanı sunulmamıştır. Gamescom 2019'da oyunun erken erişim tarihi verilmiş. Ayrıca bu çıkış tarihi Mount & Blade:Warband'ın 10. yılına denk gelmiş olacak.", null, 1, null, 160m, null, 0 },
                    { 1, "Rimworld", 4, 0m, "C:\\Users\\semih\\source\\repos/GameStation/Pictures/ProductPictures/Steam/rimworld_logo.png", "The futuristic plot originally revolved around three characters being stranded on a planet located in the frontiers of known space (a 'rim world'), where their space liner crashed. The game is set in a universe where faster-than-light travel and superluminal communication are, so far, impossible, making large galactic empires inherently unfeasible. With its release on Steam the game came with the addition, among other things, of a scenario editor, allowing users to choose and modify different starting plots, with different numbers of characters, starting items and map effects available; however, the location of these plots still remained the same, that is, still on a 'rim world'", "RimWorld", null, null, null, null, null, null, null, null, "RimWorld is a top-down construction and management simulation video game by Montreal-based developer Ludeon Studios. Originally called Eclipse Colony, it was initially released as a Kickstarter crowdfunding project in early access for Microsoft Windows, macOS, and Linux in November 2013, and was officially released on October 17, 2018.", null, 1, null, 50m, null, 0 },
                    { 9, "Counter-Strike: Global Offensive", 1, 0m, "C:\\Users\\semih\\source\\repos/GameStation/Pictures/ProductPictures/Steam/csgo_logo.png", "Serinin önceki oyunları gibi Global Offensive, görev tabanlı birçok oyunculu birinci şahıs nişancı oyunudur. Oyuncular ilk önce görevleri tamamlamak veya düşman takımı yok etmek için teröristler (Terrorists) veya terörle mücadele ekibi (Counter-Terrorists) takımlarından birini seçerler. Örneğin, yıkım haritalarında (de_) teröristler bomba kurmaya çalışırken, terörle mücadele bombanın kurulmasını engellemeye veya kurulmuş bombayı imha etmeye çalışır. Global Offensive'e önceki oyunlardaki görevlere ek olarak silah yarışı (arms race) denilen bir mod eklenmiş, bu modla birlikte klasik Counter-Strike haritalarının yanında farklı haritalar da oyuna dahil edilmiştir.", "Counter-Strike: Global Offensive", null, null, null, null, null, null, null, null, "Counter-Strike: Global Offensive (kısaca CS: GO), Valve ve Hidden Path Entertainment tarafından geliştirilen çevrim içi bir birinci şahıs nişancı türünde aksiyon oyunudur.", null, 1, null, 20m, null, 0 },
                    { 20, "Star Wars Battlefront", 1, 0m, "C:\\Users\\semih\\source\\repos/GameStation/Pictures/ProductPictures/Steam/starwars-battlefron_logo.png", "Oyunda hikâye modu bulunmamakta ve genel olarak çok oyunculu bölüme odaklı. Ama oyuncuların offline olarak, tek başlarına oynayabilecekleri görevler de bulunuyor. Ayrıca oyuncular bu görevleri arkadaşlarıyla birlikte Co-op (kooperatif) olarak da oynayabilirler. Co-op (kooperatif) görevler konsollarda split screen olarak oynanabilir. Oyun hem birinci şahıs nişancı hem de üçüncü şahıs nişancı olarak oynanabiliyor. Oyuncular Rebel Alliance (Asi Birliği) ya da Stormtrooper taraflarından birini seçerek birbirleriyle savaşıyorlar. Ayrıca Darth Vader ve Boba Fett gibi Star Wars evreninin önemli karakterleri de oynanabiliyor. Oyuncular karakterlerini özelleştirebilirler. Hoth, Endor, Tatooine, Sullust gezegenlerinde geçecek olan oyunda 12 tane harita bulunuyor. Haritalar 40 oyuncuyu destekliyor. Oyunda X-Wing, Millennium Falcon, TIE Fighters ve AT-ST Walker gibi oyuncuların kullanabileceği birçok araç bulunuyor.", "Star Wars Battlefront", null, null, null, null, null, null, null, null, "Star Wars: Battlefront, DICE tarafından geliştirilen, Electronic Arts'ın ise yayımcılığı yaptığı video oyunudur.", null, 2, null, 100m, null, 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_CustomerID",
                table: "OrderDetails",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductID",
                table: "OrderDetails",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderDetailID",
                table: "Orders",
                column: "OrderDetailID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PaymentID",
                table: "Orders",
                column: "PaymentID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ShippingDetailID",
                table: "Orders",
                column: "ShippingDetailID");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_PaymentTypeID",
                table: "Payments",
                column: "PaymentTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SupplierID",
                table: "Products",
                column: "SupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_RecentlyViews_CustomerID",
                table: "RecentlyViews",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_RecentlyViews_ProductID",
                table: "RecentlyViews",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_CustomerID",
                table: "Reviews",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ProductID",
                table: "Reviews",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Wishlists_CustomerID",
                table: "Wishlists",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Wishlists_ProductID",
                table: "Wishlists",
                column: "ProductID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "RecentlyViews");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Wishlists");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "ShippingDetails");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "PaymentTypes");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Suppliers");
        }
    }
}
