using System;

namespace Code13
{
    class Program
    {
        static void Main(string[] args)
        {
            float alt, area, menor, maior;

            Console.WriteLine("Digite a altura do trapézio: ");
            alt = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a base menor do trapézio: ");
            menor = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a base maior do trapézio: ");
            maior = float.Parse(Console.ReadLine());

            area = ((menor + maior) * alt) / 2;
            Console.WriteLine("A área do trapézio é: " + area);
        }
    }
}
