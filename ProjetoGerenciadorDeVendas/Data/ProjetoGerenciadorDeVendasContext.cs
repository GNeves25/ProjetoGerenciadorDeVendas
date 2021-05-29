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

        public DbSet<ProjetoGerenciadorDeVendas.Models.Department> Department { get; set; }
    }
}
