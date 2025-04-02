using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numeros_pares_2_a_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador;

            for (contador = 2; contador <= 100; contador++)
            // for = para
            {

                if (contador % 2 == 0)
                {
                    Console.Write(contador + "\n");
                }

            }
        }
    }
}










