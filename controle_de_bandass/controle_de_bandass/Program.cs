using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace controle_de_bandass
{
    internal class Program
    {/* 

      se / enquanto / para / caso

      if / while / for / switch


        Crie um sistema de cadastro de Álbuns de um artista / banda em que seá possível cadastrar

        um número x de músicas informada pelo usuário. Crie um menu de opções para isso


        */
        static void Main(string[] args)

        {

            int opcao = 0;

            while (opcao != 4)

            {

                Console.Clear(); // limpa a tela Console.ForegroundColor = ConsoleColor.DarkBlue;

                Console.WriteLine(@"
░█████╗░░█████╗░███╗░░██╗████████╗██████╗░░█████╗░██╗░░░░░███████╗  ██████╗░███████╗
██╔══██╗██╔══██╗████╗░██║╚══██╔══╝██╔══██╗██╔══██╗██║░░░░░██╔════╝  ██╔══██╗██╔════╝
██║░░╚═╝██║░░██║██╔██╗██║░░░██║░░░██████╔╝██║░░██║██║░░░░░█████╗░░  ██║░░██║█████╗░░
██║░░██╗██║░░██║██║╚████║░░░██║░░░██╔══██╗██║░░██║██║░░░░░██╔══╝░░  ██║░░██║██╔══╝░░
╚█████╔╝╚█████╔╝██║░╚███║░░░██║░░░██║░░██║╚█████╔╝███████╗███████╗  ██████╔╝███████╗
░╚════╝░░╚════╝░╚═╝░░╚══╝░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░╚══════╝╚══════╝  ╚═════╝░╚══════╝

██████╗░░█████╗░███╗░░██╗██████╗░░█████╗░░██████╗
██╔══██╗██╔══██╗████╗░██║██╔══██╗██╔══██╗██╔════╝
██████╦╝███████║██╔██╗██║██║░░██║███████║╚█████╗░
██╔══██╗██╔══██║██║╚████║██║░░██║██╔══██║░╚═══██╗
██████╦╝██║░░██║██║░╚███║██████╔╝██║░░██║██████╔╝
╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░╚═╝░░╚═╝╚═════╝░

        ");


                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.DarkGray;

                Console.WriteLine(" 1 - Cadastrar Album da Banda ");

                Console.WriteLine(" 2-Cadastrar Album Do Artista ");

                Console.WriteLine(" 3-cadastar Músicas ");

                Console.WriteLine(" 4 sair do programa ");

                Console.ResetColor();

                opcao = int.Parse(Console.ReadLine());


                switch (opcao)

                {

                    case 1:


                        Cadastro_das_Bandas();


                        break;

                    case 2:
                        album_artista();
                        break;

                    case 3:

                        break;

                    case 4:

                        Console.Clear();

                        Console.WriteLine("saindo do  programa !!! tchau tchau !! :)");

                        break;

                }



            }

        }


        static void Cadastro_das_Bandas()

        {

            string nomeBanda, nomeAlbum;

            int qtdMusicas;

            Console.Clear();

            Console.WriteLine(@"
░█████╗░░█████╗░███╗░░██╗████████╗██████╗░░█████╗░██╗░░░░░███████╗  ██████╗░███████╗
██╔══██╗██╔══██╗████╗░██║╚══██╔══╝██╔══██╗██╔══██╗██║░░░░░██╔════╝  ██╔══██╗██╔════╝
██║░░╚═╝██║░░██║██╔██╗██║░░░██║░░░██████╔╝██║░░██║██║░░░░░█████╗░░  ██║░░██║█████╗░░
██║░░██╗██║░░██║██║╚████║░░░██║░░░██╔══██╗██║░░██║██║░░░░░██╔══╝░░  ██║░░██║██╔══╝░░
╚█████╔╝╚█████╔╝██║░╚███║░░░██║░░░██║░░██║╚█████╔╝███████╗███████╗  ██████╔╝███████╗
░╚════╝░░╚════╝░╚═╝░░╚══╝░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░╚══════╝╚══════╝  ╚═════╝░╚══════╝

██████╗░░█████╗░███╗░░██╗██████╗░░█████╗░░██████╗
██╔══██╗██╔══██╗████╗░██║██╔══██╗██╔══██╗██╔════╝
██████╦╝███████║██╔██╗██║██║░░██║███████║╚█████╗░
██╔══██╗██╔══██║██║╚████║██║░░██║██╔══██║░╚═══██╗
██████╦╝██║░░██║██║░╚███║██████╔╝██║░░██║██████╔╝
╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░╚═╝░░╚═╝╚═════╝░");


            Console.ResetColor();


            Console.WriteLine(" Digite o Nome da Banda ");

            nomeBanda = Console.ReadLine();


            Console.WriteLine(" Digite o Nome do Album ");

            nomeAlbum = Console.ReadLine();


            Console.WriteLine(" Digite o Número Da Musica ");

            qtdMusicas = int.Parse(Console.ReadLine());


            Console.WriteLine("\n cadastro realizado com sucesso !!! ");

            Console.WriteLine("\n" + nomeBanda);

            Console.WriteLine("\n" + nomeAlbum);

            Console.WriteLine("\n" + qtdMusicas);

            Thread.Sleep(2000);

        }
        static void album_artista()
        {
            int ano, qtdAlbum, vendas;
            string nome_artista;
            Console.WriteLine(" Digite o ano do album ");

           ano  = int.Parse(Console.ReadLine());


            Console.WriteLine(" Digite o nome do artista ");

            nome_artista = Console.ReadLine();


            Console.WriteLine(" Digite o qtd albums ");

            qtdAlbum = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a qtd de vendas ");
            vendas = int.Parse(Console.ReadLine());

            Console.WriteLine("\n cadastro realizado com sucesso !!! ");

            Console.WriteLine("\n" + ano);

            Console.WriteLine("\n" + nome_artista);

            Console.WriteLine("\n" + qtdAlbum);
            Console.WriteLine("\n " + vendas);
            Thread.Sleep(5000);
        }


    }

}
