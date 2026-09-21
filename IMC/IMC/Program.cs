using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //5 - Faça um algoritmo que calcule o IMC(Índice de Massa Corporal) de uma pessoa, leia o seu peso e sua altura e imprima na tela sua condição

            /* Abaixo de 18,5   | Abaixo do peso          
 Entre 18,6 e 24,9 | Peso ideal (parabéns)  
 Entre 25,0 e 29,9 | Levemente acima do peso
 Entre 30,0 e 34,9 | Obesidade grau I 
 Entre 35,0 e 39,9 | Obesidade grau II (severa)
 Maior ou igual a 40 | Obesidade grau III (mórbida)

             */

            double peso, altura, resultado;

            Console.WriteLine(" O peso ");
            peso = double.Parse(Console.ReadLine());
            Console.WriteLine(" A altura ");
            altura = double.Parse(Console.ReadLine());
            resultado = peso / (altura * altura);

            if (resultado < 18.5)
            {
                Console.WriteLine(" Esta a baixo do peso");
            }
            else if (resultado <= 24.9)
            {
                Console.WriteLine(" peso ideal ( parabéns)");
            }
            else if (resultado >= 29.9)
            {
                Console.WriteLine(" Levemente acima do peso ");
            }
            else if (resultado >= 34.9)
            {
                Console.WriteLine(" Obesidade Grau I ");
            }
            else if (resultado >= 39.9)
            {
                Console.WriteLine(" Obesidade grau II (severa) ");
            }
            else Console.WriteLine(" Obesidade grau III (mórbida) ");

        }
    }
}
            
            
            
            
            
          
            
          
        
        
        
        
        
    

