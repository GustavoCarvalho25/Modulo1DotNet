using System;

namespace List_6
{
    class Program
    {
        static void Main(string[] args)
        {   
            int numero;

            Console.WriteLine("Qual o numero solicitado por Mallu? ");
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine($"Tabuada do {numero}");

            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"    {numero} x {i} = {numero * i}");
            }

            
        }
    }
}
