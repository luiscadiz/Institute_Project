using Microsoft.EntityFrameworkCore.Migrations;

namespace Institute_Project.Migrations
{
    public partial class ChangeParameters : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Teachers",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Students",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "courseId",
                table: "Inscriptions",
                newName: "CourseID");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Inscriptions",
                newName: "StudentID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Inscriptions",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_Inscriptions_StudentId",
                table: "Inscriptions",
                newName: "IX_Inscriptions_StudentID");

            migrationBuilder.RenameIndex(
                name: "IX_Inscriptions_courseId",
                table: "Inscriptions",
                newName: "IX_Inscriptions_CourseID");

            migrationBuilder.RenameColumn(
                name: "TeacherId",
                table: "Courses",
                newName: "TeacherID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Courses",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_Courses_TeacherId",
                table: "Courses",
                newName: "IX_Courses_TeacherID");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Teachers_TeacherID",
                table: "Courses",
                column: "TeacherID",
                principalTable: "Teachers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Inscriptions_Courses_CourseID",
                table: "Inscriptions",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Inscriptions_Students_StudentID",
                table: "Inscriptions",
                column: "StudentID",
                principalTable: "Students",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Teachers_TeacherID",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Inscriptions_Courses_CourseID",
                table: "Inscriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Inscriptions_Students_StudentID",
                table: "Inscriptions");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Teachers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Students",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "StudentID",
                table: "Inscriptions",
                newName: "StudentId");

            migrationBuilder.RenameColumn(
                name: "CourseID",
                table: "Inscriptions",
                newName: "courseId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Inscriptions",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Inscriptions_StudentID",
                table: "Inscriptions",
                newName: "IX_Inscriptions_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Inscriptions_CourseID",
                table: "Inscriptions",
                newName: "IX_Inscriptions_courseId");

            migrationBuilder.RenameColumn(
                name: "TeacherID",
                table: "Courses",
                newName: "TeacherId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Courses",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Courses_TeacherID",
                table: "Courses",
                newName: "IX_Courses_TeacherId");

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
    }
}
