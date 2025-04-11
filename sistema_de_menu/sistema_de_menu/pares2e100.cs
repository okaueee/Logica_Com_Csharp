using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_de_menu
{
    internal class pares2e100
    {
      public  static void pares()
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
    
