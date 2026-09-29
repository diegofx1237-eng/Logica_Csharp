using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nomePokemon =
{
    "pikachu",
    "bulbasaur",
    "charmander",
    "squirtle",
    "zubat",
    "meowth",
    "psyduck",
    "poliwag",
    "machop",
    "poliwhirl",


};
            string[] tipoPokemon = {
    "elétrico","planta",
    "fogo",
    "água",
    "venenoso",
    "normal",
    "água",
    "água",
    "lutador",
    "água"};
            string[] pesoPokemon =

            {
            " 6.0 kg", // Pikachu
             "6,9 kg", // bulbassauro
             "8,5 kg", // charmander
             "9.0 kg", // zubat
             "7,5 kg", //  meowth
             "4.2 kg", // Psyduck
            "19.6 kg", //poliwag
            "12,4 kg", // machop
            "19,5 kg", //poliwhirl
            "20.0 kg", // squirtle

            };

            string[] alturaPokemon = {
                  "0,4m",
                  "0,7m",
                  "0,6m",
                   "0,5m",
                   "0,8m",
                   "0,8m",
                    "1m",
                   "0,8m",
                   "1,3m"};

            int[] NumeroPokemon = {


            25,
            1,
            4,
            7,
            41,
            52,
            54,
            60,
            56,
            61,
            };
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nLISTAGEM DE POKEMONS");
            Console.ResetColor();

            for (int i = 0; i < NumeroPokemon.Length; i++)
            {

                Console.WriteLine("ID:        " + NumeroPokemon[i]);   
                Console.WriteLine("Nome:      " + nomePokemon[i]);
                Console.WriteLine("Tipo:      " + tipoPokemon[i]);
                Console.WriteLine("Altura:  "+  alturaPokemon[i]);
                Console.WriteLine("Peso:      " + pesoPokemon[i]); 




            }
            



        }
    }
}
