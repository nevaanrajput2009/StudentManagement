using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UI.Web.Migrations
{
    public partial class addTeacherAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TeacherAddress",
                columns: table => new
                {
                    TeacherAddressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address1 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TeacherId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherAddress", x => x.TeacherAddressId);
                    table.ForeignKey(
                        name: "FK_TeacherAddress_TeacherMaster_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "TeacherMaster",
                        principalColumn: "TeachedId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TeacherAddress_TeacherId",
                table: "TeacherAddress",
                column: "TeacherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeacherAddress");
        }
    }
}
