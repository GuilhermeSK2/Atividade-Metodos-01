using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeMetodos01
{
    internal class Exercicio06
    {
        //Crie um método chamado EhPar que receba um inteiro como parâmetro e retorne verdadeiro se o número for par e falso se for ímpar.

        public static bool EhPar(int numero)
        {
            if (numero % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void Main(string[] args)
        {
            bool resultado = EhPar(2);
            if (resultado == true)
            {
                Console.WriteLine("O número é par?: Sim");
            }
            else
            { 
                Console.WriteLine("O número é par?: Não");
            }
        }
    }
}
