using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reajuste_5_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Faça um algoritmo que leia um valor qualquer e imprima na tela com um reajuste de 5%.

            double reajuste = 1.05, valor, valorFinal;

            Console.WriteLine("Digite o valor"); valor = double.Parse(Console.ReadLine());

            valorFinal = valor * reajuste;

            Console.WriteLine("o valor com reajuste é: " + valorFinal);





            }
        }
    }
