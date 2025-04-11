using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_de_menu
{
    internal class Program
    {
        // crie um sistema de menu em que sera possivel acessar todas as atividades ja realizadas.
        // Cada atividade devera ter um arquivo separado para ter um aceso, Cada tela terá que ter titulo em ASCII e enunciado.
        static void Main(string[] args)
        {
            int opcao = 1;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"

███╗░░░███╗███████╗███╗░░██╗██╗░░░██╗  ██████╗░███████╗
████╗░████║██╔════╝████╗░██║██║░░░██║  ██╔══██╗██╔════╝
██╔████╔██║█████╗░░██╔██╗██║██║░░░██║  ██║░░██║█████╗░░
██║╚██╔╝██║██╔══╝░░██║╚████║██║░░░██║  ██║░░██║██╔══╝░░
██║░╚═╝░██║███████╗██║░╚███║╚██████╔╝  ██████╔╝███████╗
╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚══╝░╚═════╝░  ╚═════╝░╚══════╝

░█████╗░████████╗██╗██╗░░░██╗██╗██████╗░░█████╗░██████╗░███████╗░██████╗
██╔══██╗╚══██╔══╝██║██║░░░██║██║██╔══██╗██╔══██╗██╔══██╗██╔════╝██╔════╝
███████║░░░██║░░░██║╚██╗░██╔╝██║██║░░██║███████║██║░░██║█████╗░░╚█████╗░
██╔══██║░░░██║░░░██║░╚████╔╝░██║██║░░██║██╔══██║██║░░██║██╔══╝░░░╚═══██╗
██║░░██║░░░██║░░░██║░░╚██╔╝░░██║██████╔╝██║░░██║██████╔╝███████╗██████╔╝
╚═╝░░╚═╝░░░╚═╝░░░╚═╝░░░╚═╝░░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░╚══════╝╚═════╝░

██████╗░███████╗░█████╗░██╗░░░░░██╗███████╗░█████╗░██████╗░░█████╗░░██████╗
██╔══██╗██╔════╝██╔══██╗██║░░░░░██║╚════██║██╔══██╗██╔══██╗██╔══██╗██╔════╝
██████╔╝█████╗░░███████║██║░░░░░██║░░███╔═╝███████║██║░░██║███████║╚█████╗░
██╔══██╗██╔══╝░░██╔══██║██║░░░░░██║██╔══╝░░██╔══██║██║░░██║██╔══██║░╚═══██╗
██║░░██║███████╗██║░░██║███████╗██║███████╗██║░░██║██████╔╝██║░░██║██████╔╝
╚═╝░░╚═╝╚══════╝╚═╝░░╚═╝╚══════╝╚═╝╚══════╝╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░");
            Console.ResetColor();
            Console.WriteLine("\n atividades c#\n");
            Console.Write("1 -  atividade vinho \n");
            Console.Write("2 - soma_dois_numeros\n");
            Console.Write("3 - soma_3numeros\n");
            Console.Write("4 -sobre multa\n");
            Console.Write("5 -salario_minimo\n");
            Console.Write("6 -reajuste_%\n");
            Console.Write("7 -positivo_negativo\n");
            Console.Write("8 -peso_peixe\n");
            Console.Write("9 -peso_altura_imc\n");
            Console.Write("10 -pares_enquanto\n");
            Console.Write("11 - pagamento\n");
            Console.Write("12 -numeros_pares_2_e_100\n");
            Console.Write("13 -numero_entre_20_e_90\n");
            Console.Write("15 -nota_dinheiro\n");
            Console.Write("16 -multiplo_de_3\n");
            Console.Write("17 -menu\n");
            Console.Write("18 -ler_20numeros\n");
            Console.Write("29 -leia_dois_valores\n");
            Console.Write("20 -leia_dois\n");
            Console.Write("21 -laço_repetiçao_tabuada");
            Console.Write("22 -keno_perna\n");
            Console.Write("23 -idade_para_eleitor\n");
            Console.Write("24 -falso_verdadeiro\n");
            Console.Write("25 -fabrica\n");
            Console.Write("26 -emprestimo\n");
            Console.Write("27 - eleitor\n");
            Console.Write("28 -desconto\n");
            Console.Write("29 -calcule_desconto\n");
            Console.Write("30 -calcule_idade\n");
            Console.Write("31 -cadastre_dados_cliente\n");
            Console.Write("32 -ano_bissexto\n");
            Console.Write("33 -acertar numero\n");
            Console.Write("34 -real_nota\n");
            Console.ResetColor();
            while (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 0 || opcao > 5)
            {
                Console.WriteLine("opcao invalida digite novamente:\n");
            }
            switch (opcao)

            {
                case 1:

                    atividade_vinho.vinho();

                    break;
              

                        case 2:

                         some_dois_numeros.dois_numeros();

                    break;

                        case 3:

                    soma_3numeros.soma3numeros();

                    break;

                        case 4:

                    sobre_multa.sobremulta();

                    break;

                        case 5:

                    salario_minimo.salario();

                    break;

                    case 6:

                    reajuste.reajuuste();

                    break;
                        
                        case 7:

                    positivo_negativo.positivo();

                    break;

                    case 8:

                    peso_peixe.peixes();

                    break;

                    case 9:

                    peso_altura_imc.imc_altura_peso();

                    break;
                    
                    case 10:

                    pares_enquanto.equanto_pares();

                    break;

                    case 11:

                    pagamento.pagar();

                    break;  

                    case 12:

                    pares2e100.pares();

                        break;

                    case 13:

                    nota_dinheiro.dinheiro();

                    break;

                    case 14:

                    multiplo_de_3.multiplo_3();

                    break;

                    case 15:

                    ler_20numeros.ler_20numeros();

                    break;

                    case 16:

                    leia_dois_valores.dois_valores();

                    break;

                case 17:
                    laço_reptiçao_tabuada.tabuada();
                    break;
        }
        }
    }
}