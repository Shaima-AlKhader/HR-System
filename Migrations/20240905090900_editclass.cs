using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication4.Migrations
{
    /// <inheritdoc />
    public partial class editclass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Project_projsID",
                schema: "EmpDet",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Employee_projsID",
                schema: "EmpDet",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "ProRef",
                schema: "EmpDet",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "projsID",
                schema: "EmpDet",
                table: "Employee");

            migrationBuilder.AddColumn<int>(
                name: "EmpRef",
                schema: "EmpDet",
                table: "Project",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmpsId",
                schema: "EmpDet",
                table: "Project",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProjectUrl",
                schema: "EmpDet",
                table: "Project",
                type: "nvarchar(MAX)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Project_EmpsId",
                schema: "EmpDet",
                table: "Project",
                column: "EmpsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Project_Employee_EmpsId",
                schema: "EmpDet",
                table: "Project",
                column: "EmpsId",
                principalSchema: "EmpDet",
                principalTable: "Employee",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Project_Employee_EmpsId",
                schema: "EmpDet",
                table: "Project");

            migrationBuilder.DropIndex(
                name: "IX_Project_EmpsId",
                schema: "EmpDet",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "EmpRef",
                schema: "EmpDet",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "EmpsId",
                schema: "EmpDet",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "ProjectUrl",
                schema: "EmpDet",
                table: "Project");

            migrationBuilder.AddColumn<int>(
                name: "ProRef",
                schema: "EmpDet",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "projsID",
                schema: "EmpDet",
                table: "Employee",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employee_projsID",
                schema: "EmpDet",
                table: "Employee",
                column: "projsID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Project_projsID",
                schema: "EmpDet",
                table: "Employee",
                column: "projsID",
                principalSchema: "EmpDet",
                principalTable: "Project",
                principalColumn: "ID");
        }
    }
}
