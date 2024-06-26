using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeMetodos01
{
    internal class Exercicio08
    {
        public static int CalcularFatorial(int numero)
        {
            if (numero < 0)
            {
                Console.WriteLine("O número deve ser um inteiro positivo!");
                return 0;
            }
            else 
            {
                int fatorial = 1;
                for (int i = 1; i <= numero; i++) 
                { 
                    fatorial *= i;
                }
                return fatorial;
            }
        }

        public static void Main(string[] args)
        {
            int numero = 7;
            int resultado = CalcularFatorial(numero);
            Console.WriteLine("O fatorial de " + numero + " é: " + resultado);
        }
    }
}
