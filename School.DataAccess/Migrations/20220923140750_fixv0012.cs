using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace School.DataAccess.Migrations
{
    public partial class fixv0012 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mark_SkillsType_FinalSkillsTypeId",
                table: "Mark");

            migrationBuilder.DropForeignKey(
                name: "FK_Mark_SkillsType_FSkillsTypeId",
                table: "Mark");

            migrationBuilder.DropForeignKey(
                name: "FK_Mark_SkillsType_MSkillsTypeId",
                table: "Mark");

            migrationBuilder.DropIndex(
                name: "IX_Mark_FinalSkillsTypeId",
                table: "Mark");

            migrationBuilder.DropIndex(
                name: "IX_Mark_FSkillsTypeId",
                table: "Mark");

            migrationBuilder.DropIndex(
                name: "IX_Mark_MSkillsTypeId",
                table: "Mark");

            migrationBuilder.DropColumn(
                name: "FSkillsTypeId",
                table: "Mark");

            migrationBuilder.DropColumn(
                name: "FinalSkillsTypeId",
                table: "Mark");

            migrationBuilder.DropColumn(
                name: "IsAllowToAdd",
                table: "Mark");

            migrationBuilder.DropColumn(
                name: "MSkillsTypeId",
                table: "Mark");

            migrationBuilder.DropColumn(
                name: "Notice",
                table: "Mark");

            migrationBuilder.AlterColumn<float>(
                name: "FirstTermValue",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "FirstTermValue",
                table: "Mark",
                type: "real",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AddColumn<int>(
                name: "FSkillsTypeId",
                table: "Mark",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FinalSkillsTypeId",
                table: "Mark",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsAllowToAdd",
                table: "Mark",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MSkillsTypeId",
                table: "Mark",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Notice",
                table: "Mark",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(2858));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(3925));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(3932));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(3938));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(3945));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(3973));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(3979));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(3985));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(3991));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(3997));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(991));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(1860));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(1884));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(1890));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 846, DateTimeKind.Local).AddTicks(3664));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 846, DateTimeKind.Local).AddTicks(4693));

            migrationBuilder.UpdateData(
                table: "Semester",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 847, DateTimeKind.Local).AddTicks(9579));

            migrationBuilder.UpdateData(
                table: "Semester",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(343));

            migrationBuilder.UpdateData(
                table: "SkillsType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(8611));

            migrationBuilder.UpdateData(
                table: "SkillsType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(9457));

            migrationBuilder.UpdateData(
                table: "SkillsType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(9475));

            migrationBuilder.UpdateData(
                table: "SkillsType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(9479));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(6994));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7000));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7006));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7012));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7018));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7023));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7029));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7035));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7041));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7047));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7053));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7059));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7065));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7071));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7078));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7084));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7096));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7102));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7108));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7115));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7121));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7128));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7135));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7141));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7147));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7154));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7166));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7172));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7178));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7185));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7191));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7197));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7203));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7209));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7216));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7222));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7228));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7235));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7241));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7247));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7253));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7259));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7265));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7288));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7294));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7301));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7307));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7313));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7319));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7326));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7332));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7338));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7344));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7350));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7356));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7363));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7370));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7375));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7381));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7389));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7402));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7417));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7431));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7446));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7471));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(7482));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(5009));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(6934));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(6957));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(6963));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 600,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(6976));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 700,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(6982));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 800,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 848, DateTimeKind.Local).AddTicks(6988));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 849, DateTimeKind.Local).AddTicks(201));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 849, DateTimeKind.Local).AddTicks(2133));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 849, DateTimeKind.Local).AddTicks(2151));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 849, DateTimeKind.Local).AddTicks(2156));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 849, DateTimeKind.Local).AddTicks(2160));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 600,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 849, DateTimeKind.Local).AddTicks(2165));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 700,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 849, DateTimeKind.Local).AddTicks(2169));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 800,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 849, DateTimeKind.Local).AddTicks(2173));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 900,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 849, DateTimeKind.Local).AddTicks(2177));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1000,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 849, DateTimeKind.Local).AddTicks(2181));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1100,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 849, DateTimeKind.Local).AddTicks(2185));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1200,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 849, DateTimeKind.Local).AddTicks(2189));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1300,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 849, DateTimeKind.Local).AddTicks(2193));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1400,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 849, DateTimeKind.Local).AddTicks(2198));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1500,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 849, DateTimeKind.Local).AddTicks(2220));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1600,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 849, DateTimeKind.Local).AddTicks(2225));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1700,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 17, 21, 34, 26, 849, DateTimeKind.Local).AddTicks(2229));

            migrationBuilder.CreateIndex(
                name: "IX_Mark_FinalSkillsTypeId",
                table: "Mark",
                column: "FinalSkillsTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Mark_FSkillsTypeId",
                table: "Mark",
                column: "FSkillsTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Mark_MSkillsTypeId",
                table: "Mark",
                column: "MSkillsTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Mark_SkillsType_FinalSkillsTypeId",
                table: "Mark",
                column: "FinalSkillsTypeId",
                principalTable: "SkillsType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mark_SkillsType_FSkillsTypeId",
                table: "Mark",
                column: "FSkillsTypeId",
                principalTable: "SkillsType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mark_SkillsType_MSkillsTypeId",
                table: "Mark",
                column: "MSkillsTypeId",
                principalTable: "SkillsType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
