using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula8
{
    class Program
    {
        static void Main(string[] args)
        {
            Casa cs = new Casa();
            cs.Area = 400.0F;
            cs.Altura = 20.0F;
            cs.Preco = 800000;

            Console.WriteLine("Área: " + cs.Area + "metros quadrados");
            Console.WriteLine("Altura: " + cs.Altura + "metros");
            Console.WriteLine("Preço: R$ " + cs.Preco);
        }
    }
}
