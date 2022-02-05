using Microsoft.EntityFrameworkCore.Migrations;

namespace DardaniaRealEstate.Data.Migrations
{
    public partial class ResController : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Residence",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Photo = table.Column<string>(nullable: true),
                    Warehouse = table.Column<string>(nullable: true),
                    GardenSpace = table.Column<int>(nullable: false),
                    ResidenceSpace = table.Column<int>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    Garage = table.Column<bool>(nullable: false),
                    Floors = table.Column<int>(nullable: false),
                    CityDistance = table.Column<int>(nullable: false),
                    RoomNumber = table.Column<int>(nullable: false),
                    SleepingRoom = table.Column<int>(nullable: false),
                    Bathrooms = table.Column<int>(nullable: false),
                    BuildingType = table.Column<string>(nullable: true),
                    Commune = table.Column<string>(nullable: true),
                    Agent = table.Column<string>(nullable: true),
                    ConstructionYear = table.Column<int>(nullable: false),
                    Description = table.Column<int>(nullable: false),
                    Option = table.Column<string>(nullable: true),
                    Price = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Residence", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Residence");
        }
    }
}
