using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace School.DataAccess.Migrations
{
    public partial class fixproplem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsEnabled",
                table: "AspNetUsers",
                type: "bit",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 384, DateTimeKind.Local).AddTicks(8558));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 384, DateTimeKind.Local).AddTicks(9134));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 384, DateTimeKind.Local).AddTicks(9147));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 384, DateTimeKind.Local).AddTicks(9151));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 384, DateTimeKind.Local).AddTicks(9155));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 384, DateTimeKind.Local).AddTicks(9158));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 384, DateTimeKind.Local).AddTicks(9161));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 384, DateTimeKind.Local).AddTicks(9164));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 384, DateTimeKind.Local).AddTicks(9167));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 384, DateTimeKind.Local).AddTicks(9171));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 384, DateTimeKind.Local).AddTicks(9174));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 384, DateTimeKind.Local).AddTicks(6168));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 384, DateTimeKind.Local).AddTicks(6778));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 384, DateTimeKind.Local).AddTicks(6791));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 384, DateTimeKind.Local).AddTicks(6795));

            migrationBuilder.UpdateData(
                table: "EvaluationType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(2244));

            migrationBuilder.UpdateData(
                table: "EvaluationType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(2821));

            migrationBuilder.UpdateData(
                table: "EvaluationType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(2834));

            migrationBuilder.UpdateData(
                table: "EvaluationType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(2838));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 383, DateTimeKind.Local).AddTicks(2393));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 383, DateTimeKind.Local).AddTicks(3282));

            migrationBuilder.UpdateData(
                table: "MarkType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 384, DateTimeKind.Local).AddTicks(7337));

            migrationBuilder.UpdateData(
                table: "MarkType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 384, DateTimeKind.Local).AddTicks(7982));

            migrationBuilder.UpdateData(
                table: "MarkType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 384, DateTimeKind.Local).AddTicks(7994));

            migrationBuilder.UpdateData(
                table: "Semester",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 384, DateTimeKind.Local).AddTicks(4651));

            migrationBuilder.UpdateData(
                table: "Semester",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 384, DateTimeKind.Local).AddTicks(5453));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1195));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1198));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1201));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1204));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1207));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1211));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1214));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1217));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1220));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1224));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1227));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1230));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1234));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1238));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1241));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1244));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1247));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1250));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1254));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1257));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1260));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1263));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1267));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1341));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1345));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1348));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1351));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1354));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1358));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1361));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1364));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1367));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1370));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1374));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1377));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1380));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1383));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1386));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1390));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1394));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1397));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1400));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1403));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1406));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1413));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1416));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1419));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1423));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1426));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1429));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1432));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1435));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1439));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1442));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1445));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1448));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1451));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1454));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1458));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1461));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1464));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1467));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1470));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1473));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1477));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1480));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1483));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1486));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1489));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 384, DateTimeKind.Local).AddTicks(9781));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1157));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1174));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1178));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1181));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 600,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1185));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 700,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1189));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 800,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(1192));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(3355));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(4694));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(4708));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(4713));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 600,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(4720));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 700,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(4723));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 800,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(4727));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 900,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(4731));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1000,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(4734));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1100,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(4737));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1200,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(4741));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1300,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(4744));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1400,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(4749));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1500,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(4752));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1600,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(4755));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1700,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 27, 0, 6, 20, 385, DateTimeKind.Local).AddTicks(4758));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsEnabled",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 799, DateTimeKind.Local).AddTicks(9243));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 799, DateTimeKind.Local).AddTicks(9819));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 799, DateTimeKind.Local).AddTicks(9831));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 799, DateTimeKind.Local).AddTicks(9835));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 799, DateTimeKind.Local).AddTicks(9838));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 799, DateTimeKind.Local).AddTicks(9841));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 799, DateTimeKind.Local).AddTicks(9845));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 799, DateTimeKind.Local).AddTicks(9848));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 799, DateTimeKind.Local).AddTicks(9852));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 799, DateTimeKind.Local).AddTicks(9855));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 799, DateTimeKind.Local).AddTicks(9858));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 799, DateTimeKind.Local).AddTicks(6857));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 799, DateTimeKind.Local).AddTicks(7477));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 799, DateTimeKind.Local).AddTicks(7490));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 799, DateTimeKind.Local).AddTicks(7494));

            migrationBuilder.UpdateData(
                table: "EvaluationType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(2366));

            migrationBuilder.UpdateData(
                table: "EvaluationType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(2933));

            migrationBuilder.UpdateData(
                table: "EvaluationType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(2943));

            migrationBuilder.UpdateData(
                table: "EvaluationType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(2947));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 798, DateTimeKind.Local).AddTicks(3362));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 798, DateTimeKind.Local).AddTicks(4242));

            migrationBuilder.UpdateData(
                table: "MarkType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 799, DateTimeKind.Local).AddTicks(8023));

            migrationBuilder.UpdateData(
                table: "MarkType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 799, DateTimeKind.Local).AddTicks(8661));

            migrationBuilder.UpdateData(
                table: "MarkType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 799, DateTimeKind.Local).AddTicks(8673));

            migrationBuilder.UpdateData(
                table: "Semester",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 799, DateTimeKind.Local).AddTicks(5396));

            migrationBuilder.UpdateData(
                table: "Semester",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 799, DateTimeKind.Local).AddTicks(6212));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1490));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1493));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1496));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1500));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1503));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1507));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1510));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1514));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1517));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1521));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1524));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1527));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1530));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1534));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1537));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1597));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1601));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1605));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1608));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1611));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1615));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1619));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1622));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1625));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1629));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1632));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1635));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1639));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1643));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1647));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1650));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1654));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1657));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1660));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1664));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1667));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1670));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1674));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1678));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1681));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1685));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1688));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1691));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1695));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1699));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1702));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1705));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1709));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1712));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1716));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1719));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1723));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1726));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1729));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1733));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1736));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1740));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1743));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1746));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1749));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1752));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1756));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1759));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1763));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1766));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1769));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1772));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1776));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1779));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(388));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1452));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1464));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1468));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1476));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 600,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1479));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 700,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1483));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 800,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(1487));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(3437));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(4764));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(4777));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(4781));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(4785));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 600,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(4789));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 700,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(4792));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 800,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(4795));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 900,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(4799));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1000,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(4802));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1100,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(4805));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1200,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(4808));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1300,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(4812));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1400,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(4815));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1500,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(4818));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1600,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(4822));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1700,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 17, 27, 39, 800, DateTimeKind.Local).AddTicks(4825));
        }
    }
}
