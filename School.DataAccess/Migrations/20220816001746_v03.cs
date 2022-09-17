using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace School.DataAccess.Migrations
{
    public partial class v03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNo",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(2505));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(3133));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(3136));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(3140));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(3144));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(3147));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(3151));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(3154));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(3157));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(3160));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 713, DateTimeKind.Local).AddTicks(9748));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(598));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(613));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(616));

            migrationBuilder.UpdateData(
                table: "EvaluationType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(5856));

            migrationBuilder.UpdateData(
                table: "EvaluationType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "EvaluationType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(6484));

            migrationBuilder.UpdateData(
                table: "EvaluationType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(6487));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 712, DateTimeKind.Local).AddTicks(5667));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 712, DateTimeKind.Local).AddTicks(6618));

            migrationBuilder.UpdateData(
                table: "MarkType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(1188));

            migrationBuilder.UpdateData(
                table: "MarkType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(1906));

            migrationBuilder.UpdateData(
                table: "MarkType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(1921));

            migrationBuilder.UpdateData(
                table: "Semester",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 713, DateTimeKind.Local).AddTicks(8317));

            migrationBuilder.UpdateData(
                table: "Semester",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 713, DateTimeKind.Local).AddTicks(9126));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(4924));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(4927));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(4930));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(4933));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(4937));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(4940));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(4943));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(4946));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(4951));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(4955));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(4958));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(4961));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(4964));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(4968));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(4971));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(4974));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(4977));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(4980));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(4984));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(4987));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(4990));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(5052));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(5056));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(5060));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(5063));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(5066));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(5069));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(5072));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(5075));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(5079));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(5082));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(5085));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(5088));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(5091));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(5095));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(5099));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(5102));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(5105));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(5108));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(5112));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(5115));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(5118));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(5121));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(5124));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(5128));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(5131));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(5134));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(5137));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(5140));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(5144));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(5147));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(5150));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(5153));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(5156));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(5160));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(5163));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(5166));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(5169));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(5172));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(5175));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(5179));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(5183));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(5186));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(5189));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(5192));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(5195));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(5198));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(5202));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(5205));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(5208));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(3739));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(4888));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(4903));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(4907));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(4910));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 600,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(4914));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 700,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(4918));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 800,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(4921));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(7053));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(8481));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(8495));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(8499));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(8503));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 600,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(8507));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 700,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(8511));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 800,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(8514));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 900,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(8517));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1000,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(8522));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1100,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(8525));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1200,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(8529));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1300,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(8532));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1400,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(8535));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1500,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(8538));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1600,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1700,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 3, 17, 44, 714, DateTimeKind.Local).AddTicks(8545));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PhoneNo",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(1755));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(2837));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(2856));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(2861));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(2867));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(2873));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(2879));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(2884));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(2890));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(2896));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(2901));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 740, DateTimeKind.Local).AddTicks(7388));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 740, DateTimeKind.Local).AddTicks(8534));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 740, DateTimeKind.Local).AddTicks(8556));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 740, DateTimeKind.Local).AddTicks(8562));

            migrationBuilder.UpdateData(
                table: "EvaluationType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "EvaluationType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "EvaluationType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(8662));

            migrationBuilder.UpdateData(
                table: "EvaluationType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(8668));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 734, DateTimeKind.Local).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 738, DateTimeKind.Local).AddTicks(6867));

            migrationBuilder.UpdateData(
                table: "MarkType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 740, DateTimeKind.Local).AddTicks(9675));

            migrationBuilder.UpdateData(
                table: "MarkType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(792));

            migrationBuilder.UpdateData(
                table: "MarkType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(813));

            migrationBuilder.UpdateData(
                table: "Semester",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 740, DateTimeKind.Local).AddTicks(4989));

            migrationBuilder.UpdateData(
                table: "Semester",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 740, DateTimeKind.Local).AddTicks(6288));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6009));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6016));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6021));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6027));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6032));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6038));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6044));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6049));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6054));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6060));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6067));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6073));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6078));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6084));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6090));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6095));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6101));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6106));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6112));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6117));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6123));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6128));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6134));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6139));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6144));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6151));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6157));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6162));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6168));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6173));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6179));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6185));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6191));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6309));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6319));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6324));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6330));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6335));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6341));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6346));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6351));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6356));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6362));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6367));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6373));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6380));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6386));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6392));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6398));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6403));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6408));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6413));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6418));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6424));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6429));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6435));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6440));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6445));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6455));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6462));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6468));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6474));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6479));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6485));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6491));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6497));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6503));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6509));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6514));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(3875));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(5951));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(5975));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(5981));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(5987));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 600,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(5992));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 700,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(5998));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 800,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(6004));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 741, DateTimeKind.Local).AddTicks(9591));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 742, DateTimeKind.Local).AddTicks(2206));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 742, DateTimeKind.Local).AddTicks(2230));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 742, DateTimeKind.Local).AddTicks(2407));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 742, DateTimeKind.Local).AddTicks(2419));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 600,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 742, DateTimeKind.Local).AddTicks(2425));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 700,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 742, DateTimeKind.Local).AddTicks(2430));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 800,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 742, DateTimeKind.Local).AddTicks(2436));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 900,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 742, DateTimeKind.Local).AddTicks(2442));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1000,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 742, DateTimeKind.Local).AddTicks(2448));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1100,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 742, DateTimeKind.Local).AddTicks(2455));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1200,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 742, DateTimeKind.Local).AddTicks(2461));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1300,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 742, DateTimeKind.Local).AddTicks(2466));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1400,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 742, DateTimeKind.Local).AddTicks(2473));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1500,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 742, DateTimeKind.Local).AddTicks(2479));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1600,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 742, DateTimeKind.Local).AddTicks(2485));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1700,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 16, 0, 42, 26, 742, DateTimeKind.Local).AddTicks(2491));
        }
    }
}
