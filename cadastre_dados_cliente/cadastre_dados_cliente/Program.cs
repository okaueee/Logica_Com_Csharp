using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastre_dados_cliente
{
    internal class Program
    {
        //Crie um sistema de cadastro para um skate parque, que possui duas pistas distintas, 
        // pista adulta para maiores de 18 anos, e pista infantil para menos de 18 anos e que é obrigatório o uso de equipamento de segurança.
        static void Main(string[] args)
        {
            int  dezoito_anos;
            string nome;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("escreva seu nome :");
            Console.ResetColor();
            nome = Console.ReadLine();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("escreva sua idade:");                                                         
            Console.ForegroundColor= ConsoleColor.Red;
            Console.ResetColor();
            dezoito_anos = int.Parse(Console.ReadLine());
            Console.ResetColor();
            if (dezoito_anos >= 18)
            {
                
                Console.WriteLine(" voce não pode usar pista infantil, procure e reserve a de adulto!");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("===================================================================");
            }
            else 
             { 
            
                Console.WriteLine("voce pode usar pista infantil,usando os equipamentos de proteção!!");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("===================================================================");

            }
               
                
            }
        }
        
    }

