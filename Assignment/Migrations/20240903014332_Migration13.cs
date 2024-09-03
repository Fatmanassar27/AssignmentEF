using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment.Migrations
{
    public partial class Migration13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseID",
                table: "Stud_Course",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StudentID",
                table: "Stud_Course",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CourseID",
                table: "Course_Inst",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InstructorID",
                table: "Course_Inst",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Stud_Course_CourseID",
                table: "Stud_Course",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_Stud_Course_StudentID",
                table: "Stud_Course",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_Course_Inst_CourseID",
                table: "Course_Inst",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_Course_Inst_InstructorID",
                table: "Course_Inst",
                column: "InstructorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Inst_Course_CourseID",
                table: "Course_Inst",
                column: "CourseID",
                principalTable: "Course",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Inst_Instructor_InstructorID",
                table: "Course_Inst",
                column: "InstructorID",
                principalTable: "Instructor",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Course_Course_CourseID",
                table: "Stud_Course",
                column: "CourseID",
                principalTable: "Course",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Course_Student_StudentID",
                table: "Stud_Course",
                column: "StudentID",
                principalTable: "Student",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Inst_Course_CourseID",
                table: "Course_Inst");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_Inst_Instructor_InstructorID",
                table: "Course_Inst");

            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Course_Course_CourseID",
                table: "Stud_Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Course_Student_StudentID",
                table: "Stud_Course");

            migrationBuilder.DropIndex(
                name: "IX_Stud_Course_CourseID",
                table: "Stud_Course");

            migrationBuilder.DropIndex(
                name: "IX_Stud_Course_StudentID",
                table: "Stud_Course");

            migrationBuilder.DropIndex(
                name: "IX_Course_Inst_CourseID",
                table: "Course_Inst");

            migrationBuilder.DropIndex(
                name: "IX_Course_Inst_InstructorID",
                table: "Course_Inst");

            migrationBuilder.DropColumn(
                name: "CourseID",
                table: "Stud_Course");

            migrationBuilder.DropColumn(
                name: "StudentID",
                table: "Stud_Course");

            migrationBuilder.DropColumn(
                name: "CourseID",
                table: "Course_Inst");

            migrationBuilder.DropColumn(
                name: "InstructorID",
                table: "Course_Inst");
        }
    }
}
