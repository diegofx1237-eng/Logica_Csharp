using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritimo_de_Dois_Valores
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 4-	Faça um algoritmo que leia dois valores booleanos (lógicos) e determine se ambos são VERDADEIRO ou FALSO.

            bool numero1, numero2;
            Console.WriteLine(" numero1"); numero1 = bool.Parse(Console.ReadLine()); Console.WriteLine(" numero2 "); numero2 = bool.Parse(Console.ReadLine());
            if (numero1 == true && numero2 == true)
            {
                Console.WriteLine(" ambos os numeros sao verdadeiros ");
            }
            else if (numero1 == true && numero2 == false)
            {
                Console.WriteLine(" O numero1 é verdadeiro e numero2 falso");
            }
            else if (numero1 == false && numero2 == false)
            {
                Console.WriteLine(" Ambos os numeros sao falsos ");
            }
            else
            
                Console.WriteLine(" o numero1 e falso e o numero2 verdadeiro");








            }
        }
    }
