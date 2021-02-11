using Microsoft.EntityFrameworkCore.Migrations;

namespace Institute_Project.Migrations
{
    public partial class AddCourses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Teachers_TeacherId",
                table: "Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Inscriptions_Course_courseId",
                table: "Inscriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Inscriptions_Students_NameId",
                table: "Inscriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course",
                table: "Course");

            migrationBuilder.RenameTable(
                name: "Course",
                newName: "Courses");

            migrationBuilder.RenameColumn(
                name: "NameId",
                table: "Inscriptions",
                newName: "StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Inscriptions_NameId",
                table: "Inscriptions",
                newName: "IX_Inscriptions_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Course_TeacherId",
                table: "Courses",
                newName: "IX_Courses_TeacherId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Courses",
                table: "Courses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Teachers_TeacherId",
                table: "Courses",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Inscriptions_Courses_courseId",
                table: "Inscriptions",
                column: "courseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Inscriptions_Students_StudentId",
                table: "Inscriptions",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Teachers_TeacherId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Inscriptions_Courses_courseId",
                table: "Inscriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Inscriptions_Students_StudentId",
                table: "Inscriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Courses",
                table: "Courses");

            migrationBuilder.RenameTable(
                name: "Courses",
                newName: "Course");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Inscriptions",
                newName: "NameId");

            migrationBuilder.RenameIndex(
                name: "IX_Inscriptions_StudentId",
                table: "Inscriptions",
                newName: "IX_Inscriptions_NameId");

            migrationBuilder.RenameIndex(
                name: "IX_Courses_TeacherId",
                table: "Course",
                newName: "IX_Course_TeacherId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course",
                table: "Course",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Teachers_TeacherId",
                table: "Course",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Inscriptions_Course_courseId",
                table: "Inscriptions",
                column: "courseId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Inscriptions_Students_NameId",
                table: "Inscriptions",
                column: "NameId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
