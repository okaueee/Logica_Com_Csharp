using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu
{
    internal class CadastrarPedido
    {
       public static void Pedido()
        {
            Console.WriteLine("\n Cadastro de Pedidos");
            Console.WriteLine(" Digite o codigo do Pedido: ");
            int pedido = int.Parse(Console.ReadLine());
            Console.WriteLine($" pedido{pedido} cadastrado com sucesso");
        }
    }
}
