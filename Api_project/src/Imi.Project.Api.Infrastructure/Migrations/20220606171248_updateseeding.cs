using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Imi.Project.Api.Infrastructure.Migrations
{
    public partial class updateseeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEFjbwW1mSijKQnFqSEyBblTXIHEl/xcuoosUD0BuaKiKCVCw2lBxUYagPWk4snYp4g==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAECvYqKOeKOcTJKwc1oWhUmdX0bK7oRhk1mFRsbAL0DOOwdabsoSCSJv08rMtMNSL7g==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEHfQKUOBTtf9G/jycUvyjPucmFBcLmfhsLPJJa04xnlxkPrbZanV5rL0KMDs86I9rw==");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(2266), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(2268) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(2270), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(2270) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(2271), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(2272) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(2273), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(2274) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(2275), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(2275) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(2276), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(2277) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(2278), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(2278) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(2279), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(2280) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(2281), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(2281) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(2282), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(2283) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(2284), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(2284) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(2285), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(2286) });

            migrationBuilder.UpdateData(
                table: "FishProcessings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(3116), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(3118) });

            migrationBuilder.UpdateData(
                table: "FishProcessings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(3120), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(3120) });

            migrationBuilder.UpdateData(
                table: "FishProcessings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(3121), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(3122) });

            migrationBuilder.UpdateData(
                table: "FishProcessings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(3123), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(3123) });

            migrationBuilder.UpdateData(
                table: "FishProcessings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(3124), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(3125) });

            migrationBuilder.UpdateData(
                table: "FishProcessings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(3170), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(3171) });

            migrationBuilder.UpdateData(
                table: "FishProcessings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(3172), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(3173) });

            migrationBuilder.UpdateData(
                table: "FishProcessings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(3174), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(3174) });

            migrationBuilder.UpdateData(
                table: "FishProcessings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(3175), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(3176) });

            migrationBuilder.UpdateData(
                table: "FishProcessings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(3177), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(3178) });

            migrationBuilder.UpdateData(
                table: "FishProcessings",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(3178), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(3179) });

            migrationBuilder.UpdateData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "DateOfArrival", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1128), new DateTime(2022, 6, 6, 19, 12, 47, 815, DateTimeKind.Local).AddTicks(9380), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1357) });

            migrationBuilder.UpdateData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "DateOfArrival", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1593), new DateTime(2022, 6, 6, 19, 12, 47, 816, DateTimeKind.Local).AddTicks(1589), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1594) });

            migrationBuilder.UpdateData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "DateOfArrival", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1600), new DateTime(2022, 6, 6, 19, 12, 47, 816, DateTimeKind.Local).AddTicks(1597), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1601) });

            migrationBuilder.UpdateData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "DateOfArrival", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1606), new DateTime(2022, 6, 6, 19, 12, 47, 816, DateTimeKind.Local).AddTicks(1604), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1607) });

            migrationBuilder.UpdateData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "DateOfArrival", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1612), new DateTime(2022, 6, 6, 19, 12, 47, 816, DateTimeKind.Local).AddTicks(1610), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1613) });

            migrationBuilder.UpdateData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "DateOfArrival", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1618), new DateTime(2022, 6, 6, 19, 12, 47, 816, DateTimeKind.Local).AddTicks(1615), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1619) });

            migrationBuilder.UpdateData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "DateOfArrival", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1624), new DateTime(2022, 6, 6, 19, 12, 47, 816, DateTimeKind.Local).AddTicks(1622), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1625) });

            migrationBuilder.UpdateData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "DateOfArrival", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1630), new DateTime(2022, 6, 6, 19, 12, 47, 816, DateTimeKind.Local).AddTicks(1627), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1631) });

            migrationBuilder.UpdateData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "DateOfArrival", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1637), new DateTime(2022, 6, 6, 19, 12, 47, 816, DateTimeKind.Local).AddTicks(1634), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1638) });

            migrationBuilder.UpdateData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "DateOfArrival", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1644), new DateTime(2022, 6, 6, 19, 12, 47, 816, DateTimeKind.Local).AddTicks(1641), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1644) });

            migrationBuilder.UpdateData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "DateOfArrival", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1650), new DateTime(2022, 6, 6, 19, 12, 47, 816, DateTimeKind.Local).AddTicks(1648), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1651) });

            migrationBuilder.UpdateData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "DateOfArrival", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1656), new DateTime(2022, 6, 6, 19, 12, 47, 816, DateTimeKind.Local).AddTicks(1654), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1657) });

            migrationBuilder.UpdateData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "DateOfArrival", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1662), new DateTime(2022, 6, 6, 19, 12, 47, 816, DateTimeKind.Local).AddTicks(1660), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1663) });

            migrationBuilder.UpdateData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "DateOfArrival", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1668), new DateTime(2022, 6, 6, 19, 12, 47, 816, DateTimeKind.Local).AddTicks(1665), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1668) });

            migrationBuilder.UpdateData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "DateOfArrival", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1673), new DateTime(2022, 6, 6, 19, 12, 47, 816, DateTimeKind.Local).AddTicks(1671), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1674) });

            migrationBuilder.UpdateData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "DateOfArrival", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1679), new DateTime(2022, 6, 6, 19, 12, 47, 816, DateTimeKind.Local).AddTicks(1677), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1680) });

            migrationBuilder.UpdateData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "DateOfArrival", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1685), new DateTime(2022, 6, 6, 19, 12, 47, 816, DateTimeKind.Local).AddTicks(1683), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1686) });

            migrationBuilder.UpdateData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "DateOfArrival", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1691), new DateTime(2022, 6, 6, 19, 12, 47, 816, DateTimeKind.Local).AddTicks(1688), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1692) });

            migrationBuilder.UpdateData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "DateOfArrival", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1697), new DateTime(2022, 6, 6, 19, 12, 47, 816, DateTimeKind.Local).AddTicks(1694), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1697) });

            migrationBuilder.UpdateData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "DateOfArrival", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1702), new DateTime(2022, 6, 6, 19, 12, 47, 816, DateTimeKind.Local).AddTicks(1700), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1703) });

            migrationBuilder.UpdateData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "DateOfArrival", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1708), new DateTime(2022, 6, 6, 19, 12, 47, 816, DateTimeKind.Local).AddTicks(1706), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1709) });

            migrationBuilder.UpdateData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "DateOfArrival", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1714), new DateTime(2022, 6, 6, 19, 12, 47, 816, DateTimeKind.Local).AddTicks(1712), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1715) });

            migrationBuilder.UpdateData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "DateOfArrival", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1720), new DateTime(2022, 6, 6, 19, 12, 47, 816, DateTimeKind.Local).AddTicks(1718), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1721) });

            migrationBuilder.UpdateData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "DateOfArrival", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1726), new DateTime(2022, 6, 6, 19, 12, 47, 816, DateTimeKind.Local).AddTicks(1724), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1727) });

            migrationBuilder.UpdateData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "DateOfArrival", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1732), new DateTime(2022, 6, 6, 19, 12, 47, 816, DateTimeKind.Local).AddTicks(1729), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1732) });

            migrationBuilder.UpdateData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "DateOfArrival", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1737), new DateTime(2022, 6, 6, 19, 12, 47, 816, DateTimeKind.Local).AddTicks(1735), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1738) });

            migrationBuilder.UpdateData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "DateOfArrival", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1743), new DateTime(2022, 6, 6, 19, 12, 47, 816, DateTimeKind.Local).AddTicks(1741), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1744) });

            migrationBuilder.UpdateData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "DateOfArrival", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1749), new DateTime(2022, 6, 6, 19, 12, 47, 816, DateTimeKind.Local).AddTicks(1747), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1750) });

            migrationBuilder.UpdateData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedOn", "DateOfArrival", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1755), new DateTime(2022, 6, 6, 19, 12, 47, 816, DateTimeKind.Local).AddTicks(1753), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1756) });

            migrationBuilder.UpdateData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "DateOfArrival", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1761), new DateTime(2022, 6, 6, 19, 12, 47, 816, DateTimeKind.Local).AddTicks(1759), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1762) });

            migrationBuilder.UpdateData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "DateOfArrival", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1767), new DateTime(2022, 6, 6, 19, 12, 47, 816, DateTimeKind.Local).AddTicks(1765), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1768) });

            migrationBuilder.UpdateData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "DateOfArrival", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1773), new DateTime(2022, 6, 6, 19, 12, 47, 816, DateTimeKind.Local).AddTicks(1771), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1774) });

            migrationBuilder.UpdateData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "DateOfArrival", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1779), new DateTime(2022, 6, 6, 19, 12, 47, 816, DateTimeKind.Local).AddTicks(1776), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1779) });

            migrationBuilder.InsertData(
                table: "Fishs",
                columns: new[] { "Id", "CategoryId", "CreatedOn", "DateOfArrival", "LastEditedOn", "MaxWeight", "MinWeigth", "Name", "OriginCountryId", "Price", "UrlImage" },
                values: new object[,]
                {
                    { 34L, 10L, new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1784), new DateTime(2022, 6, 6, 19, 12, 47, 816, DateTimeKind.Local).AddTicks(1782), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1785), 10m, 0.5m, "Zwarte-heilbot", 5L, 6m, "images/Zwarte-heilbot.png" },
                    { 36L, 1L, new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1796), new DateTime(2022, 6, 6, 19, 12, 47, 816, DateTimeKind.Local).AddTicks(1793), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1796), 125m, 0.2m, "witte_heilbot", 4L, 35m, "images/witte_heilbot.jpg" },
                    { 35L, 12L, new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1790), new DateTime(2022, 6, 6, 19, 12, 47, 816, DateTimeKind.Local).AddTicks(1788), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(1791), 2m, 0.2m, "Zeepaling", 1L, 35m, "images/zeepaling_b.jpg" }
                });

            migrationBuilder.UpdateData(
                table: "OriginCountries",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(2702), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(2704) });

            migrationBuilder.UpdateData(
                table: "OriginCountries",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(2706), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(2706) });

            migrationBuilder.UpdateData(
                table: "OriginCountries",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(2707), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(2708) });

            migrationBuilder.UpdateData(
                table: "OriginCountries",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(2709), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(2709) });

            migrationBuilder.UpdateData(
                table: "OriginCountries",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(2710), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(2711) });

            migrationBuilder.UpdateData(
                table: "OriginCountries",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(2712), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(2712) });

            migrationBuilder.UpdateData(
                table: "OriginCountries",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(2713), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(2714) });

            migrationBuilder.UpdateData(
                table: "OriginCountries",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(2715), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(2715) });

            migrationBuilder.UpdateData(
                table: "OriginCountries",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(2716), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(2717) });

            migrationBuilder.UpdateData(
                table: "OriginCountries",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(2718), new DateTime(2022, 6, 6, 17, 12, 47, 816, DateTimeKind.Utc).AddTicks(2718) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEOyzSkUJtHgOvYU2HtWfS8wnnDwNkVBPI2Z1HqsMHsTyuzNq2Fl0eSn4krMsn6R+Og==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEKwBq58r8xssBQWyxRaOFnU7rXM1Bd7j5ueWJKyZlc86shy0Zi3t9ZvLq7KqlpT+Pw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEDFpM1yKDzydL6+b+VdtnnxNkIaDxX1qWsa9EiHc0mhaW8RFviN0Y25YOWqe1xKeYQ==");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2213), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2215) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2217), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2217) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2218), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2219) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2220), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2221) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2222), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2223) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2224), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2224) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2225), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2226) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2227), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2227) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2228), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2229) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2230), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2231) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2232), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2232) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2233), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2234) });

            migrationBuilder.UpdateData(
                table: "FishProcessings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(3159), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(3161) });

            migrationBuilder.UpdateData(
                table: "FishProcessings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(3163), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(3164) });

            migrationBuilder.UpdateData(
                table: "FishProcessings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(3165), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(3165) });

            migrationBuilder.UpdateData(
                table: "FishProcessings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(3166), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(3167) });

            migrationBuilder.UpdateData(
                table: "FishProcessings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(3168), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(3169) });

            migrationBuilder.UpdateData(
                table: "FishProcessings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(3170), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(3170) });

            migrationBuilder.UpdateData(
                table: "FishProcessings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(3171), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(3172) });

            migrationBuilder.UpdateData(
                table: "FishProcessings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(3173), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(3173) });

            migrationBuilder.UpdateData(
                table: "FishProcessings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(3174), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(3175) });

            migrationBuilder.UpdateData(
                table: "FishProcessings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(3176), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(3176) });

            migrationBuilder.UpdateData(
                table: "FishProcessings",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(3177), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(3178) });

            migrationBuilder.UpdateData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "DateOfArrival", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1040), new DateTime(2022, 4, 17, 1, 50, 25, 854, DateTimeKind.Local).AddTicks(9113), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1275) });

            migrationBuilder.UpdateData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "DateOfArrival", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1523), new DateTime(2022, 4, 17, 1, 50, 25, 855, DateTimeKind.Local).AddTicks(1518), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1523) });

            migrationBuilder.UpdateData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "DateOfArrival", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1530), new DateTime(2022, 4, 17, 1, 50, 25, 855, DateTimeKind.Local).AddTicks(1527), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1531) });

            migrationBuilder.UpdateData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "DateOfArrival", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1536), new DateTime(2022, 4, 17, 1, 50, 25, 855, DateTimeKind.Local).AddTicks(1533), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1537) });

            migrationBuilder.UpdateData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "DateOfArrival", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1543), new DateTime(2022, 4, 17, 1, 50, 25, 855, DateTimeKind.Local).AddTicks(1540), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1543) });

            migrationBuilder.UpdateData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "DateOfArrival", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1549), new DateTime(2022, 4, 17, 1, 50, 25, 855, DateTimeKind.Local).AddTicks(1546), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1549) });

            migrationBuilder.UpdateData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "DateOfArrival", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1555), new DateTime(2022, 4, 17, 1, 50, 25, 855, DateTimeKind.Local).AddTicks(1552), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1555) });

            migrationBuilder.UpdateData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "DateOfArrival", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1561), new DateTime(2022, 4, 17, 1, 50, 25, 855, DateTimeKind.Local).AddTicks(1558), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1561) });

            migrationBuilder.UpdateData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "DateOfArrival", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1567), new DateTime(2022, 4, 17, 1, 50, 25, 855, DateTimeKind.Local).AddTicks(1564), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1567) });

            migrationBuilder.UpdateData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "DateOfArrival", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1573), new DateTime(2022, 4, 17, 1, 50, 25, 855, DateTimeKind.Local).AddTicks(1570), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1573) });

            migrationBuilder.UpdateData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "DateOfArrival", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1579), new DateTime(2022, 4, 17, 1, 50, 25, 855, DateTimeKind.Local).AddTicks(1576), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1579) });

            migrationBuilder.UpdateData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "DateOfArrival", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1585), new DateTime(2022, 4, 17, 1, 50, 25, 855, DateTimeKind.Local).AddTicks(1582), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1585) });

            migrationBuilder.UpdateData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "DateOfArrival", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1591), new DateTime(2022, 4, 17, 1, 50, 25, 855, DateTimeKind.Local).AddTicks(1588), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1591) });

            migrationBuilder.UpdateData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "DateOfArrival", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1597), new DateTime(2022, 4, 17, 1, 50, 25, 855, DateTimeKind.Local).AddTicks(1594), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1598) });

            migrationBuilder.UpdateData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "DateOfArrival", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1603), new DateTime(2022, 4, 17, 1, 50, 25, 855, DateTimeKind.Local).AddTicks(1600), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1603) });

            migrationBuilder.UpdateData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "DateOfArrival", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1609), new DateTime(2022, 4, 17, 1, 50, 25, 855, DateTimeKind.Local).AddTicks(1606), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1609) });

            migrationBuilder.UpdateData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "DateOfArrival", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1614), new DateTime(2022, 4, 17, 1, 50, 25, 855, DateTimeKind.Local).AddTicks(1612), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1615) });

            migrationBuilder.UpdateData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "DateOfArrival", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1620), new DateTime(2022, 4, 17, 1, 50, 25, 855, DateTimeKind.Local).AddTicks(1618), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1621) });

            migrationBuilder.UpdateData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "DateOfArrival", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1626), new DateTime(2022, 4, 17, 1, 50, 25, 855, DateTimeKind.Local).AddTicks(1624), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1627) });

            migrationBuilder.UpdateData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "DateOfArrival", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1632), new DateTime(2022, 4, 17, 1, 50, 25, 855, DateTimeKind.Local).AddTicks(1630), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1633) });

            migrationBuilder.UpdateData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "DateOfArrival", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1638), new DateTime(2022, 4, 17, 1, 50, 25, 855, DateTimeKind.Local).AddTicks(1636), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1639) });

            migrationBuilder.UpdateData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "DateOfArrival", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1644), new DateTime(2022, 4, 17, 1, 50, 25, 855, DateTimeKind.Local).AddTicks(1642), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1645) });

            migrationBuilder.UpdateData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "DateOfArrival", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1650), new DateTime(2022, 4, 17, 1, 50, 25, 855, DateTimeKind.Local).AddTicks(1648), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1651) });

            migrationBuilder.UpdateData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "DateOfArrival", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1657), new DateTime(2022, 4, 17, 1, 50, 25, 855, DateTimeKind.Local).AddTicks(1654), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1657) });

            migrationBuilder.UpdateData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "DateOfArrival", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1663), new DateTime(2022, 4, 17, 1, 50, 25, 855, DateTimeKind.Local).AddTicks(1660), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1663) });

            migrationBuilder.UpdateData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "DateOfArrival", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1669), new DateTime(2022, 4, 17, 1, 50, 25, 855, DateTimeKind.Local).AddTicks(1666), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1669) });

            migrationBuilder.UpdateData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "DateOfArrival", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1674), new DateTime(2022, 4, 17, 1, 50, 25, 855, DateTimeKind.Local).AddTicks(1672), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1675) });

            migrationBuilder.UpdateData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "DateOfArrival", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1681), new DateTime(2022, 4, 17, 1, 50, 25, 855, DateTimeKind.Local).AddTicks(1678), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1681) });

            migrationBuilder.UpdateData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedOn", "DateOfArrival", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1687), new DateTime(2022, 4, 17, 1, 50, 25, 855, DateTimeKind.Local).AddTicks(1684), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1687) });

            migrationBuilder.UpdateData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "DateOfArrival", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1693), new DateTime(2022, 4, 17, 1, 50, 25, 855, DateTimeKind.Local).AddTicks(1690), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1693) });

            migrationBuilder.UpdateData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "DateOfArrival", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1698), new DateTime(2022, 4, 17, 1, 50, 25, 855, DateTimeKind.Local).AddTicks(1696), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1699) });

            migrationBuilder.UpdateData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "DateOfArrival", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1704), new DateTime(2022, 4, 17, 1, 50, 25, 855, DateTimeKind.Local).AddTicks(1702), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1705) });

            migrationBuilder.UpdateData(
                table: "Fishs",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "DateOfArrival", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1711), new DateTime(2022, 4, 17, 1, 50, 25, 855, DateTimeKind.Local).AddTicks(1708), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(1712) });

            migrationBuilder.UpdateData(
                table: "OriginCountries",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2727), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2729) });

            migrationBuilder.UpdateData(
                table: "OriginCountries",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2731), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2732) });

            migrationBuilder.UpdateData(
                table: "OriginCountries",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2733), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2733) });

            migrationBuilder.UpdateData(
                table: "OriginCountries",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2734), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2735) });

            migrationBuilder.UpdateData(
                table: "OriginCountries",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2736), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2737) });

            migrationBuilder.UpdateData(
                table: "OriginCountries",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2738), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2738) });

            migrationBuilder.UpdateData(
                table: "OriginCountries",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2739), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2740) });

            migrationBuilder.UpdateData(
                table: "OriginCountries",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2741), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2741) });

            migrationBuilder.UpdateData(
                table: "OriginCountries",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2742), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2743) });

            migrationBuilder.UpdateData(
                table: "OriginCountries",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2744), new DateTime(2022, 4, 16, 23, 50, 25, 855, DateTimeKind.Utc).AddTicks(2745) });
        }
    }
}
