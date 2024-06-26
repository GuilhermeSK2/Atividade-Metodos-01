using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeMetodos01
{
    internal class Exercicio10
    {
        //Crie um método chamado CalcularMedia que receba três números decimais como parâmetros e retorne a média desses números. 

        public static float CalcularMedia(float a, float b, float c)
        {
            return (a + b + c) / 3;
        }

        public static void Main(string[] args)
        {
            float media = CalcularMedia(7,5,7);
            Console.WriteLine($"A media é: {media:F2}");
        }
    }
}
