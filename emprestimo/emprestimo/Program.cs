using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emprestimo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //A prefeitura de Contagem abriu uma linha de crédito para os funcionários estatutários. O valor máximo da prestação não poderá ultrapassar 30% do salário bruto. Fazer um algoritmo que permita entrar com o salário bruto e o valor da prestação, e informar se o empréstimo pode ou não ser concedido.




            int salario_bruto, valor_prestacao;

            Console.Write("Digite o valor do salário bruto: ");
            salario_bruto = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor da prestação: ");
                  valor_prestacao = int.Parse(Console.ReadLine());


      if(valor_prestacao <= (salario_bruto * 0.30))
            
                {
                    Console.WriteLine("Empréstimo pode ser concedido.");
                }
               
                    else{
                Console.Write("Empréstimo não pode ser concedido.");
    }
                }
            }

        }
    

