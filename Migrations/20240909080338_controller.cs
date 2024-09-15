using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication4.Migrations
{
    /// <inheritdoc />
    public partial class controller : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmplosId",
                schema: "EmpDet",
                table: "Project",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "empFK",
                schema: "EmpDet",
                table: "Project",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmpRef",
                schema: "EmpDet",
                table: "LeaveRequest",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "empsId",
                schema: "EmpDet",
                table: "LeaveRequest",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmpRef",
                schema: "EmpDet",
                table: "Invoice",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "empsId",
                schema: "EmpDet",
                table: "Invoice",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmpRef",
                schema: "EmpDet",
                table: "Contract",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "empsId",
                schema: "EmpDet",
                table: "Contract",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Project_EmplosId",
                schema: "EmpDet",
                table: "Project",
                column: "EmplosId");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequest_empsId",
                schema: "EmpDet",
                table: "LeaveRequest",
                column: "empsId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_empsId",
                schema: "EmpDet",
                table: "Invoice",
                column: "empsId");

            migrationBuilder.CreateIndex(
                name: "IX_Contract_empsId",
                schema: "EmpDet",
                table: "Contract",
                column: "empsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contract_Employee_empsId",
                schema: "EmpDet",
                table: "Contract",
                column: "empsId",
                principalSchema: "EmpDet",
                principalTable: "Employee",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoice_Employee_empsId",
                schema: "EmpDet",
                table: "Invoice",
                column: "empsId",
                principalSchema: "EmpDet",
                principalTable: "Employee",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveRequest_Employee_empsId",
                schema: "EmpDet",
                table: "LeaveRequest",
                column: "empsId",
                principalSchema: "EmpDet",
                principalTable: "Employee",
                principalColumn: "Id");

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
                name: "FK_Contract_Employee_empsId",
                schema: "EmpDet",
                table: "Contract");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoice_Employee_empsId",
                schema: "EmpDet",
                table: "Invoice");

            migrationBuilder.DropForeignKey(
                name: "FK_LeaveRequest_Employee_empsId",
                schema: "EmpDet",
                table: "LeaveRequest");

            migrationBuilder.DropForeignKey(
                name: "FK_Project_Employee_EmplosId",
                schema: "EmpDet",
                table: "Project");

            migrationBuilder.DropIndex(
                name: "IX_Project_EmplosId",
                schema: "EmpDet",
                table: "Project");

            migrationBuilder.DropIndex(
                name: "IX_LeaveRequest_empsId",
                schema: "EmpDet",
                table: "LeaveRequest");

            migrationBuilder.DropIndex(
                name: "IX_Invoice_empsId",
                schema: "EmpDet",
                table: "Invoice");

            migrationBuilder.DropIndex(
                name: "IX_Contract_empsId",
                schema: "EmpDet",
                table: "Contract");

            migrationBuilder.DropColumn(
                name: "EmplosId",
                schema: "EmpDet",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "empFK",
                schema: "EmpDet",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "EmpRef",
                schema: "EmpDet",
                table: "LeaveRequest");

            migrationBuilder.DropColumn(
                name: "empsId",
                schema: "EmpDet",
                table: "LeaveRequest");

            migrationBuilder.DropColumn(
                name: "EmpRef",
                schema: "EmpDet",
                table: "Invoice");

            migrationBuilder.DropColumn(
                name: "empsId",
                schema: "EmpDet",
                table: "Invoice");

            migrationBuilder.DropColumn(
                name: "EmpRef",
                schema: "EmpDet",
                table: "Contract");

            migrationBuilder.DropColumn(
                name: "empsId",
                schema: "EmpDet",
                table: "Contract");
        }
    }
}
