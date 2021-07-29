using System;

namespace Code6
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1, n2;

            Console.WriteLine("Digite a primeira nota: ");
            n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            n2 = float.Parse(Console.ReadLine());

            if ((n1 >= 0.0) && (n1 <= 10.0))
            {
                if ((n2 >= 0.0) && (n2 <= 10.0))
                {
                    Console.WriteLine("A média das notas que foram digitadas é: " + (n1 + n2) / 2);
                }
                else

                    Console.WriteLine("A segunda nota é inválida! (digite um número entre 0.0 e 10.0) ");
            }
            else if (((n1 < 0.0) || (n1 > 10.0)) && ((n2 < 0.0) || (n2 > 10.0)))
                Console.WriteLine("As duas notas são inválidas! (digite valores entre 0.0 e 10.0)");
            else
                Console.WriteLine("A primeira nota é inválida! (digite um número entre 0.0 e 10.0) ");
        }
    }
}
