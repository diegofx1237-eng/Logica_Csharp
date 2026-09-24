using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Podologia
{
    public static class variaveisGlobais
    {
        public static int idCliente;
        public static string nomeCliente;
        public static string cpfCliente;
        public static string telefoneCliente;
        public static string dataNascimentoCliente;
        public static bool PossuiDiabetes;
        public static string ObersavacoesAnamnese;
        public static int IDServico;
        public static string nomeServico;
        public static int duracaoMinutosServico;
        public static double valorServico;

        public static int idProfissional;
        public static string nomeProfissional;
        public static string registroProfissional;
        public static string especialiadeProfissional;
        public static string telefoneProfissional;
        public static int idConsulta;
        public static int clientIDconsulta;
        public static int podologoIDconsulta;
        public static int procedimentoIDconsulta;
        public static string statusConsulta;
        public static string dataHoraConsulta;
    }
    internal class Program
    {
        /*Objetivo
Mapear os requisitos de atendimento da clínica, implementar a estrutura de Funçãos com atributos específicos da podologia e construir uma interface via terminal (switch-case com do-while) para gerenciar clientes, profissionais, serviços e consultas.
Requisitos do Projeto: Estrutura de Campos
Crie uma Função para cada entidade do sistema com os devidos tipos de dados em C#:
Estrutura do Menu Principal*/
        static void Main(string[] args)
        {
            int opcao = 7;
            while (opcao != 0)
            {


                Console.WriteLine("1- cadastrar cliente (ficha rapida) ");
                Console.WriteLine("2- cadastrar podologo");
                Console.WriteLine("3- cadastrar procedimento / serviço");
                Console.WriteLine("4- agendar consulta");
                Console.WriteLine("5- listar agendamento");
                Console.WriteLine("6- exibir todos os cadastros");
                Console.WriteLine("0- sair");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        cadastro_cliente();
                        break;
                    case 2:
                        cadastroPodologo();
                        break;
                    case 3:
                        procedimento_serviço();
                        break;
                    case 4:
                        agendaConsulta();
                        break;
                    case 5:
                        listagem();
                        break;
                    case 6:
                        break;
                    case 0:
                        break;

                }

            }





        }
        static void cadastro_cliente()
        {

            Console.WriteLine("Digite o ID do cliente: ");
            variaveisGlobais.idCliente = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Nome Do Cliente: ");
            variaveisGlobais.nomeCliente = Console.ReadLine();
            Console.WriteLine("Digite o CPF do cliente: ");
            variaveisGlobais.cpfCliente = Console.ReadLine();
            Console.WriteLine("Digite o telefone Para Contato: ");
            variaveisGlobais.telefoneCliente = Console.ReadLine();
            Console.WriteLine("digite de nascimento do cliente:");
            variaveisGlobais.dataNascimentoCliente = Console.ReadLine();
            Console.WriteLine("Digite se o cliente possui diabetes (true/false): ");
            variaveisGlobais.PossuiDiabetes = bool.Parse(Console.ReadLine());
            Console.WriteLine("Digite as observações da anamnese: ");
            variaveisGlobais.ObersavacoesAnamnese = Console.ReadLine();
        }
        static void procedimento_serviço()
        {

            Console.WriteLine("digite o id do procedimento/serviço: ");
            variaveisGlobais.IDServico = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o nome do procedimento/serviço: ");
            variaveisGlobais.nomeServico = Console.ReadLine();
            Console.WriteLine("digite a duração em minutos do procedimento/serviço: ");
            variaveisGlobais.duracaoMinutosServico = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o valor do procedimento/serviço: ");
            variaveisGlobais.valorServico = double.Parse(Console.ReadLine());
        }
        static void cadastroPodologo()
        {

            Console.WriteLine("Digite o ID Do Podologo: ");
            variaveisGlobais.idProfissional = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Nome do Podologo: ");
            variaveisGlobais.nomeProfissional = Console.ReadLine();
            Console.WriteLine("Digite o Registro Profissional do Podologo: ");
            variaveisGlobais.registroProfissional = Console.ReadLine();
            Console.WriteLine("Digite a Especialidade Do Podologo: ");
            variaveisGlobais.especialiadeProfissional = Console.ReadLine();
            Console.WriteLine("Digite o Telefone Do Podologo: ");
            variaveisGlobais.telefoneProfissional = Console.ReadLine();
        }
        static void agendaConsulta()
        {

            Console.WriteLine("Digite o ID Da Consulta: ");
            variaveisGlobais.idConsulta = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o ClienteID: ");
            variaveisGlobais.clientIDconsulta = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o PodologoID: ");
            variaveisGlobais.podologoIDconsulta = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o ProcedimentoID");
            variaveisGlobais.procedimentoIDconsulta = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Status Do Procedimento: ");
            variaveisGlobais.statusConsulta = Console.ReadLine();
            Console.WriteLine("Digite a Data: ");
            variaveisGlobais.dataHoraConsulta = Console.ReadLine();
        }

        static void listagem()
        {

            Console.WriteLine(" cliente id" + variaveisGlobais.idCliente);
            Console.WriteLine("Nome: " + variaveisGlobais.nomeCliente);
            Console.WriteLine("CPF: " + variaveisGlobais.cpfCliente);
            Console.WriteLine("Telefone: " + variaveisGlobais.telefoneCliente);
            Console.WriteLine("Data de Nascimento: " + variaveisGlobais.dataNascimentoCliente);
            Console.WriteLine("Possui Diabetes: " + variaveisGlobais.PossuiDiabetes);
            Console.WriteLine("Observações da Anamnese: " + variaveisGlobais.ObersavacoesAnamnese);
            Console.WriteLine("\nProcedimento/Serviço:");
            Console.WriteLine("ID: " + variaveisGlobais.IDServico);
            Console.WriteLine("Nome: " + variaveisGlobais.nomeServico);
            Console.WriteLine("Duração (minutos): " + variaveisGlobais.duracaoMinutosServico);
            Console.WriteLine("Valor: " + variaveisGlobais.valorServico);
            Console.WriteLine("\nPodólogo:");
            Console.WriteLine("ID: " + variaveisGlobais.idProfissional);
            Console.WriteLine("Nome: " + variaveisGlobais.nomeProfissional);
            Console.WriteLine("Registro Profissional: " + variaveisGlobais.registroProfissional);
            Console.WriteLine("Especialidade: " + variaveisGlobais.especialiadeProfissional);
            Console.WriteLine("Telefone: " + variaveisGlobais.telefoneProfissional);
            Console.WriteLine("\nConsulta:");
            Console.WriteLine("ID: " + variaveisGlobais.idConsulta);
            Console.WriteLine("Cliente ID: " + variaveisGlobais.clientIDconsulta);
            Console.WriteLine("Podólogo ID: " + variaveisGlobais.podologoIDconsulta);
            Console.WriteLine("Procedimento ID: " + variaveisGlobais.procedimentoIDconsulta);
            Console.WriteLine("Status: " + variaveisGlobais.statusConsulta);
            Console.WriteLine("Data e Hora: " + variaveisGlobais.dataHoraConsulta);

        }
    }
}