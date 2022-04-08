using System;
using System.Collections.Generic;
using Exercise_class_8___VS.src;

namespace Exercise_class_8___VS
{
    class Program
    {
        static void Main(string[] args)
        {
            Robo alpha = new Robo("alpha", "1094X", "grande", "adamantium");
            Robo beta = new Robo("beta", "8828-Y", "medio", "aço");
            Robo gama = new Robo("gama", "5421G", "medio", "metal");
            Robo teta = new Robo();
            List<Robo> listaRobos = new List<Robo>();

            Console.WriteLine("Qual o numero de serie do robo teta?");
            teta.NumeroDeSerie = Console.ReadLine();
            Console.WriteLine("\nQual o tamanho do robo teta?");
            teta.Tamanho = Console.ReadLine();
            Console.WriteLine("\nQual o material do robo teta?");
            teta.Material = Console.ReadLine();
            teta.Nome = "teta";

            listaRobos.Add(alpha);
            listaRobos.Add(beta);
            listaRobos.Add(gama);
            listaRobos.Add(teta);

            foreach(Robo robo in listaRobos)
            {
                Console.WriteLine($"O robo {robo.Nome} tem o numero de serie '{robo.NumeroDeSerie}', tamanho '{robo.Tamanho}' e material '{robo.Material}'!!");
            }

            Console.WriteLine("\nAlpha ira cantar! Prepare-se!!");
            alpha.Cantar();
            Console.WriteLine("\nAlpha ira contar uma piada! Prepare-se!!");
            alpha.ContarPiada();
            Console.WriteLine("\nAlpha tambem pode andar, insira uma direcao para ele demonstrar!");
            string direcao = Console.ReadLine();
            alpha.Andar(direcao);
        }
    }
}
