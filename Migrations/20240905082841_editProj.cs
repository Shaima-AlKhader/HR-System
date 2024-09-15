using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication4.Migrations
{
    /// <inheritdoc />
    public partial class editProj : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                schema: "EmpDet",
                table: "Project",
                type: "datetime",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProjectStatus",
                schema: "EmpDet",
                table: "Project",
                type: "nvarchar(MAX)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "startDate",
                schema: "EmpDet",
                table: "Project",
                type: "datetime",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndDate",
                schema: "EmpDet",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "ProjectStatus",
                schema: "EmpDet",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "startDate",
                schema: "EmpDet",
                table: "Project");
        }
    }
}
