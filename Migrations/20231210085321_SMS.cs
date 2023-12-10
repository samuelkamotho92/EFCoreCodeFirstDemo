using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreCodeFirstDemo.Migrations
{
    /// <inheritdoc />
    public partial class SMS : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StandardId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Courses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "StudentAddresses",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    Address1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentAddresses", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_StudentAddresses_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_StudentId",
                table: "Courses",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Students_StudentId",
                table: "Courses",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Students_StudentId",
                table: "Courses");

            migrationBuilder.DropTable(
                name: "StudentAddresses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_StudentId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "StandardId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Courses");
        }
    }
}
