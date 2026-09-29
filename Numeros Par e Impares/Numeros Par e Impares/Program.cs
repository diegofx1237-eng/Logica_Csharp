using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros_Par_e_Impares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // crie um programa que armazene 20 numeros e os separe-os em dois arrays: um com numeros pares
            // outro com numeros impares
            int[] numero = new int[20];
           int[] impares = new int[20];
            int[] pares = new int[20];
            int contPares = 0;
            int ContImpares = 0;

            for (int i = 0; i < numero.Length; i++)
            {
                Console.WriteLine("Digite o" + (i + 1)+" numero: ");
                numero[i] = int.Parse(Console.ReadLine());
                if (numero[i] % 2 == 0)
                {

                    pares[contPares] = numero[i];
                    contPares++;


                }
                else
                {


                    impares[ContImpares] = numero[i];
                    ContImpares++;
                }


            }
            Console.WriteLine("Numeros Pares:" + contPares);
            Console.WriteLine("Numeros Impares: " + ContImpares);
        
        
        
        
        
        
        }
    }
}
