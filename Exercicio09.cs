using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeMetodos01
{
    internal class Exercicio09
    {
        //Crie um método chamado ConcatenarStrings que receba duas strings como parâmetros e retorne a concatenação dessas duas strings.

        public static string ConcatenaStrings(string a, string b)
        {
            return a + " " + b ;
        }

        public static void Main(string[] args)
        {
            string concatenacao = ConcatenaStrings("Hello", "world");
            Console.WriteLine("O resultado da concatenação entre as duas strings é: " + concatenacao);
        }
    }
}
