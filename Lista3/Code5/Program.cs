using System;

namespace Code5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool num = false;

            Console.WriteLine("Digite um número: ");
            int i = int.Parse(Console.ReadLine());

            for (i = i + 1; num == false; i++)
            {
                if (i % 11 == 0)
                {
                    Console.Write(i + " é o primeiro múltiplo de 11 após o número dado!");
                    break;
                }
                else if (i % 13 == 0)
                {
                    Console.Write(i + " é o primeiro múltiplo de 13 após o número dado!");
                    break;
                }
                else if (i % 17 == 0)
                {
                    Console.Write(i + " é o primeiro múltiplo de 17 após o número dado!");
                    break;
                }
            }
        }
    }
}
