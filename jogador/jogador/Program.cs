using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogador
{
    internal class Program
    {
        public class Ficha
        {
            public string nomedojogador;
            public string nomedopersonagem;
            public string raca;
            public string classe;
            public int vida;


            public void ImprimirFicha()
            {
                Console.WriteLine(" \n");
                Console.WriteLine("=========================");
                Console.WriteLine("=====Ficha do personagem=====");
                Console.WriteLine("Nome do personagem : " + nomedopersonagem);
                Console.WriteLine("raça : "+ raca);
                Console.WriteLine("classe :  " + classe);
                Console.WriteLine("vida " + vida);
                Console.WriteLine("=======================================");
                Console.WriteLine("========================================");
                Console.WriteLine("\n");

            }

            static void Main(string[] args)
            {
                Random random = new Random();
                int d6 = random.Next(1, 6);
                int d6jogador = 0;
                int d6inimigo = 0;

                Ficha personagemPrincipal = new Ficha();
                personagemPrincipal.nomedojogador = "Kaue";
                personagemPrincipal.nomedopersonagem = "silva";
                personagemPrincipal.raca = "elfo";
                personagemPrincipal.classe = "guereiro ";
                personagemPrincipal.vida = 100;


                Console.WriteLine("===== AVENTURA COMEÇA =======");
                personagemPrincipal.ImprimirFicha();

                Console.WriteLine("Voce esta bebendo em uma taverna.");
                Console.WriteLine("Uma pessoa esbarra em voce. o que voce faz ?\n [ 1 ] se vira ? \n [ 2 ]  continua como se nada fosse");

                string decisao = Console.ReadLine();

                if (decisao == "1")
                {
                    Console.WriteLine("\n\n");
                    Console.WriteLine("agora começa!!!!");
                    Ficha inimigo = new Ficha();
                    inimigo.nomedojogador = "NPC";
                    inimigo.nomedopersonagem = "baltazar";
                    inimigo.raca = "ORC";
                    inimigo.classe = "ladrao";
                    inimigo.vida = 100;
                    inimigo.ImprimirFicha();


                    while (inimigo.vida > 0 && personagemPrincipal.vida > 0)

                    {
                        d6jogador = random.Next(1, 6);
                        d6inimigo = random.Next(1, 6);

                        if (d6jogador > d6inimigo)
                        {
                            inimigo.vida -= 10;
                            Console.WriteLine("Boa, consegui acertar");
                        }
                        else if (d6jogador < d6inimigo)
                        {
                            personagemPrincipal.vida -= 10;
                            Console.WriteLine("Eita, essa doeu!");
                        }
                        else
                        {
                            Console.WriteLine("nada acontece");
                        }

                        {
                          else
                        }
                        Console.WriteLine("Voce continua a beber");
                        {
                            
                        }
                        
                          
                        

                    }

                      




            }
        }
    }

