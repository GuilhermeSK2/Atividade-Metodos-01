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
