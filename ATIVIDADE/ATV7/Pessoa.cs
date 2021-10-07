using System;

namespace A7
{
    class Pessoa
    {
        private string nome = "Larissa";
        private string sobrenome = "Barros";
        private byte idade = 18;
        private float altura = 1.60F;
        private float peso = 50.0F;

        public string getNome()
        {
            return this.nome;
        }
    }
}
