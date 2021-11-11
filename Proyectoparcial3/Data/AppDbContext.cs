using Microsoft.EntityFrameworkCore;
using Proyectoparcial3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyectoparcial3.Data
{
    public class AppDbContext : DbContext

    {


        public DbSet<Gestion> Gestiones { get; set; } //Llama al modelo (Person) 


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)

        {



        }

    }
}

