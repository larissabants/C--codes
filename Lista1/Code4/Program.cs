using System;

namespace Code4
{
    class Program
    {
        static void Main(string[] args)
        {
            float num;

            Console.WriteLine("Digite um número real: ");
            num = float.Parse(Console.ReadLine());

            Console.WriteLine("O quadrado do número digitado é: " + Math.Pow(num, 2));
        }
    }
}
