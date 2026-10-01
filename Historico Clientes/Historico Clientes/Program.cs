using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Historico_Clientes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Desenvolva um programa que armazene o historico de compras de 10 clientes e mostre
            // total gasto

            int[] Clients = new int[10];
            int totalClientes = 0;

            for (int i = 0; i < 10; i++) {

                Console.WriteLine($"Digite o total gasto do cliente{i + 1}: ");
                Clients[i] = int.Parse(Console.ReadLine());
                totalClientes += Clients[i];
            
            
            
            
            
            
            }

            Console.WriteLine($"total gastos pelos 10 clientes{totalClientes}");
        
        
        
        
        }
    }
}
