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
            string classPeso;

            Console.WriteLine("Qual a sua altura em metros?");
            altura = float.Parse(Console.ReadLine());

            Console.WriteLine("\nQual o seu peso em kg?");
            peso = float.Parse(Console.ReadLine());

            imc = peso / (altura * altura);

            if (imc < 18.5)
            {
                classPeso = "abaixo do peso";
            }
            else if (imc < 25)
            {
                classPeso = "com peso normal";
            }
            else if (imc < 30)
            {
                classPeso = "em sobrepeso";
            }
            else
            {
                classPeso = "em obesidade";
            }

            Console.WriteLine($"\nVoce esta {classPeso}");
        }
    }
}
