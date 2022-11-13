using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace School.DataAccess.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Classes_ClassId",
                table: "Skills");

            migrationBuilder.DropForeignKey(
                name: "FK_SkillsBehavior_Classes_ClassId",
                table: "SkillsBehavior");

            migrationBuilder.DropTable(
                name: "SkillsSuggestions");

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
                name: "AppointmentYear",
                table: "Teacher");

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

            migrationBuilder.AlterColumn<int>(
                name: "ClassId",
                table: "SkillsBehavior",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ClassId",
                table: "Skills",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(2572));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(3758));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(3779));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(3785));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(3795));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(3801));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(3806));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(3811));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(3819));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(3825), "   الصف الحادي عشر أدبي" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Capacity", "CreatedAt", "CreatedBy", "IsActive", "IsArchive", "IsDelete", "Name", "Symbol", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 112, 0, new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(3830), null, null, false, false, "  الصف الحادي عشر علمي", null, null, null },
                    { 113, 0, new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(3835), null, null, false, false, "   الصف الثاني عشر", null, null, null }
                });

            migrationBuilder.UpdateData(
                table: "Decisions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 66, DateTimeKind.Local).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(238));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(1649));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(1680));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 63, DateTimeKind.Local).AddTicks(315));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 63, DateTimeKind.Local).AddTicks(1921));

            migrationBuilder.UpdateData(
                table: "Semester",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 66, DateTimeKind.Local).AddTicks(4881));

            migrationBuilder.UpdateData(
                table: "Semester",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 66, DateTimeKind.Local).AddTicks(6280));

            migrationBuilder.UpdateData(
                table: "SkillsType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(8006));

            migrationBuilder.UpdateData(
                table: "SkillsType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(9067));

            migrationBuilder.UpdateData(
                table: "SkillsType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(9085));

            migrationBuilder.UpdateData(
                table: "SkillsType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(9097));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(6515));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(6521));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(6526));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(6532));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(6537));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(6543));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(6548));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(6554));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(6560));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(6566));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(6571));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(6577));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(6582));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(6588));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(6593));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(6599));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(6606));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(6612));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(6625));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(6631));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(6787));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(6797));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(6802));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(6809));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(6816));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(6821));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(6826));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(6831));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(6837));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(6843));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(6848));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(6854));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(6859));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(6865));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(6877));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(6884));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(6901));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(6907));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(6918));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(6924));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(6929));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(6934));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(6941));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(6947));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(6952));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(6957));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(6962));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(6968));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(6973));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(6979));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(6985));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(6992));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(7000));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(7006));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(7013));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(7018));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(7024));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(7030));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(7035));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(7041));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(7047));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(7052));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(7058));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(7063));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(7069));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(4675));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(6459));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(6482));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(6488));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(6494));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 600,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 700,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(6505));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 800,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 67, DateTimeKind.Local).AddTicks(6510));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 68, DateTimeKind.Local).AddTicks(275));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 68, DateTimeKind.Local).AddTicks(3763));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 68, DateTimeKind.Local).AddTicks(3805));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 68, DateTimeKind.Local).AddTicks(3817));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 68, DateTimeKind.Local).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 600,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 68, DateTimeKind.Local).AddTicks(3835));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 700,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 68, DateTimeKind.Local).AddTicks(3842));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 800,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 68, DateTimeKind.Local).AddTicks(3853));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 900,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 68, DateTimeKind.Local).AddTicks(3867));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1000,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 68, DateTimeKind.Local).AddTicks(3877));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1100,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 68, DateTimeKind.Local).AddTicks(3883));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1200,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 68, DateTimeKind.Local).AddTicks(3896));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1300,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 68, DateTimeKind.Local).AddTicks(3908));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1400,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 68, DateTimeKind.Local).AddTicks(3916));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1500,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 68, DateTimeKind.Local).AddTicks(3922));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1600,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 68, DateTimeKind.Local).AddTicks(3933));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1700,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 22, 6, 53, 46, 68, DateTimeKind.Local).AddTicks(3946));

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Classes_ClassId",
                table: "Skills",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SkillsBehavior_Classes_ClassId",
                table: "SkillsBehavior",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Classes_ClassId",
                table: "Skills");

            migrationBuilder.DropForeignKey(
                name: "FK_SkillsBehavior_Classes_ClassId",
                table: "SkillsBehavior");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.AddColumn<DateTime>(
                name: "AppointmentYear",
                table: "Teacher",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<int>(
                name: "ClassId",
                table: "SkillsBehavior",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClassId",
                table: "Skills",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

            migrationBuilder.CreateTable(
                name: "SkillsSuggestions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsArchive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentId = table.Column<int>(type: "int", nullable: true),
                    SubjectId = table.Column<int>(type: "int", nullable: true),
                    TeacherId = table.Column<int>(type: "int", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillsSuggestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SkillsSuggestions_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SkillsSuggestions_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SkillsSuggestions_Subject_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SkillsSuggestions_Teacher_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teacher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 10, 15, 15, 1, 50, 324, DateTimeKind.Local).AddTicks(2301), "   الصف الحادي عشر" });

            migrationBuilder.UpdateData(
                table: "Decisions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 15, 15, 1, 50, 323, DateTimeKind.Local).AddTicks(4872));

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

            migrationBuilder.CreateIndex(
                name: "IX_SkillsSuggestions_ClassId",
                table: "SkillsSuggestions",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillsSuggestions_StudentId",
                table: "SkillsSuggestions",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillsSuggestions_SubjectId",
                table: "SkillsSuggestions",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillsSuggestions_TeacherId",
                table: "SkillsSuggestions",
                column: "TeacherId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Classes_ClassId",
                table: "Skills",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SkillsBehavior_Classes_ClassId",
                table: "SkillsBehavior",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
