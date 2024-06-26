using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeMetodos01
{
    internal class Exercicio07
    {
        public static string ObterDataAtual()
        {
            return DateTime.Now.ToString("dd/MM/yyyy");
        }

        public static void Main(string[] args)
        {
            string dataAtual = ObterDataAtual();
            Console.WriteLine("A data atual é: " + dataAtual);
        }
    }
}
