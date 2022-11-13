using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace School.DataAccess.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mark_Classes_ClassId",
                table: "Mark");

            migrationBuilder.DropForeignKey(
                name: "FK_Mark_Student_StudentId",
                table: "Mark");

            migrationBuilder.DropForeignKey(
                name: "FK_Mark_Subject_SubjectId",
                table: "Mark");

            migrationBuilder.DropForeignKey(
                name: "FK_Mark_Teacher_TeacherId",
                table: "Mark");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_CompletionType_CompletionTypeId",
                table: "Skills");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Duration_DurationId",
                table: "Skills");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Student_StudentId",
                table: "Skills");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Subject_SubjectId",
                table: "Skills");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Teacher_TeacherId",
                table: "Skills");

            migrationBuilder.DropForeignKey(
                name: "FK_SkillsBehavior_CompletionType_CompletionTypeId",
                table: "SkillsBehavior");

            migrationBuilder.DropForeignKey(
                name: "FK_SkillsBehavior_Student_StudentId",
                table: "SkillsBehavior");

            migrationBuilder.DropForeignKey(
                name: "FK_SkillsBehavior_Teacher_TeacherId",
                table: "SkillsBehavior");

            migrationBuilder.DropForeignKey(
                name: "FK_SkillsSuggestions_Classes_ClassId",
                table: "SkillsSuggestions");

            migrationBuilder.DropForeignKey(
                name: "FK_SkillsSuggestions_Student_StudentId",
                table: "SkillsSuggestions");

            migrationBuilder.DropForeignKey(
                name: "FK_SkillsSuggestions_Subject_SubjectId",
                table: "SkillsSuggestions");

            migrationBuilder.DropForeignKey(
                name: "FK_SkillsSuggestions_Teacher_TeacherId",
                table: "SkillsSuggestions");

            migrationBuilder.AlterColumn<int>(
                name: "TeacherId",
                table: "SkillsSuggestions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SubjectId",
                table: "SkillsSuggestions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "SkillsSuggestions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ClassId",
                table: "SkillsSuggestions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TeacherId",
                table: "SkillsBehavior",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "SkillsBehavior",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CompletionTypeId",
                table: "SkillsBehavior",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TeacherId",
                table: "Skills",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SubjectId",
                table: "Skills",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "Skills",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DurationId",
                table: "Skills",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CompletionTypeId",
                table: "Skills",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TeacherId",
                table: "Mark",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SubjectId",
                table: "Mark",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "Mark",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ClassId",
                table: "Mark",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Mark_Classes_ClassId",
                table: "Mark",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mark_Student_StudentId",
                table: "Mark",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mark_Subject_SubjectId",
                table: "Mark",
                column: "SubjectId",
                principalTable: "Subject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mark_Teacher_TeacherId",
                table: "Mark",
                column: "TeacherId",
                principalTable: "Teacher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_CompletionType_CompletionTypeId",
                table: "Skills",
                column: "CompletionTypeId",
                principalTable: "CompletionType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Duration_DurationId",
                table: "Skills",
                column: "DurationId",
                principalTable: "Duration",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Student_StudentId",
                table: "Skills",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Subject_SubjectId",
                table: "Skills",
                column: "SubjectId",
                principalTable: "Subject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Teacher_TeacherId",
                table: "Skills",
                column: "TeacherId",
                principalTable: "Teacher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SkillsBehavior_CompletionType_CompletionTypeId",
                table: "SkillsBehavior",
                column: "CompletionTypeId",
                principalTable: "CompletionType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SkillsBehavior_Student_StudentId",
                table: "SkillsBehavior",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SkillsBehavior_Teacher_TeacherId",
                table: "SkillsBehavior",
                column: "TeacherId",
                principalTable: "Teacher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SkillsSuggestions_Classes_ClassId",
                table: "SkillsSuggestions",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SkillsSuggestions_Student_StudentId",
                table: "SkillsSuggestions",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SkillsSuggestions_Subject_SubjectId",
                table: "SkillsSuggestions",
                column: "SubjectId",
                principalTable: "Subject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SkillsSuggestions_Teacher_TeacherId",
                table: "SkillsSuggestions",
                column: "TeacherId",
                principalTable: "Teacher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mark_Classes_ClassId",
                table: "Mark");

            migrationBuilder.DropForeignKey(
                name: "FK_Mark_Student_StudentId",
                table: "Mark");

            migrationBuilder.DropForeignKey(
                name: "FK_Mark_Subject_SubjectId",
                table: "Mark");

            migrationBuilder.DropForeignKey(
                name: "FK_Mark_Teacher_TeacherId",
                table: "Mark");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_CompletionType_CompletionTypeId",
                table: "Skills");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Duration_DurationId",
                table: "Skills");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Student_StudentId",
                table: "Skills");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Subject_SubjectId",
                table: "Skills");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Teacher_TeacherId",
                table: "Skills");

            migrationBuilder.DropForeignKey(
                name: "FK_SkillsBehavior_CompletionType_CompletionTypeId",
                table: "SkillsBehavior");

            migrationBuilder.DropForeignKey(
                name: "FK_SkillsBehavior_Student_StudentId",
                table: "SkillsBehavior");

            migrationBuilder.DropForeignKey(
                name: "FK_SkillsBehavior_Teacher_TeacherId",
                table: "SkillsBehavior");

            migrationBuilder.DropForeignKey(
                name: "FK_SkillsSuggestions_Classes_ClassId",
                table: "SkillsSuggestions");

            migrationBuilder.DropForeignKey(
                name: "FK_SkillsSuggestions_Student_StudentId",
                table: "SkillsSuggestions");

            migrationBuilder.DropForeignKey(
                name: "FK_SkillsSuggestions_Subject_SubjectId",
                table: "SkillsSuggestions");

            migrationBuilder.DropForeignKey(
                name: "FK_SkillsSuggestions_Teacher_TeacherId",
                table: "SkillsSuggestions");

            migrationBuilder.AlterColumn<int>(
                name: "TeacherId",
                table: "SkillsSuggestions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SubjectId",
                table: "SkillsSuggestions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "SkillsSuggestions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClassId",
                table: "SkillsSuggestions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TeacherId",
                table: "SkillsBehavior",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "SkillsBehavior",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CompletionTypeId",
                table: "SkillsBehavior",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TeacherId",
                table: "Skills",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SubjectId",
                table: "Skills",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "Skills",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DurationId",
                table: "Skills",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CompletionTypeId",
                table: "Skills",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TeacherId",
                table: "Mark",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SubjectId",
                table: "Mark",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "Mark",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClassId",
                table: "Mark",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(5774));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(6388));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(6398));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(6402));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(6406));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(6409));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(6413));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(6416));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(6419));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(6422));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(6426));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(4164));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(4831));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(4845));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(4849));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 574, DateTimeKind.Local).AddTicks(8173));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 574, DateTimeKind.Local).AddTicks(9045));

            migrationBuilder.UpdateData(
                table: "Semester",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(2737));

            migrationBuilder.UpdateData(
                table: "Semester",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(3518));

            migrationBuilder.UpdateData(
                table: "SkillsType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8938));

            migrationBuilder.UpdateData(
                table: "SkillsType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(9565));

            migrationBuilder.UpdateData(
                table: "SkillsType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(9576));

            migrationBuilder.UpdateData(
                table: "SkillsType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8098));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8102));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8105));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8108));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8112));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8115));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8118));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8121));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8124));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8128));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8131));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8134));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8138));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8141));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8144));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8147));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8151));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8154));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8157));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8160));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8164));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8167));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8170));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8174));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8232));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8236));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8243));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8246));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8249));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8252));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8256));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8259));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8262));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8265));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8268));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8271));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8275));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8278));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8281));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8285));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8288));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8292));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8295));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8298));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8302));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8305));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8311));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8314));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8318));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8321));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8331));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8334));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8337));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8343));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8346));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8353));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8359));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8362));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8365));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8373));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8376));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8379));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(6993));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8066));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8078));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8082));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8085));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 600,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8089));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 700,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8092));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 800,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 576, DateTimeKind.Local).AddTicks(8095));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 577, DateTimeKind.Local).AddTicks(145));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 577, DateTimeKind.Local).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 577, DateTimeKind.Local).AddTicks(1481));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 577, DateTimeKind.Local).AddTicks(1485));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 577, DateTimeKind.Local).AddTicks(1489));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 600,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 577, DateTimeKind.Local).AddTicks(1493));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 700,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 577, DateTimeKind.Local).AddTicks(1496));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 800,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 577, DateTimeKind.Local).AddTicks(1500));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 900,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 577, DateTimeKind.Local).AddTicks(1503));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1000,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 577, DateTimeKind.Local).AddTicks(1507));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1100,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 577, DateTimeKind.Local).AddTicks(1510));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1200,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 577, DateTimeKind.Local).AddTicks(1514));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1300,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 577, DateTimeKind.Local).AddTicks(1517));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1400,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 577, DateTimeKind.Local).AddTicks(1521));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1500,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 577, DateTimeKind.Local).AddTicks(1525));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1600,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 577, DateTimeKind.Local).AddTicks(1528));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1700,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 14, 19, 38, 24, 577, DateTimeKind.Local).AddTicks(1531));

            migrationBuilder.AddForeignKey(
                name: "FK_Mark_Classes_ClassId",
                table: "Mark",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Mark_Student_StudentId",
                table: "Mark",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Mark_Subject_SubjectId",
                table: "Mark",
                column: "SubjectId",
                principalTable: "Subject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Mark_Teacher_TeacherId",
                table: "Mark",
                column: "TeacherId",
                principalTable: "Teacher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_CompletionType_CompletionTypeId",
                table: "Skills",
                column: "CompletionTypeId",
                principalTable: "CompletionType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Duration_DurationId",
                table: "Skills",
                column: "DurationId",
                principalTable: "Duration",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Student_StudentId",
                table: "Skills",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Subject_SubjectId",
                table: "Skills",
                column: "SubjectId",
                principalTable: "Subject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Teacher_TeacherId",
                table: "Skills",
                column: "TeacherId",
                principalTable: "Teacher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SkillsBehavior_CompletionType_CompletionTypeId",
                table: "SkillsBehavior",
                column: "CompletionTypeId",
                principalTable: "CompletionType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SkillsBehavior_Student_StudentId",
                table: "SkillsBehavior",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SkillsBehavior_Teacher_TeacherId",
                table: "SkillsBehavior",
                column: "TeacherId",
                principalTable: "Teacher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SkillsSuggestions_Classes_ClassId",
                table: "SkillsSuggestions",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SkillsSuggestions_Student_StudentId",
                table: "SkillsSuggestions",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SkillsSuggestions_Subject_SubjectId",
                table: "SkillsSuggestions",
                column: "SubjectId",
                principalTable: "Subject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SkillsSuggestions_Teacher_TeacherId",
                table: "SkillsSuggestions",
                column: "TeacherId",
                principalTable: "Teacher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
