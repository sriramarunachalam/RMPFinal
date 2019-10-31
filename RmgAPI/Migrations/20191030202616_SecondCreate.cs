using Microsoft.EntityFrameworkCore.Migrations;

namespace RmgAPI.Migrations
{
    public partial class SecondCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountID",
                table: "ListOfRequests");

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "ListOfRequests",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                table: "ListOfRequests");

            migrationBuilder.AddColumn<int>(
                name: "AccountID",
                table: "ListOfRequests",
                nullable: false,
                defaultValue: 0);
        }
    }
}
