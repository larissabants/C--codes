using System;

namespace Code6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, maior, menor;

            Console.WriteLine("Digite um número inteiro: ");
            num = int.Parse(Console.ReadLine());

            maior = num;
            menor = num;

            if (num >= 0)
                do
                {
                    num = int.Parse(Console.ReadLine());
                    if (num > 0)
                    {
                        if (num > maior)
                            maior = num;
                        if (num < menor)
                            menor = num;
                    }
                } while (!(num < 0));

            Console.WriteLine("O maior número digitado é: " + maior);
            Console.WriteLine("O menor número digitado é: " + menor);

        }
    }
}
