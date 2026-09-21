using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_de_Advinhaçao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //simular o jogo de advinhação: o jogador 1 escolhe um numero entre 1 a 10; o jogador 2 insere numeros na tentativa
            // de acertar  numero escolhido pelo jogador 1. Quando ele acertar,o algaritimo deve informar que ele acertou o numero x 
            // (escolhido pelo jogador 1) em x tentativas (quantidade de jogador 2).

            int numeroEscolhido, palpite = 0, tentativa = 0;
           

           

            Console.WriteLine("jogador 1,escolha um numero entre 1 a 10: ");
            numeroEscolhido = int.Parse(Console.ReadLine());
            Console.Clear();

            while (palpite != numeroEscolhido)
            {

                Console.WriteLine("escreva seu palpite ");
                palpite = int.Parse(Console.ReadLine());

                tentativa++;

            }
            Console.WriteLine($" voce acertou o numero {numeroEscolhido} em {tentativa}. parabems!");
            
            
        
        }
    }
}
