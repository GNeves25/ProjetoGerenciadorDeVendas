using ProjetoGerenciadorDeVendas.Models;
using System.Linq;
using System.Collections.Generic;

namespace ProjetoGerenciadorDeVendas.Services
{
    public class DepartmentService
    {
        private readonly ProjetoGerenciadorDeVendasContext _context;

        public DepartmentService(ProjetoGerenciadorDeVendasContext context)
        {
            _context = context;
        }

        public List<Department> FindAll() 
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
