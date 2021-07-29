using System;

namespace Code4
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

            if (num > num2)
            {
                Console.WriteLine("O número " + num + " é maior que o número " + num2);
                Console.WriteLine("A diferença entre os dois números é de: " + (num - num2));
            }
            else
            {
                Console.WriteLine("O número " + num2 + " é maior que o número " + num);
                Console.WriteLine("A diferença entre os dois números é de: " + (num2 - num));

            }
        }
    }
}
