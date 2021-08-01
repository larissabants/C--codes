using System;

namespace Code3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, aux = 0;

            Console.WriteLine("Digite 10 números!");

            for (int i = 0; i < 10; i++)
            {
                num = int.Parse(Console.ReadLine());
                aux += num;
            }

            Console.WriteLine("A soma dos números digitados é: " + aux);
        }
    }
}
