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
    public class EditarModel : PageModel

    {
        private static IRepositorioPaciente _repoPaciente = new RepositorioPaciente(new Persistencia.Appcontext());
        [BindProperty]
        public Paciente paciente { get; set; }


        public IActionResult OnGet(int? Id)

        {
            if (Id.HasValue)
            {
                paciente = _repoPaciente.GetPaciente(Id.Value);

            }
            else
            {
                paciente = new Paciente();
            }
            if (paciente == null)
            {
                return RedirectToPage("./List");

            }
            else
                return Page();
        }

        public IActionResult OnPost()


        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            else
            {if (paciente.Id > 0)
                    {
                        _repoPaciente.UpdatePaciente(paciente);

                    } else
                    {
                        _repoPaciente.AddPaciente(paciente);
                    }

                if (paciente.EdadEnAnos >= 1 && paciente.EdadEnAnos <= 5)
                {
                    paciente.Prioridad = (paciente.PesoEnKilogramos / paciente.EstaturaEnCentimetros) + 3;
                    paciente.Riesgo = (paciente.EdadEnAnos * paciente.Prioridad) / 100;
                }
               else if (paciente.EdadEnAnos >= 6 && paciente.EdadEnAnos <= 12)
                {
                    paciente.Prioridad = (paciente.PesoEnKilogramos / paciente.EstaturaEnCentimetros) + 2;
                    paciente.Riesgo = (paciente.EdadEnAnos * paciente.Prioridad) / 100;
                }
                else if (paciente.EdadEnAnos >= 13 && paciente.EdadEnAnos <= 15)
                {
                    paciente.Prioridad = (paciente.PesoEnKilogramos / paciente.EstaturaEnCentimetros) + 1;
                    paciente.Riesgo = (paciente.EdadEnAnos * paciente.Prioridad) / 100;
                }
                else if (paciente.EdadEnAnos >= 16 && paciente.EdadEnAnos <= 41)
                {
                    if (paciente.EsFumador == 0)
                    {
                        paciente.Prioridad = (paciente.af / 4) + 2;

                    }
                    else
                    {
                        paciente.Prioridad = 2;
                    }
                }
                else if (paciente.EdadEnAnos >= 41 && paciente.EdadEnAnos <= 100)
                {
                    if (paciente.tieneDieta == 0 && paciente.EdadEnAnos >= 60)
                    {
                        paciente.Prioridad = (paciente.EdadEnAnos / 20) + 4;
                       paciente.Riesgo = ((paciente.EdadEnAnos * paciente.Prioridad) / 100) + 5.3;
                    }

                   
                }                
                   


                return RedirectToPage("/Index");
            }

        }
    }
}





