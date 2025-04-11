using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_de_menu
{
    internal class leia_dois_valores
    {
      public  static void dois_valores()
        {
            int a, b, c;

            Console.Write("Digite o primeiro numero: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo numero: ");
            b = int.Parse(Console.ReadLine());

            if (a == b)
            {
                c = a + b;
                Console.WriteLine("Resultado: " + c);
            }
            else
            {
                c = a * b;
                Console.WriteLine("Resultado: " + c);
            }
        }
    }
}
    

