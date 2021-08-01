using System;

namespace Code7
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Digite um número par positvo: ");
            num = int.Parse(Console.ReadLine());

            if ((num > 0) && (num % 2 == 0))
            {
                for (int i = 0; i <= num; ++i)
                    if (i % 2 == 0)

                        Console.Write(i + "\n");
            }
        }
    }
}
