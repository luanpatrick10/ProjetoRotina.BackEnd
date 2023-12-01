using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ProjetoRotina.BackEnd.Migrations
{
    public partial class Proxima : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rotinas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NomeDaRotina = table.Column<string>(type: "text", nullable: false),
                    DiasDaSemana = table.Column<string>(type: "text", nullable: false),
                    IdDoUsuario = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rotinas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RotinaRealizada",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Realizado = table.Column<bool>(type: "boolean", nullable: false),
                    DataDaRealizacao = table.Column<string>(type: "text", nullable: false),
                    IdDaRotina = table.Column<int>(type: "integer", nullable: false),
                    RotinaId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RotinaRealizada", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RotinaRealizada_Rotinas_RotinaId",
                        column: x => x.RotinaId,
                        principalTable: "Rotinas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_RotinaRealizada_RotinaId",
                table: "RotinaRealizada",
                column: "RotinaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RotinaRealizada");

            migrationBuilder.DropTable(
                name: "Rotinas");
        }
    }
}
