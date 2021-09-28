using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente cliente1 = new();
            Conta c1 = new Conta();

            c1.setAgencia("Santander");
            c1.setNumero(8);
            c1.setSaldo(5000.0f);

            cliente1.setNome("Larissa");
            cliente1.setSobrenome("Barros");
            cliente1.setCpf("029.430.948-99");
            cliente1.setConta(c1);

            Console.WriteLine("---------- CLIENTE 1 ----------");
            Console.WriteLine("Nome: " + cliente1.getNome());
            Console.WriteLine("Sobrenome: " + cliente1.getSobrenome());
            Console.WriteLine("CPF: " + cliente1.getCpf());
            Console.WriteLine("Agência: " + cliente1.getConta().getAgencia());
            Console.WriteLine("Número: " + cliente1.getConta().getNumero());
            Console.WriteLine("Saldo: " + cliente1.getConta().getSaldo() + "\n");

            Cliente cliente2 = new Cliente();
            Conta c2 = new Conta();

            c2.setAgencia("Bradesco");
            c2.setNumero(000);
            c2.setSaldo(5000.0f);

            cliente2.setNome("Sofia");
            cliente2.setSobrenome("Barros");
            cliente2.setCpf("538.947.888-00");
            cliente2.setConta(c2);

            Console.WriteLine("---------- CLIENTE 2 ----------");
            Console.WriteLine("Nome: " + cliente2.getNome());
            Console.WriteLine("Sobrenome: " + cliente2.getSobrenome());
            Console.WriteLine("CPF:" + cliente2.getCpf());
            Console.WriteLine("Agência: " + cliente2.getConta().getAgencia());
            Console.WriteLine("Número: " + cliente2.getConta().getNumero());
            Console.WriteLine("Saldo: " + cliente2.getConta().getSaldo() + "\n");

            Cliente cliente3 = new Cliente();
            Conta c3 = new Conta();

            c3.setAgencia("Itau");
            c3.setNumero(1);
            c3.setSaldo(5000.0f);

            cliente3.setNome("Emily");
            cliente3.setSobrenome("Barros");
            cliente3.setCpf("648.940.983-44");
            cliente3.setConta(c3);

            Console.WriteLine("---------- CLIENTE 3 ----------");
            Console.WriteLine("Nome: " + cliente3.getNome());
            Console.WriteLine("Sobrenome: " + cliente3.getSobrenome());
            Console.WriteLine("CPF: " + cliente3.getCpf());
            Console.WriteLine("Agência: " + cliente3.getConta().getAgencia());
            Console.WriteLine("Número: " + cliente3.getConta().getNumero());
            Console.WriteLine("Saldo: " + cliente3.getConta().getSaldo());

        }
    }
}
