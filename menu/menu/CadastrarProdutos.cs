using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu
{
    internal class CadastrarProdutos
    {
        public static void Produtos()
        {
            Console.WriteLine("\n Cadastro de Produtos");
            Console.WriteLine(" Digite o codigo do Produto: ");
            int produto = int.Parse(Console.ReadLine());
            Console.WriteLine($" produto {produto} cadastrado com sucesso");
        }

    }
}
