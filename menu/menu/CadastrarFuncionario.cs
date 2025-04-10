using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu
{
    internal class CadastrarFuncionario
    {
       public static void Funcionario()
        {
            Console.WriteLine("\n Cadastro de Funcionarios");
            Console.WriteLine(" Digite o nome do Funcionario: ");
            string funcionario = Console.ReadLine();
            Console.WriteLine($" Funcionario {funcionario} cadastrado com sucesso");
        }

    }
}
