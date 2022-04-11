using System;

namespace Aula6___Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;

            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine($"Insira o {i}º valor que deseja somar: ");
                soma += int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Valor da soma: {soma}");
        }
    }
}
