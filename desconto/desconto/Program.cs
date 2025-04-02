using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desconto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double precoProduto, descontoPreco;

            Console.WriteLine("Digite o preço do produto: ");
            precoProduto = double.Parse(Console.ReadLine());

            if (precoProduto > 100)
            {
                descontoPreco = precoProduto * 0.10;

                Console.WriteLine(descontoPreco + " reais de desconto ");
            }
            else
            {
                descontoPreco = precoProduto * 0.05;

                Console.WriteLine(descontoPreco + " reais de desconto ");
            }



        }
    }
}

        
    

