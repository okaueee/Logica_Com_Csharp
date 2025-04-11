using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_de_menu
{
    internal class some_dois_numeros
    {
        
        public static void dois_numeros() 
        {
            int valor1, valor2, soma;


            Console.WriteLine("digite um numero inteiro: ");
            valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o segundo numero inteiro: ");
            valor2 = int.Parse(Console.ReadLine());
            soma = valor1 + valor2;
            Console.WriteLine(soma);





        }
    }
}
        
    
    
