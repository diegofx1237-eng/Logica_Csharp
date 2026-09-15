using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
namespace Calcular_desconto
{
    internal class Program
    {  /*
        5. Calcular Desconto
        um produto com preço acima de 100 reais tem um desconto de 10%. caso contrario, o desconto é de 5%
        Dado o preço, calcule o valor do desconto
        . entrada:120
        .saida esperada:12 reais de desconto
        */
        
        
        
░█████╗░░█████╗░██╗░░░░░░█████╗░██╗░░░██╗██╗░░░░░░█████╗░██████╗░
██╔══██╗██╔══██╗██║░░░░░██╔══██╗██║░░░██║██║░░░░░██╔══██╗██╔══██╗
██║░░╚═╝███████║██║░░░░░██║░░╚═╝██║░░░██║██║░░░░░███████║██████╔╝
██║░░██╗██╔══██║██║░░░░░██║░░██╗██║░░░██║██║░░░░░██╔══██║██╔══██╗
╚█████╔╝██║░░██║███████╗╚█████╔╝╚██████╔╝███████╗██║░░██║██║░░██║
░╚════╝░╚═╝░░╚═╝╚══════╝░╚════╝░░╚═════╝░╚══════╝╚═╝░░╚═╝╚═╝░░╚═╝

██████╗░███████╗░██████╗░█████╗░░█████╗░███╗░░██╗████████╗░█████╗░
██╔══██╗██╔════╝██╔════╝██╔══██╗██╔══██╗████╗░██║╚══██╔══╝██╔══██╗
██║░░██║█████╗░░╚█████╗░██║░░╚═╝██║░░██║██╔██╗██║░░░██║░░░██║░░██║
██║░░██║██╔══╝░░░╚═══██╗██║░░██╗██║░░██║██║╚████║░░░██║░░░██║░░██║
██████╔╝███████╗██████╔╝╚█████╔╝╚█████╔╝██║░╚███║░░░██║░░░╚█████╔╝
╚═════╝░╚══════╝╚═════╝░░╚════╝░░╚════╝░╚═╝░░╚══╝░░░╚═╝░░░░╚════╝░
        
        
        static void Main(string[] args)
        {
            double valor, desconto;
            Console.WriteLine(" valor do produto ");
            valor = double.Parse(Console.ReadLine());
            if (valor > 100)
            {
                desconto = valor * 0.10;
            }
            else
            {
                desconto = valor * 0.05;
            }
            Console.WriteLine(desconto + " reais de desconto");
        }
    }
}