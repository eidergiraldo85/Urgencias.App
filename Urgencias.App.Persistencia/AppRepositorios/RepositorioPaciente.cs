using System.Collections.Generic;
using System.Linq;
using Urgencias.App.Dominio;

namespace Urgencias.App.Persistencia
{
    public class RepositorioPaciente : IRepositorioPaciente
    {
        private static Appcontext _appContext;

        IEnumerable<Paciente> pacientes;

        public RepositorioPaciente(Appcontext appContext)
        {
            _appContext = appContext;
        }
        Paciente IRepositorioPaciente.AddPaciente(Paciente paciente)
        {
            var pacienteAdicionado = _appContext.Pacientes.Add(paciente);
            _appContext.SaveChanges();
            return pacienteAdicionado.Entity;
        }
        IEnumerable<Paciente> IRepositorioPaciente.GetAllPacientes()
        {
            
                return _appContext.Pacientes;
            }
            Paciente IRepositorioPaciente.GetPaciente(int Id)
     {
                return _appContext.Pacientes.FirstOrDefault(p => p.Id == Id);

            }
            Paciente IRepositorioPaciente.UpdatePaciente(Paciente paciente)
        {         
                var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Id == paciente.Id);
             
                
                 
                {
                    pacienteEncontrado.Id = paciente.Id;
                    pacienteEncontrado.NumeroDeDocumento = paciente.NumeroDeDocumento;
                    pacienteEncontrado.Nombres = paciente.Nombres;
                    pacienteEncontrado.Apellidos = paciente.Apellidos;
                    pacienteEncontrado.EdadEnAnos = paciente.EdadEnAnos;
                    pacienteEncontrado.Direccion = paciente.Direccion;
                    pacienteEncontrado.Sexo = paciente.Sexo;
                    pacienteEncontrado.PesoEnKilogramos = paciente.PesoEnKilogramos;
                    pacienteEncontrado.EstaturaEnCentimetros = paciente.EstaturaEnCentimetros;
                    pacienteEncontrado.Prioridad = paciente.Prioridad;
                    pacienteEncontrado.Riesgo = paciente.Riesgo;
                    pacienteEncontrado.EsFumador = paciente.EsFumador;
                    pacienteEncontrado.af   = paciente.af;
                    pacienteEncontrado.tieneDieta = paciente.tieneDieta;
                    
                    _appContext.SaveChanges();
                }
                return pacienteEncontrado;
            }
        }
    }