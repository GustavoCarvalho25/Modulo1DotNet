using System;
using System.Collections.Generic;
using Zoologico.src;

namespace Zoologico
{
    class Program
    {
        static void Main(string[] args)
        {   
            //nova forma de implementar listas
            List<Animal> animais = new List<Animal>(
                new Animal[]{
                    new Gato("Gato felix", "Cinza", "Felino"),
                    new Cachorro("Cachorro RoRo", "Preto", "Canídio"),
                    new Cachorro("Cachorro Nino", "Amarelo", "Canídio"),
                    new Gato("Gato Doritos", "Laranja", "Felino"),
                    new Macaco("Zeca", "Marrom", "Primata")
                }
            );

            foreach (Animal animal in animais)
            {
                if (animal.Classificacao == "Canídio")
                {
                    Console.WriteLine($"{animal.Nome} é um {animal.Classificacao}");
                    animal.Comunicar("Au au!");
                }
                else if (animal.Classificacao == "Felino")
                {
                    Console.WriteLine($"{animal.Nome} é um {animal.Classificacao}");
                    animal.Comunicar("Miau!");
                }
                else if (animal.Classificacao == "Primata")
                {
                    Console.WriteLine($"{animal.Nome} é um {animal.Classificacao}");
                    animal.Comunicar("Uhuuu HAHAHA!");
                }
            }
        }
    }
}
