using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeMetodos01
{
    internal class Exercicio04
    {
        //Crie um método chamado Multiplicar que receba dois inteiros como parâmetros e retorne o produto desses dois números.

        public static int Multiplicar(int numero1, int numero2)
        {
            return numero1 * numero2;
        }

        public static void Main(string[] args)
        {
            int produto = Multiplicar(2, 3);
            Console.WriteLine("A o produto entre os números é " + produto);
        }
    }
}
