using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ano_Bissexto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //6 ano bissexto determine se o ano é bissexto. se o ano for bissexto é disesivel por 4, mais não por 100, a não ser decisevel por 400 
            // entrada:2024 saida
            // saida:
            
░█████╗░███╗░░██╗░█████╗░  ██████╗░██╗░██████╗░██████╗███████╗██╗░░██╗████████╗░█████╗░
██╔══██╗████╗░██║██╔══██╗  ██╔══██╗██║██╔════╝██╔════╝██╔════╝╚██╗██╔╝╚══██╔══╝██╔══██╗
███████║██╔██╗██║██║░░██║  ██████╦╝██║╚█████╗░╚█████╗░█████╗░░░╚███╔╝░░░░██║░░░██║░░██║
██╔══██║██║╚████║██║░░██║  ██╔══██╗██║░╚═══██╗░╚═══██╗██╔══╝░░░██╔██╗░░░░██║░░░██║░░██║
██║░░██║██║░╚███║╚█████╔╝  ██████╦╝██║██████╔╝██████╔╝███████╗██╔╝╚██╗░░░██║░░░╚█████╔╝
╚═╝░░╚═╝╚═╝░░╚══╝░╚════╝░  ╚═════╝░╚═╝╚═════╝░╚═════╝░╚══════╝╚═╝░░╚═╝░░░╚═╝░░░░╚════╝░
            int ano;

            Console.WriteLine("digite o numero do ano");
            ano = int.Parse(Console.ReadLine());
            if (ano % 4 == 0 && ano % 100 != 0) 
            {
                Console.WriteLine("ano bissexto");
            }
            else if (ano % 400 == 0) 

            {
                Console.WriteLine("ano bissexto");
            }
            else

            {
                Console.WriteLine("ano nao bissexto");
            }
               
                
        
        }
    }
}
