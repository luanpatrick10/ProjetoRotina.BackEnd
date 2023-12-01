using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoRotina.BackEnd.Migrations
{
    public partial class campoFaltando : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DataDaRealizacao",
                table: "RotinaRealizada",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DataDaRealizacao",
                table: "RotinaRealizada",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);
        }
    }
}
