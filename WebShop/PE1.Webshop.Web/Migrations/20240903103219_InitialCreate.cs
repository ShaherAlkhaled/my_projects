using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PE1.Webshop.Web.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Properties",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImageFileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: true),
                    CatergoryId = table.Column<long>(type: "bigint", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CatergoryId",
                        column: x => x.CatergoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductProperty",
                columns: table => new
                {
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    PropertyId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductProperty", x => new { x.ProductId, x.PropertyId });
                    table.ForeignKey(
                        name: "FK_ProductProperty_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductProperty_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DateCreated", "DateModified", "Name" },
                values: new object[,]
                {
                    { 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Computer" },
                    { 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SmartPhone" },
                    { 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TV" },
                    { 4L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Games" },
                    { 5L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Large Electric" }
                });

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "Id", "DateCreated", "DateModified", "Name" },
                values: new object[,]
                {
                    { 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Desktop" },
                    { 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Student" },
                    { 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Budget" },
                    { 4L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Speed" },
                    { 5L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Family" },
                    { 6L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gaming" },
                    { 7L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Graphics card" },
                    { 8L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Luxury" },
                    { 9L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "kitchen" },
                    { 10L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wash" },
                    { 11L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cooling" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "CatergoryId", "DateCreated", "DateModified", "ImageFileName", "Model", "Name", "Price", "Rating" },
                values: new object[,]
                {
                    { 1L, "MSI", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gaming-laptop-GE63.gif", "GE63", "GAMING LAPTOP", 1549m, 5 },
                    { 25L, "LG", 5L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "LG-Wasmachine.png", "VOORLADER E (LC1R7N2)", "WASMACHINE", 998m, 5 },
                    { 24L, "SAMSUNG", 5L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SAMSUNG-Wasmachine.png", "VOORLADER A (WW90T684ALE/S2)", "WASMACHINE", 749m, 4 },
                    { 23L, "BOSCH", 5L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BOSCH-Wasmachine.png", "VOORLADER C (WAX32MM0FG)", "WASMACHINE", 989m, 4 },
                    { 22L, "SAMSUNG", 5L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "KoelingSamsung.jpg", "RS68A8831B1 SPACEMAX™", "AMERIKAANSE KOELKAST", 1298m, 5 },
                    { 21L, "LG", 5L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "LG-Amerikaanse-koeling.png", "E-(GSXV90MCDE)", "AMERIKAANSE KOELKAST", 2599m, 5 },
                    { 20L, "BOSCH", 5L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BOSCH-Koel.png", "VRIESCOMBINATIE-E-(KGN39VLEA)", "KOELKAST", 599m, 3 },
                    { 19L, "SONY", 4L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PlayStation5.png", "DIGITAL EDITION", "PLAYSTATION 5", 399m, 5 },
                    { 18L, "SONY", 4L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Palystation4.png", "PRO-1TB", "PLAYSTATION 4", 250m, 3 },
                    { 17L, "SONY", 4L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "playstation3.jpg", "SLIM-320GB", "PLAYSTATION 3", 109m, 1 },
                    { 16L, "SAMSUNG", 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "43TU7020.png", "43TU7020", "CRYSTAL UHD", 439m, 2 },
                    { 15L, "SAMSUNG", 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "QE65QN95AATXXN.jpg", "QE65QN95AATXXN", "TV NEO QLED 4K 65 INCH", 1389m, 5 },
                    { 26L, "WHIRLPOOL", 5L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "WHIRLPOOL-Wasmachine.png", "VOORLADER D (FFSBE 7438 WE F)", "WASMACHINE", 299m, 1 },
                    { 14L, "SAMSUNG", 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UE40T5300AWXXN.jpg", "UE40T5300AWXXN", "TV LED", 399m, 3 },
                    { 12L, "APPLE", 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "APPLE-iPhone-13-Pro-5G-1-TB.png", "13 PRO 5G 1 TB GRAPHITE", "IPHONE", 1795m, 5 },
                    { 11L, "APPLE", 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "APPLE-iPhone-13-Pro-Max-5G-1-TB-Silver.png", "13 PRO MAX 5G 1 TB SILVER", "IPHONE", 1893m, 5 },
                    { 10L, "SAMSUNG", 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "S21-Ultra.jpg", "S21 ULTRA", "GALAXY", 1099m, 5 },
                    { 9L, "SAMSUNG", 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "S21.jpg", "S21", "GALAXY", 700m, 5 },
                    { 8L, "SAMSUNG", 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "S20.jpg", "S20", "GALAXY", 600m, 4 },
                    { 7L, "LENVOVO", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "LENOVO-Laptop-IdeaPad-3.png", "15ALC6 AMD RYZEN 5 5500U (82KU00NLMB)", "LAPTOP IDEAPAD 3", 599m, 4 },
                    { 6L, "LENOVO", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "LENOVO-Laptop-Yoga-Slim-9-14ITL5-Intel-Core-i7.png", "YOGA SLIM 9 14ITL5 INTEL CORE I7-1065G7", "GAMING LAPTOP", 1999m, 8 },
                    { 5L, "HP", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "HP-Laptop-15-dw1050nb-Intel-Pentium.png", "15-DW1050NB INTEL PENTIUM GOLD 6405U (2B0C1EA)", "LAPTOP", 499m, 2 },
                    { 4L, "HP", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "HP-Gaming-Laptop-OMEN-15-ek1021nb-Intel-Core-i7.png", "OMEN 15-EK1021NB INTEL CORE I7-10870H", "GAMING LAPTOP", 2199m, 5 },
                    { 3L, "MSI", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MSI-Gaming-Laptop-GF63.png", "GF63", "GAMING LAPTOP", 995m, 4 },
                    { 2L, "ASUS", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gaming-laptop-GL504GM.jpg", "GL504GM", "GAMING LAPTOP", 1389m, 4 },
                    { 13L, "APPLE", 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "APPLE-iPhone-SE-64-GB.png", "SE 64 GB 2ND GEN. ZWART (MX9R2ZD/A)", "IPHONE", 439m, 5 },
                    { 27L, "AEG", 5L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AEG-Wasmachine.png", "VOORLADER PROSTEAM C (L7FE86PROS)", "WASMACHINE", 699m, 5 }
                });

            migrationBuilder.InsertData(
                table: "ProductProperty",
                columns: new[] { "ProductId", "PropertyId" },
                values: new object[,]
                {
                    { 1L, 1L },
                    { 20L, 5L },
                    { 20L, 3L },
                    { 19L, 8L },
                    { 19L, 6L },
                    { 19L, 5L },
                    { 19L, 4L },
                    { 18L, 6L },
                    { 18L, 5L },
                    { 18L, 4L },
                    { 17L, 6L },
                    { 17L, 5L },
                    { 17L, 4L },
                    { 16L, 6L },
                    { 16L, 5L },
                    { 16L, 3L },
                    { 16L, 1L },
                    { 15L, 8L },
                    { 15L, 6L },
                    { 15L, 5L },
                    { 15L, 3L },
                    { 15L, 1L },
                    { 14L, 8L },
                    { 14L, 6L },
                    { 14L, 5L },
                    { 14L, 3L },
                    { 14L, 1L },
                    { 13L, 6L },
                    { 13L, 4L },
                    { 13L, 3L },
                    { 20L, 9L },
                    { 12L, 8L },
                    { 20L, 11L },
                    { 21L, 5L },
                    { 27L, 5L },
                    { 27L, 4L },
                    { 27L, 3L },
                    { 26L, 10L },
                    { 26L, 9L },
                    { 26L, 5L },
                    { 26L, 4L },
                    { 26L, 3L }
                });

            migrationBuilder.InsertData(
                table: "ProductProperty",
                columns: new[] { "ProductId", "PropertyId" },
                values: new object[,]
                {
                    { 25L, 10L },
                    { 25L, 9L },
                    { 25L, 5L },
                    { 25L, 4L },
                    { 25L, 3L },
                    { 24L, 10L },
                    { 24L, 9L },
                    { 24L, 5L },
                    { 24L, 4L },
                    { 24L, 3L },
                    { 23L, 10L },
                    { 23L, 9L },
                    { 23L, 5L },
                    { 23L, 4L },
                    { 23L, 3L },
                    { 22L, 11L },
                    { 22L, 9L },
                    { 22L, 5L },
                    { 22L, 3L },
                    { 21L, 11L },
                    { 21L, 9L },
                    { 21L, 3L },
                    { 27L, 9L },
                    { 12L, 6L },
                    { 12L, 3L },
                    { 4L, 7L },
                    { 4L, 6L },
                    { 4L, 5L },
                    { 4L, 4L },
                    { 4L, 3L },
                    { 4L, 2L },
                    { 4L, 1L },
                    { 3L, 7L },
                    { 3L, 6L },
                    { 3L, 5L },
                    { 3L, 4L },
                    { 3L, 3L },
                    { 3L, 2L },
                    { 3L, 1L },
                    { 2L, 8L },
                    { 2L, 7L },
                    { 2L, 6L }
                });

            migrationBuilder.InsertData(
                table: "ProductProperty",
                columns: new[] { "ProductId", "PropertyId" },
                values: new object[,]
                {
                    { 2L, 5L },
                    { 2L, 4L },
                    { 2L, 3L },
                    { 2L, 2L },
                    { 2L, 1L },
                    { 1L, 8L },
                    { 1L, 7L },
                    { 1L, 6L },
                    { 1L, 5L },
                    { 1L, 4L },
                    { 1L, 3L },
                    { 1L, 2L },
                    { 4L, 8L },
                    { 12L, 4L },
                    { 5L, 1L },
                    { 5L, 4L },
                    { 11L, 8L },
                    { 11L, 6L },
                    { 11L, 4L },
                    { 11L, 3L },
                    { 10L, 8L },
                    { 10L, 6L },
                    { 10L, 4L },
                    { 10L, 3L },
                    { 9L, 6L },
                    { 9L, 4L },
                    { 9L, 3L },
                    { 8L, 6L },
                    { 8L, 4L },
                    { 8L, 3L },
                    { 7L, 7L },
                    { 7L, 5L },
                    { 7L, 4L },
                    { 7L, 2L },
                    { 7L, 1L },
                    { 6L, 8L },
                    { 6L, 7L },
                    { 6L, 6L },
                    { 6L, 5L },
                    { 6L, 4L },
                    { 6L, 3L },
                    { 6L, 2L }
                });

            migrationBuilder.InsertData(
                table: "ProductProperty",
                columns: new[] { "ProductId", "PropertyId" },
                values: new object[,]
                {
                    { 6L, 1L },
                    { 5L, 7L },
                    { 5L, 5L },
                    { 5L, 2L },
                    { 27L, 10L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductProperty_PropertyId",
                table: "ProductProperty",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CatergoryId",
                table: "Products",
                column: "CatergoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductProperty");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Properties");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
