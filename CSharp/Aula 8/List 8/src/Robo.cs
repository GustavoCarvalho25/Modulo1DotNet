using System;

namespace List_8.src
{
    public class Robo
    {
        public string Material { get ; set ; }
        public string Tamanho { get ; set ; }
        public string NumeroDeSerie { get ; set ; }

        public Robo(string numeroDeSerie, string tamanho, string material)
        {
            this.NumeroDeSerie = numeroDeSerie;
            this.Tamanho = tamanho;
            this.Material = material;
        }

        public Robo()
        {
            
        }

        public void Andar(string direcao)
        {
            Console.WriteLine($"Tic...Tic...vum.. 1 passo para {direcao}");
        }

        public void Cantar()
        {
            Console.WriteLine("Laaa..LaAaAaaa....sou apenas um robo, nao espere muita coisa");
        }

        public void ContarPiada()
        {
            Console.WriteLine("O que é o que é, tem uma cabeca de metal e fala engracado!");
        }

    }
}