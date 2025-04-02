using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numero_entre_20_e_90
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Digite um numero entre 20 e 90: ");
                  numero= int.Parse(Console.ReadLine());

            //if =   SE
            // && = e
            if(numero > 20 && numero < 90)
            {
            Console.Write("este numero esta dentro do compreendido de 20 e 90 ");
            }
            else{
                // else = senão
        
            Console.Write("O numero ", numero, "\nnão esta dentro do compreendido de 20 e 90");
    }



                
            
















        }
    }
}
