using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace School.DataAccess.Migrations
{
    public partial class v6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 25, 23, 57, 41, 698, DateTimeKind.Local).AddTicks(5243));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 25, 23, 57, 41, 698, DateTimeKind.Local).AddTicks(5250));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 25, 23, 57, 41, 698, DateTimeKind.Local).AddTicks(5258));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 25, 23, 57, 41, 698, DateTimeKind.Local).AddTicks(5263));

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Capacity", "CreatedAt", "CreatedBy", "IsActive", "IsArchive", "IsDelete", "Name", "Symbol", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1100, 0, new DateTime(2022, 10, 25, 23, 57, 41, 698, DateTimeKind.Local).AddTicks(5236), null, null, false, false, " الصف العاشر ", null, null, null },
                    { 1090, 0, new DateTime(2022, 10, 25, 23, 57, 41, 698, DateTimeKind.Local).AddTicks(5229), null, null, false, false, "   الصف التاسع ", null, null, null },
                    { 1080, 0, new DateTime(2022, 10, 25, 23, 57, 41, 698, DateTimeKind.Local).AddTicks(5223), null, null, false, false, " الصف الثامن", null, null, null },
                    { 1010, 0, new DateTime(2022, 10, 25, 23, 57, 41, 698, DateTimeKind.Local).AddTicks(3850), null, null, false, false, " الصف الأول ", null, null, null },
                    { 1060, 0, new DateTime(2022, 10, 25, 23, 57, 41, 698, DateTimeKind.Local).AddTicks(5209), null, null, false, false, "  الصف السادس  ", null, null, null },
                    { 1050, 0, new DateTime(2022, 10, 25, 23, 57, 41, 698, DateTimeKind.Local).AddTicks(5202), null, null, false, false, "  الصف الخامس  ", null, null, null },
                    { 1040, 0, new DateTime(2022, 10, 25, 23, 57, 41, 698, DateTimeKind.Local).AddTicks(5193), null, null, false, false, "   الصف الرابع ", null, null, null },
                    { 1030, 0, new DateTime(2022, 10, 25, 23, 57, 41, 698, DateTimeKind.Local).AddTicks(5062), null, null, false, false, "  الصف الثالث  ", null, null, null },
                    { 1020, 0, new DateTime(2022, 10, 25, 23, 57, 41, 698, DateTimeKind.Local).AddTicks(5040), null, null, false, false, " الصف الثاني      ", null, null, null },
                    { 1070, 0, new DateTime(2022, 10, 25, 23, 57, 41, 698, DateTimeKind.Local).AddTicks(5216), null, null, false, false, "   الصف السابع ", null, null, null }
                });

            migrationBuilder.UpdateData(
                table: "Decisions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 25, 23, 57, 41, 697, DateTimeKind.Local).AddTicks(8661));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 25, 23, 57, 41, 698, DateTimeKind.Local).AddTicks(1610));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 25, 23, 57, 41, 698, DateTimeKind.Local).AddTicks(2866));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 25, 23, 57, 41, 698, DateTimeKind.Local).AddTicks(2892));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 25, 23, 57, 41, 698, DateTimeKind.Local).AddTicks(2899));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 25, 23, 57, 41, 694, DateTimeKind.Local).AddTicks(7724));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 25, 23, 57, 41, 695, DateTimeKind.Local).AddTicks(1312));

            migrationBuilder.UpdateData(
                table: "Semester",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 25, 23, 57, 41, 697, DateTimeKind.Local).AddTicks(6219));

            migrationBuilder.UpdateData(
                table: "Semester",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 25, 23, 57, 41, 697, DateTimeKind.Local).AddTicks(7695));

            migrationBuilder.UpdateData(
                table: "SkillsType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 25, 23, 57, 41, 698, DateTimeKind.Local).AddTicks(6285));

            migrationBuilder.UpdateData(
                table: "SkillsType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 25, 23, 57, 41, 698, DateTimeKind.Local).AddTicks(7413));

            migrationBuilder.UpdateData(
                table: "SkillsType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 25, 23, 57, 41, 698, DateTimeKind.Local).AddTicks(7436));

            migrationBuilder.UpdateData(
                table: "SkillsType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 25, 23, 57, 41, 698, DateTimeKind.Local).AddTicks(7447));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 1010);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 1020);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 1030);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 1040);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 1050);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 1060);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 1070);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 1080);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 1090);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 1100);

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 25, 23, 53, 27, 116, DateTimeKind.Local).AddTicks(5655));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 25, 23, 53, 27, 116, DateTimeKind.Local).AddTicks(5662));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 25, 23, 53, 27, 116, DateTimeKind.Local).AddTicks(5669));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 25, 23, 53, 27, 116, DateTimeKind.Local).AddTicks(5676));

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Capacity", "CreatedAt", "CreatedBy", "IsActive", "IsArchive", "IsDelete", "Name", "Symbol", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 110, 0, new DateTime(2022, 10, 25, 23, 53, 27, 116, DateTimeKind.Local).AddTicks(5649), null, null, false, false, " الصف العاشر ", null, null, null },
                    { 109, 0, new DateTime(2022, 10, 25, 23, 53, 27, 116, DateTimeKind.Local).AddTicks(5642), null, null, false, false, "   الصف التاسع ", null, null, null },
                    { 108, 0, new DateTime(2022, 10, 25, 23, 53, 27, 116, DateTimeKind.Local).AddTicks(5636), null, null, false, false, " الصف الثامن", null, null, null },
                    { 101, 0, new DateTime(2022, 10, 25, 23, 53, 27, 116, DateTimeKind.Local).AddTicks(4364), null, null, false, false, " الصف الأول ", null, null, null },
                    { 106, 0, new DateTime(2022, 10, 25, 23, 53, 27, 116, DateTimeKind.Local).AddTicks(5623), null, null, false, false, "  الصف السادس  ", null, null, null },
                    { 105, 0, new DateTime(2022, 10, 25, 23, 53, 27, 116, DateTimeKind.Local).AddTicks(5618), null, null, false, false, "  الصف الخامس  ", null, null, null },
                    { 104, 0, new DateTime(2022, 10, 25, 23, 53, 27, 116, DateTimeKind.Local).AddTicks(5611), null, null, false, false, "   الصف الرابع ", null, null, null },
                    { 103, 0, new DateTime(2022, 10, 25, 23, 53, 27, 116, DateTimeKind.Local).AddTicks(5605), null, null, false, false, "  الصف الثالث  ", null, null, null },
                    { 102, 0, new DateTime(2022, 10, 25, 23, 53, 27, 116, DateTimeKind.Local).AddTicks(5579), null, null, false, false, " الصف الثاني      ", null, null, null },
                    { 107, 0, new DateTime(2022, 10, 25, 23, 53, 27, 116, DateTimeKind.Local).AddTicks(5630), null, null, false, false, "   الصف السابع ", null, null, null }
                });

            migrationBuilder.UpdateData(
                table: "Decisions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 25, 23, 53, 27, 115, DateTimeKind.Local).AddTicks(4058));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 25, 23, 53, 27, 116, DateTimeKind.Local).AddTicks(1548));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 25, 23, 53, 27, 116, DateTimeKind.Local).AddTicks(3042));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 25, 23, 53, 27, 116, DateTimeKind.Local).AddTicks(3071));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 25, 23, 53, 27, 116, DateTimeKind.Local).AddTicks(3079));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 25, 23, 53, 27, 112, DateTimeKind.Local).AddTicks(6322));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 25, 23, 53, 27, 112, DateTimeKind.Local).AddTicks(7868));

            migrationBuilder.UpdateData(
                table: "Semester",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 25, 23, 53, 27, 115, DateTimeKind.Local).AddTicks(1774));

            migrationBuilder.UpdateData(
                table: "Semester",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 25, 23, 53, 27, 115, DateTimeKind.Local).AddTicks(2994));

            migrationBuilder.UpdateData(
                table: "SkillsType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 25, 23, 53, 27, 116, DateTimeKind.Local).AddTicks(6848));

            migrationBuilder.UpdateData(
                table: "SkillsType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 25, 23, 53, 27, 116, DateTimeKind.Local).AddTicks(8005));

            migrationBuilder.UpdateData(
                table: "SkillsType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 25, 23, 53, 27, 116, DateTimeKind.Local).AddTicks(8025));

            migrationBuilder.UpdateData(
                table: "SkillsType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 25, 23, 53, 27, 116, DateTimeKind.Local).AddTicks(8033));
        }
    }
}
