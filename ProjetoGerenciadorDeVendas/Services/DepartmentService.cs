using ProjetoGerenciadorDeVendas.Models;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjetoGerenciadorDeVendas.Services
{
    public class DepartmentService
    {
        private readonly ProjetoGerenciadorDeVendasContext _context;

        public DepartmentService(ProjetoGerenciadorDeVendasContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync() 
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
