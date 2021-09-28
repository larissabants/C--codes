using System;

namespace Exercicio4
{
    class UsuarioPostagem
    {
        static void Main(string[] args)
        {

            Postagem primeirapost = new Postagem();
            primeirapost.setTitulo("Postagem 1");
            primeirapost.setData("24/08/2021");
            primeirapost.setConteudo("Primeiro conteúdo");
            primeirapost.setVisitas(1);

            Postagem segundapost = new Postagem();
            segundapost.setTitulo("Postagem 2");
            segundapost.setData("24/08/2021");
            segundapost.setConteudo("Segundo conteúdo");
            segundapost.setVisitas(2);

            Postagem terceirapost = new Postagem();
            terceirapost.setTitulo("Exercício");
            terceirapost.setData("24/08/2021");
            terceirapost.setConteudo("Terceiro conteúdo");
            terceirapost.setVisitas(3);

            Postagem[] Postagens = new Postagem[3];
            Postagens[0] = primeirapost;
            Postagens[1] = segundapost;
            Postagens[2] = terceirapost;

            Usuario user = new Usuario();
            user.setNome("Larissa");
            user.setSobrenome("Barros");
            user.setSenha("Abc1234");
            for (int i = 0; i < 3; i++)
            {
                user.setPostagens(Postagens);
            }

            Console.WriteLine("Nome: " + user.getNome());
            Console.WriteLine("Sobrenome: " + user.getSobrenome());
            Console.WriteLine("Senha: " + user.getSenha() + "\n");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Título: " + user.getPostagens()[i].getTitulo());
                Console.WriteLine("Data: " + user.getPostagens()[i].getData());
                Console.WriteLine("Conteúdo: " + user.getPostagens()[i].getConteudo());
                Console.WriteLine("Visitas: " + user.getPostagens()[i].getVisitas() + "\n");
            }
        }
    }
}
