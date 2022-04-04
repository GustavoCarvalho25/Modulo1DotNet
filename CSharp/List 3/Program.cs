using System;

namespace List_3
{
    class Program
    {   

        static void Main(string[] args)
        {
            
            float altura;
            float peso;
            float imc;

            Console.WriteLine("Qual a sua altura?");
            altura = float.Parse(Console.ReadLine());

            Console.WriteLine("\nQual o seu peso?");
            peso = float.Parse(Console.ReadLine());

            imc = peso / (altura * altura);


            Console.WriteLine($"\nSeu IMC é: {imc}");
        }
    }
}
