using System;

namespace Code9
{
    class Program
    {
        static void Main(string[] args)
        {
            int aux = 0;
            string num;

            Console.WriteLine("Digite um número inteiro (maior que 0): ");
            num = Console.ReadLine();

            if (int.Parse(num) > 0)
            {
                foreach (char x in num)
                {
                    aux += (int)char.GetNumericValue(x);
                }
                Console.Write("A soma dos algarismos digitados é: " + aux);
            }
            else
                Console.WriteLine("Número inválido!");
        }
    }
}
