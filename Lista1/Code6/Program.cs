using System;

namespace Code6
{
    class Program
    {
        static void Main(string[] args)
        {
            double c, f;

            Console.WriteLine("Digite a temperatura em Celsius para convertermos para Fahrenheit: ");
            c = double.Parse(Console.ReadLine());
            f = c * (9.0 / 5.0) + 32;

            Console.WriteLine("A temperatura em Fahrenheit é: " + f);

        }
    }
}
