using System;

namespace Exercise_class_6___VSC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabuada");

            for(int x = 0; x <= 10; x++)
            {
                Console.WriteLine($"\nTabuada do: {x}");
                for(int y = 1; y <= 10; y++)
                {
                    Console.WriteLine(x + "x" + y + " = " + (x*y));
                }
            }
        }
    }
}
