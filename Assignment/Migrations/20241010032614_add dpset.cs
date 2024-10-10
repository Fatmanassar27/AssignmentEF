using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment.Migrations
{
    public partial class adddpset : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Department_Instructor_Ins_ID",
                table: "Department");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructor_Department_Dept_ID",
                table: "Instructor");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Department_Dep_Id",
                table: "Student");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Department",
                table: "Department");

            migrationBuilder.RenameTable(
                name: "Department",
                newName: "Departments");

            migrationBuilder.RenameIndex(
                name: "IX_Department_Ins_ID",
                table: "Departments",
                newName: "IX_Departments_Ins_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departments",
                table: "Departments",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Instructor_Ins_ID",
                table: "Departments",
                column: "Ins_ID",
                principalTable: "Instructor",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructor_Departments_Dept_ID",
                table: "Instructor",
                column: "Dept_ID",
                principalTable: "Departments",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Departments_Dep_Id",
                table: "Student",
                column: "Dep_Id",
                principalTable: "Departments",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Instructor_Ins_ID",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructor_Departments_Dept_ID",
                table: "Instructor");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Departments_Dep_Id",
                table: "Student");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departments",
                table: "Departments");

            migrationBuilder.RenameTable(
                name: "Departments",
                newName: "Department");

            migrationBuilder.RenameIndex(
                name: "IX_Departments_Ins_ID",
                table: "Department",
                newName: "IX_Department_Ins_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Department",
                table: "Department",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Department_Instructor_Ins_ID",
                table: "Department",
                column: "Ins_ID",
                principalTable: "Instructor",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructor_Department_Dept_ID",
                table: "Instructor",
                column: "Dept_ID",
                principalTable: "Department",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Department_Dep_Id",
                table: "Student",
                column: "Dep_Id",
                principalTable: "Department",
                principalColumn: "ID");
        }
    }
}
