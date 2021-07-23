using System;

namespace Code8
{
    class Program
    {
        static void Main(string[] args)
        {
            double k, c;

            Console.WriteLine("Digite a temperatura em Kelvin para convertermos para Celsius: ");
            k = double.Parse(Console.ReadLine());
            c = k - 273.15;

            Console.WriteLine("A temperatura de Celsius é: " + c);
        }
    }
}
