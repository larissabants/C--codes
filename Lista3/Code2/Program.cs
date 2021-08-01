using System;

namespace Code2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            Console.WriteLine("Estrutura de repetição FOR:");
            for (i = 1; i <= 100; i++)
            {
                Console.Write("\n " + i);
            }
            Console.WriteLine("\nEstrutura de repetição WHILE:");
            int x = 1;

            while (x <= 100)
            {
                Console.Write("\n" + x);
                x++;
            }
            Console.WriteLine("\nEstrutura de repetição DO WHILE");
            int aux = 1;

            do
            {
                Console.Write("\n" + aux);
                aux++;

            } while (aux <= 100);
        }
    }
}
