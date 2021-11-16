using Microsoft.EntityFrameworkCore.Migrations;

namespace Urgencias.App.Persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroDeDocumento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EdadEnAnos = table.Column<int>(type: "int", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sexo = table.Column<int>(type: "int", nullable: false),
                    PesoEnKilogramos = table.Column<int>(type: "int", nullable: false),
                    EstaturaEnCentimetros = table.Column<int>(type: "int", nullable: false),
                    Prioridad = table.Column<double>(type: "float", nullable: false),
                    Riesgo = table.Column<double>(type: "float", nullable: false),
                    EsFumador = table.Column<bool>(type: "bit", nullable: false),
                    anosFumando = table.Column<int>(type: "int", nullable: false),
                    tieneDieta = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacientes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pacientes");
        }
    }
}
