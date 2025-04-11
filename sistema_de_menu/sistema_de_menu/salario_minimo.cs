using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_de_menu
{
    internal class salario_minimo
    {
      public static void salario()
        {
            double salarioMinimo = 1518, salarioUsuario, qtdSalarioMinimo;

            Console.Write("Digite o salario: ");
            salarioUsuario = double.Parse(Console.ReadLine());

            qtdSalarioMinimo = (int)(salarioUsuario / salarioMinimo);
            Console.WriteLine("Salario usuario: " + salarioUsuario + "\nSalario minimo " + salarioMinimo + "\nQuantidade de salario minimo: " + qtdSalarioMinimo);

        }
    }
}
    
    
