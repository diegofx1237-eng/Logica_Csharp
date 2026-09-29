using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_Produto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] estoque = new int[10];
            int max = int.MinValue, min = int.MaxValue, ProdMax = 0, ProdMin = 0;
            for (int i = 0; i < 10; i++) {
            
            Console.WriteLine($"Quantidade do Produto {i + 1}: ");
           estoque[i] = int.Parse( Console.ReadLine() );
            
            
            if (estoque[i] > max) {
                max = estoque[i];
                ProdMax = i;
            }
            if (estoque[i] < min) { min = estoque[i]; ProdMin = i; }
             }
            Console.WriteLine($"Produto com maior estoque: { ProdMax + 1} ({max})");
            Console.WriteLine($"Prduto com menor estoque: {ProdMax + 1} ({min})");


           
            







        }
    }
}
