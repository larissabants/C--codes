using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class Postagem
    {
        private string titulo;
        private string data;
        private string conteudo;
        private int visitas;

        public string getTitulo()
        {
            return this.titulo;
        }
        public void setTitulo(string titulo)
        {
            this.titulo = titulo;
        }

        public string getData()
        {
            return this.data;
        }
        public void setData(string data)
        {
            this.data = data;
        }

        public string getConteudo()
        {
            return this.conteudo;
        }
        public void setConteudo(string conteudo)
        {
            this.conteudo = conteudo;
        }

        public int getVisitas()
        {
            return this.visitas;
        }
        public void setVisitas(int visitas)
        {
            this.visitas = visitas;
        }

    }
}