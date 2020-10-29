using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVendas.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; } //Associação um para um
        public ICollection<RegistroVendas> Vendas { get; set; } = new List<RegistroVendas>(); //Associação muitos para um 

        public Vendedor() { }

        public Vendedor(int id, string nome, string email, DateTime dataNascimento, double salarioBase, Departamento departamento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void AdicionarVenda(RegistroVendas venda)
        {
            Vendas.Add(venda);
        }

        public void RemoverVenda(RegistroVendas venda)
        {
            Vendas.Add(venda);
        }

        public double TotalVendas(DateTime inicio, DateTime final)
        {
            return Vendas.Where(vendas => vendas.Data >= inicio && vendas.Data <= final).Sum(vendas => vendas.Total);
        }
    }
}
