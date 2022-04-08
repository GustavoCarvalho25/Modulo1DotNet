using List_8.src;
using System;
using System.Collections.Generic;

namespace List_8
{
    public class Program
    {
        
        
        static void Main(string[] args)
        {
            Robo alpha = new Robo("1094X", "grande", "adamantium");
            Robo beta = new Robo("8828-Y", "medio", "aço");
            Robo gama = new Robo("5421G", "medio", "metal");
            Robo teta = new Robo();
            List<Robo> listaRobos = new List<Robo>();

            Console.WriteLine("Qual o numero de serie do robo teta?");
            teta.NumeroDeSerie = Console.ReadLine();
            Console.WriteLine("Qual o tamanho do robo teta?");
            teta.Tamanho = Console.ReadLine();
            Console.WriteLine("Qual o material do robo teta?");
            teta.Material = Console.ReadLine();

            listaRobos.Add(alpha);
            listaRobos.Add(beta);
            listaRobos.Add(gama);
            listaRobos.Add(teta);

            foreach(Robo robo in listaRobos)
            {
                Console.WriteLine($"O robo {nameof(robo)} tem o numero de serie '{robo.NumeroDeSerie}', tamanho '{robo.Tamanho}' e material '{robo.Material}'!!");
            }

            Console.WriteLine("\n\nAlpha ira cantar! Prepare-se!!");
            alpha.Cantar();
            Console.WriteLine("\n\nAlpha ira contar uma piada! Prepare-se!!");
            alpha.ContarPiada();
            Console.WriteLine("\n\nAlpha tambem pode andar, insira uma direcao para ele demonstrar!");
            string direcao = Console.ReadLine();
            alpha.Andar(direcao);


        }

        

    }
}
