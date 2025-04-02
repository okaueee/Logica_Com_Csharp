using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace falso_verdadeiro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool valor1, valor2;

            Console.WriteLine("Digite true para (Verdadeiro) ou false para (Falso): ");
            valor1 = bool.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro true para (Verdadeiro) ou false para (Falso): ");
            valor2 = bool.Parse(Console.ReadLine());

            if (valor1 == true && valor2 == true)
            {
                Console.WriteLine("Verdadeiro");
            }
            else
            {
                Console.WriteLine("Falso");
            }
        }
    }
}
