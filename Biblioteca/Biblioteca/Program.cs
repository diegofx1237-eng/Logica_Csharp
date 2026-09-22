using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace livros
{
    internal class Program
    {
        /*Atividade Prática: Modelagem do Sistema de Biblioteca (C#)
 
Objetivo
 
Mapear os requisitos do sistema e implementar no console em C# a estrutura de classes com suas respectivas propriedades , simulando a instanciação de objetos na memória.
 
 
Estrutura do Menu Principal
 
 
==================================================
 
SISTEMA DE GESTÃO DE BIBLIOTECA
 
==================================================
 
1 - Cadastrar Livro
 
2 - Cadastrar Jogo
 
3 - Cadastrar Cliente
 
4 - Cadastrar Fornecedor
 
5 - Registrar Empréstimo
 
0 - Sair
 
==================================================
 
Escolha uma opção: _
 
 
 
Requisitos do Projeto: Estrutura de Campos
 
Crie uma classe dedicada para cada uma das entidades listadas abaixo, utilizando os tipos de dados apropriados (string, int, decimal, DateTime, bool, etc.).
 
1. Classe Livro
 
Campo Tipo em C# Descrição
 
Id int Identificador único
 
Titulo string Título da obra
 
Autor string Nome do autor
 
ISBN string Código de identificação internacional
 
AnoPublicacao int Ano de lançamento
 
Genero string Categoria (ex: Ficção, Técnico)
 
QuantidadeExemplares int Total de cópias na biblioteca
 
2. Classe Jogo (Jogos de Tabuleiro / Educativos)
 
Campo Tipo em C# Descrição
 
Id int Identificador único
 
Nome string Nome do jogo
 
Categoria string Tipo (ex: Estratégia, RPG, Tabuleiro)
 
FaixaEtaria int Idade mínima recomendada
 
NumMinJogadores int Quantidade mínima de participantes
 
Campo Tipo em C# Descrição
 
NumMaxJogadores int Quantidade máxima de participantes
 
QuantidadeExemplares int Total de caixas disponíveis
 
3. Classe Cliente
 
Campo Tipo em C# Descrição
 
Id int Identificador único
 
Nome string Nome completo do usuário
 
CPF string Documento de identificação
 
Telefone string Número de contato
 
Email string Endereço de e-mail
 
DataNascimento DateTime Data de nascimento
 
Ativo bool Situação do cadastro (true/false)
 
4. Classe Fornecedor
 
Campo Tipo em C# Descrição
 
Id int Identificador único
 
RazaoSocial string Nome jurídico da empresa/editora
 
CNPJ string Registro nacional
 
Campo Tipo em C# Descrição
 
Telefone string Telefone corporativo
 
Email string E-mail de contato comercial
 
Endereco string Logradouro e cidade
 
5. Classe Emprestimo
 
Campo Tipo em C# Descrição
 
Id int Identificador único
 
ClienteId int Código do cliente associado
 
TipoItem string Define se é "Livro" ou "Jogo"
 
ItemId int Código do livro ou jogo emprestado
 
DataEmprestimo DateTime Data/hora da retirada
 
DataDevolucaoPrevista DateTime Data limite para entrega
 
Devolvido bool Status de devolução
 
Instruções para os Alunos
 
1. Criação da Solução: Crie um projeto do tipo.
 
2. Criação de Funções: Adicione um arquivo separado para cada classe (Livro, Jogo, Cliente, Fornecedor, Empréstimo).
 
3. Em cada função deverá ter AO MENOS UM dos recursos aplicados como: IF, ELSE, FOR, SWITCH, WHILE.*/
        static void Main(string[] args)
        {
            int opcao = 0;
            while (opcao != 6)
            {
                Console.WriteLine("1 - Cadastrar Livro: ");
                Console.WriteLine("2 - Cadastrar Jogo: ");
                Console.WriteLine("3 - Cadastrar Cliente");
                Console.WriteLine("4 - Cadastrar Fornecedor");
                Console.WriteLine("5 - Registrar Empréstimo");
                Console.WriteLine("0 - Sair");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        cadastroLivro();
                        break;
                    case 2:
                        cadastroJogo();
                        break;
                    case 3:
                        cadastarCliente();
                        break;
                    case 4:
                        cadastrarFonercedor();
                        break;
                    case 5:
                        cadastrarEmprestimo();
                        break;
                    case 0:
                        Console.Clear();
                        Console.WriteLine("saindo do programa!!!! tchau  tchau!! :)");
                        break;
                }


            }


        }
        static void cadastroLivro()
        {
            int id, anoPubli, qtdExemplares, qtdCadastro;
            string titulo, autor, ISBN, Genero;

            Console.WriteLine("digite a qtdCadastro:");
            qtdCadastro = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtdCadastro; i++)
            {
                Console.WriteLine($"Cadastro #{i + 1}");
                Console.WriteLine("digite o id do livro: ");
                id = int.Parse(Console.ReadLine());
                Console.WriteLine("digite a qtd de exemplares desse livro no estoque: ");
                qtdExemplares = int.Parse(Console.ReadLine());
                Console.WriteLine("digite o ano de publicação: ");
                anoPubli = int.Parse(Console.ReadLine());
                Console.WriteLine("digite o titulo: ");
                titulo = Console.ReadLine();
                Console.WriteLine("digite o nome do autor: ");
                autor = Console.ReadLine();
                Console.WriteLine("digite o codigo ISBN: ");
                ISBN = Console.ReadLine();
                Console.WriteLine("digite o genero: ");
                Genero = Console.ReadLine();

                // aqui você pode criar e armazenar o objeto Livro, se já tiver a classe/coleção
            }

        }
        static void cadastroJogo()
        {
            int id, faixaEtaria, numMinJogadores, numMaxJogadores, qtdExemplares, qtdCadastro;
            string nome, categoria;
            Console.WriteLine("digite a qtdCadastro:");
            qtdCadastro = int.Parse(Console.ReadLine());
            for (int i = 0; i < qtdCadastro; i++)
            {
                Console.WriteLine($"Cadastro #{i + 1}");
                Console.WriteLine("digite o id do jogo: ");
                id = int.Parse(Console.ReadLine());
                Console.WriteLine("digite a qtd de exemplares desse jogo no estoque: ");
                qtdExemplares = int.Parse(Console.ReadLine());
                Console.WriteLine("digite a faixa etária recomendada: ");
                faixaEtaria = int.Parse(Console.ReadLine());
                Console.WriteLine("digite o número mínimo de jogadores: ");
                numMinJogadores = int.Parse(Console.ReadLine());
                Console.WriteLine("digite o número máximo de jogadores: ");
                numMaxJogadores = int.Parse(Console.ReadLine());
                Console.WriteLine("digite o nome do jogo: ");
                nome = Console.ReadLine();
                Console.WriteLine("digite a categoria do jogo: ");
                categoria = Console.ReadLine();
                // aqui você pode criar e armazenar o objeto Jogo, se já tiver a classe/coleção
            }

        }
        static void cadastarCliente()
        {
            int id;
            string nome, cpf, telefone, email;
            DateTime dataNascimento;
            bool ativo;
            Console.WriteLine("digite o id do cliente: ");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o nome completo do cliente: ");
            nome = Console.ReadLine();
            Console.WriteLine("digite o CPF do cliente: ");
            cpf = Console.ReadLine();
            Console.WriteLine("digite o telefone do cliente: ");
            telefone = Console.ReadLine();
            Console.WriteLine("digite o email do cliente: ");
            email = Console.ReadLine();
            Console.WriteLine("digite a data de nascimento do cliente (dd/MM/yyyy): ");
            dataNascimento = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            Console.WriteLine("o cliente está ativo? (true/false): ");
            ativo = bool.Parse(Console.ReadLine());
            // aqui você pode criar e armazenar o objeto Cliente, se já tiver a classe/coleção
        }
        static void cadastrarFonercedor()
        {
            int id;
            string razaoSocial, cnpj, telefone, email, endereco;
            Console.WriteLine("digite o id do fornecedor: ");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("digite a razão social do fornecedor: ");
            razaoSocial = Console.ReadLine();
            Console.WriteLine("digite o CNPJ do fornecedor: ");
            cnpj = Console.ReadLine();
            Console.WriteLine("digite o telefone do fornecedor: ");
            telefone = Console.ReadLine();
            Console.WriteLine("digite o email do fornecedor: ");
            email = Console.ReadLine();
            Console.WriteLine("digite o endereço do fornecedor: ");
            endereco = Console.ReadLine();

        }  // aqui você pode criar e armazenar o objeto Fornecedor, se já tiver a classe/coleção
        static void cadastrarEmprestimo()
        {
            int id, clienteId, itemId;
            string tipoItem;
            DateTime dataEmprestimo, dataDevolucaoPrevista;
            bool devolvido;
            Console.WriteLine("digite o id do empréstimo: ");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o id do cliente associado: ");
            clienteId = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o tipo de item (Livro/Jogo): ");
            tipoItem = Console.ReadLine();
            Console.WriteLine("digite o id do item emprestado: ");
            itemId = int.Parse(Console.ReadLine());
            Console.WriteLine("digite a data do empréstimo (dd/MM/yyyy): ");
            dataEmprestimo = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            Console.WriteLine("digite a data prevista para devolução (dd/MM/yyyy): ");
            dataDevolucaoPrevista = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            Console.WriteLine("o item foi devolvido? (true/false): ");
            devolvido = bool.Parse(Console.ReadLine());
            // aqui você pode criar e armazenar o objeto Emprestimo, se já tiver a classe/coleção
        }
    }

}