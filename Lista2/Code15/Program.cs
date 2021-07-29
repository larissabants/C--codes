using System;

namespace Code15
{
    class Program
    {
        static void Main(string[] args)
        {
            int trab, idade;

            Console.WriteLine("Digite a sua idade: ");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite durante quantos anos você já trabalhou: ");
            trab = int.Parse(Console.ReadLine());

            if ((idade >= 65) || (trab >= 30) || ((idade >= 60) && (trab >= 25)))
                Console.WriteLine("Você pode se aposentar!");
            else
                Console.WriteLine("Você não pode se aposentar");
        }
    }
}
