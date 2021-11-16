using Urgencias.App.Dominio;
using System.Collections.Generic;

namespace Urgencias.App.Persistencia
{
    public interface IRepositorioPaciente
    {
        IEnumerable<Paciente> GetAllPacientes();
        Paciente GetPaciente(int Id);
        Paciente AddPaciente(Paciente paciente);
        Paciente UpdatePaciente(Paciente paciente);
    }
}