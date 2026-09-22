using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
namespace cadastros_bandas
{
    internal class Program
    {
        /*
         se /enquanto/para/caso
        if   while    for   switch
        crie um sistema para cadastro de albuns de um artista / banda em que sera possivel cadastrar um numero x
        de musicas informada pelo usuario. crie um menu de opçao para isso
         
         */
        static void Main(string[] args)
        {
            int opcao = 0;
            while (opcao != 4)
            {
                Console.Clear();
                Console.WriteLine(@"
░█████╗░░█████╗░███╗░░██╗████████╗██████╗░░█████╗░██╗░░░░░███████╗  ██████╗░███████╗
██╔══██╗██╔══██╗████╗░██║╚══██╔══╝██╔══██╗██╔══██╗██║░░░░░██╔════╝  ██╔══██╗██╔════╝
██║░░╚═╝██║░░██║██╔██╗██║░░░██║░░░██████╔╝██║░░██║██║░░░░░█████╗░░  ██║░░██║█████╗░░
██║░░██╗██║░░██║██║╚████║░░░██║░░░██╔══██╗██║░░██║██║░░░░░██╔══╝░░  ██║░░██║██╔══╝░░
╚█████╔╝╚█████╔╝██║░╚███║░░░██║░░░██║░░██║╚█████╔╝███████╗███████╗  ██████╔╝███████╗
░╚════╝░░╚════╝░╚═╝░░╚══╝░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░╚══════╝╚══════╝  ╚═════╝░╚══════╝
██████╗░░█████╗░███╗░░██╗██████╗░░█████╗░
██╔══██╗██╔══██╗████╗░██║██╔══██╗██╔══██╗
██████╦╝███████║██╔██╗██║██║░░██║███████║
██╔══██╗██╔══██║██║╚████║██║░░██║██╔══██║
██████╦╝██║░░██║██║░╚███║██████╔╝██║░░██║
╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░╚═╝░░╚═╝0");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" 1 - cadastrar album da banda");
                Console.WriteLine(" 2 - cadastrar album do artista");
                Console.WriteLine(" 3 - cadastrar musicas");// digitar a qtd musicas( nome musica, duração,premiação)Console.WriteLine(" 4 - sair do programa");
                Console.WriteLine("------------>");
                Console.ResetColor();
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        cadastro_bandas();
                        break;
                    case 2:
                        album_artista();
                        break;
                    case 3:
                        cadastro_musicas();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("saindo do programa!!!! tchau  tchau!! :)");
                        break;
                }
            }

        }
        static void cadastro_bandas()
        {
            int qtdmusicas;
            string nomebanda, nomealbum;
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░  ██████╗░███████╗
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ██╔══██╗██╔════╝
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║  ██║░░██║█████╗░░
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║  ██║░░██║██╔══╝░░
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝  ██████╔╝███████╗
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ╚═════╝░╚══════╝
██████╗░░█████╗░███╗░░██╗██████╗░░█████╗░
██╔══██╗██╔══██╗████╗░██║██╔══██╗██╔══██╗
██████╦╝███████║██╔██╗██║██║░░██║███████║
██╔══██╗██╔══██║██║╚████║██║░░██║██╔══██║
██████╦╝██║░░██║██║░╚███║██████╔╝██║░░██║
╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░╚═╝░░╚═╝");
            Console.WriteLine("digite o nome da banda: ");
            nomebanda = Console.ReadLine();
            Console.WriteLine("digite o nome do album");
            nomealbum = Console.ReadLine();
            Console.WriteLine("digite o numero de musicas");
            qtdmusicas = int.Parse(Console.ReadLine());
            Console.WriteLine("\n cadastro realizado com sucesso ! ! ! ");
            Console.WriteLine("\n" + nomebanda);
            Console.WriteLine("\n" + nomealbum);
            Console.WriteLine("\n" + qtdmusicas);
            Thread.Sleep(3000);
        }
        static void album_artista()
        {
            int ano, qtd_album, qtd_vendas;
            string nome_artista;
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░  ░█████╗░██╗░░░░░██████╗░██╗░░░██╗███╗░░░███╗
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ██╔══██╗██║░░░░░██╔══██╗██║░░░██║████╗░████║
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║  ███████║██║░░░░░██████╦╝██║░░░██║██╔████╔██║
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║  ██╔══██║██║░░░░░██╔══██╗██║░░░██║██║╚██╔╝██║
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝  ██║░░██║███████╗██████╦╝╚██████╔╝██║░╚═╝░██║
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ╚═╝░░╚═╝╚══════╝╚═════╝░░╚═════╝░╚═╝░░░░░╚═╝");
            Console.WriteLine("digite o ano do album: ");
            ano = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o nome do artista: ");
            nome_artista = Console.ReadLine();
            Console.WriteLine("digite a qtd de albums: ");
            qtd_album = int.Parse(Console.ReadLine());
            Console.WriteLine("digite a qtd de vendas");
            qtd_vendas = int.Parse(Console.ReadLine());
            Console.WriteLine("\n cadastro realizado com sucesso:");
            Console.WriteLine("\n" + ano);
            Console.WriteLine("\n" + nome_artista);
            Console.WriteLine("\n" + qtd_album);
            Console.WriteLine("\n" + qtd_vendas);
            Thread.Sleep(3000);
        }
        static void cadastro_musicas()
        {
            int qtdMusica;
            string nomeMusica, premiação, duraçao;

            Console.WriteLine("digite a qtd de musica: ");
            qtdMusica = int.Parse(Console.ReadLine());
            Console.WriteLine("digite a duração da musica: ");
            duraçao = Console.ReadLine();
            Console.WriteLine("digite o nome da musica: ");
            nomeMusica = Console.ReadLine();
            Console.WriteLine("digite a premiação: ");
            premiação = Console.ReadLine();

            Console.WriteLine("\n cadastro realizado com sucesso");
            Console.WriteLine("\n" + qtdMusica);
            Console.WriteLine("\n" + duraçao);
            Console.WriteLine("\n " + nomeMusica);
            Console.WriteLine("\n " + premiação);
            Thread.Sleep(3000);
        }
    }
}