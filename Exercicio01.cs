using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeMetodos01
{

    // Crie um método chamado ImprimirSaudacao que não receba parâmetros e apenas imprima "Olá, bem-vindo ao curso de C#!" na tela. 

    internal class Exercicio01
    {
        public static void ImprimirSaudacao() 
        {
            Console.WriteLine("Olá, bem vindo ao curso de C#!");
        }

        public static void Main(string [] args)
            {
                ImprimirSaudacao();
            }
    }
}
