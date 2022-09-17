using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace School.DataAccess.Migrations
{
    public partial class UpdateVersion01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AddressName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClassId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DOP",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmailAddress",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GenderId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PlaceOBirth",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SchoolYear",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SemesterId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(1476));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(2611));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(2633));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(2639));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(2646));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(2652));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(2657));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(2664));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(2670));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(2677));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(2683));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 382, DateTimeKind.Local).AddTicks(7219));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 382, DateTimeKind.Local).AddTicks(8392));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 382, DateTimeKind.Local).AddTicks(8413));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 382, DateTimeKind.Local).AddTicks(8421));

            migrationBuilder.UpdateData(
                table: "EvaluationType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(7338));

            migrationBuilder.UpdateData(
                table: "EvaluationType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(8612));

            migrationBuilder.UpdateData(
                table: "EvaluationType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(8633));

            migrationBuilder.UpdateData(
                table: "EvaluationType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(8639));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 380, DateTimeKind.Local).AddTicks(5689));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 380, DateTimeKind.Local).AddTicks(7143));

            migrationBuilder.UpdateData(
                table: "MarkType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 382, DateTimeKind.Local).AddTicks(9349));

            migrationBuilder.UpdateData(
                table: "MarkType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(486));

            migrationBuilder.UpdateData(
                table: "MarkType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(508));

            migrationBuilder.UpdateData(
                table: "Semester",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 382, DateTimeKind.Local).AddTicks(4899));

            migrationBuilder.UpdateData(
                table: "Semester",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 382, DateTimeKind.Local).AddTicks(6187));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(5913));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(5919));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(5925));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(5931));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(5937));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(5943));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(5949));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(5954));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(5960));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(5966));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(5972));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(5977));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(5983));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(5990));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(5997));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6003));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6009));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6015));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6021));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6027));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6032));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6038));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6044));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6050));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6056));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6061));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6067));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6073));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6089));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6094));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6100));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6106));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6112));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6118));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6124));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6130));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6135));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6141));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6149));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6155));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6161));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6165));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6171));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6176));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6182));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6187));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6193));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6199));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6205));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6211));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6216));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6222));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6228));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6233));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6239));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6245));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6251));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6256));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6261));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6267));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6273));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6277));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6283));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6288));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6294));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6300));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6314));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6321));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6326));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(3702));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(5854));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(5861));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(5868));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 600,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(5874));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 700,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(5880));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 800,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(5907));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(9638));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 384, DateTimeKind.Local).AddTicks(2215));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 384, DateTimeKind.Local).AddTicks(2239));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 384, DateTimeKind.Local).AddTicks(2247));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 384, DateTimeKind.Local).AddTicks(2255));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 600,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 384, DateTimeKind.Local).AddTicks(2261));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 700,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 384, DateTimeKind.Local).AddTicks(2268));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 800,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 384, DateTimeKind.Local).AddTicks(2274));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 900,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 384, DateTimeKind.Local).AddTicks(2281));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1000,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 384, DateTimeKind.Local).AddTicks(2287));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1100,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 384, DateTimeKind.Local).AddTicks(2294));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1200,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 384, DateTimeKind.Local).AddTicks(2301));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1300,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 384, DateTimeKind.Local).AddTicks(2308));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1400,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 384, DateTimeKind.Local).AddTicks(2314));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1500,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 384, DateTimeKind.Local).AddTicks(2320));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1600,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 384, DateTimeKind.Local).AddTicks(2326));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1700,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 384, DateTimeKind.Local).AddTicks(2332));

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ClassId",
                table: "AspNetUsers",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_GenderId",
                table: "AspNetUsers",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_SemesterId",
                table: "AspNetUsers",
                column: "SemesterId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Classes_ClassId",
                table: "AspNetUsers",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Gender_GenderId",
                table: "AspNetUsers",
                column: "GenderId",
                principalTable: "Gender",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Semester_SemesterId",
                table: "AspNetUsers",
                column: "SemesterId",
                principalTable: "Semester",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Classes_ClassId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Gender_GenderId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Semester_SemesterId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ClassId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_GenderId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_SemesterId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "AddressName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ClassId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DOP",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EmailAddress",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "GenderId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PlaceOBirth",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SchoolYear",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SemesterId",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 883, DateTimeKind.Local).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 883, DateTimeKind.Local).AddTicks(7950));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 883, DateTimeKind.Local).AddTicks(7983));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 883, DateTimeKind.Local).AddTicks(7994));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 883, DateTimeKind.Local).AddTicks(8007));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 883, DateTimeKind.Local).AddTicks(8017));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 883, DateTimeKind.Local).AddTicks(8029));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 883, DateTimeKind.Local).AddTicks(8043));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 883, DateTimeKind.Local).AddTicks(8052));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 883, DateTimeKind.Local).AddTicks(8064));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 883, DateTimeKind.Local).AddTicks(8075));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 883, DateTimeKind.Local).AddTicks(266));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 883, DateTimeKind.Local).AddTicks(1869));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 883, DateTimeKind.Local).AddTicks(1902));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 883, DateTimeKind.Local).AddTicks(1914));

            migrationBuilder.UpdateData(
                table: "EvaluationType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(6111));

            migrationBuilder.UpdateData(
                table: "EvaluationType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(7441));

            migrationBuilder.UpdateData(
                table: "EvaluationType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(7475));

            migrationBuilder.UpdateData(
                table: "EvaluationType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(7488));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 879, DateTimeKind.Local).AddTicks(6696));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 879, DateTimeKind.Local).AddTicks(8789));

            migrationBuilder.UpdateData(
                table: "MarkType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 883, DateTimeKind.Local).AddTicks(3332));

            migrationBuilder.UpdateData(
                table: "MarkType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 883, DateTimeKind.Local).AddTicks(4938));

            migrationBuilder.UpdateData(
                table: "MarkType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 883, DateTimeKind.Local).AddTicks(4969));

            migrationBuilder.UpdateData(
                table: "Semester",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 882, DateTimeKind.Local).AddTicks(6795));

            migrationBuilder.UpdateData(
                table: "Semester",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 882, DateTimeKind.Local).AddTicks(8700));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(2811));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(2816));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(2822));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(2827));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(2832));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(2838));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(2852));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(2861));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(2866));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(2876));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3093));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3109));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3122));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3135));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3149));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3161));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3174));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3187));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3201));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3216));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3227));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3239));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3252));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3265));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3279));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3292));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3307));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3316));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3330));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3338));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3351));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3361));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3370));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3378));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3383));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3390));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3395));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3400));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3405));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3411));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3416));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3421));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3427));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3432));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3437));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3443));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3449));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3454));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3465));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3470));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3475));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3480));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3485));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3490));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3495));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3501));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3506));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3514));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3526));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3536));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3542));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3549));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3555));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3561));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3567));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3575));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3581));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3588));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(3594));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 883, DateTimeKind.Local).AddTicks(9896));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(2720));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(2759));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(2766));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(2772));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 600,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(2777));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 700,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(2789));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 800,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(2803));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 884, DateTimeKind.Local).AddTicks(9306));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 885, DateTimeKind.Local).AddTicks(2697));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 885, DateTimeKind.Local).AddTicks(2774));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 885, DateTimeKind.Local).AddTicks(2789));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 885, DateTimeKind.Local).AddTicks(2803));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 600,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 885, DateTimeKind.Local).AddTicks(2816));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 700,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 885, DateTimeKind.Local).AddTicks(2835));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 800,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 885, DateTimeKind.Local).AddTicks(2844));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 900,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 885, DateTimeKind.Local).AddTicks(2856));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1000,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 885, DateTimeKind.Local).AddTicks(2870));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1100,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 885, DateTimeKind.Local).AddTicks(2884));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1200,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 885, DateTimeKind.Local).AddTicks(2891));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1300,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 885, DateTimeKind.Local).AddTicks(2901));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1400,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 885, DateTimeKind.Local).AddTicks(2906));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1500,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 885, DateTimeKind.Local).AddTicks(2913));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1600,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 885, DateTimeKind.Local).AddTicks(2919));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1700,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 16, 51, 21, 885, DateTimeKind.Local).AddTicks(2925));
        }
    }
}
