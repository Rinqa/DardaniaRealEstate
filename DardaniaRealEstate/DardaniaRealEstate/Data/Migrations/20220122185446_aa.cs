using Microsoft.EntityFrameworkCore.Migrations;

namespace DardaniaRealEstate.Data.Migrations
{
    public partial class aa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ResidenceInfo");

            migrationBuilder.AddColumn<string>(
                name: "GoogleMapsLink",
                table: "Residence",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AgentsID",
                table: "Properties",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "GoogleMapsLink",
                table: "Properties",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "Properties",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Properties",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Sketch",
                table: "Properties",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Office",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Properties_AgentsID",
                table: "Properties",
                column: "AgentsID");

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_Agents_AgentsID",
                table: "Properties",
                column: "AgentsID",
                principalTable: "Agents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Properties_Agents_AgentsID",
                table: "Properties");

            migrationBuilder.DropIndex(
                name: "IX_Properties_AgentsID",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "GoogleMapsLink",
                table: "Residence");

            migrationBuilder.DropColumn(
                name: "AgentsID",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "GoogleMapsLink",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "Sketch",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Office");

            migrationBuilder.CreateTable(
                name: "ResidenceInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DistanceOfMedicineCenter = table.Column<int>(type: "int", nullable: false),
                    DistanceOfRestaurant = table.Column<int>(type: "int", nullable: false),
                    DistanceOfSchool = table.Column<int>(type: "int", nullable: false),
                    DistanceOfSupermarket = table.Column<int>(type: "int", nullable: false),
                    ResidenceID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResidenceInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResidenceInfo_Residence_ResidenceID",
                        column: x => x.ResidenceID,
                        principalTable: "Residence",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ResidenceInfo_ResidenceID",
                table: "ResidenceInfo",
                column: "ResidenceID");
        }
    }
}
