using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace School.DataAccess.Migrations
{
    public partial class addentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAllowToAdd",
                table: "Mark",
                type: "bit",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AllowModification",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MarkId = table.Column<int>(type: "int", nullable: false),
                    Answer = table.Column<bool>(type: "bit", nullable: true),
                    AnswerEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TeacherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_AllowModification", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 720, DateTimeKind.Local).AddTicks(8846));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(159));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(186));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(197));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(212));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(226));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(241));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(260));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(266));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(272));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(279));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 720, DateTimeKind.Local).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 720, DateTimeKind.Local).AddTicks(5154));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 720, DateTimeKind.Local).AddTicks(5179));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 720, DateTimeKind.Local).AddTicks(5198));

            migrationBuilder.UpdateData(
                table: "EvaluationType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(7300));

            migrationBuilder.UpdateData(
                table: "EvaluationType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(8703));

            migrationBuilder.UpdateData(
                table: "EvaluationType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(8728));

            migrationBuilder.UpdateData(
                table: "EvaluationType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(8743));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 718, DateTimeKind.Local).AddTicks(369));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 718, DateTimeKind.Local).AddTicks(1705));

            migrationBuilder.UpdateData(
                table: "MarkType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 720, DateTimeKind.Local).AddTicks(6317));

            migrationBuilder.UpdateData(
                table: "MarkType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 720, DateTimeKind.Local).AddTicks(7630));

            migrationBuilder.UpdateData(
                table: "MarkType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 720, DateTimeKind.Local).AddTicks(7657));

            migrationBuilder.UpdateData(
                table: "Semester",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 720, DateTimeKind.Local).AddTicks(943));

            migrationBuilder.UpdateData(
                table: "Semester",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 720, DateTimeKind.Local).AddTicks(2578));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(4735));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(4741));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(4750));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(4763));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(4777));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(4790));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(4804));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(4833));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(4846));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(4874));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(4888));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(4901));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(4915));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(4928));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(4940));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(4978));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(4987));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(4993));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(4998));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5004));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5009));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5014));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5019));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5024));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5029));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5034));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5039));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5045));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5051));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5056));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5062));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5067));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5072));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5078));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5083));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5123));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5128));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5133));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5140));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5146));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5151));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5156));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5161));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5167));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5172));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5177));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5182));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5339));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5348));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5355));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5365));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5375));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5381));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5386));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5391));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5397));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5402));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5413));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5419));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5424));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5428));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5435));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5440));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5446));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(5452));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(1702));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(4654));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(4684));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 600,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(4702));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 700,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(4717));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 800,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 721, DateTimeKind.Local).AddTicks(4727));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 722, DateTimeKind.Local).AddTicks(38));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 722, DateTimeKind.Local).AddTicks(3214));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 722, DateTimeKind.Local).AddTicks(3241));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 722, DateTimeKind.Local).AddTicks(3249));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 722, DateTimeKind.Local).AddTicks(3255));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 600,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 722, DateTimeKind.Local).AddTicks(3261));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 700,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 722, DateTimeKind.Local).AddTicks(3274));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 800,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 722, DateTimeKind.Local).AddTicks(3287));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 900,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 722, DateTimeKind.Local).AddTicks(3301));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1000,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 722, DateTimeKind.Local).AddTicks(3315));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1100,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 722, DateTimeKind.Local).AddTicks(3328));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1200,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 722, DateTimeKind.Local).AddTicks(3342));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1300,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 722, DateTimeKind.Local).AddTicks(3356));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1400,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 722, DateTimeKind.Local).AddTicks(3369));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1500,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 722, DateTimeKind.Local).AddTicks(3384));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1600,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 722, DateTimeKind.Local).AddTicks(3398));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1700,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 3, 15, 44, 32, 722, DateTimeKind.Local).AddTicks(3411));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AllowModification");

            migrationBuilder.DropColumn(
                name: "IsAllowToAdd",
                table: "Mark");

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
    }
}
