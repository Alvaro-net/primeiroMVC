using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models
{
    public class Context : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         => optionsBuilder.UseNpgsql("Host = ec2-18-235-109-97.compute-1.amazonaws.com;" +
             "Port = 5432;" +
             "Database = doecdpeqdn0qn; " +
             "Username = eqczgdacqdibgl; " +
             "Password = a3f204f94fb4e397858e06fc1103390d15a91e1c86603734932dd473e8fe5632;" +
             "Pooling=true;SSL Mode=Require;TrustServerCertificate=True;");
         
    }
}
