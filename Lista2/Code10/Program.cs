using System;

namespace Code10
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, n3, media;

            Console.WriteLine("Digite a primeira nota: ");
            n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            n2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota: ");
            n3 = float.Parse(Console.ReadLine());

            media = ((n1 + n2 + (n3 * 2)) / 4) * 10;

            Console.WriteLine("A média das notas que foram digitadas é: " + media);
            if (media >= 60)
                Console.WriteLine("Aluno aprovado!");
            else
                Console.WriteLine("Aluno reprovado.");
        }
    }
}
