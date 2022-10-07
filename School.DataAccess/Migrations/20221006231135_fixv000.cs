using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace School.DataAccess.Migrations
{
    public partial class fixv000 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MidTermValue",
                table: "Mark");

            migrationBuilder.RenameColumn(
                name: "SecondMonth",
                table: "Mark",
                newName: "ShortQuizzes");

            migrationBuilder.RenameColumn(
                name: "FirstMonth",
                table: "Mark",
                newName: "QualitativeAssessmentGrades");

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 122, DateTimeKind.Local).AddTicks(6249));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 122, DateTimeKind.Local).AddTicks(7426));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 122, DateTimeKind.Local).AddTicks(7451));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 122, DateTimeKind.Local).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 122, DateTimeKind.Local).AddTicks(7465));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 122, DateTimeKind.Local).AddTicks(7475));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 122, DateTimeKind.Local).AddTicks(7489));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 122, DateTimeKind.Local).AddTicks(7502));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 122, DateTimeKind.Local).AddTicks(7516));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 122, DateTimeKind.Local).AddTicks(7529));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 122, DateTimeKind.Local).AddTicks(7543));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 122, DateTimeKind.Local).AddTicks(3961));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 122, DateTimeKind.Local).AddTicks(5168));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 122, DateTimeKind.Local).AddTicks(5193));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 122, DateTimeKind.Local).AddTicks(5206));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 119, DateTimeKind.Local).AddTicks(5821));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 119, DateTimeKind.Local).AddTicks(7437));

            migrationBuilder.UpdateData(
                table: "Semester",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 122, DateTimeKind.Local).AddTicks(1544));

            migrationBuilder.UpdateData(
                table: "Semester",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 122, DateTimeKind.Local).AddTicks(2887));

            migrationBuilder.UpdateData(
                table: "SkillsType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(2916));

            migrationBuilder.UpdateData(
                table: "SkillsType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(4077));

            migrationBuilder.UpdateData(
                table: "SkillsType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(4103));

            migrationBuilder.UpdateData(
                table: "SkillsType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(4117));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1026));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1040));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1054));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1079));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1094));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1108));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1122));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1134));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1140));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1146));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1152));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1158));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1164));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1169));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1176));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1182));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1188));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1194));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1203));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1217));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1231));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1245));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1259));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1274));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1290));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1302));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1316));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1330));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1344));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1353));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1359));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1365));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1371));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1377));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1383));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1389));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1395));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1404));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1419));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1433));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1447));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1461));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1475));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1489));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1503));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1517));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1531));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1546));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1554));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1561));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1566));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1572));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1578));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1584));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1592));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1702));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1718));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1732));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1746));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1752));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1758));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1773));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1787));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1801));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1816));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1830));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1844));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1856));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 122, DateTimeKind.Local).AddTicks(8697));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(932));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(958));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(976));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 600,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(984));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 700,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(998));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 800,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(1012));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(5065));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(7934));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(7960));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(7974));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(7988));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 600,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(7997));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 700,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(8010));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 800,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(8025));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 900,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(8038));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1000,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(8052));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1100,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(8062));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1200,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(8068));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1300,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(8073));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1400,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(8081));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1500,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(8089));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1600,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(8102));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1700,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 7, 2, 11, 32, 123, DateTimeKind.Local).AddTicks(8116));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ShortQuizzes",
                table: "Mark",
                newName: "SecondMonth");

            migrationBuilder.RenameColumn(
                name: "QualitativeAssessmentGrades",
                table: "Mark",
                newName: "FirstMonth");

            migrationBuilder.AddColumn<float>(
                name: "MidTermValue",
                table: "Mark",
                type: "real",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 864, DateTimeKind.Local).AddTicks(4398));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 865, DateTimeKind.Local).AddTicks(9986));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 866, DateTimeKind.Local).AddTicks(54));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 866, DateTimeKind.Local).AddTicks(70));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 866, DateTimeKind.Local).AddTicks(84));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 866, DateTimeKind.Local).AddTicks(99));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 866, DateTimeKind.Local).AddTicks(114));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 866, DateTimeKind.Local).AddTicks(1074));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 866, DateTimeKind.Local).AddTicks(1086));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 866, DateTimeKind.Local).AddTicks(1091));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 866, DateTimeKind.Local).AddTicks(1096));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 863, DateTimeKind.Local).AddTicks(9942));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 864, DateTimeKind.Local).AddTicks(2451));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 864, DateTimeKind.Local).AddTicks(2490));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 864, DateTimeKind.Local).AddTicks(2505));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 855, DateTimeKind.Local).AddTicks(4676));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 855, DateTimeKind.Local).AddTicks(6406));

            migrationBuilder.UpdateData(
                table: "Semester",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 862, DateTimeKind.Local).AddTicks(8662));

            migrationBuilder.UpdateData(
                table: "Semester",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 863, DateTimeKind.Local).AddTicks(2687));

            migrationBuilder.UpdateData(
                table: "SkillsType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 868, DateTimeKind.Local).AddTicks(1671));

            migrationBuilder.UpdateData(
                table: "SkillsType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 868, DateTimeKind.Local).AddTicks(3370));

            migrationBuilder.UpdateData(
                table: "SkillsType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 868, DateTimeKind.Local).AddTicks(3402));

            migrationBuilder.UpdateData(
                table: "SkillsType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 868, DateTimeKind.Local).AddTicks(3416));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(8613));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(8628));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(8643));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(8658));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(8815));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(8832));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(8840));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(8847));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(8856));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(8865));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(8874));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(8889));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(8901));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(8907));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(8913));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(8918));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(8923));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(8929));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(8934));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(8939));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(8964));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(8979));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(8986));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(8991));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(8997));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(9003));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(9009));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(9015));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(9021));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(9026));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(9033));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(9040));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(9046));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(9053));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(9067));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(9073));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(9086));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(9094));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(9100));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(9106));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(9113));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(9127));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(9141));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(9154));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(9169));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(9184));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(9198));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(9222));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(9228));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(9242));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(9254));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(9262));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(9268));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(9276));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(9289));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(9302));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(9316));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(9329));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(9343));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(9358));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(9372));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(9386));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(9404));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(9419));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(9433));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 866, DateTimeKind.Local).AddTicks(7626));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(8448));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(8515));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(8531));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(8545));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 600,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(8559));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 700,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(8573));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 800,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 867, DateTimeKind.Local).AddTicks(8587));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 868, DateTimeKind.Local).AddTicks(4857));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 868, DateTimeKind.Local).AddTicks(9352));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 868, DateTimeKind.Local).AddTicks(9401));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 868, DateTimeKind.Local).AddTicks(9415));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 868, DateTimeKind.Local).AddTicks(9421));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 600,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 868, DateTimeKind.Local).AddTicks(9427));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 700,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 868, DateTimeKind.Local).AddTicks(9434));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 800,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 868, DateTimeKind.Local).AddTicks(9440));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 900,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 868, DateTimeKind.Local).AddTicks(9446));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1000,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 868, DateTimeKind.Local).AddTicks(9454));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1100,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 868, DateTimeKind.Local).AddTicks(9460));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1200,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 868, DateTimeKind.Local).AddTicks(9467));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1300,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 868, DateTimeKind.Local).AddTicks(9474));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1400,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 868, DateTimeKind.Local).AddTicks(9481));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1500,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 868, DateTimeKind.Local).AddTicks(9486));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1600,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 868, DateTimeKind.Local).AddTicks(9494));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1700,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 18, 56, 26, 868, DateTimeKind.Local).AddTicks(9499));
        }
    }
}
