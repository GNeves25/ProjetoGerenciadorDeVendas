using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjetoGerenciadorDeVendas.Models
{
    public class ProjetoGerenciadorDeVendasContext : DbContext
    {
        public ProjetoGerenciadorDeVendasContext (DbContextOptions<ProjetoGerenciadorDeVendasContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
