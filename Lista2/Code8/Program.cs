using System;

namespace Code8
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura;
            string sexo;

            Console.WriteLine("Digite a sua altura (ex: 1.60): ");
            altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o seu sexo (ex: 'feminino' ou 'masculino'): ");
            sexo = Console.ReadLine();

            if (sexo.ToLower() == "masculino")
                Console.WriteLine("O peso ideal é " + ((72.7 * altura) - 58.0));
            else if (sexo.ToLower() == "feminino")
                Console.WriteLine("O peso ideal é " + ((62.1 * altura) - 44.7));
            else
                Console.WriteLine("Valor inválido, digite novamente!");

        }
    }
}
