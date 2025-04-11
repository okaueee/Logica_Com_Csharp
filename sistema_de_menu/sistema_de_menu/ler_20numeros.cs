using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_de_menu
{
    internal class ler_20numeros
    {
       public static void ler_20numeros()
        {
            int num, contador, numMaior;


            numMaior = -1;
            contador = 1;

            while (contador <= 20)
            {
                Console.WriteLine("Digite um numero: ");
                num = int.Parse(Console.ReadLine());
                contador++;

                if (num > numMaior)
                {
                    numMaior = num;
                }
                {

                    Console.WriteLine("O numero Maior é : " + numMaior);
                }

            }

        }
    }
}
    

