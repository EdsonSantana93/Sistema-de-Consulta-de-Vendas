using SistemaVendas.Data;
using SistemaVendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVendas.Services
{
    public class DepartamentoService
    {
        private readonly SistemaVendasContext _context;

        public DepartamentoService(SistemaVendasContext context)
        {
            _context = context;
        }

        public List<Departamento> BuscarDepartamentos()
        {
            return _context.Departamento.OrderBy(departamento => departamento.Nome).ToList();
        }
    }
}
