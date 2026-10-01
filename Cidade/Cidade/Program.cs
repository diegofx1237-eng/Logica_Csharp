using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cidade
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // crie um algoratimo que armazene as temperaturas diarias de uma cidade durante 
            // uma semana informa o dia mais quente e mais frio.

            int[] temperatura = new int[7];
            for (int i = 0; i < temperatura.Length; i++) {

                Console.WriteLine($"Temperatura Do dia {i + 1}: ");
                string entarda = Console.ReadLine();
                if (!int.TryParse(entarda, out temperatura[i]))
                {

                    Console.WriteLine("Entrada invalida. Digite um Numero inteiro.");
                    i--;
                }
                
                }
              int indiceMax =0, indiceMin =0;
                for (int i = 1; i < temperatura.Length; i++) {

                    if (temperatura[i] > temperatura[++indiceMax]) indiceMax = i;
                    if (temperatura[i] < temperatura[++indiceMin]) indiceMin = i;
                }
                Console.WriteLine($"Dia Mais Quente: Dia {indiceMax + 1} com {temperatura[indiceMax]}");
            Console.WriteLine($"Dia mais frio: Dia {indiceMin + 1} com {temperatura[indiceMin]}");

            }

        
        
        
        
        
        
        
        
        }
    }

