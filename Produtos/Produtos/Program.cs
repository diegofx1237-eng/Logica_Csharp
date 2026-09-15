using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produtos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // crie um algoratimo para cadastro de produto: codigo, fabricante,categoria,preço,estoque,valor total em estoque

            int codigo, estoque;
            String fabricante, categoria;
            double preco, total;
            Console.WriteLine("digite o codigo: ");
            codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o fabricante: ");
            fabricante = Console.ReadLine();
            Console.WriteLine("digite a categoria: ");
            categoria = Console.ReadLine();
            Console.WriteLine("digite o preco: ");
            preco = double.Parse(Console.ReadLine());
            Console.WriteLine("digite o estoque: ");
            estoque = int.Parse(Console.ReadLine());
            total = preco * estoque;
        
        }   

    }
}
