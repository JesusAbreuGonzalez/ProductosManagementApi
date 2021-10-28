using Microsoft.EntityFrameworkCore;
using ProductosManagementApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductosManagementApi.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Productos> Productos { get; set; }

        public Contexto(DbContextOptions<Contexto> options) : base(options) 
        {
        
        }
    }
}
