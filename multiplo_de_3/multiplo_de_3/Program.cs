﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplo_de_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Digite seu numero: ");
            numero = int.Parse(Console.ReadLine());

            if (numero % 3 == 0)
            {
                Console.WriteLine("\nesse numero é multiplo de 3 ");
            }
            else
            {
                Console.WriteLine("\nesse numero não é multiplo de 3 ");
            }
            if (numero % 5 == 0)
            {
                Console.WriteLine("\nesse numero é multiplo de 5 ");
            }
            else
            {
                Console.WriteLine("\nesse numero não é multiplo de 5 ");
            }




        }
    }
}

        
    

