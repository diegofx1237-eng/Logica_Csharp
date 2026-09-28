using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
namespace hospital
{
    public static class variaveis
    {
        public static int idMedico, idPaciente, idLeito, idInternacao, pacienteInternacao, medicoInternacao, LeitoIdInternacao;
        public static string nomeMedico, TipoDeSala, NumeroSala, CRM, especialidade, telefone, numeroQuarto, Tipo, CPF, NomePaciente, dataNasciemento, tipoSanguineo, Alergias, ContatoEmergencia, dataEntrada, dataAlta, diagnosticoEntrada, status;
        public static bool Ocupado;
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            int opcao = 9;
            while (opcao != 0)
                Console.WriteLine("1 - cadastrar paciente");
            Console.WriteLine("2 - cadastrar médico");
            Console.WriteLine("3 - cadastrar leito");
            Console.WriteLine("4 - registrar internação(admissao)");
            Console.WriteLine("5 - dar alta hospitalar");
            Console.WriteLine("6 - listar pacientes internados");
            Console.WriteLine("7 - exibir relatorio geral hospital");
            Console.WriteLine("0 - sair");
            opcao = int.Parse(Console.ReadLine());


            switch (opcao)
            {
                case 1:
                    Cadastrar_Paciente();
                    Console.WriteLine("Cadastrar paciente");
                    break;
                case 2:
                    cadastrar_medico();
                    Console.WriteLine("Cadastrar médico");
                    break;
                case 3:
                    Funcao_Leito();
                    Console.WriteLine("Cadastrar leito");
                    break;
                case 4:
                    internacao();
                    Console.WriteLine("Registrar internação");
                    break;
                case 5:
                    Dar_alta_hospitalar();
                    Console.WriteLine("Dar alta hospitalar");
                    break;
                case 6:
                    funcao_listar();
                    Console.WriteLine("Listar pacientes internados");
                    break;
                case 7:
                    relatorio_geral();
                    Console.WriteLine("Exibir relatório geral do hospital");
                    break;
                case 0:
                    Console.WriteLine("Saindo...");
                    break;
            }


        }

