using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoRotina.BackEnd.Migrations
{
    public partial class verificandoNovamente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RotinaId1",
                table: "RotinaRealizada",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RotinaRealizada_RotinaId1",
                table: "RotinaRealizada",
                column: "RotinaId1");

            migrationBuilder.AddForeignKey(
                name: "FK_RotinaRealizada_Rotinas_RotinaId1",
                table: "RotinaRealizada",
                column: "RotinaId1",
                principalTable: "Rotinas",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RotinaRealizada_Rotinas_RotinaId1",
                table: "RotinaRealizada");

            migrationBuilder.DropIndex(
                name: "IX_RotinaRealizada_RotinaId1",
                table: "RotinaRealizada");

            migrationBuilder.DropColumn(
                name: "RotinaId1",
                table: "RotinaRealizada");
        }
    }
}
