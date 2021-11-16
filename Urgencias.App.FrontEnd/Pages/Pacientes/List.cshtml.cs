using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Urgencias.App.Persistencia;
using Urgencias.App.Dominio;

namespace Urgencias.App.FrontEnd.Pages
{
    public class ListModel : PageModel
    {
     
     
       
            private static IRepositorioPaciente _repoPaciente = new RepositorioPaciente(new Persistencia.Appcontext());
            [BindProperty]

            public IEnumerable<Paciente>pacientes {get; set;}

            public void OnGet()
            {
                pacientes = _repoPaciente.GetAllPacientes();
                
            }
        }
    }


