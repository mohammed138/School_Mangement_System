using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace School.DataAccess.Migrations
{
    public partial class fixv002 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notice");

            migrationBuilder.DropTable(
                name: "SkillsStudentBehavior");

            migrationBuilder.CreateTable(
                name: "SkillsBehavior",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    SubjectId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    TeacherId = table.Column<int>(type: "int", nullable: false),
                    DurationId = table.Column<int>(type: "int", nullable: false),
                    SkillsTypeId = table.Column<int>(type: "int", nullable: false),
                    Notice = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_SkillsBehavior", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SkillsBehavior_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_SkillsBehavior_Duration_DurationId",
                        column: x => x.DurationId,
                        principalTable: "Duration",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_SkillsBehavior_SkillsType_SkillsTypeId",
                        column: x => x.SkillsTypeId,
                        principalTable: "SkillsType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_SkillsBehavior_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_SkillsBehavior_Subject_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_SkillsBehavior_Teacher_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teacher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 334, DateTimeKind.Local).AddTicks(8292));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 334, DateTimeKind.Local).AddTicks(9477));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 334, DateTimeKind.Local).AddTicks(9499));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 334, DateTimeKind.Local).AddTicks(9505));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 334, DateTimeKind.Local).AddTicks(9511));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 334, DateTimeKind.Local).AddTicks(9516));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 334, DateTimeKind.Local).AddTicks(9521));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 334, DateTimeKind.Local).AddTicks(9527));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 334, DateTimeKind.Local).AddTicks(9532));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 334, DateTimeKind.Local).AddTicks(9538));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 334, DateTimeKind.Local).AddTicks(9545));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 334, DateTimeKind.Local).AddTicks(6073));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 334, DateTimeKind.Local).AddTicks(7165));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 334, DateTimeKind.Local).AddTicks(7186));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 334, DateTimeKind.Local).AddTicks(7192));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 331, DateTimeKind.Local).AddTicks(1237));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 331, DateTimeKind.Local).AddTicks(2221));

            migrationBuilder.UpdateData(
                table: "Semester",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 334, DateTimeKind.Local).AddTicks(3901));

            migrationBuilder.UpdateData(
                table: "Semester",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 334, DateTimeKind.Local).AddTicks(5027));

            migrationBuilder.UpdateData(
                table: "SkillsType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3965));

            migrationBuilder.UpdateData(
                table: "SkillsType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3981));

            migrationBuilder.UpdateData(
                table: "SkillsType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3987));

            migrationBuilder.UpdateData(
                table: "SkillsType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3992));

            migrationBuilder.InsertData(
                table: "SkillsType",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsActive", "IsArchive", "IsDelete", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 10, new DateTime(2022, 9, 15, 9, 2, 40, 334, DateTimeKind.Local).AddTicks(1274), null, null, false, false, "إنجاز سريع", null, null },
                    { 30, new DateTime(2022, 9, 15, 9, 2, 40, 334, DateTimeKind.Local).AddTicks(2673), null, null, false, false, "إنجاز بمساعدة ", null, null },
                    { 40, new DateTime(2022, 9, 15, 9, 2, 40, 334, DateTimeKind.Local).AddTicks(2680), null, null, false, false, "لم ينجز", null, null },
                    { 20, new DateTime(2022, 9, 15, 9, 2, 40, 334, DateTimeKind.Local).AddTicks(2647), null, null, false, false, "إنجاز بمساعدة ", null, null }
                });

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3044));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3050));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3056));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3062));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3068));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3074));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3080));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3086));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3092));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3097));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3103));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3108));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3114));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3126));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3132));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3138));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3145));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3151));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3157));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3162));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3168));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3173));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3185));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3190));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3195));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3201));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3207));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3213));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3219));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3225));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3230));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3236));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3242));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3247));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3253));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3260));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3266));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3272));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3278));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3283));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3288));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3295));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3300));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3306));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3311));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3316));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3322));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3408));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3417));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3422));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3427));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3432));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3438));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3444));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3450));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3461));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3466));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3471));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3477));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3483));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3488));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3492));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3497));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3502));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3508));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3514));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3520));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(674));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(2981));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3009));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3015));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3021));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 600,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3026));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 700,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3032));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 800,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(3038));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(4828));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(7473));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(7505));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(7511));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(7516));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 600,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(7521));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 700,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(7527));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 800,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(7533));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 900,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(7538));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1000,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(7544));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1100,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(7549));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1200,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(7554));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1300,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1400,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(7565));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1500,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(7571));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1600,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(7577));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1700,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 15, 9, 2, 40, 335, DateTimeKind.Local).AddTicks(7584));

            migrationBuilder.CreateIndex(
                name: "IX_SkillsBehavior_ClassId",
                table: "SkillsBehavior",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillsBehavior_DurationId",
                table: "SkillsBehavior",
                column: "DurationId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillsBehavior_SkillsTypeId",
                table: "SkillsBehavior",
                column: "SkillsTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillsBehavior_StudentId",
                table: "SkillsBehavior",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillsBehavior_SubjectId",
                table: "SkillsBehavior",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillsBehavior_TeacherId",
                table: "SkillsBehavior",
                column: "TeacherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SkillsBehavior");

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

            migrationBuilder.CreateTable(
                name: "Notice",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsArchive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    Notices = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notice_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SkillsStudentBehavior",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DurationId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsArchive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    Notice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkillsTypeId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    SubjectId = table.Column<int>(type: "int", nullable: false),
                    TeacherId = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillsStudentBehavior", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SkillsStudentBehavior_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SkillsStudentBehavior_Duration_DurationId",
                        column: x => x.DurationId,
                        principalTable: "Duration",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SkillsStudentBehavior_SkillsType_SkillsTypeId",
                        column: x => x.SkillsTypeId,
                        principalTable: "SkillsType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SkillsStudentBehavior_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SkillsStudentBehavior_Subject_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SkillsStudentBehavior_Teacher_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teacher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(3812));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(5366));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(5390));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(5403));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(5415));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(5423));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(5434));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(5445));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(5457));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(5466));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(5475));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(1185));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(2572));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(2595));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(2609));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 183, DateTimeKind.Local).AddTicks(2986));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 183, DateTimeKind.Local).AddTicks(4737));

            migrationBuilder.UpdateData(
                table: "Semester",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 185, DateTimeKind.Local).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "Semester",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 185, DateTimeKind.Local).AddTicks(9808));

            migrationBuilder.UpdateData(
                table: "SkillsType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 187, DateTimeKind.Local).AddTicks(1392));

            migrationBuilder.UpdateData(
                table: "SkillsType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 187, DateTimeKind.Local).AddTicks(2707));

            migrationBuilder.UpdateData(
                table: "SkillsType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 187, DateTimeKind.Local).AddTicks(2739));

            migrationBuilder.UpdateData(
                table: "SkillsType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 187, DateTimeKind.Local).AddTicks(2751));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(9403));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(9409));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(9415));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(9437));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(9447));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(9453));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(9459));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(9465));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(9472));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(9478));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(9485));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(9491));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(9496));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(9503));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(9509));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(9523));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(9537));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(9548));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(9559));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(9568));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(9574));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(9588));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(9601));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(9615));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(9627));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(9638));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(9650));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(9663));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(9673));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(9681));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(9694));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(9794));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(9802));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(9809));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(9815));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(9821));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(9826));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(9832));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(9838));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(9848));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(9859));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(9872));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(9884));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(9896));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(9902));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(9909));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(9922));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(9936));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(9951));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(9961));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(9972));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(9985));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(9996));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 187, DateTimeKind.Local).AddTicks(6));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 187, DateTimeKind.Local).AddTicks(16));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 187, DateTimeKind.Local).AddTicks(29));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 187, DateTimeKind.Local).AddTicks(42));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 187, DateTimeKind.Local).AddTicks(55));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 187, DateTimeKind.Local).AddTicks(65));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 187, DateTimeKind.Local).AddTicks(72));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 187, DateTimeKind.Local).AddTicks(79));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 187, DateTimeKind.Local).AddTicks(92));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 187, DateTimeKind.Local).AddTicks(101));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 187, DateTimeKind.Local).AddTicks(107));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 187, DateTimeKind.Local).AddTicks(114));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 187, DateTimeKind.Local).AddTicks(121));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 187, DateTimeKind.Local).AddTicks(128));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 187, DateTimeKind.Local).AddTicks(135));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 187, DateTimeKind.Local).AddTicks(147));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(6671));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(9300));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(9333));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(9339));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(9350));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 600,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(9364));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 700,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(9377));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 800,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 186, DateTimeKind.Local).AddTicks(9391));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 187, DateTimeKind.Local).AddTicks(3814));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 187, DateTimeKind.Local).AddTicks(7004));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 187, DateTimeKind.Local).AddTicks(7192));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 187, DateTimeKind.Local).AddTicks(7205));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 187, DateTimeKind.Local).AddTicks(7212));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 600,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 187, DateTimeKind.Local).AddTicks(7218));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 700,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 187, DateTimeKind.Local).AddTicks(7224));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 800,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 187, DateTimeKind.Local).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 900,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 187, DateTimeKind.Local).AddTicks(7238));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1000,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 187, DateTimeKind.Local).AddTicks(7244));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1100,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 187, DateTimeKind.Local).AddTicks(7251));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1200,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 187, DateTimeKind.Local).AddTicks(7257));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1300,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 187, DateTimeKind.Local).AddTicks(7271));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1400,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 187, DateTimeKind.Local).AddTicks(7283));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1500,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 187, DateTimeKind.Local).AddTicks(7296));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1600,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 187, DateTimeKind.Local).AddTicks(7307));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1700,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 14, 0, 31, 29, 187, DateTimeKind.Local).AddTicks(7316));

            migrationBuilder.CreateIndex(
                name: "IX_Notice_StudentId",
                table: "Notice",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillsStudentBehavior_ClassId",
                table: "SkillsStudentBehavior",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillsStudentBehavior_DurationId",
                table: "SkillsStudentBehavior",
                column: "DurationId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillsStudentBehavior_SkillsTypeId",
                table: "SkillsStudentBehavior",
                column: "SkillsTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillsStudentBehavior_StudentId",
                table: "SkillsStudentBehavior",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillsStudentBehavior_SubjectId",
                table: "SkillsStudentBehavior",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillsStudentBehavior_TeacherId",
                table: "SkillsStudentBehavior",
                column: "TeacherId");
        }
    }
}
