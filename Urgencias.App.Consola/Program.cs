using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Urgencias.App.Dominio;
using Urgencias.App.Persistencia;

namespace Urgencias.App.Consola
{
    class Program
    {
         private static IRepositorioPaciente _repoPaciente = new RepositorioPaciente(new Persistencia.Appcontext());
        static void Main(string[] args)
        {
            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("                          Bienvenido                                   ");
                Console.WriteLine("                Asistente para seguimiento de Urgencias             ");
                Console.WriteLine("-----------------------------------------------------------------------");
                Console.WriteLine("                        MENÚ PRINCIPAL                             ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("                           1.Registrar Paciente \n");
                Console.Write("                           2.Salir\n");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Seleccione opcion...");
                 

                //métodos son acciones, las propiedades son valores
                int opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Documento");
                        string NumeroDeDocumento = Console.ReadLine();
                        Console.WriteLine("nombre :");
                        string Nombres = Console.ReadLine();
                        Console.WriteLine("apellido :");
                        string Apellidos = Console.ReadLine();
                        Console.WriteLine("edad :");
                        int EdadEnAnos = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine ("Direccion");
                        string Direccion= Console.ReadLine();
                        Console.WriteLine("Sexo");                       
                        Console.WriteLine("Peso");
                        int PesoEnKilogramos = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Estatura");
                        int EstaturaEnCentimetros = Convert.ToInt32(Console.ReadLine());
                        

                        var paciente = new Paciente()
                        {
                            NumeroDeDocumento=NumeroDeDocumento,
                            Nombres=Nombres,
                            Apellidos=Apellidos,
                            EdadEnAnos=EdadEnAnos,
                            Direccion=Direccion,                             
                            PesoEnKilogramos=PesoEnKilogramos,
                            EstaturaEnCentimetros=EstaturaEnCentimetros,
                           

                        };
                        _repoPaciente.AddPaciente(paciente);




                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();

                        break;



                    

                     
                    case 2:
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Elige una opcion entre 1 y 4");
                        break;




                }
            }
        }

      
    }
}