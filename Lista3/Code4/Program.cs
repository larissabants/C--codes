using System;

namespace Code4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Digite um número: ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("\nOs " + num + " primeiros número naturais ímpares são: ");

            for (int i = 0; num > 0; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    num--;
                }
            }
        }
    }
}
