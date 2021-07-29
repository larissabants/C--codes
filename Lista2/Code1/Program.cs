using System;

namespace Code1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, num2;

            Console.WriteLine("Digite o primeiro número: ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            if (num > num2)
                Console.WriteLine("O número " + num + " é maior!");
            else
                Console.WriteLine("O número " + num2 + " é maior!");
        }
    }
}
