using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication4.Migrations
{
    /// <inheritdoc />
    public partial class editData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contract_Position_posID",
                schema: "EmpDet",
                table: "Contract");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Position_posID",
                schema: "EmpDet",
                table: "Employee");

            migrationBuilder.DropTable(
                name: "Position",
                schema: "EmpDet");

            migrationBuilder.DropIndex(
                name: "IX_Employee_posID",
                schema: "EmpDet",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Contract_posID",
                schema: "EmpDet",
                table: "Contract");

            migrationBuilder.DropColumn(
                name: "PosRef",
                schema: "EmpDet",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "posID",
                schema: "EmpDet",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "PosRef",
                schema: "EmpDet",
                table: "Contract");

            migrationBuilder.DropColumn(
                name: "posID",
                schema: "EmpDet",
                table: "Contract");

            migrationBuilder.AddColumn<string>(
                name: "position",
                schema: "EmpDet",
                table: "Contract",
                type: "nvarchar(MAX)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "position",
                schema: "EmpDet",
                table: "Contract");

            migrationBuilder.AddColumn<int>(
                name: "PosRef",
                schema: "EmpDet",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "posID",
                schema: "EmpDet",
                table: "Employee",
                type: "int",
                nullable: true);

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

            migrationBuilder.CreateTable(
                name: "Position",
                schema: "EmpDet",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PositionDescription = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    PositionTitle = table.Column<string>(type: "nvarchar(MAX)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_posID",
                schema: "EmpDet",
                table: "Employee",
                column: "posID");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Position_posID",
                schema: "EmpDet",
                table: "Employee",
                column: "posID",
                principalSchema: "EmpDet",
                principalTable: "Position",
                principalColumn: "ID");
        }
    }
}
