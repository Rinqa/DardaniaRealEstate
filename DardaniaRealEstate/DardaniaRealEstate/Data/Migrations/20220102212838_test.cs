using Microsoft.EntityFrameworkCore.Migrations;

namespace DardaniaRealEstate.Data.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GoogleMapsLink",
                table: "Office",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "Office",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Office",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GoogleMapsLink",
                table: "Office");

            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Office");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Office");
        }
    }
}
