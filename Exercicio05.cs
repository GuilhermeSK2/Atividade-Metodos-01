using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeMetodos01
{
    internal class Exercicio05
    {
        //Crie um método chamado MaiorNumero que receba dois inteiros como parâmetros e retorne o maior entre eles.

        public static int MaiorNumero(int numero1, int numero2)
        {
            if (numero1 > numero2)
            {
                return numero1;
            }
            else
            {
                return numero2;
            }
        }

        public static void Main(string[] args)
        {
            int maiorNum = MaiorNumero(4, 6);
            Console.WriteLine("O maior número é " + maiorNum);
        }
    }
}
