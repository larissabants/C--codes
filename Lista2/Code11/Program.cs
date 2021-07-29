using System;

namespace Code11
{
    class Program
    {
        static void Main(string[] args)
        {
            float trab, aval, exame, media;

            Console.WriteLine("Digite a nota do trabalho de laboratório (0 a 10): ");
            trab = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota da avaliação semestral (0 a 10): ");
            aval = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota do exame final (0 a 10): ");
            exame = float.Parse(Console.ReadLine());

            media = ((trab * 2) + (aval * 3) + (exame * 5)) / 10;

            Console.WriteLine("A média das notas que foram digitadas é " + media);

            if ((media >= 5) && (media <= 10))
                Console.WriteLine("Aluno aprovado!");

            else if ((media >= 3) && (media <= 4.9))
                Console.WriteLine("Aluno de recuperação.");

            else if ((media >= 0) && (media <= 2.9))
                Console.WriteLine("Aluno reprovado.");
        }
    }
}
