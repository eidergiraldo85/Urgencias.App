using Microsoft.EntityFrameworkCore.Migrations;

namespace Urgencias.App.Persistencia.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "af",
                table: "Pacientes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "af",
                table: "Pacientes");
        }
    }
}
