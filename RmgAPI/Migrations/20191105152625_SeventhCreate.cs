using Microsoft.EntityFrameworkCore.Migrations;

namespace RmgAPI.Migrations
{
    public partial class SeventhCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                table: "Employees",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ContactNumber",
                table: "Employees",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
