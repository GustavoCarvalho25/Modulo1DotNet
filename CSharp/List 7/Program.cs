using System;

namespace List_7
{
    class Program
    {   
        static int num1;
        static int num2;
        static string operador;

        static void Main(string[] args)
        {   
            Console.WriteLine("Aperte a tecla 's' para ligar a calculadora!");

            
            if(Console.ReadKey().Key == ConsoleKey.S)
            {
                while(Console.ReadKey().Key != ConsoleKey.S)
                {   
                    Console.WriteLine("\nInsira o primeiro numero:");
                    num1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("\nQual operacao deseja? (+) (-) (*) (/)");
                    operador = Console.ReadLine();

                    Console.WriteLine("\nInsira o segundo numero:");
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
                    Console.WriteLine("Aperte 'Enter' para continuar ou 's' para parar a calculadora!");
                }
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
