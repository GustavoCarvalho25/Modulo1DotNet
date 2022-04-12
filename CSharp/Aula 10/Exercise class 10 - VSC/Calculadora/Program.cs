using System;
using Calculadora.src;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            IOperacoes calculadora = new Calc();

            Console.WriteLine($"Soma: {calculadora.Somar(1, 2)}");
            Console.WriteLine($"Subtração: {calculadora.Subtrair(1, 2)}");
            Console.WriteLine($"Multiplicação: {calculadora.Multiplicar(1, 2)}");
            Console.WriteLine($"Divisão: {calculadora.Dividir(1, 2)}");
        }
    }
}
