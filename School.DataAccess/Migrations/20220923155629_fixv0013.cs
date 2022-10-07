using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace School.DataAccess.Migrations
{
    public partial class fixv0013 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FirstTermValue",
                table: "Mark",
                newName: "SecondMonth");

            migrationBuilder.AddColumn<float>(
                name: "FirstMonth",
                table: "Mark",
                type: "real",
                nullable: false,
                defaultValue: 0f);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstMonth",
                table: "Mark");

            migrationBuilder.RenameColumn(
                name: "SecondMonth",
                table: "Mark",
                newName: "FirstTermValue");

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 291, DateTimeKind.Local).AddTicks(1309));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 291, DateTimeKind.Local).AddTicks(6505));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 291, DateTimeKind.Local).AddTicks(6562));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 291, DateTimeKind.Local).AddTicks(6568));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 291, DateTimeKind.Local).AddTicks(6574));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 291, DateTimeKind.Local).AddTicks(6579));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 291, DateTimeKind.Local).AddTicks(6585));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 291, DateTimeKind.Local).AddTicks(6591));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 291, DateTimeKind.Local).AddTicks(6598));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 291, DateTimeKind.Local).AddTicks(6603));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 291, DateTimeKind.Local).AddTicks(6609));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 290, DateTimeKind.Local).AddTicks(4656));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 290, DateTimeKind.Local).AddTicks(6079));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 290, DateTimeKind.Local).AddTicks(6106));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 290, DateTimeKind.Local).AddTicks(6120));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 286, DateTimeKind.Local).AddTicks(5917));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 286, DateTimeKind.Local).AddTicks(7574));

            migrationBuilder.UpdateData(
                table: "Semester",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 289, DateTimeKind.Local).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "Semester",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 290, DateTimeKind.Local).AddTicks(686));

            migrationBuilder.UpdateData(
                table: "SkillsType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(8246));

            migrationBuilder.UpdateData(
                table: "SkillsType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(9662));

            migrationBuilder.UpdateData(
                table: "SkillsType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(9686));

            migrationBuilder.UpdateData(
                table: "SkillsType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(9692));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(5746));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(5752));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(5760));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(5768));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(5773));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(5780));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(5787));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(5794));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(5801));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(5807));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(5813));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(5819));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(5825));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(5832));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(5838));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(5845));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(5852));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(5858));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(5864));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(5876));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(5881));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(5888));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(5894));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(5901));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(5907));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(5914));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(5920));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(5926));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(5932));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(5939));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(5944));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(5950));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(5957));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(5963));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(5969));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(5975));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(5980));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(5986));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(5992));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(5998));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(6008));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(6013));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(6018));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(6024));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(6029));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(6035));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(6040));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(6046));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(6052));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(6058));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(6063));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(6068));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(6074));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(6080));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(6086));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(6092));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(6099));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(6105));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(6111));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(6118));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(6123));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(6129));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(6135));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(6224));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(6234));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(6241));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(6247));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(6252));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(6258));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(1038));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(5453));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(5512));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(5521));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(5710));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 600,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(5726));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 700,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(5732));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 800,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 292, DateTimeKind.Local).AddTicks(5739));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 293, DateTimeKind.Local).AddTicks(1013));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 293, DateTimeKind.Local).AddTicks(4358));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 293, DateTimeKind.Local).AddTicks(4396));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 293, DateTimeKind.Local).AddTicks(4404));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 293, DateTimeKind.Local).AddTicks(4411));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 600,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 293, DateTimeKind.Local).AddTicks(4417));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 700,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 293, DateTimeKind.Local).AddTicks(4423));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 800,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 293, DateTimeKind.Local).AddTicks(4432));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 900,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 293, DateTimeKind.Local).AddTicks(4440));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1000,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 293, DateTimeKind.Local).AddTicks(4445));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1100,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 293, DateTimeKind.Local).AddTicks(4452));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1200,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 293, DateTimeKind.Local).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1300,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 293, DateTimeKind.Local).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1400,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 293, DateTimeKind.Local).AddTicks(4473));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1500,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 293, DateTimeKind.Local).AddTicks(4480));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1600,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 293, DateTimeKind.Local).AddTicks(4486));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1700,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 23, 17, 7, 46, 293, DateTimeKind.Local).AddTicks(4493));
        }
    }
}
