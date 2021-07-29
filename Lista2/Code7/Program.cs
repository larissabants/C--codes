using System;

namespace Code7
{
    class Program
    {
        static void Main(string[] args)
        {
            double emp, sal;

            Console.WriteLine("Digite seu salário: ");
            sal = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da prestação do empréstimo: ");
            emp = double.Parse(Console.ReadLine());

            if (emp > ((20.0 / 100.0) * sal))
                Console.WriteLine("Empréstimo não concedido!");
            else
                Console.WriteLine("Empréstimo concedido!");

        }
    }
}
