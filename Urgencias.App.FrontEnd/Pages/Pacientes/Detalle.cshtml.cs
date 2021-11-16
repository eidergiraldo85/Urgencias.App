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
    public class DetalleModel : PageModel
    {
      
        private static IRepositorioPaciente _repoPaciente = new RepositorioPaciente(new Persistencia.Appcontext());
     
  public Paciente paciente{get; set;}

        public IActionResult OnGet(int Id)
    
        {
          
            paciente =_repoPaciente.GetPaciente(Id);
            
            if(paciente==null)
            {
                return RedirectToPage("./List");
            }else
            return Page();        
        }

        
        
    }
}
