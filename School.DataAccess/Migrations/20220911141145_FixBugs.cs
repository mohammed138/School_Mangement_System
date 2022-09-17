using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace School.DataAccess.Migrations
{
    public partial class FixBugs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mark_EvaluationType_FEvaluationTypeId",
                table: "Mark");

            migrationBuilder.DropForeignKey(
                name: "FK_Mark_EvaluationType_FinalEvaluationTypeId",
                table: "Mark");

            migrationBuilder.DropForeignKey(
                name: "FK_Mark_EvaluationType_MEvaluationTypeId",
                table: "Mark");

            migrationBuilder.DropTable(
                name: "AllowModification");

            migrationBuilder.DropTable(
                name: "Evaluation");

            migrationBuilder.DropTable(
                name: "EvaluationStudentBehavior");

            migrationBuilder.DropTable(
                name: "ExamsTables");

            migrationBuilder.DropTable(
                name: "MarkType");

            migrationBuilder.DropTable(
                name: "WeaknessStrength");

            migrationBuilder.DropTable(
                name: "EvaluationType");

            migrationBuilder.RenameColumn(
                name: "MEvaluationTypeId",
                table: "Mark",
                newName: "MSkillsTypeId");

            migrationBuilder.RenameColumn(
                name: "FinalEvaluationTypeId",
                table: "Mark",
                newName: "FinalSkillsTypeId");

            migrationBuilder.RenameColumn(
                name: "FEvaluationTypeId",
                table: "Mark",
                newName: "FSkillsTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Mark_MEvaluationTypeId",
                table: "Mark",
                newName: "IX_Mark_MSkillsTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Mark_FinalEvaluationTypeId",
                table: "Mark",
                newName: "IX_Mark_FinalSkillsTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Mark_FEvaluationTypeId",
                table: "Mark",
                newName: "IX_Mark_FSkillsTypeId");

            migrationBuilder.AddColumn<DateTime>(
                name: "AppointmentYear",
                table: "Teacher",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Specialization",
                table: "Teacher",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Decisions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AllowToCreatMarks = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAllowedFrom = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAllowedTo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AllowToUpdatedMarks = table.Column<bool>(type: "bit", nullable: true),
                    UpdatedAllowedFrom = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAllowedTo = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    table.PrimaryKey("PK_Decisions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SkillsSuggestions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    SubjectId = table.Column<int>(type: "int", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    TeacherId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_SkillsSuggestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SkillsSuggestions_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_SkillsSuggestions_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_SkillsSuggestions_Subject_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_SkillsSuggestions_Teacher_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teacher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "SkillsType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_SkillsType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
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
                    table.PrimaryKey("PK_Skills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Skills_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Skills_Duration_DurationId",
                        column: x => x.DurationId,
                        principalTable: "Duration",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Skills_SkillsType_SkillsTypeId",
                        column: x => x.SkillsTypeId,
                        principalTable: "SkillsType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Skills_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Skills_Subject_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Skills_Teacher_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teacher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "SkillsStudentBehavior",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    table.PrimaryKey("PK_SkillsStudentBehavior", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SkillsStudentBehavior_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_SkillsStudentBehavior_Duration_DurationId",
                        column: x => x.DurationId,
                        principalTable: "Duration",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_SkillsStudentBehavior_SkillsType_SkillsTypeId",
                        column: x => x.SkillsTypeId,
                        principalTable: "SkillsType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_SkillsStudentBehavior_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_SkillsStudentBehavior_Subject_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_SkillsStudentBehavior_Teacher_TeacherId",
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
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(1955));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(3162));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(3186));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(3193));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(3199));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(3205));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(3253));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(3260));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(3266));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(3273));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(3278));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 11, 17, 11, 42, 536, DateTimeKind.Local).AddTicks(9313), "الشهر الأول " });

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(619), "الشهر الثاني " });

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(646), "الشهر الثالث " });

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(654), "الشهر الرابع " });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 534, DateTimeKind.Local).AddTicks(4588));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 534, DateTimeKind.Local).AddTicks(5990));

            migrationBuilder.UpdateData(
                table: "Semester",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 536, DateTimeKind.Local).AddTicks(6333));

            migrationBuilder.UpdateData(
                table: "Semester",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 536, DateTimeKind.Local).AddTicks(8051));

            migrationBuilder.InsertData(
                table: "SkillsType",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsActive", "IsArchive", "IsDelete", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(8774), null, null, false, false, " ممتاز", null, null },
                    { 3, new DateTime(2022, 9, 11, 17, 11, 42, 538, DateTimeKind.Local).AddTicks(17), null, null, false, false, "   جيد  ", null, null },
                    { 2, new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(9994), null, null, false, false, "جيد جدا ", null, null },
                    { 4, new DateTime(2022, 9, 11, 17, 11, 42, 538, DateTimeKind.Local).AddTicks(24), null, null, false, false, "  مقبول   ", null, null }
                });

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(6908));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(6915));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(6922));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(6929));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(6935));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(6944));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(6950));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(6956));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(6963));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(6969));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(6976));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(6982));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(6989));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(6995));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(7002));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(7009));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(7016));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(7022));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(7029));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(7035));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(7042));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(7048));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(7055));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(7061));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(7067));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(7074));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(7086));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(7093));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(7105));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(7112));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(7118));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(7124));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(7129));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(7142));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(7148));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(7155));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(7248));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(7258));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(7264));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(7270));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(7276));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(7283));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(7289));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(7295));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(7301));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(7307));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(7313));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(7320));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(7327));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(7333));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(7339));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(7344));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(7351));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(7356));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(7363));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(7370));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(7377));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(7383));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(7389));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(7395));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(7401));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(7407));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(7414));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(7421));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(7428));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(7435));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(7441));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(4422));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(6836));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(6868));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(6876));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(6882));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 600,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(6889));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 700,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 800,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 537, DateTimeKind.Local).AddTicks(6902));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 538, DateTimeKind.Local).AddTicks(1167));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 538, DateTimeKind.Local).AddTicks(4202));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 538, DateTimeKind.Local).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 538, DateTimeKind.Local).AddTicks(4248));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 538, DateTimeKind.Local).AddTicks(4255));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 600,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 538, DateTimeKind.Local).AddTicks(4262));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 700,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 538, DateTimeKind.Local).AddTicks(4268));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 800,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 538, DateTimeKind.Local).AddTicks(4276));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 900,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 538, DateTimeKind.Local).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1000,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 538, DateTimeKind.Local).AddTicks(4421));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1100,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 538, DateTimeKind.Local).AddTicks(4427));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1200,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 538, DateTimeKind.Local).AddTicks(4434));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1300,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 538, DateTimeKind.Local).AddTicks(4442));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1400,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 538, DateTimeKind.Local).AddTicks(4449));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1500,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 538, DateTimeKind.Local).AddTicks(4456));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1600,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 538, DateTimeKind.Local).AddTicks(4464));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1700,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 11, 17, 11, 42, 538, DateTimeKind.Local).AddTicks(4471));

            migrationBuilder.CreateIndex(
                name: "IX_Skills_ClassId",
                table: "Skills",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_DurationId",
                table: "Skills",
                column: "DurationId");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_SkillsTypeId",
                table: "Skills",
                column: "SkillsTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_StudentId",
                table: "Skills",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_SubjectId",
                table: "Skills",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_TeacherId",
                table: "Skills",
                column: "TeacherId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropTable(
                name: "Decisions");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "SkillsStudentBehavior");

            migrationBuilder.DropTable(
                name: "SkillsSuggestions");

            migrationBuilder.DropTable(
                name: "SkillsType");

            migrationBuilder.DropColumn(
                name: "AppointmentYear",
                table: "Teacher");

            migrationBuilder.DropColumn(
                name: "Specialization",
                table: "Teacher");

            migrationBuilder.RenameColumn(
                name: "MSkillsTypeId",
                table: "Mark",
                newName: "MEvaluationTypeId");

            migrationBuilder.RenameColumn(
                name: "FinalSkillsTypeId",
                table: "Mark",
                newName: "FinalEvaluationTypeId");

            migrationBuilder.RenameColumn(
                name: "FSkillsTypeId",
                table: "Mark",
                newName: "FEvaluationTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Mark_MSkillsTypeId",
                table: "Mark",
                newName: "IX_Mark_MEvaluationTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Mark_FSkillsTypeId",
                table: "Mark",
                newName: "IX_Mark_FEvaluationTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Mark_FinalSkillsTypeId",
                table: "Mark",
                newName: "IX_Mark_FinalEvaluationTypeId");

            migrationBuilder.CreateTable(
                name: "AllowModification",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Answer = table.Column<bool>(type: "bit", nullable: true),
                    AnswerEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsArchive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    MarkId = table.Column<int>(type: "int", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeacherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllowModification", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AllowModification_Mark_MarkId",
                        column: x => x.MarkId,
                        principalTable: "Mark",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "EvaluationType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsArchive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvaluationType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExamsTables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FinalTremsImg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsArchive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    MidTremImg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamsTables", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MarkType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsArchive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarkType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WeaknessStrength",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsArchive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    StrengthPonts = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    SubjectId = table.Column<int>(type: "int", nullable: false),
                    TeacherId = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WeaknessPonts = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeaknessStrength", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WeaknessStrength_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_WeaknessStrength_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_WeaknessStrength_Subject_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_WeaknessStrength_Teacher_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teacher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Evaluation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DurationId = table.Column<int>(type: "int", nullable: false),
                    EvaluationTypeId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsArchive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    Notice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    SubjectId = table.Column<int>(type: "int", nullable: false),
                    TeacherId = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evaluation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Evaluation_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Evaluation_Duration_DurationId",
                        column: x => x.DurationId,
                        principalTable: "Duration",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Evaluation_EvaluationType_EvaluationTypeId",
                        column: x => x.EvaluationTypeId,
                        principalTable: "EvaluationType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Evaluation_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Evaluation_Subject_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Evaluation_Teacher_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teacher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "EvaluationStudentBehavior",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DurationId = table.Column<int>(type: "int", nullable: false),
                    EvaluationTypeId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsArchive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    Notice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    SubjectId = table.Column<int>(type: "int", nullable: false),
                    TeacherId = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvaluationStudentBehavior", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EvaluationStudentBehavior_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_EvaluationStudentBehavior_Duration_DurationId",
                        column: x => x.DurationId,
                        principalTable: "Duration",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_EvaluationStudentBehavior_EvaluationType_EvaluationTypeId",
                        column: x => x.EvaluationTypeId,
                        principalTable: "EvaluationType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_EvaluationStudentBehavior_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_EvaluationStudentBehavior_Subject_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_EvaluationStudentBehavior_Teacher_TeacherId",
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
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(1476));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(2611));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(2633));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(2639));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(2646));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(2652));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(2657));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(2664));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(2670));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(2677));

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(2683));

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 7, 21, 19, 5, 382, DateTimeKind.Local).AddTicks(7219), "الأسبوع الأول " });

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 7, 21, 19, 5, 382, DateTimeKind.Local).AddTicks(8392), "الأسبوع الثاني " });

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 7, 21, 19, 5, 382, DateTimeKind.Local).AddTicks(8413), "الأسبوع الثالث " });

            migrationBuilder.UpdateData(
                table: "Duration",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 7, 21, 19, 5, 382, DateTimeKind.Local).AddTicks(8421), "الأسبوع الرابع " });

            migrationBuilder.InsertData(
                table: "EvaluationType",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsActive", "IsArchive", "IsDelete", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(7338), null, null, false, false, " ممتاز", null, null },
                    { 4, new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(8639), null, null, false, false, "  مقبول   ", null, null },
                    { 3, new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(8633), null, null, false, false, "   جيد  ", null, null },
                    { 2, new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(8612), null, null, false, false, "جيد جدا ", null, null }
                });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 380, DateTimeKind.Local).AddTicks(5689));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 380, DateTimeKind.Local).AddTicks(7143));

            migrationBuilder.InsertData(
                table: "MarkType",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsActive", "IsArchive", "IsDelete", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 3, new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(508), null, null, false, false, "الدرجة النهائية  ", null, null },
                    { 2, new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(486), null, null, false, false, " الدرجة الفصلية  ", null, null },
                    { 1, new DateTime(2022, 9, 7, 21, 19, 5, 382, DateTimeKind.Local).AddTicks(9349), null, null, false, false, " الدرجة الشهرية ", null, null }
                });

            migrationBuilder.UpdateData(
                table: "Semester",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 382, DateTimeKind.Local).AddTicks(4899));

            migrationBuilder.UpdateData(
                table: "Semester",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 382, DateTimeKind.Local).AddTicks(6187));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(5913));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(5919));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(5925));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(5931));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(5937));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(5943));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(5949));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(5954));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(5960));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(5966));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(5972));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(5977));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(5983));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(5990));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(5997));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6003));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6009));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6015));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6021));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6027));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6032));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6038));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6044));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6050));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6056));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6061));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6067));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6073));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6089));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6094));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6100));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6106));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6112));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6118));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6124));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6130));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6135));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6141));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6149));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6155));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6161));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6165));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6171));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6176));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6182));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6187));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6193));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6199));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6205));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6211));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6216));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6222));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6228));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6233));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6239));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6245));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6251));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6256));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6261));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6267));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6273));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6277));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6283));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6288));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6294));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6300));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6314));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6321));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(6326));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(3702));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(5854));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(5861));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(5868));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 600,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(5874));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 700,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(5880));

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 800,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(5907));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 383, DateTimeKind.Local).AddTicks(9638));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 384, DateTimeKind.Local).AddTicks(2215));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 384, DateTimeKind.Local).AddTicks(2239));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 384, DateTimeKind.Local).AddTicks(2247));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 384, DateTimeKind.Local).AddTicks(2255));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 600,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 384, DateTimeKind.Local).AddTicks(2261));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 700,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 384, DateTimeKind.Local).AddTicks(2268));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 800,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 384, DateTimeKind.Local).AddTicks(2274));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 900,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 384, DateTimeKind.Local).AddTicks(2281));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1000,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 384, DateTimeKind.Local).AddTicks(2287));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1100,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 384, DateTimeKind.Local).AddTicks(2294));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1200,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 384, DateTimeKind.Local).AddTicks(2301));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1300,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 384, DateTimeKind.Local).AddTicks(2308));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1400,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 384, DateTimeKind.Local).AddTicks(2314));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1500,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 384, DateTimeKind.Local).AddTicks(2320));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1600,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 384, DateTimeKind.Local).AddTicks(2326));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1700,
                column: "CreatedAt",
                value: new DateTime(2022, 9, 7, 21, 19, 5, 384, DateTimeKind.Local).AddTicks(2332));

            migrationBuilder.CreateIndex(
                name: "IX_AllowModification_MarkId",
                table: "AllowModification",
                column: "MarkId");

            migrationBuilder.CreateIndex(
                name: "IX_Evaluation_ClassId",
                table: "Evaluation",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Evaluation_DurationId",
                table: "Evaluation",
                column: "DurationId");

            migrationBuilder.CreateIndex(
                name: "IX_Evaluation_EvaluationTypeId",
                table: "Evaluation",
                column: "EvaluationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Evaluation_StudentId",
                table: "Evaluation",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Evaluation_SubjectId",
                table: "Evaluation",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Evaluation_TeacherId",
                table: "Evaluation",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_EvaluationStudentBehavior_ClassId",
                table: "EvaluationStudentBehavior",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_EvaluationStudentBehavior_DurationId",
                table: "EvaluationStudentBehavior",
                column: "DurationId");

            migrationBuilder.CreateIndex(
                name: "IX_EvaluationStudentBehavior_EvaluationTypeId",
                table: "EvaluationStudentBehavior",
                column: "EvaluationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_EvaluationStudentBehavior_StudentId",
                table: "EvaluationStudentBehavior",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_EvaluationStudentBehavior_SubjectId",
                table: "EvaluationStudentBehavior",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_EvaluationStudentBehavior_TeacherId",
                table: "EvaluationStudentBehavior",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_WeaknessStrength_ClassId",
                table: "WeaknessStrength",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_WeaknessStrength_StudentId",
                table: "WeaknessStrength",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_WeaknessStrength_SubjectId",
                table: "WeaknessStrength",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_WeaknessStrength_TeacherId",
                table: "WeaknessStrength",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Mark_EvaluationType_FEvaluationTypeId",
                table: "Mark",
                column: "FEvaluationTypeId",
                principalTable: "EvaluationType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mark_EvaluationType_FinalEvaluationTypeId",
                table: "Mark",
                column: "FinalEvaluationTypeId",
                principalTable: "EvaluationType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mark_EvaluationType_MEvaluationTypeId",
                table: "Mark",
                column: "MEvaluationTypeId",
                principalTable: "EvaluationType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
