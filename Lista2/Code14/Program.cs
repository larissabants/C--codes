using System;

namespace Code14
{
    class Program
    {
        static void Main(string[] args)
        {
            float lado1, lado2, lado3;

            Console.WriteLine("Primeiro lado: ");
            lado1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo lado: ");
            lado2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Terceiro lado: ");
            lado3 = float.Parse(Console.ReadLine());

            if (((lado1 + lado2) > lado3) && ((lado1 + lado3) > lado2) && ((lado3 + lado2) > lado1))
            {
                if ((lado1 == lado2) && (lado2 == lado3))
                    Console.WriteLine("O triângulo é equilátero!");
                else if ((lado1 != lado2) && (lado1 != lado3) && (lado2 != lado3))
                    Console.WriteLine("O triângulo é escaleno!");
                else
                    Console.WriteLine("O triângulo é isósceles!");
            }
            else
                Console.WriteLine("Os valores digitados não podem ser valores dos lados de um triângulo!");
        }
    }
}
