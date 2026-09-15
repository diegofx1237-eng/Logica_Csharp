using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time;

            Console.WriteLine("digite o tempo");
            time = int.Parse(Console.ReadLine());
            if (time <= 15)
            {


                Console.WriteLine("entrega perfeita! bonus perfeito.");
            }
            if (time > 15 && time < 30) {
                Console.WriteLine("pizza entregue a tempo,sem tempo");




            }
            if (time >= 30) {
            Console.WriteLine("pizza esfriou! peter foi demitido");
            }


        }
    }
}
