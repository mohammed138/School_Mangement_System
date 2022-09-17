using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace School.DataAccess.Migrations
{
    public partial class fixv004 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skills_SkillsType_SkillsTypeId",
                table: "Skills");

            migrationBuilder.DropForeignKey(
                name: "FK_SkillsBehavior_Duration_DurationId",
                table: "SkillsBehavior");

            migrationBuilder.DropForeignKey(
                name: "FK_SkillsBehavior_SkillsType_SkillsTypeId",
                table: "SkillsBehavior");

            migrationBuilder.DropForeignKey(
                name: "FK_SkillsBehavior_Subject_SubjectId",
                table: "SkillsBehavior");

            migrationBuilder.DeleteData(
                table: "SkillsType",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "SkillsType",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "SkillsType",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "SkillsType",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DropColumn(
                name: "Notice",
                table: "SkillsBehavior");

            migrationBuilder.RenameColumn(
                name: "SkillsTypeId",
                table: "SkillsBehavior",
                newName: "CompletionTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_SkillsBehavior_SkillsTypeId",
                table: "SkillsBehavior",
                newName: "IX_SkillsBehavior_CompletionTypeId");

            migrationBuilder.RenameColumn(
                name: "SkillsTypeId",
                table: "Skills",
                newName: "CompletionTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Skills_SkillsTypeId",
                table: "Skills",
                newName: "IX_Skills_CompletionTypeId");

            migrationBuilder.AlterColumn<int>(
                name: "SubjectId",
                table: "SkillsBehavior",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "SkillsBehavior",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DurationId",
                table: "SkillsBehavior",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Skills",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Gender",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "CompletionType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompletionType", x => x.Id);
                });

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

            migrationBuilder.InsertData(
                table: "CompletionType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "إنجاز سريع" },
                    { 3, "إنجاز بمساعدة " },
                    { 2, "إنجاز بمساعدة " },
                    { 4, "لم ينجز" }
                });

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

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_CompletionType_CompletionTypeId",
                table: "Skills",
                column: "CompletionTypeId",
                principalTable: "CompletionType",
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
                name: "FK_SkillsBehavior_Duration_DurationId",
                table: "SkillsBehavior",
                column: "DurationId",
                principalTable: "Duration",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SkillsBehavior_Subject_SubjectId",
                table: "SkillsBehavior",
                column: "SubjectId",
                principalTable: "Subject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skills_CompletionType_CompletionTypeId",
                table: "Skills");

            migrationBuilder.DropForeignKey(
                name: "FK_SkillsBehavior_CompletionType_CompletionTypeId",
                table: "SkillsBehavior");

            migrationBuilder.DropForeignKey(
                name: "FK_SkillsBehavior_Duration_DurationId",
                table: "SkillsBehavior");

            migrationBuilder.DropForeignKey(
                name: "FK_SkillsBehavior_Subject_SubjectId",
                table: "SkillsBehavior");

            migrationBuilder.DropTable(
                name: "CompletionType");

            migrationBuilder.RenameColumn(
                name: "CompletionTypeId",
                table: "SkillsBehavior",
                newName: "SkillsTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_SkillsBehavior_CompletionTypeId",
                table: "SkillsBehavior",
                newName: "IX_SkillsBehavior_SkillsTypeId");

            migrationBuilder.RenameColumn(
                name: "CompletionTypeId",
                table: "Skills",
                newName: "SkillsTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Skills_CompletionTypeId",
                table: "Skills",
                newName: "IX_Skills_SkillsTypeId");

            migrationBuilder.AlterColumn<int>(
                name: "SubjectId",
                table: "SkillsBehavior",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "SkillsBehavior",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "DurationId",
                table: "SkillsBehavior",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Notice",
                table: "SkillsBehavior",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Skills",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Gender",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(3292));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(4778));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(4804));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(4813));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(4827));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(4833));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(4840));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(4846));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(4853));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(4859));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(755));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(1853));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(1873));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(1881));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 152, DateTimeKind.Local).AddTicks(7855));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 152, DateTimeKind.Local).AddTicks(9405));

            migrationBuilder.UpdateData(
                table: "Semester",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 159, DateTimeKind.Local).AddTicks(8637));

            migrationBuilder.UpdateData(
                table: "Semester",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 159, DateTimeKind.Local).AddTicks(9792));

            migrationBuilder.UpdateData(
                table: "SkillsType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(9628));

            migrationBuilder.UpdateData(
                table: "SkillsType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(9645));

            migrationBuilder.UpdateData(
                table: "SkillsType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(9651));

            migrationBuilder.UpdateData(
                table: "SkillsType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(9658));

            migrationBuilder.InsertData(
                table: "SkillsType",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsActive", "IsArchive", "IsDelete", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 10, new DateTime(2022, 9, 15, 9, 9, 25, 159, DateTimeKind.Local).AddTicks(6036), null, null, false, false, "إنجاز سريع", null, null },
                    { 30, new DateTime(2022, 9, 15, 9, 9, 25, 159, DateTimeKind.Local).AddTicks(7475), null, null, false, false, "إنجاز بمساعدة ", null, null },
                    { 40, new DateTime(2022, 9, 15, 9, 9, 25, 159, DateTimeKind.Local).AddTicks(7484), null, null, false, false, "لم ينجز", null, null },
                    { 20, new DateTime(2022, 9, 15, 9, 9, 25, 159, DateTimeKind.Local).AddTicks(7449), null, null, false, false, "إنجاز بمساعدة ", null, null }
                });

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8232));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8245));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8466));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8489));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8497));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8503));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8516));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8523));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8529));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8536));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8549));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8555));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8562));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8569));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8575));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8582));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8588));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8595));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8601));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8608));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8621));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8627));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8634));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8640));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8647));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8653));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8660));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8667));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8674));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8686));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8693));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8699));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8706));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8713));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8719));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8726));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8739));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8745));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8752));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8759));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8765));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8772));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8778));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8785));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8792));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8798));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8804));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8811));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8817));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8824));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8830));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8837));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8844));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8857));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8863));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8876));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8884));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8891));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8897));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8903));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8910));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(6072));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8167));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8191));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8199));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8206));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 600,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8213));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 700,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8219));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 800,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 160, DateTimeKind.Local).AddTicks(8225));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 161, DateTimeKind.Local).AddTicks(586));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 161, DateTimeKind.Local).AddTicks(3420));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 161, DateTimeKind.Local).AddTicks(3451));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 161, DateTimeKind.Local).AddTicks(3458));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 161, DateTimeKind.Local).AddTicks(3464));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 600,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 161, DateTimeKind.Local).AddTicks(3470));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 700,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 161, DateTimeKind.Local).AddTicks(3477));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 800,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 161, DateTimeKind.Local).AddTicks(3483));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 900,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 161, DateTimeKind.Local).AddTicks(3491));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1000,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 161, DateTimeKind.Local).AddTicks(3497));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1100,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 161, DateTimeKind.Local).AddTicks(3503));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1200,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 161, DateTimeKind.Local).AddTicks(3509));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1300,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 161, DateTimeKind.Local).AddTicks(3515));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1400,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 161, DateTimeKind.Local).AddTicks(3521));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1500,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 161, DateTimeKind.Local).AddTicks(3546));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1600,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 161, DateTimeKind.Local).AddTicks(3552));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1700,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 9, 25, 161, DateTimeKind.Local).AddTicks(3577));

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_SkillsType_SkillsTypeId",
                table: "Skills",
                column: "SkillsTypeId",
                principalTable: "SkillsType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SkillsBehavior_Duration_DurationId",
                table: "SkillsBehavior",
                column: "DurationId",
                principalTable: "Duration",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SkillsBehavior_SkillsType_SkillsTypeId",
                table: "SkillsBehavior",
                column: "SkillsTypeId",
                principalTable: "SkillsType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SkillsBehavior_Subject_SubjectId",
                table: "SkillsBehavior",
                column: "SubjectId",
                principalTable: "Subject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
