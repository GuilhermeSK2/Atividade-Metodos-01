﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeMetodos01
{
    internal class Exercicio02
    {
        //Crie um método chamado ImprimirMensagem que receba uma string como parâmetro e imprima essa mensagem na tela.

        public static void ImprimirMensagem(string Nome)
        {
            Console.WriteLine("Olá " + Nome + ", bem vindo ao curso de C#!");
        }

        public static void Main(string[] args)
        {
            ImprimirMensagem("Guilherme");
        }
    }
}
