using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVendas.Models.ViewModels
{
    public class VendedorFormViewModel
    {
        public Vendedor Vendedor { get; set; }
        public List<Departamento> Departamentos { get; set; }
    }
}
