using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salario_minimo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2- Faça um algoritmo que leia o valor do salário mínimo e o valor do salário de um usuário, calcule quantos salários mínimos esse 
            // usuário ganha e imprima na tela o resultado. (Base para o Salário mínimo R$ 1.518,00).

            double salarioMinimo = 1518.00,salarioUsado, Resultado;

            

            Console.WriteLine("Valor do salario Usado");
         salarioUsado = double.Parse(Console.ReadLine());

            Resultado = salarioUsado / salarioMinimo;
        
        Console.WriteLine($"voce ganha o equivalente a {Resultado:F2}salarioMinimo ");
        
        
        }
    }
}
