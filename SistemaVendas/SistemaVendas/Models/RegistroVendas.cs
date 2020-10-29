using SistemaVendas.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVendas.Models
{
    public class RegistroVendas
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Total { get; set; }
        public EStatusVenda Status { get; set; }
        public Vendedor Vendedor { get; set; }

        public RegistroVendas() { }

        public RegistroVendas(int id, DateTime data, double total, EStatusVenda status, Vendedor vendedor)
        {
            Id = id;
            Data = data;
            Total = total;
            Status = status;
            Vendedor = vendedor;
        }
    }
}
