using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoratimo_A_e_B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um algoritmo que leia dois valores inteiros A e B, se os valores de A e B forem iguais, deverá somar os dois valores
            //caso contrário devera multiplicar A por B. Ao final de qualquer um dos cálculos deve-se atribuir o resultado a uma variável C e
            // imprimir seu valor na tela.

            int a, b, c;

            Console.WriteLine("Digite o valor inteiro do a");
            a= int.Parse(Console.ReadLine());

            Console.WriteLine("digite o valor inteiro do b");
            b= int.Parse(Console.ReadLine());

            if (a == b)
            {
                
                c = a + b;
                Console.WriteLine("o valor é igual ");

            }
            else { c = a * b; }
            
                Console.WriteLine($"O valor da variável C é: {c}");
            }
            

        }
    }

