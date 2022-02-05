using Microsoft.EntityFrameworkCore.Migrations;

namespace DardaniaRealEstate.Data.Migrations
{
    public partial class relationships1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Residence_Agents_AgentsId",
                table: "Residence");

            migrationBuilder.DropColumn(
                name: "Agent",
                table: "Residence");

            migrationBuilder.RenameColumn(
                name: "AgentsId",
                table: "Residence",
                newName: "AgentsID");

            migrationBuilder.RenameIndex(
                name: "IX_Residence_AgentsId",
                table: "Residence",
                newName: "IX_Residence_AgentsID");

            migrationBuilder.AlterColumn<int>(
                name: "AgentsID",
                table: "Residence",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Residence_Agents_AgentsID",
                table: "Residence",
                column: "AgentsID",
                principalTable: "Agents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Residence_Agents_AgentsID",
                table: "Residence");

            migrationBuilder.RenameColumn(
                name: "AgentsID",
                table: "Residence",
                newName: "AgentsId");

            migrationBuilder.RenameIndex(
                name: "IX_Residence_AgentsID",
                table: "Residence",
                newName: "IX_Residence_AgentsId");

            migrationBuilder.AlterColumn<int>(
                name: "AgentsId",
                table: "Residence",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "Agent",
                table: "Residence",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Residence_Agents_AgentsId",
                table: "Residence",
                column: "AgentsId",
                principalTable: "Agents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
