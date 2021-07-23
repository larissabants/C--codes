using System;

namespace Code2
{
    class Program
    {
        static void Main(string[] args)
        {
            float num;

            Console.WriteLine("Digite um número real: ");
            num = float.Parse(Console.ReadLine());

            Console.WriteLine("O número digitado foi: " + num);
        }
    }
}
