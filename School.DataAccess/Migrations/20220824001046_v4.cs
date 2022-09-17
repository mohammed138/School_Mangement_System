using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace School.DataAccess.Migrations
{
    public partial class v4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "MidTermValue",
                table: "Mark",
                type: "real",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<float>(
                name: "FirstTermValue",
                table: "Mark",
                type: "real",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<float>(
                name: "FinalTermValue",
                table: "Mark",
                type: "real",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AddColumn<int>(
                name: "FEvaluationTypeId",
                table: "Mark",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FinalEvaluationTypeId",
                table: "Mark",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MEvaluationTypeId",
                table: "Mark",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(4006));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(4594));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(4606));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(4614));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(4617));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(4620));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(4623));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(4627));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(4633));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(1208));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(2144));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(2159));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(2162));

            migrationBuilder.UpdateData(
                table: "EvaluationType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(7781));

            migrationBuilder.UpdateData(
                table: "EvaluationType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(8753));

            migrationBuilder.UpdateData(
                table: "EvaluationType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(8772));

            migrationBuilder.UpdateData(
                table: "EvaluationType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(8778));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 75, DateTimeKind.Local).AddTicks(2519));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 75, DateTimeKind.Local).AddTicks(3589));

            migrationBuilder.UpdateData(
                table: "MarkType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(2817));

            migrationBuilder.UpdateData(
                table: "MarkType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(3435));

            migrationBuilder.UpdateData(
                table: "MarkType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(3447));

            migrationBuilder.UpdateData(
                table: "Semester",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 76, DateTimeKind.Local).AddTicks(8923));

            migrationBuilder.UpdateData(
                table: "Semester",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(201));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6484));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6488));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6491));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6494));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6498));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6501));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6504));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6507));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6511));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6514));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6520));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6523));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6527));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6530));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6534));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6537));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6541));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6544));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6547));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6550));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6553));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6557));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6560));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6563));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6566));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6569));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6572));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6576));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6579));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6582));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6585));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6588));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6591));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6595));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6598));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6601));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6604));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6607));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6611));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6614));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6617));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6623));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6626));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6636));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6639));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6643));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6646));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6650));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6653));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6656));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6724));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6727));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6731));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6735));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6738));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6743));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6747));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6753));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6756));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6759));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6765));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6768));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6775));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6781));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(5336));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6451));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6464));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6468));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6471));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 600,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6475));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 700,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6478));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 800,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(6481));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 77, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 78, DateTimeKind.Local).AddTicks(1932));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 78, DateTimeKind.Local).AddTicks(1954));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 78, DateTimeKind.Local).AddTicks(1960));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 78, DateTimeKind.Local).AddTicks(1964));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 600,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 78, DateTimeKind.Local).AddTicks(1969));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 700,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 78, DateTimeKind.Local).AddTicks(1973));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 800,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 78, DateTimeKind.Local).AddTicks(1978));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 900,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 78, DateTimeKind.Local).AddTicks(1983));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1000,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 78, DateTimeKind.Local).AddTicks(1989));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1100,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 78, DateTimeKind.Local).AddTicks(1994));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1200,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 78, DateTimeKind.Local).AddTicks(1998));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1300,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 78, DateTimeKind.Local).AddTicks(2002));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1400,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 78, DateTimeKind.Local).AddTicks(2009));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1500,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 78, DateTimeKind.Local).AddTicks(2014));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1600,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 78, DateTimeKind.Local).AddTicks(2019));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1700,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 24, 3, 10, 45, 78, DateTimeKind.Local).AddTicks(2023));

            migrationBuilder.CreateIndex(
                name: "IX_Mark_FEvaluationTypeId",
                table: "Mark",
                column: "FEvaluationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Mark_FinalEvaluationTypeId",
                table: "Mark",
                column: "FinalEvaluationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Mark_MEvaluationTypeId",
                table: "Mark",
                column: "MEvaluationTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Mark_EvaluationType_FEvaluationTypeId",
                table: "Mark",
                column: "FEvaluationTypeId",
                principalTable: "EvaluationType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mark_EvaluationType_FinalEvaluationTypeId",
                table: "Mark",
                column: "FinalEvaluationTypeId",
                principalTable: "EvaluationType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mark_EvaluationType_MEvaluationTypeId",
                table: "Mark",
                column: "MEvaluationTypeId",
                principalTable: "EvaluationType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mark_EvaluationType_FEvaluationTypeId",
                table: "Mark");

            migrationBuilder.DropForeignKey(
                name: "FK_Mark_EvaluationType_FinalEvaluationTypeId",
                table: "Mark");

            migrationBuilder.DropForeignKey(
                name: "FK_Mark_EvaluationType_MEvaluationTypeId",
                table: "Mark");

            migrationBuilder.DropIndex(
                name: "IX_Mark_FEvaluationTypeId",
                table: "Mark");

            migrationBuilder.DropIndex(
                name: "IX_Mark_FinalEvaluationTypeId",
                table: "Mark");

            migrationBuilder.DropIndex(
                name: "IX_Mark_MEvaluationTypeId",
                table: "Mark");

            migrationBuilder.DropColumn(
                name: "FEvaluationTypeId",
                table: "Mark");

            migrationBuilder.DropColumn(
                name: "FinalEvaluationTypeId",
                table: "Mark");

            migrationBuilder.DropColumn(
                name: "MEvaluationTypeId",
                table: "Mark");

            migrationBuilder.AlterColumn<float>(
                name: "MidTermValue",
                table: "Mark",
                type: "real",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "FirstTermValue",
                table: "Mark",
                type: "real",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "FinalTermValue",
                table: "Mark",
                type: "real",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

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
    }
}
