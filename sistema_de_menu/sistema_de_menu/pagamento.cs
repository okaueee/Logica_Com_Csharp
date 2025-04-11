using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_de_menu
{
    internal class pagamento
    {
      public  static void pagar()
        {
            double valorProduto, valorAserPago;
            string formaDePagamento;

            Console.Write("Digite o valor a ser pago: ");
            valorProduto = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a forma de pagamento \n 1-(a vista em Dinheiro) \n 2-(a vista no Pix) \n 3-(a vista no cartão de crédito)\n 4-(Parcelado no cartão em duas vezes)\n 5-(Parcelado no cartão em três vezes)");
            formaDePagamento = Console.ReadLine();

            if (formaDePagamento == "1" || formaDePagamento == "2")
            {
                valorAserPago = valorProduto - (valorProduto * 0.15);
                Console.WriteLine("Valor total com desconto: " + valorAserPago);
            }
            else if (formaDePagamento == "3")
            {
                valorAserPago = valorProduto - (valorProduto * 0.10);
                Console.WriteLine("Valor total com desconto: " + valorAserPago);
            }
            else if (formaDePagamento == "4")
            {
                valorAserPago = valorProduto;
                Console.WriteLine("Valor total: " + valorAserPago);
            }
            else if (formaDePagamento == "5")
            {
                valorAserPago = valorProduto + (valorProduto * 0.10);
                Console.WriteLine("Valor total: " + valorAserPago);
            }
            else
            {
                Console.WriteLine("Forma de pagamento inválida");
            }
        }
    }
}
    
