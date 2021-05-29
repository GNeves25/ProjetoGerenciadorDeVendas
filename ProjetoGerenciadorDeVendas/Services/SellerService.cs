using ProjetoGerenciadorDeVendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoGerenciadorDeVendas.Services
{
    public class SellerService
    {
        private readonly ProjetoGerenciadorDeVendasContext _context;

        public SellerService(ProjetoGerenciadorDeVendasContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
