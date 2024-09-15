using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication4.Migrations
{
    /// <inheritdoc />
    public partial class relation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Project_Employee_EmpsId",
                schema: "EmpDet",
                table: "Project");

            migrationBuilder.RenameColumn(
                name: "empRef",
                schema: "EmpDet",
                table: "Project",
                newName: "empFK");

            migrationBuilder.RenameColumn(
                name: "EmpsId",
                schema: "EmpDet",
                table: "Project",
                newName: "EmplosId");

            migrationBuilder.RenameIndex(
                name: "IX_Project_EmpsId",
                schema: "EmpDet",
                table: "Project",
                newName: "IX_Project_EmplosId");

            migrationBuilder.AddForeignKey(
                name: "FK_Project_Employee_EmplosId",
                schema: "EmpDet",
                table: "Project",
                column: "EmplosId",
                principalSchema: "EmpDet",
                principalTable: "Employee",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Project_Employee_EmplosId",
                schema: "EmpDet",
                table: "Project");

            migrationBuilder.RenameColumn(
                name: "empFK",
                schema: "EmpDet",
                table: "Project",
                newName: "empRef");

            migrationBuilder.RenameColumn(
                name: "EmplosId",
                schema: "EmpDet",
                table: "Project",
                newName: "EmpsId");

            migrationBuilder.RenameIndex(
                name: "IX_Project_EmplosId",
                schema: "EmpDet",
                table: "Project",
                newName: "IX_Project_EmpsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Project_Employee_EmpsId",
                schema: "EmpDet",
                table: "Project",
                column: "EmpsId",
                principalSchema: "EmpDet",
                principalTable: "Employee",
                principalColumn: "Id");
        }
    }
}
