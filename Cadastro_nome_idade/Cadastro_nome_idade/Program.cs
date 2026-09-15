using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_nome_idade
{
    internal class Program
    {
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░  ░█████╗░███╗░░██╗░█████╗░  ███████╗
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ██╔══██╗████╗░██║██╔══██╗  ██╔════╝
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║  ███████║██╔██╗██║██║░░██║  █████╗░░
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║  ██╔══██║██║╚████║██║░░██║  ██╔══╝░░
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝  ██║░░██║██║░╚███║╚█████╔╝  ███████╗
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ╚═╝░░╚═╝╚═╝░░╚══╝░╚════╝░  ╚══════╝

██╗██████╗░░█████╗░██████╗░███████╗
██║██╔══██╗██╔══██╗██╔══██╗██╔════╝
██║██║░░██║███████║██║░░██║█████╗░░
██║██║░░██║██╔══██║██║░░██║██╔══╝░░
██║██████╔╝██║░░██║██████╔╝███████╗
╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░╚══════╝
        static void Main(string[] args)
        {
            string nome; // variavel cadeia
           int idade; // variavel inteiro

            Console.WriteLine(" digite seu nome: ");
            nome = Console.ReadLine(); // variavel leia
            Console.WriteLine(" digite sua idade: ");
            idade = int .Parse(Console.ReadLine());
            Console.WriteLine(" parabens " + nome + " voce acabou de ganhar um coca_cola ");
            Console.WriteLine(" \n voce possui " + idade + " anos beba mais agua ");
        
        } 
    }
}
