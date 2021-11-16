using Microsoft.EntityFrameworkCore.Migrations;

namespace Urgencias.App.Persistencia.Migrations
{
    public partial class Inicial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "anosFumando",
                table: "Pacientes");

            migrationBuilder.AlterColumn<int>(
                name: "tieneDieta",
                table: "Pacientes",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "EsFumador",
                table: "Pacientes",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "tieneDieta",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "EsFumador",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "anosFumando",
                table: "Pacientes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
