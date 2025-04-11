using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_de_menu
{
    internal class atividade_vinho
    {
     public  static void vinho()
        {

            {
                int contador, quantidadeBranco = 0, quantidadeTinto = 0;
                char vinho;


                for (contador = 1; contador > 0; contador++)
                {
                    Console.WriteLine("Digite qual o tipo de vinho ou digite 'f' para finalizar o programa \n Digite ('t' para vinho tinto e 'b' para vinho branco): ");
                    vinho = char.Parse(Console.ReadLine());

                    if (vinho == 'b')
                    {
                        quantidadeBranco = quantidadeBranco + 1;
                    }
                    else if (vinho == 't')
                    {
                        quantidadeTinto = quantidadeTinto + 1;
                    }

                    else if (vinho == 'f')
                    {
                        Console.WriteLine("O total de vinhos brancos em estoque são: \", quantidadeBranco, \"\\ne o de vinhos tintos são: \", quantidadeTinto");
                    }





                }

            }
        }
    }
}
