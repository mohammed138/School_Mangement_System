using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace School.DataAccess.Migrations
{
    public partial class v02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExamsTables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Notice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MidTremImg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FinalTremsImg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    IsArchive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamsTables", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExamsTables");

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 5, DateTimeKind.Local).AddTicks(7711));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 5, DateTimeKind.Local).AddTicks(8494));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 5, DateTimeKind.Local).AddTicks(8507));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 5, DateTimeKind.Local).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 5, DateTimeKind.Local).AddTicks(8514));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 5, DateTimeKind.Local).AddTicks(8518));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 5, DateTimeKind.Local).AddTicks(8521));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 5, DateTimeKind.Local).AddTicks(8524));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 5, DateTimeKind.Local).AddTicks(8527));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 5, DateTimeKind.Local).AddTicks(8531));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 5, DateTimeKind.Local).AddTicks(8534));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 5, DateTimeKind.Local).AddTicks(5331));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 5, DateTimeKind.Local).AddTicks(5980));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 5, DateTimeKind.Local).AddTicks(5994));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 5, DateTimeKind.Local).AddTicks(5998));

            migrationBuilder.UpdateData(
                table: "EvaluationType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(1265));

            migrationBuilder.UpdateData(
                table: "EvaluationType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(1871));

            migrationBuilder.UpdateData(
                table: "EvaluationType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(1884));

            migrationBuilder.UpdateData(
                table: "EvaluationType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(1887));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 1, DateTimeKind.Local).AddTicks(6506));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 4, DateTimeKind.Local).AddTicks(2796));

            migrationBuilder.UpdateData(
                table: "MarkType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 5, DateTimeKind.Local).AddTicks(6549));

            migrationBuilder.UpdateData(
                table: "MarkType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 5, DateTimeKind.Local).AddTicks(7155));

            migrationBuilder.UpdateData(
                table: "MarkType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 5, DateTimeKind.Local).AddTicks(7168));

            migrationBuilder.UpdateData(
                table: "Semester",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 5, DateTimeKind.Local).AddTicks(3877));

            migrationBuilder.UpdateData(
                table: "Semester",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 5, DateTimeKind.Local).AddTicks(4641));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(339));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(343));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(346));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(349));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(352));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(356));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(359));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(362));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(366));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(369));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(373));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(376));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(379));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(441));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(445));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(449));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(452));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(455));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(459));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(462));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(465));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(469));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(472));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(475));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(478));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(481));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(485));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(488));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(491));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(494));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(497));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(500));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(504));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(507));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(510));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(513));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(516));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(519));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(523));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(526));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(529));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(532));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(535));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(538));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(542));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(546));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(549));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(552));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(556));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(559));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(563));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(566));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(569));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(572));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(575));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(579));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(582));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(585));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(588));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(591));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(594));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(597));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(601));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(604));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(607));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(610));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(613));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(616));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(620));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(623));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 5, DateTimeKind.Local).AddTicks(9106));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(304));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(319));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(322));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(326));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 600,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(330));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 700,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(333));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 800,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(336));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(2411));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(3806));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(3821));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(3825));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(3828));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 600,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(3832));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 700,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(3835));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 800,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(3839));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 900,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(3842));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1000,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(3845));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1100,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(3848));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1200,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(3852));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1300,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(3855));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1400,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(3858));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1500,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(3862));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1600,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(3865));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1700,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(3869));
        }
    }
}
