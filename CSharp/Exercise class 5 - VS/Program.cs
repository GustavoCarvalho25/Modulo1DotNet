using System;

namespace Ex_aula_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int qntdCursos;
            string condConclusao;
            string condQuitacao;
            string condBiblioteca;

            Console.WriteLine("Você concluiu o curso(s/n): ");
            condConclusao = Console.ReadLine();

            Console.WriteLine("Quantos cursos você concluiu?: ");
            qntdCursos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Você quitou o valor do curso?(s/n): ");
            condQuitacao = Console.ReadLine();

            Console.WriteLine("Você devolveu todos os livros?(s/n): ");
            condBiblioteca = Console.ReadLine();

            if ((condConclusao == "s") && (qntdCursos >= 25) && (condQuitacao == "s") && (condBiblioteca == "s"))
            {
                Console.WriteLine("Candidato aprovado");
            }
            else
            {
                Console.WriteLine("Candidato reprovado");
            }
        }
    }
}
