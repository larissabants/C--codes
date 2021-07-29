using System;

namespace Code5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, num2;

            Console.WriteLine("Digite o primeiro número: ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            if (num == num2)
                Console.WriteLine("Os dois números que foram digitados são iguais!");
            else if (num > num2)
                Console.WriteLine("O número " + num + " é maior que o número " + num2);
            else
                Console.WriteLine("O número " + num2 + " é maior que o número " + num);
        }
    }
}
