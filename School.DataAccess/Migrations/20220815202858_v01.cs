using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace School.DataAccess.Migrations
{
    public partial class v01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Symbol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Capacity = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_Classes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Duration",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_Duration", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EvaluationType",
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
                    table.PrimaryKey("PK_EvaluationType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gender",
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
                    table.PrimaryKey("PK_Gender", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MarkType",
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
                    table.PrimaryKey("PK_MarkType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Semester",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_Semester", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teacher",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_Teacher", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DOP = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddressName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SchoolYear = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlaceOBirth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GenderId = table.Column<int>(type: "int", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    SemesterId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_Student", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Student_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Student_Gender_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Gender",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Student_Semester_SemesterId",
                        column: x => x.SemesterId,
                        principalTable: "Semester",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Subject",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_Subject", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subject_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Subject_Teacher_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teacher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notice",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Notices = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_Notice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notice_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Evaluation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    SubjectId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    TeacherId = table.Column<int>(type: "int", nullable: false),
                    DurationId = table.Column<int>(type: "int", nullable: false),
                    EvaluationTypeId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_Evaluation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Evaluation_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Evaluation_Duration_DurationId",
                        column: x => x.DurationId,
                        principalTable: "Duration",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Evaluation_EvaluationType_EvaluationTypeId",
                        column: x => x.EvaluationTypeId,
                        principalTable: "EvaluationType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Evaluation_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Evaluation_Subject_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Evaluation_Teacher_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teacher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EvaluationStudentBehavior",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    SubjectId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    TeacherId = table.Column<int>(type: "int", nullable: false),
                    DurationId = table.Column<int>(type: "int", nullable: false),
                    EvaluationTypeId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_EvaluationStudentBehavior", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EvaluationStudentBehavior_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EvaluationStudentBehavior_Duration_DurationId",
                        column: x => x.DurationId,
                        principalTable: "Duration",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EvaluationStudentBehavior_EvaluationType_EvaluationTypeId",
                        column: x => x.EvaluationTypeId,
                        principalTable: "EvaluationType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EvaluationStudentBehavior_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EvaluationStudentBehavior_Subject_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EvaluationStudentBehavior_Teacher_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teacher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Mark",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Notice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstTermValue = table.Column<float>(type: "real", nullable: false),
                    MidTermValue = table.Column<float>(type: "real", nullable: false),
                    FinalTermValue = table.Column<float>(type: "real", nullable: false),
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
                    table.PrimaryKey("PK_Mark", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mark_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mark_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mark_Subject_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mark_Teacher_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teacher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WeaknessStrength",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WeaknessPonts = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrengthPonts = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_WeaknessStrength", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WeaknessStrength_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WeaknessStrength_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WeaknessStrength_Subject_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WeaknessStrength_Teacher_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teacher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Capacity", "CreatedAt", "CreatedBy", "IsActive", "IsArchive", "IsDelete", "Name", "Symbol", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 101, 0, new DateTime(2022, 8, 15, 23, 28, 58, 5, DateTimeKind.Local).AddTicks(7711), null, null, false, false, " الصف الأول ", null, null, null },
                    { 110, 0, new DateTime(2022, 8, 15, 23, 28, 58, 5, DateTimeKind.Local).AddTicks(8531), null, null, false, false, " الصف العاشر ", null, null, null },
                    { 109, 0, new DateTime(2022, 8, 15, 23, 28, 58, 5, DateTimeKind.Local).AddTicks(8527), null, null, false, false, "   الصف التاسع ", null, null, null },
                    { 108, 0, new DateTime(2022, 8, 15, 23, 28, 58, 5, DateTimeKind.Local).AddTicks(8524), null, null, false, false, " الصف الثامن", null, null, null },
                    { 107, 0, new DateTime(2022, 8, 15, 23, 28, 58, 5, DateTimeKind.Local).AddTicks(8521), null, null, false, false, "   الصف السابع ", null, null, null },
                    { 111, 0, new DateTime(2022, 8, 15, 23, 28, 58, 5, DateTimeKind.Local).AddTicks(8534), null, null, false, false, "   الصف الحادي عشر", null, null, null },
                    { 105, 0, new DateTime(2022, 8, 15, 23, 28, 58, 5, DateTimeKind.Local).AddTicks(8514), null, null, false, false, "  الصف الخامس  ", null, null, null },
                    { 104, 0, new DateTime(2022, 8, 15, 23, 28, 58, 5, DateTimeKind.Local).AddTicks(8510), null, null, false, false, "   الصف الرابع ", null, null, null },
                    { 103, 0, new DateTime(2022, 8, 15, 23, 28, 58, 5, DateTimeKind.Local).AddTicks(8507), null, null, false, false, "  الصف الثالث  ", null, null, null },
                    { 102, 0, new DateTime(2022, 8, 15, 23, 28, 58, 5, DateTimeKind.Local).AddTicks(8494), null, null, false, false, " الصف الثاني      ", null, null, null },
                    { 106, 0, new DateTime(2022, 8, 15, 23, 28, 58, 5, DateTimeKind.Local).AddTicks(8518), null, null, false, false, "  الصف السادس  ", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Duration",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsActive", "IsArchive", "IsDelete", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 8, 15, 23, 28, 58, 5, DateTimeKind.Local).AddTicks(5331), null, null, false, false, "الأسبوع الأول ", null, null },
                    { 2, new DateTime(2022, 8, 15, 23, 28, 58, 5, DateTimeKind.Local).AddTicks(5980), null, null, false, false, "الأسبوع الثاني ", null, null },
                    { 3, new DateTime(2022, 8, 15, 23, 28, 58, 5, DateTimeKind.Local).AddTicks(5994), null, null, false, false, "الأسبوع الثالث ", null, null },
                    { 4, new DateTime(2022, 8, 15, 23, 28, 58, 5, DateTimeKind.Local).AddTicks(5998), null, null, false, false, "الأسبوع الرابع ", null, null }
                });

            migrationBuilder.InsertData(
                table: "EvaluationType",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsActive", "IsArchive", "IsDelete", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(1265), null, null, false, false, " ممتاز", null, null },
                    { 2, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(1871), null, null, false, false, "جيد جدا ", null, null },
                    { 3, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(1884), null, null, false, false, "   جيد  ", null, null },
                    { 4, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(1887), null, null, false, false, "  مقبول   ", null, null }
                });

            migrationBuilder.InsertData(
                table: "Gender",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsActive", "IsArchive", "IsDelete", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 2, new DateTime(2022, 8, 15, 23, 28, 58, 4, DateTimeKind.Local).AddTicks(2796), null, null, false, false, "أنثى", null, null },
                    { 1, new DateTime(2022, 8, 15, 23, 28, 58, 1, DateTimeKind.Local).AddTicks(6506), null, null, false, false, "ذكر", null, null }
                });

            migrationBuilder.InsertData(
                table: "MarkType",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsActive", "IsArchive", "IsDelete", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 3, new DateTime(2022, 8, 15, 23, 28, 58, 5, DateTimeKind.Local).AddTicks(7168), null, null, false, false, "الدرجة النهائية  ", null, null },
                    { 1, new DateTime(2022, 8, 15, 23, 28, 58, 5, DateTimeKind.Local).AddTicks(6549), null, null, false, false, " الدرجة الشهرية ", null, null },
                    { 2, new DateTime(2022, 8, 15, 23, 28, 58, 5, DateTimeKind.Local).AddTicks(7155), null, null, false, false, " الدرجة الفصلية  ", null, null }
                });

            migrationBuilder.InsertData(
                table: "Semester",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsActive", "IsArchive", "IsDelete", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 8, 15, 23, 28, 58, 5, DateTimeKind.Local).AddTicks(3877), null, null, false, false, "الفصل الدراسي الأول ", null, null },
                    { 2, new DateTime(2022, 8, 15, 23, 28, 58, 5, DateTimeKind.Local).AddTicks(4641), null, null, false, false, "الفصل الدراسي الثاني", null, null }
                });

            migrationBuilder.InsertData(
                table: "Teacher",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "EmailAddress", "FirstName", "IsActive", "IsArchive", "IsDelete", "LastName", "PhoneNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1600, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(3865), null, "", "اسلام", null, false, false, "أبو شمالة", "", null, null },
                    { 1500, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(3862), null, "", "سحر ", null, false, false, "لبد", "", null, null },
                    { 1400, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(3858), null, "", "هديل", null, false, false, "عكاشة ", "", null, null },
                    { 1300, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(3855), null, "", "هبة  ", null, false, false, "وشاح", "", null, null },
                    { 1200, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(3852), null, "", "نداء ", null, false, false, "الغولة ", "", null, null },
                    { 1100, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(3848), null, "", " رشا ", null, false, false, " الخضري ", "", null, null },
                    { 1000, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(3845), null, "", "وفاء ", null, false, false, "نصار  ", "", null, null },
                    { 900, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(3842), null, "", " رنا ", null, false, false, "أبو حمد ", "", null, null },
                    { 700, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(3835), null, "", "رانيا", null, false, false, "حسان", "", null, null },
                    { 600, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(3832), null, "", "إسلام  ", null, false, false, "البرعي", "", null, null },
                    { 500, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(3828), null, "", "علا", null, false, false, "محسن", "", null, null },
                    { 400, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(3825), null, "", "رندة ", null, false, false, "الزيناتي ", "", null, null },
                    { 300, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(3821), null, "", "إيمان ", null, false, false, "الجخبير ", "", null, null },
                    { 200, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(3806), null, "", "مها  ", null, false, false, "ستوم", "", null, null },
                    { 100, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(2411), null, "", "ألاء", null, false, false, "أبو شعير", "", null, null },
                    { 800, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(3839), null, "", "اسلام  ", null, false, false, "أبو ندى", "", null, null }
                });

            migrationBuilder.InsertData(
                table: "Teacher",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "EmailAddress", "FirstName", "IsActive", "IsArchive", "IsDelete", "LastName", "PhoneNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 1700, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(3869), null, "", "أمل", null, false, false, "ياسين ", "", null, null });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "Id", "ClassId", "CreatedAt", "CreatedBy", "Description", "IsActive", "IsArchive", "IsDelete", "Name", "TeacherId", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 100, 101, new DateTime(2022, 8, 15, 23, 28, 58, 5, DateTimeKind.Local).AddTicks(9106), null, null, null, false, false, " 	لغة عربية  ", 100, null, null },
                    { 45, 107, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(516), null, null, null, false, false, " 	علوم  ", 1200, null, null },
                    { 71, 111, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(601), null, null, null, false, false, " 	لغة عربية  ", 1100, null, null },
                    { 48, 108, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(526), null, null, null, false, false, " 	لغة عربية  ", 1100, null, null },
                    { 41, 107, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(504), null, null, null, false, false, " 	لغة عربية  ", 1100, null, null },
                    { 40, 106, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(500), null, null, null, false, false, "تكنولوجيا   ", 1000, null, null },
                    { 39, 106, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(497), null, null, null, false, false, "الرياضيات", 1000, null, null },
                    { 38, 106, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(494), null, null, null, false, false, " 	علوم  ", 1000, null, null },
                    { 33, 105, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(478), null, null, null, false, false, "تكنولوجيا   ", 1000, null, null },
                    { 32, 105, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(475), null, null, null, false, false, "الرياضيات", 1000, null, null },
                    { 31, 105, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(472), null, null, null, false, false, " 	علوم  ", 1000, null, null },
                    { 74, 111, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(610), null, null, null, false, false, " تربية إسلامية ", 900, null, null },
                    { 65, 110, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(582), null, null, null, false, false, " تربية إسلامية ", 900, null, null },
                    { 58, 109, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(559), null, null, null, false, false, " تربية إسلامية ", 900, null, null },
                    { 51, 108, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(535), null, null, null, false, false, " تربية إسلامية ", 900, null, null },
                    { 44, 107, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(513), null, null, null, false, false, " تربية إسلامية ", 900, null, null },
                    { 46, 107, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(519), null, null, null, false, false, "الرياضيات", 1200, null, null },
                    { 47, 107, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(523), null, null, null, false, false, "تكنولوجيا   ", 1200, null, null },
                    { 52, 108, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(538), null, null, null, false, false, " 	علوم  ", 1200, null, null },
                    { 53, 108, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(542), null, null, null, false, false, "الرياضيات", 1200, null, null },
                    { 70, 110, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(597), null, null, null, false, false, "تكنولوجيا   ", 1600, null, null },
                    { 68, 110, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(591), null, null, null, false, false, "أحياء", 1600, null, null },
                    { 67, 110, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(588), null, null, null, false, false, "كيمياء", 1600, null, null },
                    { 66, 110, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(585), null, null, null, false, false, "الفيزياء", 1600, null, null },
                    { 59, 109, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(563), null, null, null, false, false, " 	علوم  ", 1600, null, null },
                    { 77, 111, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(620), null, null, null, false, false, "ثقافة عامة", 1500, null, null },
                    { 72, 111, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(604), null, null, null, false, false, "الرياضيات", 1500, null, null },
                    { 37, 106, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(491), null, null, null, false, false, " تربية إسلامية ", 900, null, null },
                    { 69, 110, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(594), null, null, null, false, false, "الرياضيات", 1500, null, null },
                    { 60, 109, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(566), null, null, null, false, false, "الرياضيات", 1500, null, null },
                    { 73, 111, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(607), null, null, null, false, false, "  لغة انجليزية  ", 1400, null, null },
                    { 63, 110, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(575), null, null, null, false, false, "  لغة انجليزية  ", 1400, null, null },
                    { 56, 109, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(552), null, null, null, false, false, "  لغة انجليزية  ", 1400, null, null },
                    { 62, 110, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(572), null, null, null, false, false, " 	لغة عربية  ", 1300, null, null },
                    { 55, 109, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(549), null, null, null, false, false, " 	لغة عربية  ", 1300, null, null },
                    { 54, 108, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(546), null, null, null, false, false, "تكنولوجيا", 1200, null, null },
                    { 61, 109, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(569), null, null, null, false, false, "تكنولوجيا   ", 1500, null, null },
                    { 30, 105, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(469), null, null, null, false, false, " تربية إسلامية ", 900, null, null },
                    { 75, 111, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(613), null, null, null, false, false, " تاريخ   ", 800, null, null },
                    { 64, 110, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(579), null, null, null, false, false, " تاريخ وجغرافيا      ", 800, null, null },
                    { 20, 104, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(376), null, null, null, false, false, " 	لغة عربية  ", 400, null, null },
                    { 19, 103, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(373), null, null, null, false, false, " علوم عامة  ", 300, null, null }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "Id", "ClassId", "CreatedAt", "CreatedBy", "Description", "IsActive", "IsArchive", "IsDelete", "Name", "TeacherId", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 18, 103, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(369), null, null, null, false, false, "الرياضيات", 300, null, null },
                    { 17, 103, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(366), null, null, null, false, false, " 	حاسوب  ", 300, null, null },
                    { 16, 103, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(362), null, null, null, false, false, " تربية إسلامية ", 300, null, null },
                    { 15, 103, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(359), null, null, null, false, false, "تنشئة وطنية واجتماعية ", 300, null, null },
                    { 13, 103, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(352), null, null, null, false, false, " 	لغة عربية  ", 300, null, null },
                    { 22, 104, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(441), null, null, null, false, false, "تنشئة وطنية واجتماعية  ", 400, null, null },
                    { 12, 102, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(349), null, null, null, false, false, "الرياضيات", 200, null, null },
                    { 10, 102, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(343), null, null, null, false, false, " تربية إسلامية ", 200, null, null },
                    { 9, 102, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(339), null, null, null, false, false, "تربية وطنية وحياتية ", 200, null, null },
                    { 700, 102, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(333), null, null, null, false, false, " 	لغة عربية  ", 200, null, null },
                    { 600, 101, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(330), null, null, null, false, false, "الرياضيات", 100, null, null },
                    { 500, 101, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(326), null, null, null, false, false, " 	حاسوب  ", 100, null, null },
                    { 400, 101, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(322), null, null, null, false, false, " تربية إسلامية ", 100, null, null },
                    { 300, 101, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(319), null, null, null, false, false, "تربية وطنية وحياتية ", 100, null, null },
                    { 11, 102, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(346), null, null, null, false, false, " 	حاسوب  ", 200, null, null },
                    { 78, 111, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(623), null, null, null, false, false, "تكنولوجيا   ", 1600, null, null },
                    { 23, 104, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(445), null, null, null, false, false, " تربية إسلامية ", 400, null, null },
                    { 25, 104, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(452), null, null, null, false, false, "الرياضيات", 400, null, null },
                    { 57, 109, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(556), null, null, null, false, false, " دراسات اجتماعية ", 800, null, null },
                    { 50, 108, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(532), null, null, null, false, false, " دراسات اجتماعية ", 800, null, null },
                    { 43, 107, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(510), null, null, null, false, false, " دراسات اجتماعية", 800, null, null },
                    { 36, 106, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(488), null, null, null, false, false, " دراسات اجتماعية", 800, null, null },
                    { 29, 105, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(465), null, null, null, false, false, " دراسات اجتماعية     ", 800, null, null },
                    { 49, 108, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(529), null, null, null, false, false, "  لغة انجليزية  ", 700, null, null },
                    { 42, 107, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(507), null, null, null, false, false, "  لغة انجليزية  ", 700, null, null },
                    { 24, 104, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(449), null, null, null, false, false, " 	حاسوب  ", 400, null, null },
                    { 35, 106, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(485), null, null, null, false, false, "  لغة انجليزية  ", 700, null, null },
                    { 34, 106, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(481), null, null, null, false, false, " 	لغة عربية  ", 600, null, null },
                    { 27, 105, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(459), null, null, null, false, false, " 	لغة عربية  ", 600, null, null },
                    { 21, 104, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(379), null, null, null, false, false, "  لغة انجليزية  ", 500, null, null },
                    { 14, 103, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(356), null, null, null, false, false, "  لغة انجليزية  ", 500, null, null },
                    { 800, 102, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(336), null, null, null, false, false, "  لغة انجليزية  ", 500, null, null },
                    { 200, 101, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(304), null, null, null, false, false, "  لغة انجليزية  ", 500, null, null },
                    { 26, 104, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(455), null, null, null, false, false, " علوم عامة  ", 400, null, null },
                    { 28, 105, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(462), null, null, null, false, false, "  لغة انجليزية  ", 700, null, null },
                    { 76, 111, new DateTime(2022, 8, 15, 23, 28, 58, 6, DateTimeKind.Local).AddTicks(616), null, null, null, false, false, "جغرافيا", 1700, null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

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
                name: "IX_Mark_ClassId",
                table: "Mark",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Mark_StudentId",
                table: "Mark",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Mark_SubjectId",
                table: "Mark",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Mark_TeacherId",
                table: "Mark",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Notice_StudentId",
                table: "Notice",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_ClassId",
                table: "Student",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_GenderId",
                table: "Student",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_SemesterId",
                table: "Student",
                column: "SemesterId");

            migrationBuilder.CreateIndex(
                name: "IX_Subject_ClassId",
                table: "Subject",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Subject_TeacherId",
                table: "Subject",
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Evaluation");

            migrationBuilder.DropTable(
                name: "EvaluationStudentBehavior");

            migrationBuilder.DropTable(
                name: "Mark");

            migrationBuilder.DropTable(
                name: "MarkType");

            migrationBuilder.DropTable(
                name: "Notice");

            migrationBuilder.DropTable(
                name: "WeaknessStrength");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Duration");

            migrationBuilder.DropTable(
                name: "EvaluationType");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Subject");

            migrationBuilder.DropTable(
                name: "Gender");

            migrationBuilder.DropTable(
                name: "Semester");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Teacher");
        }
    }
}
