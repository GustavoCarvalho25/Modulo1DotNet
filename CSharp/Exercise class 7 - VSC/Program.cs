using System;

namespace Exercise_class_7___VSC
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Hello World!");
            var pessoa = ImprimeNome("Gustavo");

            /* 
            o retorno do metodo ImprimeNome pode ser uma tupla, e para armazenar ambos os valores inserimos em um tipo "var", capaz de identificar que 
            existem dois valores da mesma forma que um "array".
            */
            Console.WriteLine($"O nome é: {pessoa.Item1}");
            Console.WriteLine($"O tamanho do nome é: {pessoa.Item2}");


            ImprimeNome(); //nao imprime erro

        }

        public static (string, int) ImprimeNome(string nome = default) //a palavra default permite que eu utilize o metodo sem inserir um parametro
        {
            return ($"O nome é: {nome}", nome.Length);
        }
    }
}
