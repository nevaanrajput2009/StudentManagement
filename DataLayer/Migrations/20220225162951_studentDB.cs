using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UI.Web.Migrations
{
    public partial class studentDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Class_Subject",
                columns: table => new
                {
                    ClassSubjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassId = table.Column<int>(type: "int", nullable: true),
                    SubjectId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Class_Subject", x => x.ClassSubjectId);
                });

            migrationBuilder.CreateTable(
                name: "ClassMaster",
                columns: table => new
                {
                    ClassId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    IsActive = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true, defaultValueSql: "('Y')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ClassMas__CB1927C0B2D0D4A5", x => x.ClassId);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmpId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Designation = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Gender = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Employee__AF2DBB992908E9D9", x => x.EmpId);
                });

            migrationBuilder.CreateTable(
                name: "StaffKindMaster",
                columns: table => new
                {
                    StaffKindId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    IsActive = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__StaffKin__494DA322C3442136", x => x.StaffKindId);
                });

            migrationBuilder.CreateTable(
                name: "StaffMemberMaster",
                columns: table => new
                {
                    StaffMemberId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Gender = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    DOB = table.Column<DateTime>(type: "date", nullable: false),
                    StaffKindId = table.Column<int>(type: "int", nullable: true),
                    ManagerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__StaffMem__2C1EBDC16F54351D", x => x.StaffMemberId);
                });

            migrationBuilder.CreateTable(
                name: "StudentMaster",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RollNum = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Gender = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    DOB = table.Column<DateTime>(type: "date", nullable: false),
                    LastName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentMaster", x => x.StudentId);
                });

            migrationBuilder.CreateTable(
                name: "SubjectMaster",
                columns: table => new
                {
                    SubjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Subject = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    IsActive = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true, defaultValueSql: "('Y')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectMaster", x => x.SubjectId);
                });

            migrationBuilder.CreateTable(
                name: "TeacherMaster",
                columns: table => new
                {
                    TeachedId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherMaster", x => x.TeachedId);
                });

            migrationBuilder.CreateTable(
                name: "UserMaster",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__UserMast__1788CC4C8B1E3F46", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "StudentAddress",
                columns: table => new
                {
                    StudentAddressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    MobileNumber = table.Column<decimal>(type: "decimal(12,0)", nullable: true),
                    StudentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentAddress", x => x.StudentAddressId);
                    table.ForeignKey(
                        name: "FK_StudentAddress_StudentMaster",
                        column: x => x.StudentId,
                        principalTable: "StudentMaster",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentClass",
                columns: table => new
                {
                    StudentClassId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentClass", x => x.StudentClassId);
                    table.ForeignKey(
                        name: "FK_StudentClass_ClassMaster",
                        column: x => x.ClassId,
                        principalTable: "ClassMaster",
                        principalColumn: "ClassId");
                    table.ForeignKey(
                        name: "FK_StudentClass_StudentMaster",
                        column: x => x.StudentId,
                        principalTable: "StudentMaster",
                        principalColumn: "StudentId");
                });

            migrationBuilder.CreateTable(
                name: "StudentSubjectDetail",
                columns: table => new
                {
                    StudentSubjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    ClassSubjectId = table.Column<int>(type: "int", nullable: false),
                    Percentage = table.Column<decimal>(type: "numeric(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__StudentS__54F6B821C4BC96E6", x => x.StudentSubjectId);
                    table.ForeignKey(
                        name: "FK_StudentSubject_Class_Subject",
                        column: x => x.ClassSubjectId,
                        principalTable: "Class_Subject",
                        principalColumn: "ClassSubjectId");
                    table.ForeignKey(
                        name: "FK_StudentSubject_StudentMaster",
                        column: x => x.StudentId,
                        principalTable: "StudentMaster",
                        principalColumn: "StudentId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentAddress_StudentId",
                table: "StudentAddress",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentClass_ClassId",
                table: "StudentClass",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentClass_StudentId",
                table: "StudentClass",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentSubjectDetail_ClassSubjectId",
                table: "StudentSubjectDetail",
                column: "ClassSubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentSubjectDetail_StudentId",
                table: "StudentSubjectDetail",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "UQ__UserMast__C9F284562F577134",
                table: "UserMaster",
                column: "UserName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "StaffKindMaster");

            migrationBuilder.DropTable(
                name: "StaffMemberMaster");

            migrationBuilder.DropTable(
                name: "StudentAddress");

            migrationBuilder.DropTable(
                name: "StudentClass");

            migrationBuilder.DropTable(
                name: "StudentSubjectDetail");

            migrationBuilder.DropTable(
                name: "SubjectMaster");

            migrationBuilder.DropTable(
                name: "TeacherMaster");

            migrationBuilder.DropTable(
                name: "UserMaster");

            migrationBuilder.DropTable(
                name: "ClassMaster");

            migrationBuilder.DropTable(
                name: "Class_Subject");

            migrationBuilder.DropTable(
                name: "StudentMaster");
        }
    }
}
