using System;

namespace Code3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, num2, num3;

            Console.WriteLine("Digite 3 números inteiros: ");
            num = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine()); num3 = int.Parse(Console.ReadLine());

            Console.WriteLine(num + "+" + num2 + "+" + num3 + "=" + (num + num2 + num3));
        }
    }
}
