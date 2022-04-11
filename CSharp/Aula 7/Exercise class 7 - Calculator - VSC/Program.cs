using System;

namespace Exercise_class_7___Calculator___VSC
{
    class Program
    {   
        static int num1;
        static int num2;
        static string operador;

        static void Main(string[] args)
        {
            Console.WriteLine("Insira o primeiro numero:");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual operacao deseja? (+) (-) (*) (/)");
            operador = Console.ReadLine();

            Console.WriteLine("Insira o segundo numero:");
            num2 = int.Parse(Console.ReadLine());

            switch (operador)
            {
                case "+":
                    Console.WriteLine($"Resultado da soma: {Somar(num1, num2)}");
                break;

                case "-":
                    Console.WriteLine($"Resultado da subtracao: {Subtrair(num1, num2)}");
                break;

                case "*":
                    Console.WriteLine($"Resultado da multiplicacao: {Multiplicar(num1, num2)}");
                break;

                case "/":
                    Console.WriteLine($"Resultado da divisao: {Dividir(num1, num2)}");
                break;
            }
        }

        public static string Somar(int num1, int num2)
        {
            return (num1 + num2).ToString();
        }

        public static string Subtrair(int num1, int num2)
        {
            return (num1 - num2).ToString();
        }

        public static string Multiplicar(int num1, int num2)
        {
            return (num1 * num2).ToString();
        }

        public static string Dividir(int num1, int num2) //o Dividir é um método
        {   
            string result;

            bool divisaoPorNumeroZero(int num) // a divisaoPorNumeroZero é uma função local
            {
               return (num == 0)? true : false;    
            }

            if(!divisaoPorNumeroZero(num2)){
                result = Convert.ToDecimal(num1 / num2).ToString();
            }
            else{
                result = "Nao podemos dividir um numero por 0";
            }
            
            return (result).ToString();
        }


    }
}
