using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace School.DataAccess.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(930));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(2226));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(2252));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(2258));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(2264));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(2271));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(2277));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(2283));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(2289));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(2295));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(2301));

            migrationBuilder.InsertData(
                table: "Decisions",
                columns: new[] { "Id", "AllowToCreatMarks", "AllowToUpdatedMarks", "CreatedAllowedFrom", "CreatedAllowedTo", "CreatedAt", "CreatedBy", "IsActive", "IsArchive", "IsDelete", "UpdatedAllowedFrom", "UpdatedAllowedTo", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 3, false, false, null, null, new DateTime(2022, 10, 15, 15, 1, 50, 323, DateTimeKind.Local).AddTicks(4872), null, null, false, false, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 323, DateTimeKind.Local).AddTicks(8449));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 323, DateTimeKind.Local).AddTicks(9774));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 323, DateTimeKind.Local).AddTicks(9801));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 323, DateTimeKind.Local).AddTicks(9810));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 320, DateTimeKind.Local).AddTicks(5616));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 320, DateTimeKind.Local).AddTicks(7357));

            migrationBuilder.UpdateData(
                table: "Semester",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 323, DateTimeKind.Local).AddTicks(1981));

            migrationBuilder.UpdateData(
                table: "Semester",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 323, DateTimeKind.Local).AddTicks(3349));

            migrationBuilder.UpdateData(
                table: "SkillsType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(8457));

            migrationBuilder.UpdateData(
                table: "SkillsType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(9757));

            migrationBuilder.UpdateData(
                table: "SkillsType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(9783));

            migrationBuilder.UpdateData(
                table: "SkillsType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(9791));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(6428));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(6435));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(6442));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(6449));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(6458));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(6465));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(6472));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(6480));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(6487));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(6494));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(6502));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(6508));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(6514));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(6520));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(6525));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(6531));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(6537));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(6542));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(6549));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(6556));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(6561));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(6568));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(6575));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(6582));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(6589));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(6595));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(6602));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(6608));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(6614));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(6619));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(6803));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(6814));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(6821));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(6829));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(6836));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(6843));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(6851));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(6858));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(6865));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(6873));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(6881));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(6889));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(6903));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(6911));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(6918));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(6925));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(6937));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(6944));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(6951));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(6959));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(6966));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(6974));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(6981));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(6989));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(6998));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(7005));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(7013));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(7028));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(7035));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(7043));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(7051));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(7059));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(7067));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(7077));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(7085));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(7092));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(3477));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(6382));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(6391));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(6398));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 600,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(6407));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 700,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(6413));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 800,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(6421));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 325, DateTimeKind.Local).AddTicks(1140));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 325, DateTimeKind.Local).AddTicks(4234));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 327, DateTimeKind.Local).AddTicks(3416));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 327, DateTimeKind.Local).AddTicks(3528));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 327, DateTimeKind.Local).AddTicks(3539));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 600,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 327, DateTimeKind.Local).AddTicks(3546));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 700,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 327, DateTimeKind.Local).AddTicks(3553));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 800,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 327, DateTimeKind.Local).AddTicks(3560));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 900,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 327, DateTimeKind.Local).AddTicks(3567));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1000,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 327, DateTimeKind.Local).AddTicks(3574));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1100,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 327, DateTimeKind.Local).AddTicks(3796));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1200,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 327, DateTimeKind.Local).AddTicks(3807));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1300,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 327, DateTimeKind.Local).AddTicks(3814));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1400,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 327, DateTimeKind.Local).AddTicks(3820));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1500,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 327, DateTimeKind.Local).AddTicks(3826));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1600,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 327, DateTimeKind.Local).AddTicks(3832));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1700,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 327, DateTimeKind.Local).AddTicks(3838));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Decisions",
                keyColumn: "Id",
                keyValue: 3);

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
    }
}
