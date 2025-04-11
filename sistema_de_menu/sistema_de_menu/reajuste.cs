using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_de_menu
{
    internal class reajuste
    {
        public static void reajuuste()
        {
            double valor, valorReajustado;

            Console.Write("Digite um valor: ");
            valor = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor normal: " + valor);
            valorReajustado = (valor * 0.05) + valor;

            Console.WriteLine("Valor reajustado: " + valorReajustado);
        }
    }
}

