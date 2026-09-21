using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica_de_LInha
{
    internal class Program
    {
        static void Main(string[] args)
        
            //uma fabrica tem uma linha de produção capaz de produzir 40 peças/dia funcionario
       //controla a qualidade cadastrando o numero da peça e o seu estado ( aprovado ou reprovado)
       //criar um programa para cadastrar o controle de qualidade e imprimir o total de peças aprovadas e reprovadas no final do dia.

        
        
         {


            int contador = 0, reprovadas, aprovadas, numpecas;
            string estado;
            contador = 1;
            reprovadas = 0;
            aprovadas = 0;

            Console.WriteLine("digite o numero do contador");
         numpecas = int.Parse(Console.ReadLine());

            Console.WriteLine("digite se a peça foi aprovada ou reprovada(a para aprovada/ r para reprovada");


            estado = Console.ReadLine();

            if (estado == "a")
            {
                aprovadas++;
            }
            else
            {
                reprovadas++;

           contador++;
           
              Console.WriteLine("total de  peças aprovadas" + aprovadas);  
              Console.WriteLine("total de  peças reprovadas" + reprovadas);


            }
        }
    }
}
