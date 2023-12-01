using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoRotina.BackEnd.Migrations
{
    public partial class verificando : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RotinaRealizadaId",
                table: "Rotinas",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Rotinas_RotinaRealizadaId",
                table: "Rotinas",
                column: "RotinaRealizadaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rotinas_RotinaRealizada_RotinaRealizadaId",
                table: "Rotinas",
                column: "RotinaRealizadaId",
                principalTable: "RotinaRealizada",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rotinas_RotinaRealizada_RotinaRealizadaId",
                table: "Rotinas");

            migrationBuilder.DropIndex(
                name: "IX_Rotinas_RotinaRealizadaId",
                table: "Rotinas");

            migrationBuilder.DropColumn(
                name: "RotinaRealizadaId",
                table: "Rotinas");
        }
    }
}
