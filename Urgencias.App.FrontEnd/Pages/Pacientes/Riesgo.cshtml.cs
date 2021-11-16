using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Urgencias.App.Dominio;
using Urgencias.App.Persistencia;

namespace Urgencias.App.FrontEnd.Pages
{
    public class RiesgoModel : PageModel
    {
        private static IRepositorioPaciente _repoPaciente = new RepositorioPaciente(new Persistencia.Appcontext());
        [BindProperty]
        public IEnumerable<Paciente> pacientes { get; set; }
         
        public void OnGet()
        {
            
            pacientes = _repoPaciente.GetAllPacientes();

           

        }
    }
}
