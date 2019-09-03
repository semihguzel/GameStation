using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GameStation.DAL.Migrations
{
    public partial class DbCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryName = table.Column<string>(maxLength: 50, nullable: false),
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
                name: "Customers",
                columns: table => new
                {
                    CustomerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    UserName = table.Column<string>(maxLength: 50, nullable: false),
                    Password = table.Column<string>(maxLength: 50, nullable: false),
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
                    Phone2 = table.Column<string>(maxLength: 20, nullable: true),
                    Mobile1 = table.Column<string>(maxLength: 20, nullable: true),
                    Mobile2 = table.Column<string>(maxLength: 20, nullable: true),
                    Address = table.Column<string>(maxLength: 200, nullable: true),
                    Picture = table.Column<string>(maxLength: 400, nullable: true),
                    Status = table.Column<string>(maxLength: 20, nullable: true),
                    LastLogin = table.Column<DateTime>(type: "date", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "date", nullable: false),
                    Notes = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
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
                name: "SubCategories",
                columns: table => new
                {
                    SubCategoryID = table.Column<int>(nullable: false),
                    CategoryID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: true),
                    Picture1 = table.Column<string>(maxLength: 500, nullable: true),
                    Picture2 = table.Column<string>(maxLength: 500, nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.SubCategoryID);
                    table.ForeignKey(
                        name: "FK_SubCategories_Categories_SubCategoryID",
                        column: x => x.SubCategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
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
                    SubCategoryID = table.Column<int>(nullable: false),
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
                    ShortDescription = table.Column<string>(maxLength: 300, nullable: false),
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
                        name: "FK_Products_SubCategories_SubCategoryID",
                        column: x => x.SubCategoryID,
                        principalTable: "SubCategories",
                        principalColumn: "SubCategoryID",
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
                    CustomerID = table.Column<int>(nullable: false),
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
                    CustomerID = table.Column<int>(nullable: false),
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
                    CustomerID = table.Column<int>(nullable: false),
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
                    CustomerID = table.Column<int>(nullable: false),
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
                name: "IX_Products_SubCategoryID",
                table: "Products",
                column: "SubCategoryID");

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
                name: "Orders");

            migrationBuilder.DropTable(
                name: "RecentlyViews");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Wishlists");

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
                name: "SubCategories");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
