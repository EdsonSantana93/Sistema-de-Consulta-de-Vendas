using SistemaVendas.Data;
using SistemaVendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVendas.Services
{
    public class VendedorService
    {
        private readonly SistemaVendasContext _context;

        public VendedorService(SistemaVendasContext context)
        {
            _context = context;
        }
        
        //Metodo sincrono para Buscar lista de vendedores
        public List<Vendedor> BuscarVendedores()
        {
            return _context.Vendedor.ToList();
        }
    }
}
