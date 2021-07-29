using System;

namespace Code2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Digite um número: ");
            num = int.Parse(Console.ReadLine());

            if (num > 0)
            {

                Console.WriteLine("O quadrado do número digitado é: " + Math.Pow(num, 2));

                Console.WriteLine("A raiz quadrada do número digitado é: " + Math.Sqrt(num));

            }
        }
    }
}
