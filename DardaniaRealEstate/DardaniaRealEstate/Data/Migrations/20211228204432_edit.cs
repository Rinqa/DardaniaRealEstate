using Microsoft.EntityFrameworkCore.Migrations;

namespace DardaniaRealEstate.Data.Migrations
{
    public partial class edit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Option",
                table: "Residence");

            migrationBuilder.AddColumn<string>(
                name: "Options",
                table: "Residence",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Options",
                table: "Residence");

            migrationBuilder.AddColumn<string>(
                name: "Option",
                table: "Residence",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
