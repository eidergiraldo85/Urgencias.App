using System;

namespace Urgencias.App.Dominio
{
    public class Paciente  
    {
        public int Id  {get;set;}
        public string NumeroDeDocumento {get; set;}
        public string Nombres {get;set;}
        public string Apellidos {get;set;}
        public int EdadEnAnos {get;set;}        
        public string Direccion {get;set;} 
        public Sexo Sexo {get;set;}     
        public int PesoEnKilogramos {get;set;}
        public int EstaturaEnCentimetros {get;set;}
        public double Prioridad {get;set;}
        public double Riesgo {get;set;}
        public EsFumador EsFumador {get;set;}
        public int af {get;set;}
        public tieneDieta tieneDieta {get;set;}         
        

    }
}
