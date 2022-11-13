using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace School.DataAccess.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "SchoolYear",
                table: "Student",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(2389));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(3734));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(3759));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(3768));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(3783));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(3846));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(3864));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(3873));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(3881));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(3888));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(3902));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 665, DateTimeKind.Local).AddTicks(9859));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(1209));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(1237));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(1253));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 662, DateTimeKind.Local).AddTicks(7579));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 662, DateTimeKind.Local).AddTicks(9339));

            migrationBuilder.UpdateData(
                table: "Semester",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 665, DateTimeKind.Local).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "Semester",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 665, DateTimeKind.Local).AddTicks(8670));

            migrationBuilder.UpdateData(
                table: "SkillsType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 667, DateTimeKind.Local).AddTicks(706));

            migrationBuilder.UpdateData(
                table: "SkillsType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 667, DateTimeKind.Local).AddTicks(2116));

            migrationBuilder.UpdateData(
                table: "SkillsType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 667, DateTimeKind.Local).AddTicks(2142));

            migrationBuilder.UpdateData(
                table: "SkillsType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 667, DateTimeKind.Local).AddTicks(2148));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(7857));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(7863));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(7877));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(7893));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(7909));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(7924));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(7940));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(7956));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(7970));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(7987));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(8002));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(8170));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(8188));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(8204));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(8219));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(8233));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(8246));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(8253));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(8261));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(8267));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(8274));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(8286));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(8293));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(8299));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(8306));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(8311));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(8341));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(8385));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(8400));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(8416));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(8428));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(8442));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(8458));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(8473));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(8487));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(8493));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(8499));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(8506));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(8513));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(8519));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(8525));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(8532));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(8538));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(8546));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(8561));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(8576));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(8591));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(8606));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(8621));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(8635));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(8649));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(8664));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(8677));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(8691));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(8705));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(8719));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(8726));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(8741));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(8752));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(8759));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(8776));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(8791));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(8806));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(5153));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(7736));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(7765));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(7782));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(7800));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 600,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(7816));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 700,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(7833));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 800,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 666, DateTimeKind.Local).AddTicks(7850));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 667, DateTimeKind.Local).AddTicks(3364));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 667, DateTimeKind.Local).AddTicks(6676));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 667, DateTimeKind.Local).AddTicks(6706));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 667, DateTimeKind.Local).AddTicks(6722));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 667, DateTimeKind.Local).AddTicks(6738));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 600,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 667, DateTimeKind.Local).AddTicks(6753));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 700,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 667, DateTimeKind.Local).AddTicks(6768));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 800,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 667, DateTimeKind.Local).AddTicks(6783));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 900,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 667, DateTimeKind.Local).AddTicks(6798));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1000,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 667, DateTimeKind.Local).AddTicks(6813));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1100,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 667, DateTimeKind.Local).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1200,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 667, DateTimeKind.Local).AddTicks(6841));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1300,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 667, DateTimeKind.Local).AddTicks(6848));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1400,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 667, DateTimeKind.Local).AddTicks(6858));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1500,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 667, DateTimeKind.Local).AddTicks(6872));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1600,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 667, DateTimeKind.Local).AddTicks(6888));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1700,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 14, 29, 46, 667, DateTimeKind.Local).AddTicks(6903));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SchoolYear",
                table: "Student",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 977, DateTimeKind.Local).AddTicks(8811));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 977, DateTimeKind.Local).AddTicks(9766));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 977, DateTimeKind.Local).AddTicks(9782));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 977, DateTimeKind.Local).AddTicks(9788));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 977, DateTimeKind.Local).AddTicks(9793));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 977, DateTimeKind.Local).AddTicks(9798));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 977, DateTimeKind.Local).AddTicks(9802));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 977, DateTimeKind.Local).AddTicks(9807));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 977, DateTimeKind.Local).AddTicks(9812));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 977, DateTimeKind.Local).AddTicks(9818));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 977, DateTimeKind.Local).AddTicks(9822));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 977, DateTimeKind.Local).AddTicks(6636));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 977, DateTimeKind.Local).AddTicks(7689));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 977, DateTimeKind.Local).AddTicks(7709));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 977, DateTimeKind.Local).AddTicks(7715));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 974, DateTimeKind.Local).AddTicks(5213));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 974, DateTimeKind.Local).AddTicks(6704));

            migrationBuilder.UpdateData(
                table: "Semester",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 977, DateTimeKind.Local).AddTicks(2061));

            migrationBuilder.UpdateData(
                table: "Semester",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 977, DateTimeKind.Local).AddTicks(4789));

            migrationBuilder.UpdateData(
                table: "SkillsType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(6469));

            migrationBuilder.UpdateData(
                table: "SkillsType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(8893));

            migrationBuilder.UpdateData(
                table: "SkillsType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(8934));

            migrationBuilder.UpdateData(
                table: "SkillsType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(8946));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4363));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4375));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4385));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4396));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4400));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4404));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4408));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4412));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4415));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4419));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4425));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4429));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4433));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4437));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4442));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4446));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4451));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4455));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4464));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4469));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4473));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4477));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4482));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4486));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4494));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4498));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4509));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4514));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4517));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4638));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4646));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4656));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4661));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4665));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4673));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4677));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4681));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4686));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4694));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4698));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4703));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4708));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4713));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4717));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4721));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4726));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4731));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4736));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4741));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4747));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4752));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4758));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4764));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4769));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4775));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4781));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4786));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4790));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4794));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4798));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4802));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4806));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4811));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4817));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(1008));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4255));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4295));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4306));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4316));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 600,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4327));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 700,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4339));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 800,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 978, DateTimeKind.Local).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 979, DateTimeKind.Local).AddTicks(1867));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 979, DateTimeKind.Local).AddTicks(7260));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 979, DateTimeKind.Local).AddTicks(7307));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 979, DateTimeKind.Local).AddTicks(7313));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 979, DateTimeKind.Local).AddTicks(7317));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 600,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 979, DateTimeKind.Local).AddTicks(7321));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 700,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 979, DateTimeKind.Local).AddTicks(7326));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 800,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 979, DateTimeKind.Local).AddTicks(7330));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 900,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 979, DateTimeKind.Local).AddTicks(7334));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1000,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 979, DateTimeKind.Local).AddTicks(7338));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1100,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 979, DateTimeKind.Local).AddTicks(7342));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1200,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 979, DateTimeKind.Local).AddTicks(7348));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1300,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 979, DateTimeKind.Local).AddTicks(7352));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1400,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 979, DateTimeKind.Local).AddTicks(7356));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1500,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 979, DateTimeKind.Local).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1600,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 979, DateTimeKind.Local).AddTicks(7364));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1700,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 3, 7, 4, 979, DateTimeKind.Local).AddTicks(7368));
        }
    }
}
