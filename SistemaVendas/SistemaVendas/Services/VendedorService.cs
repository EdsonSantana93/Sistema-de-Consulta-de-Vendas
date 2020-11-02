using AspNetCore;
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

        public void InserirVendedor(Vendedor vendedor) {
            _context.Add(vendedor);
            _context.SaveChanges();
        }

        public Vendedor BuscarVendedorId(int id) {
            return _context.Vendedor.FirstOrDefault(vendedor => vendedor.Id == id);            
        }

        public void ExcluirVendedor(int id)
        {
            var vendedor = _context.Vendedor.Find(id);
            _context.Remove(vendedor);
            _context.SaveChanges();
        }
    }
}
