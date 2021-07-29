using System;

namespace Code3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Digite um número: ");
            num = int.Parse(Console.ReadLine());

            if ((num % 2) == 0)
                Console.WriteLine("O número digitado é par!");
            else
                Console.WriteLine("O número digitado é ímpar!");
        }
    }
}
