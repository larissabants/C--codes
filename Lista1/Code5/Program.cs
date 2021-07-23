using System;

namespace Code5
{
    class Program
    {
        static void Main(string[] args)
        {
            float num;

            Console.WriteLine("Digite um número real: ");
            num = float.Parse(Console.ReadLine());

            Console.WriteLine("A quinta parte do número digitado é: " + num / 5);
        }
    }
}
