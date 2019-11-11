using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RmgAPI.Migrations
{
    public partial class SixthCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountID",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "src",
                table: "Employees");

            migrationBuilder.AlterColumn<string>(
                name: "Technology",
                table: "Employees",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Experience",
                table: "Employees",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "ContactNumber",
                table: "Employees",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "RequestID",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Employees",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RequestID",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Employees");

            migrationBuilder.AlterColumn<string>(
                name: "Technology",
                table: "Employees",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Experience",
                table: "Employees",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                table: "Employees",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "AccountID",
                table: "Employees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "src",
                table: "Employees",
                nullable: true);
        }
    }
}
