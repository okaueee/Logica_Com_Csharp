using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_de_menu
{
    internal class pares_enquanto
    {
      public  static void equanto_pares()
        {
            int contadorPares = 0;
            //enquanto = while

            while (contadorPares <= 100)
            {
                if (contadorPares % 2 == 0)
                {
                    Console.Write(contadorPares + "\n");
                }
                contadorPares++;
            }
        }
    }
}

