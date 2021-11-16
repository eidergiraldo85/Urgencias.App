using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Urgencias.App.Dominio;

namespace Urgencias.App.Persistencia 
{
    public class Appcontext: DbContext
    {
        public DbSet<Paciente> Pacientes {get;set;}
       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDb; Initial Catalog  =Urgencias");
            }
        }
    }
}