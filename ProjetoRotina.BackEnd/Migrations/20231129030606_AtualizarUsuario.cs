using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoRotina.BackEnd.Migrations
{
    public partial class AtualizarUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateDeNascimento",
                table: "Usuarios",
                newName: "DataDeNascimento");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataDeNascimento",
                table: "Usuarios",
                newName: "DateDeNascimento");
        }
    }
}
