using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVendas.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Display(Name = "Data Nascimento")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }
        [Display(Name = "Salário Base")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; } //Associação um para um
        public int DepartamentoId { get; set; } //Cria uma obrigatoriedade da Chave estrangeira não ser nula
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
