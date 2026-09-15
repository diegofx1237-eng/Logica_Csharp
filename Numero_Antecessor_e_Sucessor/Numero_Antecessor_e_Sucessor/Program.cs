using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numero_Antecessor_e_Sucessor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, menor, maior;

            Console.WriteLine("escolha um numero");
            num1 = int.Parse(Console.ReadLine());
            maior = num1 + 1;
            menor = num1 - 1;
         Console.WriteLine("o antecessor dele e: "+ menor);
            Console.WriteLine("o sucessor dele e: "+maior);   
                
      }
    }
}
