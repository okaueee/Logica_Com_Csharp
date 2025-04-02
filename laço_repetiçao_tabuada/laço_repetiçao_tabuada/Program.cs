using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laço_repetiçao_tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //crie um laço de repetição, que faça uma tabuada (para)

            { }
            int numero, resultado, contador;
                  Console.Write(" informe um numero para ver sua tabuada: ");
            numero = int.Parse(Console.ReadLine());

            Console.Clear();

            for (contador = 1; contador <= 10; contador++)
   { 

                resultado = numero * contador;
                Console.Write(numero + " X " + contador + "=" + resultado + "\n");
            }
        }
    }
}
            














