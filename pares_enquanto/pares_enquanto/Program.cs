using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pares_enquanto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contadorPares = 0;
            //enquanto = while

         while(contadorPares <= 100)
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
