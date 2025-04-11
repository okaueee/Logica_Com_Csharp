using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_de_menu
{
    internal class positivo_negativo
    {
      public  static void positivo()
        {
            // numero positivo, negativo ou zero


            {

                int numero;


                Console.Write("Digite um numero: ");
                numero = int.Parse(Console.ReadLine());
                if (numero > 01)
                {

                    Console.Write("O " + numero + " é um numero positivo");

                }

                else if (numero < 0)
                {

                    Console.Write("O " + numero + " é um numero negativo");

                }

                else
                {

                    Console.Write("O numero precisa ser diferente de 0 ");

                }

            }

        }
    }
}
