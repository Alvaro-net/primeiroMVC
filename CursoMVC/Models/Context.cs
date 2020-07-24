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

        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            DbContextOptionsBuilder dbContextOptionsBuilder = optionsBuilder.UseNpgsql(@"Host = ec2-54-234-44-238.compute-1.amazonaws.com;" +
                        "Port = 5432;" +
                        "Database = dfsct021grktl9; " +
                        "Username = aqunoapqdliwkg; " +
                        "Password = '70de39cbd7c7eec963b7b84f4152767308d54d812848c0a948881b339b175f25';" +
                        "Pooling=True;SSL Mode=Require;TrustServerCertificate=True;");
        }
    }
}
