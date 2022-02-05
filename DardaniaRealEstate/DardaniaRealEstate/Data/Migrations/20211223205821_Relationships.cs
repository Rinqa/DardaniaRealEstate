using Microsoft.EntityFrameworkCore.Migrations;

namespace DardaniaRealEstate.Data.Migrations
{
    public partial class Relationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Commune",
                table: "Residence");

            migrationBuilder.DropColumn(
                name: "Commune",
                table: "Office");

            migrationBuilder.RenameColumn(
                name: "ResidenceId",
                table: "ResidenceInfo",
                newName: "ResidenceID");

            migrationBuilder.AddColumn<int>(
                name: "AgentsId",
                table: "Residence",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CommunesID",
                table: "Residence",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CommunesID",
                table: "Office",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Properties",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommunesID = table.Column<int>(nullable: false),
                    Location = table.Column<string>(nullable: true),
                    Squaremeters = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Properties_Communes_CommunesID",
                        column: x => x.CommunesID,
                        principalTable: "Communes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ResidenceInfo_ResidenceID",
                table: "ResidenceInfo",
                column: "ResidenceID");

            migrationBuilder.CreateIndex(
                name: "IX_Residence_AgentsId",
                table: "Residence",
                column: "AgentsId");

            migrationBuilder.CreateIndex(
                name: "IX_Residence_CommunesID",
                table: "Residence",
                column: "CommunesID");

            migrationBuilder.CreateIndex(
                name: "IX_Office_CommunesID",
                table: "Office",
                column: "CommunesID");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_CommunesID",
                table: "Properties",
                column: "CommunesID");

            migrationBuilder.AddForeignKey(
                name: "FK_Office_Communes_CommunesID",
                table: "Office",
                column: "CommunesID",
                principalTable: "Communes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Residence_Agents_AgentsId",
                table: "Residence",
                column: "AgentsId",
                principalTable: "Agents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Residence_Communes_CommunesID",
                table: "Residence",
                column: "CommunesID",
                principalTable: "Communes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ResidenceInfo_Residence_ResidenceID",
                table: "ResidenceInfo",
                column: "ResidenceID",
                principalTable: "Residence",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Office_Communes_CommunesID",
                table: "Office");

            migrationBuilder.DropForeignKey(
                name: "FK_Residence_Agents_AgentsId",
                table: "Residence");

            migrationBuilder.DropForeignKey(
                name: "FK_Residence_Communes_CommunesID",
                table: "Residence");

            migrationBuilder.DropForeignKey(
                name: "FK_ResidenceInfo_Residence_ResidenceID",
                table: "ResidenceInfo");

            migrationBuilder.DropTable(
                name: "Properties");

            migrationBuilder.DropIndex(
                name: "IX_ResidenceInfo_ResidenceID",
                table: "ResidenceInfo");

            migrationBuilder.DropIndex(
                name: "IX_Residence_AgentsId",
                table: "Residence");

            migrationBuilder.DropIndex(
                name: "IX_Residence_CommunesID",
                table: "Residence");

            migrationBuilder.DropIndex(
                name: "IX_Office_CommunesID",
                table: "Office");

            migrationBuilder.DropColumn(
                name: "AgentsId",
                table: "Residence");

            migrationBuilder.DropColumn(
                name: "CommunesID",
                table: "Residence");

            migrationBuilder.DropColumn(
                name: "CommunesID",
                table: "Office");

            migrationBuilder.RenameColumn(
                name: "ResidenceID",
                table: "ResidenceInfo",
                newName: "ResidenceId");

            migrationBuilder.AddColumn<string>(
                name: "Commune",
                table: "Residence",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Commune",
                table: "Office",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
