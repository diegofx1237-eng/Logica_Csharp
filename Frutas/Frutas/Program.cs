using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frutas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // implemente um sistema que armazene as quantidades de 5 tipos de frutas em 3 cestas
            //e calcule o total de frutas de cada tipo 

            int[] CestaDefrutas = new int[3];
            int[] Frutas = new int[5];
            int totalFrutas = 0; 

            for (int i = 0; i < CestaDefrutas.Length; i++) { 
            
            Console.WriteLine($"cesta {i + 1}");
                for (int j = 0; j < Frutas.Length; j++)
                {

                    Console.WriteLine($"Digite a Quantidade de Frutas do Tipo{j + 1} :");
                    Frutas[j] = int.Parse(Console.ReadLine());
                    CestaDefrutas[i] += Frutas[j];
                    totalFrutas += Frutas[i];

                }
            
              Console.WriteLine($"total frutas na cesta{i + 1}: {CestaDefrutas[i]}");






            }









}
}
}
