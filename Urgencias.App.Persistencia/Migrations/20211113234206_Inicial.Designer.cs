// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Urgencias.App.Persistencia;

namespace Urgencias.App.Persistencia.Migrations
{
    [DbContext(typeof(Appcontext))]
    [Migration("20211113234206_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Urgencias.App.Dominio.Paciente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EdadEnAnos")
                        .HasColumnType("int");

                    b.Property<bool>("EsFumador")
                        .HasColumnType("bit");

                    b.Property<int>("EstaturaEnCentimetros")
                        .HasColumnType("int");

                    b.Property<string>("Nombres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroDeDocumento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PesoEnKilogramos")
                        .HasColumnType("int");

                    b.Property<double>("Prioridad")
                        .HasColumnType("float");

                    b.Property<double>("Riesgo")
                        .HasColumnType("float");

                    b.Property<int>("Sexo")
                        .HasColumnType("int");

                    b.Property<int>("anosFumando")
                        .HasColumnType("int");

                    b.Property<bool>("tieneDieta")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Pacientes");
                });
#pragma warning restore 612, 618
        }
    }
}
