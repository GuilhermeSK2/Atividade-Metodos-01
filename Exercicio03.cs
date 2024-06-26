using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeMetodos01
{
    internal class Exercicio03
    {
        //Crie um método chamado Somar que receba dois inteiros como parâmetros e retorne a soma desses dois números. 

        public static int Somar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        public static void Main(string[] args)
        {
            int resultadoDaSoma = Somar(2,3);
            Console.WriteLine("A o resultado da soma dos números é " + resultadoDaSoma);
        }
    }
}
