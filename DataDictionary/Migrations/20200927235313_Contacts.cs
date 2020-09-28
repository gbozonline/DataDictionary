using Microsoft.EntityFrameworkCore.Migrations;

namespace DataDictionary.Migrations
{
    public partial class Contacts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ISContact",
                table: "Applications",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecAppExpert",
                table: "Applications",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ISContact",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "SecAppExpert",
                table: "Applications");
        }
    }
}
