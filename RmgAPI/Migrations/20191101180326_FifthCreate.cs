using Microsoft.EntityFrameworkCore.Migrations;

namespace RmgAPI.Migrations
{
    public partial class FifthCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "ListOfRequests",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "ListOfRequests");
        }
    }
}
