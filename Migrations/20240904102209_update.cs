using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication4.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Position",
                schema: "EmpDet",
                table: "Contract");

            migrationBuilder.AddColumn<int>(
                name: "PosRef",
                schema: "EmpDet",
                table: "Contract",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "posID",
                schema: "EmpDet",
                table: "Contract",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "salary",
                schema: "EmpDet",
                table: "Contract",
                type: "decimal(18,0)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contract_posID",
                schema: "EmpDet",
                table: "Contract",
                column: "posID");

            migrationBuilder.AddForeignKey(
                name: "FK_Contract_Position_posID",
                schema: "EmpDet",
                table: "Contract",
                column: "posID",
                principalSchema: "EmpDet",
                principalTable: "Position",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contract_Position_posID",
                schema: "EmpDet",
                table: "Contract");

            migrationBuilder.DropIndex(
                name: "IX_Contract_posID",
                schema: "EmpDet",
                table: "Contract");

            migrationBuilder.DropColumn(
                name: "PosRef",
                schema: "EmpDet",
                table: "Contract");

            migrationBuilder.DropColumn(
                name: "posID",
                schema: "EmpDet",
                table: "Contract");

            migrationBuilder.DropColumn(
                name: "salary",
                schema: "EmpDet",
                table: "Contract");

            migrationBuilder.AddColumn<string>(
                name: "Position",
                schema: "EmpDet",
                table: "Contract",
                type: "nvarchar(MAX)",
                nullable: true);
        }
    }
}
