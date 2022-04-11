using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.src;

namespace Venda.src
{
    public class VendedorA : Bonus
    {
        public string Nome { get; set; }
        public double Venda { get; set; }
        public double Bonus { get; set; }
        public double TotalReceber { get; set; }
        public string Cargo { get; set; }
        private Calc _calculadora = new Calc();

        public VendedorA(string nome, double venda, double salario, string cargo)
        {
            Nome = nome;
            Venda = venda;
            Bonus = CalcularBonus(venda);
            TotalReceber = _calculadora.Somar(salario, Bonus);
            Cargo = cargo;
        }

        public override double CalcularBonus(double venda)
        {
            return venda * 0.05;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}\nVenda: {Venda}\nBonus: {Bonus}\nTotal a receber: {TotalReceber}\nCargo: {Cargo}";
        }
    }
}