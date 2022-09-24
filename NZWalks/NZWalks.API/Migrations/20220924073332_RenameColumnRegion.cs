using Microsoft.EntityFrameworkCore.Migrations;

namespace NZWalks.API.Migrations
{
    public partial class RenameColumnRegion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Lang",
                table: "Regions",
                newName:"Long");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Long",
                table: "Regions",
                newName: "Lang");

        }
    }
}
