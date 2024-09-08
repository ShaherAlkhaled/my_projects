using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Imi.Project.Api.Infrastructure.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HasApprovedTermsAndConditions = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastEditedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FishProcessings",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastEditedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FishProcessings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OriginCountries",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastEditedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OriginCountries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "Fishs",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UrlImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxWeight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MinWeigth = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DateOfArrival = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OriginCountryId = table.Column<long>(type: "bigint", nullable: false),
                    CategoryId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastEditedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fishs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fishs_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Fishs_OriginCountries_OriginCountryId",
                        column: x => x.OriginCountryId,
                        principalTable: "OriginCountries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FishFishProcessing",
                columns: table => new
                {
                    FishProssingsId = table.Column<long>(type: "bigint", nullable: false),
                    FishsId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FishFishProcessing", x => new { x.FishProssingsId, x.FishsId });
                    table.ForeignKey(
                        name: "FK_FishFishProcessing_FishProcessings_FishProssingsId",
                        column: x => x.FishProssingsId,
                        principalTable: "FishProcessings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FishFishProcessing_Fishs_FishsId",
                        column: x => x.FishsId,
                        principalTable: "Fishs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "00000000-0000-0000-0000-000000000002", "c8554266-b897-4519-9aeb-a9283053fc58", "User", "USER" },
                    { "00000000-0000-0000-0000-000000000001", "1D6B7B4D-E325-498F-8A57-3637783370E6", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "HasApprovedTermsAndConditions", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "00000000-0000-0000-0000-000000000001", 0, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c8554266-b401-4519-9aeb-a9283053fc58", "admin@imi.be", true, false, true, null, "ADMIN@IMI.BE", "IMIADMIN", "AQAAAAEAACcQAAAAEOyzSkUJtHgOvYU2HtWfS8wnnDwNkVBPI2Z1HqsMHsTyuzNq2Fl0eSn4krMsn6R+Og==", null, false, "VVPCRDAS3MJWQD5CSW2GWPRADBXEZINA", false, "ImiAdmin" },
                    { "00000000-0000-0000-0000-000000000003", 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c8554266-b897-4519-9aeb-a9283053fc58", "refuser@imi.be", true, false, false, null, "REFUSER@IMI.BE", "IMIREFUSER", "AQAAAAEAACcQAAAAEDFpM1yKDzydL6+b+VdtnnxNkIaDxX1qWsa9EiHc0mhaW8RFviN0Y25YOWqe1xKeYQ==", null, false, "VVPCRDAS3MJ7895CSW2GWPRADBXEZINA", false, "ImiRefuser" },
                    { "00000000-0000-0000-0000-000000000002", 0, new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c8554266-b897-4519-9aeb-a9283053fc58", "user@imi.be", true, true, false, null, "USER@IMI.BE", "IMIUSER", "AQAAAAEAACcQAAAAEKwBq58r8xssBQWyxRaOFnU7rXM1Bd7j5ueWJKyZlc86shy0Zi3t9ZvLq7KqlpT+Pw==", null, false, "VVPCRDAS3MJ7895CSW2GWPRADBXEZINA", false, "ImiUser" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedOn", "LastEditedOn", "Name" },
                values: new object[,]
                {
                    { 12L, new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2233), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2234), "Diverse" },
                    { 11L, new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2232), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2232), "Kreeft" },
                    { 10L, new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2230), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2231), "Wilde vis" },
                    { 8L, new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2227), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2227), "Fileren Vis" },
                    { 9L, new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2228), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2229), "Gekweekte vis" },
                    { 6L, new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2224), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2224), "Schaal & Weekdieren" },
                    { 5L, new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2222), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2223), "Mosselen" },
                    { 4L, new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2220), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2221), "Rondvis" },
                    { 3L, new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2218), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2219), "Platvis" },
                    { 2L, new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2217), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2217), "Diepvries" },
                    { 7L, new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2225), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2226), "Gerookte & gemarineerde vis" },
                    { 1L, new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2213), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2215), "Verse vis" }
                });

            migrationBuilder.InsertData(
                table: "FishProcessings",
                columns: new[] { "Id", "CreatedOn", "LastEditedOn", "Name" },
                values: new object[,]
                {
                    { 8L, new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(3173), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(3173), "Portjes-Snijden" },
                    { 11L, new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(3177), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(3178), "Koken" },
                    { 10L, new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(3176), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(3176), "Moten-snijden" },
                    { 9L, new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(3174), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(3175), "Mappen" },
                    { 6L, new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(3170), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(3170), "ZonderVel" },
                    { 5L, new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(3168), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(3169), "Haas" },
                    { 3L, new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(3165), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(3165), "OntSchubben" },
                    { 2L, new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(3163), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(3164), "Gutten" },
                    { 1L, new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(3159), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(3161), "Fileren" },
                    { 7L, new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(3171), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(3172), "Graatloos" },
                    { 4L, new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(3166), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(3167), "Kuisen" }
                });

            migrationBuilder.InsertData(
                table: "OriginCountries",
                columns: new[] { "Id", "CreatedOn", "LastEditedOn", "Name" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2727), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2729), "België" },
                    { 2L, new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2731), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2732), "Nederland" },
                    { 3L, new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2733), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2733), "Turkije" },
                    { 4L, new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2734), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2735), "Denemarken" },
                    { 5L, new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2736), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2737), "Noorwegen" },
                    { 6L, new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2738), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2738), "Frankrijk" },
                    { 7L, new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2739), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2740), "Zweden" },
                    { 8L, new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2741), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2741), "China" },
                    { 9L, new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2742), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2743), "Canada" },
                    { 10L, new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2744), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2745), "Filipijnen" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[,]
                {
                    { 1, "HasApprovedTermsAndConditions", "True", "00000000-0000-0000-0000-000000000002" },
                    { 2, "HasApprovedTermsAndConditions", "False", "00000000-0000-0000-0000-000000000003" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "00000000-0000-0000-0000-000000000001", "00000000-0000-0000-0000-000000000001" },
                    { "00000000-0000-0000-0000-000000000002", "00000000-0000-0000-0000-000000000002" },
                    { "00000000-0000-0000-0000-000000000002", "00000000-0000-0000-0000-000000000003" }
                });

            migrationBuilder.InsertData(
                table: "Fishs",
                columns: new[] { "Id", "CategoryId", "CreatedOn", "DateOfArrival", "LastEditedOn", "MaxWeight", "MinWeigth", "Name", "OriginCountryId", "Price", "UrlImage" },
                values: new object[,]
                {
                    { 4L, 3L, new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1536), new DateTime(2022, 4, 17, 1, 50, 25, 855, DateTimeKind.Local).AddTicks(1533), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1537), 0.5m, 0.4m, "Tong 4", 1L, 33m, "images/tong4.jpg" },
                    { 1L, 3L, new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1040), new DateTime(2022, 4, 17, 1, 50, 25, 854, DateTimeKind.Local).AddTicks(9113), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1275), 1.5m, 1m, "Tong 1", 1L, 30m, "images/Tongeen_met.jpg" },
                    { 27L, 11L, new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1674), new DateTime(2022, 4, 17, 1, 50, 25, 855, DateTimeKind.Local).AddTicks(1672), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1675), 1.4m, 1m, "Kreeft 1+", 9L, 42m, "images/kreeftPlus.jpg" },
                    { 26L, 11L, new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1669), new DateTime(2022, 4, 17, 1, 50, 25, 855, DateTimeKind.Local).AddTicks(1666), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1669), 0.8m, 0.7m, "Kreeft 7/8", 9L, 39m, "images/kreeft7_8.jpg" },
                    { 25L, 11L, new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1663), new DateTime(2022, 4, 17, 1, 50, 25, 855, DateTimeKind.Local).AddTicks(1660), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1663), 0.6m, 0.5m, "Kreeft 5/6", 9L, 35m, "images/canadese-kreeft_5_6.jpg" },
                    { 24L, 11L, new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1657), new DateTime(2022, 4, 17, 1, 50, 25, 855, DateTimeKind.Local).AddTicks(1654), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1657), 0.5m, 0.4m, "Kreeft 4/5", 9L, 32m, "images/canadese_kreeft_4_5.jpg" },
                    { 22L, 10L, new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1644), new DateTime(2022, 4, 17, 1, 50, 25, 855, DateTimeKind.Local).AddTicks(1642), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1645), 7m, 1m, "Zalm gewilde Heel", 9L, 14m, "images/zalm_gewilde.jpg" },
                    { 30L, 8L, new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1693), new DateTime(2022, 4, 17, 1, 50, 25, 855, DateTimeKind.Local).AddTicks(1690), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1693), 10m, 0.5m, "Zwart Heilbot Filet Z/V", 7L, 15m, "images/heilbotfilet_zwart_Por.jpg" },
                    { 29L, 8L, new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1687), new DateTime(2022, 4, 17, 1, 50, 25, 855, DateTimeKind.Local).AddTicks(1684), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1687), 10m, 0.5m, "Wit Heilbot Filet M/V", 7L, 25m, "images/Heilbot_wit_filet.jpg" },
                    { 12L, 8L, new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1585), new DateTime(2022, 4, 17, 1, 50, 25, 855, DateTimeKind.Local).AddTicks(1582), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1585), 0.25m, 0.1m, "Zalm Portjes Z/V", 5L, 31m, "images/zalm_Por_zonder.jpg" },
                    { 11L, 8L, new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1579), new DateTime(2022, 4, 17, 1, 50, 25, 855, DateTimeKind.Local).AddTicks(1576), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1579), 0.25m, 0.1m, "Zalm Portjes M/V", 5L, 29m, "images/zalm_Por.jpg" },
                    { 10L, 8L, new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1573), new DateTime(2022, 4, 17, 1, 50, 25, 855, DateTimeKind.Local).AddTicks(1570), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1573), 1.7m, 0.7m, "Zalm Filet Z/V", 5L, 25m, "images/zalm_filet_zonder.jpg" },
                    { 9L, 8L, new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1567), new DateTime(2022, 4, 17, 1, 50, 25, 855, DateTimeKind.Local).AddTicks(1564), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1567), 1.7m, 1m, "Zalm Filet M/V", 5L, 17m, "images/zalm_filet_met.jpg" },
                    { 8L, 4L, new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1561), new DateTime(2022, 4, 17, 1, 50, 25, 855, DateTimeKind.Local).AddTicks(1558), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1561), 5m, 4m, "Zalm Heel", 5L, 12m, "images/Zalm_heel.jpg" },
                    { 19L, 4L, new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1626), new DateTime(2022, 4, 17, 1, 50, 25, 855, DateTimeKind.Local).AddTicks(1624), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1627), 2m, 0.5m, "vlaswijting Heel", 4L, 12m, "images/Pollak_vlaswijting-31.jpg" },
                    { 3L, 3L, new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1530), new DateTime(2022, 4, 17, 1, 50, 25, 855, DateTimeKind.Local).AddTicks(1527), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1531), 0.75m, 0.5m, "Tong 3", 1L, 25m, "images/tong_3.jpg" },
                    { 18L, 8L, new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1620), new DateTime(2022, 4, 17, 1, 50, 25, 855, DateTimeKind.Local).AddTicks(1618), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1621), 0.25m, 0.5m, "Kool Filet M/V", 4L, 11m, "images/koolvis_fileren.jpg" },
                    { 23L, 9L, new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1650), new DateTime(2022, 4, 17, 1, 50, 25, 855, DateTimeKind.Local).AddTicks(1648), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1651), 1m, 0.2m, "Dorade Royal", 3L, 8m, "images/dorade.png" },
                    { 2L, 3L, new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1523), new DateTime(2022, 4, 17, 1, 50, 25, 855, DateTimeKind.Local).AddTicks(1518), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1523), 0.1m, 0.75m, "Tong 2", 1L, 27m, "images/tongtwee.jpg" },
                    { 33L, 5L, new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1711), new DateTime(2022, 4, 17, 1, 50, 25, 855, DateTimeKind.Local).AddTicks(1708), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1712), 0.25m, 0.1m, "Mosselen Jumbo 10kg", 2L, 6m, "images/jumbo-mosselen_15.jpg" },
                    { 32L, 5L, new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1704), new DateTime(2022, 4, 17, 1, 50, 25, 855, DateTimeKind.Local).AddTicks(1702), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1705), 0.25m, 0.1m, "Mosselen Jumbo 5kg", 2L, 6m, "images/jumbo_5.png" },
                    { 31L, 5L, new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1698), new DateTime(2022, 4, 17, 1, 50, 25, 855, DateTimeKind.Local).AddTicks(1696), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1699), 0.25m, 0.1m, "Mosselen Jumbo 1kg", 2L, 6m, "images/jumbo_1kg.jpg" },
                    { 16L, 8L, new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1609), new DateTime(2022, 4, 17, 1, 50, 25, 855, DateTimeKind.Local).AddTicks(1606), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1609), 0.25m, 0.1m, "Kabeljauw Portjes M/V", 2L, 21m, "images/kabeljauw_Por.jpg" },
                    { 15L, 8L, new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1603), new DateTime(2022, 4, 17, 1, 50, 25, 855, DateTimeKind.Local).AddTicks(1600), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1603), 2.7m, 0.2m, "Kabeljauw Filet Z/V", 2L, 18m, "images/kabeljauw_filet_zonder.jpg" },
                    { 14L, 8L, new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1597), new DateTime(2022, 4, 17, 1, 50, 25, 855, DateTimeKind.Local).AddTicks(1594), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1598), 3.5m, 0.2m, "Kabeljauw Filet M/V", 2L, 14m, "images/kabeljauw_filet_met.jpg" },
                    { 13L, 4L, new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1591), new DateTime(2022, 4, 17, 1, 50, 25, 855, DateTimeKind.Local).AddTicks(1588), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1591), 6m, 1m, "Kabeljauw Heel", 2L, 8m, "images/Kabeljauw.jpg" },
                    { 28L, 3L, new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1681), new DateTime(2022, 4, 17, 1, 50, 25, 855, DateTimeKind.Local).AddTicks(1678), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1681), 2m, 0.5m, "Griet Heel", 1L, 19m, "images/Griet_heel_2.jpg" },
                    { 21L, 10L, new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1638), new DateTime(2022, 4, 17, 1, 50, 25, 855, DateTimeKind.Local).AddTicks(1636), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1639), 2m, 0.8m, "Zeebaars Gewilde", 1L, 14m, "images/Gewilde_Zeebaars.png" },
                    { 7L, 3L, new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1555), new DateTime(2022, 4, 17, 1, 50, 25, 855, DateTimeKind.Local).AddTicks(1552), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1555), 0.15m, 0.1m, "Tong 7", 1L, 15m, "images/tong7.jpg" },
                    { 6L, 3L, new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1549), new DateTime(2022, 4, 17, 1, 50, 25, 855, DateTimeKind.Local).AddTicks(1546), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1549), 0.25m, 0.15m, "Tong 6", 1L, 19m, "images/tong6.png" },
                    { 5L, 3L, new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1543), new DateTime(2022, 4, 17, 1, 50, 25, 855, DateTimeKind.Local).AddTicks(1540), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1543), 0.4m, 0.25m, "Tong 5", 1L, 22m, "images/tong5.jpg" },
                    { 17L, 4L, new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1614), new DateTime(2022, 4, 17, 1, 50, 25, 855, DateTimeKind.Local).AddTicks(1612), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1615), 13m, 1m, "Kool vis Heel", 4L, 6m, "images/koolvis.jpg" },
                    { 20L, 9L, new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1632), new DateTime(2022, 4, 17, 1, 50, 25, 855, DateTimeKind.Local).AddTicks(1630), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1633), 1m, 0.2m, "Zeebaars Gekweekt Heel", 3L, 8m, "images/Zeebaars.jpg" }
                });

            migrationBuilder.InsertData(
                table: "FishFishProcessing",
                columns: new[] { "FishProssingsId", "FishsId" },
                values: new object[,]
                {
                    { 1L, 1L },
                    { 5L, 8L },
                    { 3L, 8L },
                    { 2L, 8L },
                    { 1L, 8L },
                    { 9L, 19L },
                    { 8L, 19L },
                    { 7L, 19L },
                    { 6L, 19L },
                    { 5L, 19L },
                    { 3L, 19L },
                    { 9L, 18L },
                    { 8L, 18L },
                    { 7L, 18L },
                    { 5L, 18L },
                    { 9L, 17L },
                    { 8L, 17L },
                    { 7L, 17L },
                    { 6L, 17L },
                    { 5L, 17L },
                    { 3L, 17L },
                    { 7L, 23L },
                    { 6L, 23L },
                    { 4L, 23L },
                    { 3L, 23L },
                    { 2L, 23L },
                    { 1L, 23L },
                    { 7L, 20L },
                    { 6L, 8L },
                    { 6L, 20L },
                    { 7L, 8L },
                    { 9L, 8L },
                    { 11L, 25L },
                    { 11L, 24L },
                    { 7L, 22L },
                    { 6L, 22L },
                    { 4L, 22L },
                    { 3L, 22L },
                    { 2L, 22L },
                    { 1L, 22L },
                    { 9L, 30L },
                    { 8L, 30L }
                });

            migrationBuilder.InsertData(
                table: "FishFishProcessing",
                columns: new[] { "FishProssingsId", "FishsId" },
                values: new object[,]
                {
                    { 9L, 29L },
                    { 8L, 29L },
                    { 6L, 29L },
                    { 6L, 12L },
                    { 9L, 11L },
                    { 6L, 11L },
                    { 9L, 10L },
                    { 8L, 10L },
                    { 7L, 10L },
                    { 5L, 10L },
                    { 9L, 9L },
                    { 8L, 9L },
                    { 7L, 9L },
                    { 6L, 9L },
                    { 5L, 9L },
                    { 3L, 9L },
                    { 10L, 8L },
                    { 8L, 8L },
                    { 4L, 20L },
                    { 3L, 20L },
                    { 2L, 20L },
                    { 9L, 7L },
                    { 6L, 7L },
                    { 4L, 7L },
                    { 1L, 7L },
                    { 9L, 6L },
                    { 6L, 6L },
                    { 4L, 6L },
                    { 1L, 6L },
                    { 9L, 5L },
                    { 6L, 5L },
                    { 4L, 5L },
                    { 1L, 5L },
                    { 9L, 4L },
                    { 6L, 4L },
                    { 4L, 4L },
                    { 1L, 4L },
                    { 9L, 3L },
                    { 6L, 3L },
                    { 4L, 3L },
                    { 1L, 3L },
                    { 9L, 2L }
                });

            migrationBuilder.InsertData(
                table: "FishFishProcessing",
                columns: new[] { "FishProssingsId", "FishsId" },
                values: new object[,]
                {
                    { 6L, 2L },
                    { 4L, 2L },
                    { 1L, 2L },
                    { 9L, 1L },
                    { 6L, 1L },
                    { 4L, 1L },
                    { 1L, 21L },
                    { 2L, 21L },
                    { 3L, 21L },
                    { 4L, 21L },
                    { 1L, 20L },
                    { 11L, 32L },
                    { 11L, 31L },
                    { 9L, 16L },
                    { 6L, 16L },
                    { 9L, 15L },
                    { 8L, 15L },
                    { 7L, 15L },
                    { 5L, 15L },
                    { 9L, 14L },
                    { 8L, 14L },
                    { 7L, 14L },
                    { 6L, 14L },
                    { 11L, 26L },
                    { 5L, 14L },
                    { 9L, 13L },
                    { 8L, 13L },
                    { 7L, 13L },
                    { 6L, 13L },
                    { 5L, 13L },
                    { 2L, 13L },
                    { 1L, 13L },
                    { 9L, 28L },
                    { 6L, 28L },
                    { 4L, 28L },
                    { 1L, 28L },
                    { 7L, 21L },
                    { 6L, 21L },
                    { 10L, 13L },
                    { 11L, 27L }
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
                name: "IX_FishFishProcessing_FishsId",
                table: "FishFishProcessing",
                column: "FishsId");

            migrationBuilder.CreateIndex(
                name: "IX_Fishs_CategoryId",
                table: "Fishs",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Fishs_OriginCountryId",
                table: "Fishs",
                column: "OriginCountryId");
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
                name: "FishFishProcessing");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "FishProcessings");

            migrationBuilder.DropTable(
                name: "Fishs");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "OriginCountries");
        }
    }
}
