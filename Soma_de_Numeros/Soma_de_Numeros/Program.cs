using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma_de_Numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int number, number2, subtrair;

            Console.WriteLine("digite o primeiro numero: ");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o segundo numero: ");
        number2 = int.Parse(Console.ReadLine());
            subtrair = number - number2;
            Console.WriteLine("o resultado da subtracao "+subtrair);
        
        }
    }
}