        static void cadastrar_medico()
        {

            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░  ███╗░░░███╗███████╗██████╗░██╗░█████╗░░█████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ████╗░████║██╔════╝██╔══██╗██║██╔══██╗██╔══██╗
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║  ██╔████╔██║█████╗░░██║░░██║██║██║░░╚═╝██║░░██║
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║  ██║╚██╔╝██║██╔══╝░░██║░░██║██║██║░░██╗██║░░██║
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝  ██║░╚═╝░██║███████╗██████╔╝██║╚█████╔╝╚█████╔╝
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ╚═╝░░░░░╚═╝╚══════╝╚═════╝░╚═╝░╚════╝░░╚════╝░");
            Console.WriteLine("Digite o ID do médico:");
            variaveis.idMedico = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome do médico:");
            variaveis.nomeMedico = Console.ReadLine();
            Console.WriteLine("Digite o CRM do médico:");
            variaveis.CRM = Console.ReadLine();
            Console.WriteLine("Digite a especialidade do médico:");
            variaveis.especialidade = Console.ReadLine();
            Console.WriteLine("Digite o telefone do médico:");
            variaveis.telefone = Console.ReadLine();
        }
        static void internacao()
        {
            Console.WriteLine("Registrar internação");
            variaveis.idInternacao = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o ID do paciente:");
            variaveis.pacienteInternacao = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o ID do médico responsável:");
            variaveis.medicoInternacao = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o ID do leito:");
            variaveis.LeitoIdInternacao = int.Parse(Console.ReadLine());
            Console.WriteLine("digite a data de entrada (dd/MM/yyyy):");
            variaveis.dataEntrada = Console.ReadLine();
            Console.WriteLine("Digite o diagnóstico de entrada:");
            variaveis.diagnosticoEntrada = Console.ReadLine();
            Console.WriteLine("digite a data de alta (dd/MM/yyyy):");
            variaveis.dataAlta = Console.ReadLine();
            Console.WriteLine("Digite o status da internação (ativo/inativo):");
            variaveis.status = Console.ReadLine();

        }
        static void Cadastrar_Paciente()
        {
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░

██████╗░░█████╗░░█████╗░██╗███████╗███╗░░██╗████████╗███████╗
██╔══██╗██╔══██╗██╔══██╗██║██╔════╝████╗░██║╚══██╔══╝██╔════╝
██████╔╝███████║██║░░╚═╝██║█████╗░░██╔██╗██║░░░██║░░░█████╗░░
██╔═══╝░██╔══██║██║░░██╗██║██╔══╝░░██║╚████║░░░██║░░░██╔══╝░░
██║░░░░░██║░░██║╚█████╔╝██║███████╗██║░╚███║░░░██║░░░███████╗
╚═╝░░░░░╚═╝░░╚═╝░╚════╝░╚═╝╚══════╝╚═╝░░╚══╝░░░╚═╝░░░╚══════╝") ;




            Console.WriteLine("Digite o Id do Paciente: ");

            variaveis.idPaciente = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Nome do Paciente: ");

            variaveis.NomePaciente = Console.ReadLine();

            Console.WriteLine("Digite o Cpf Do Paciente: ");

            variaveis.CPF = Console.ReadLine();

            Console.WriteLine("Digite o Tipo de Alergia Do Paciente: ");

            variaveis.Alergias = Console.ReadLine();

            Console.WriteLine("Digite o Tipo Sanguineo Do Paciente: ");

            variaveis.tipoSanguineo = Console.ReadLine();

            Console.WriteLine("Digite o Contato De Emergencia: ");

            variaveis.ContatoEmergencia = Console.ReadLine();

        }
        static void Funcao_Leito()
        {
            Console.WriteLine(@"
███████╗██╗░░░██╗███╗░░██╗░█████╗░░█████╗░░█████╗░  ██╗░░░░░███████╗██╗████████╗░█████╗░
██╔════╝██║░░░██║████╗░██║██╔══██╗██╔══██╗██╔══██╗  ██║░░░░░██╔════╝██║╚══██╔══╝██╔══██╗
█████╗░░██║░░░██║██╔██╗██║██║░░╚═╝███████║██║░░██║  ██║░░░░░█████╗░░██║░░░██║░░░██║░░██║
██╔══╝░░██║░░░██║██║╚████║██║░░██╗██╔══██║██║░░██║  ██║░░░░░██╔══╝░░██║░░░██║░░░██║░░██║
██║░░░░░╚██████╔╝██║░╚███║╚█████╔╝██║░░██║╚█████╔╝  ███████╗███████╗██║░░░██║░░░╚█████╔╝
╚═╝░░░░░░╚═════╝░╚═╝░░╚══╝░╚════╝░╚═╝░░╚═╝░╚════╝░  ╚══════╝╚══════╝╚═╝░░░╚═╝░░░░╚════╝░");


            Console.WriteLine("Digite ID Leito: ");

            variaveis.idLeito = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Numero Da Sala: ");

            variaveis.NumeroSala = Console.ReadLine();

            Console.WriteLine("Digite o Tipo de Sala: ");

            variaveis.TipoDeSala = Console.ReadLine();

            Console.WriteLine("Digite true/false para Ver se esta Ocupado");

            variaveis.Ocupado = bool.Parse(Console.ReadLine());

        }
        static void Dar_alta_hospitalar()
        {

            Console.WriteLine(@"
██████╗░░█████╗░██████╗░  ░█████╗░██╗░░░░░████████╗░█████╗░  ███╗░░██╗░█████╗░
██╔══██╗██╔══██╗██╔══██╗  ██╔══██╗██║░░░░░╚══██╔══╝██╔══██╗  ████╗░██║██╔══██╗
██║░░██║███████║██████╔╝  ███████║██║░░░░░░░░██║░░░███████║  ██╔██╗██║██║░░██║
██║░░██║██╔══██║██╔══██╗  ██╔══██║██║░░░░░░░░██║░░░██╔══██║  ██║╚████║██║░░██║
██████╔╝██║░░██║██║░░██║  ██║░░██║███████╗░░░██║░░░██║░░██║  ██║░╚███║╚█████╔╝
╚═════╝░╚═╝░░╚═╝╚═╝░░╚═╝  ╚═╝░░╚═╝╚══════╝░░░╚═╝░░░╚═╝░░╚═╝  ╚═╝░░╚══╝░╚════╝░

██╗░░██╗░█████╗░░██████╗██████╗░██╗████████╗░█████╗░██╗░░░░░
██║░░██║██╔══██╗██╔════╝██╔══██╗██║╚══██╔══╝██╔══██╗██║░░░░░
███████║██║░░██║╚█████╗░██████╔╝██║░░░██║░░░███████║██║░░░░░
██╔══██║██║░░██║░╚═══██╗██╔═══╝░██║░░░██║░░░██╔══██║██║░░░░░
██║░░██║╚█████╔╝██████╔╝██║░░░░░██║░░░██║░░░██║░░██║███████╗
╚═╝░░╚═╝░╚════╝░╚═════╝░╚═╝░░░░░╚═╝░░░╚═╝░░░╚═╝░░╚═╝╚══════╝");

            Console.WriteLine("Digite o Status da Internação para Inativo");
            variaveis.status = Console.ReadLine();
        }
        static void relatorio_geral()
        {
            Console.WriteLine(@"
██████╗░███████╗██╗░░░░░░█████╗░████████╗░█████╗░██████╗░██╗░█████╗░  ░██████╗░███████╗██████╗░░█████╗░██╗░░░░░
██╔══██╗██╔════╝██║░░░░░██╔══██╗╚══██╔══╝██╔══██╗██╔══██╗██║██╔══██╗  ██╔════╝░██╔════╝██╔══██╗██╔══██╗██║░░░░░
██████╔╝█████╗░░██║░░░░░███████║░░░██║░░░██║░░██║██████╔╝██║██║░░██║  ██║░░██╗░█████╗░░██████╔╝███████║██║░░░░░
██╔══██╗██╔══╝░░██║░░░░░██╔══██║░░░██║░░░██║░░██║██╔══██╗██║██║░░██║  ██║░░╚██╗██╔══╝░░██╔══██╗██╔══██║██║░░░░░
██║░░██║███████╗███████╗██║░░██║░░░██║░░░╚█████╔╝██║░░██║██║╚█████╔╝  ╚██████╔╝███████╗██║░░██║██║░░██║███████╗
╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚═╝░░░╚═╝░░░░╚════╝░╚═╝░░╚═╝╚═╝░╚════╝░  ░╚═════╝░╚══════╝╚═╝░░╚═╝╚═╝░░╚═╝╚══════╝");

            Console.WriteLine("Dados Do Paciente ");
            Console.WriteLine("ID:" + variaveis.idPaciente);
            Console.WriteLine("NomePaciente" + variaveis.NomePaciente);
            Console.WriteLine("Cpf"+ variaveis.CPF);
            Console.WriteLine("TipoSanguineo" + variaveis.tipoSanguineo);
            Console.WriteLine("Alergias" + variaveis.Alergias);
            Console.WriteLine("Contato De Emergencia" + variaveis.ContatoEmergencia);

            Console.WriteLine("Dados Do Medico");
            Console.WriteLine("Id: "+variaveis.idMedico);
            Console.WriteLine("Nome: " + variaveis.nomeMedico);
            Console.WriteLine("CRM"+ variaveis.CRM);
            Console.WriteLine("Especialiadade: " + variaveis.especialidade);
            Console.WriteLine("Telefone:" + variaveis.telefone);

            Console.WriteLine("Dados do Leito");
            Console.WriteLine("Id do Leito: " + variaveis.idLeito);
            Console.WriteLine("Nuemro Da Sala: " + variaveis.NumeroSala);
            Console.WriteLine("Tipo de Sala: " + variaveis.TipoDeSala);
            Console.WriteLine("Ocupado: "+ variaveis.Ocupado);

            Console.WriteLine("Dados Da Internação");
            Console.WriteLine("Id Do Paciente:" + variaveis.idPaciente);
            Console.WriteLine("Id Do Medico: " + variaveis.idMedico);
            Console.WriteLine("Id Do Leito:" + variaveis.idLeito);
            Console.WriteLine("Data De Entrada:" + variaveis.dataEntrada);
            Console.WriteLine("Diagnostico: " + variaveis.diagnosticoEntrada);
            Console.WriteLine("Status: " + variaveis.status);
            Console.WriteLine("Ocupdo: " + variaveis.Ocupado);
        
           
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        }
        static void funcao_listar()
        {
            Console.WriteLine(@"
██╗░░░░░██╗░██████╗████████╗░█████╗░██████╗░  ██████╗░░█████╗░░█████╗░██╗███████╗███╗░░██╗████████╗███████╗
██║░░░░░██║██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ██╔══██╗██╔══██╗██╔══██╗██║██╔════╝████╗░██║╚══██╔══╝██╔════╝
██║░░░░░██║╚█████╗░░░░██║░░░███████║██████╔╝  ██████╔╝███████║██║░░╚═╝██║█████╗░░██╔██╗██║░░░██║░░░█████╗░░
██║░░░░░██║░╚═══██╗░░░██║░░░██╔══██║██╔══██╗  ██╔═══╝░██╔══██║██║░░██╗██║██╔══╝░░██║╚████║░░░██║░░░██╔══╝░░
███████╗██║██████╔╝░░░██║░░░██║░░██║██║░░██║  ██║░░░░░██║░░██║╚█████╔╝██║███████╗██║░╚███║░░░██║░░░███████╗
╚══════╝╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚═╝  ╚═╝░░░░░╚═╝░░╚═╝░╚════╝░╚═╝╚══════╝╚═╝░░╚══╝░░░╚═╝░░░╚══════╝");


            Console.WriteLine("Listar pacientes internados");
            Console.WriteLine("ID Internação: " + variaveis.idInternacao);
            Console.WriteLine("ID Paciente: " + variaveis.pacienteInternacao);
            Console.WriteLine("ID Médico: " + variaveis.medicoInternacao);
            Console.WriteLine("ID Leito: " + variaveis.LeitoIdInternacao);
            Console.WriteLine("Data de Entrada: " + variaveis.dataEntrada);
            Console.WriteLine("Diagnóstico de Entrada: " + variaveis.diagnosticoEntrada);
            Console.WriteLine("Data de Alta: " + variaveis.dataAlta);
            Console.WriteLine("Status da Internação: " + variaveis.status);
            Console.WriteLine("medico responsável: " + variaveis.nomeMedico);
            Console.WriteLine("Paciente: " + variaveis.NomePaciente);
            Console.WriteLine("Leito: " + variaveis.NumeroSala);
            Console.WriteLine("Tipo de Sala: " + variaveis.TipoDeSala);
            Console.WriteLine("Ocupado: " + variaveis.Ocupado);
            Console.WriteLine("CRM do Médico: " + variaveis.CRM);
            Console.WriteLine("Especialidade do Médico: " + variaveis.especialidade);
            Console.WriteLine("Telefone do Médico: " + variaveis.telefone);
            Console.WriteLine("CPF do Paciente: " + variaveis.CPF);
            Console.WriteLine("Tipo Sanguíneo do Paciente: " + variaveis.tipoSanguineo);
            Console.WriteLine("Alergias do Paciente: " + variaveis.Alergias);
            Console.WriteLine("Data de Nascimento do Paciente: " + variaveis.dataNasciemento);
            Console.WriteLine("Contato de Emergência do Paciente: " + variaveis.ContatoEmergencia);
            Console.WriteLine("--------------------------------------------------");
        }





    }


}
