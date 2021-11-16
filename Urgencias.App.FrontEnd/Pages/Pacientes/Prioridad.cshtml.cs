using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Urgencias.App.Dominio;
using Urgencias.App.Persistencia;

namespace Urgencias.App.FrontEnd.Pages
{
    public class PrioridadModel : PageModel
    {
        private static IRepositorioPaciente _repoPaciente = new RepositorioPaciente(new Persistencia.Appcontext());
        [BindProperty]

        public IEnumerable<Paciente> pacientes { get; set; }
        
        public void OnGet()
        {
            var SortedPrioridad = pacientes.OrderBy(pacientes => pacientes.Prioridad);
            pacientes = _repoPaciente.GetAllPacientes();

            
        }
    }
}
