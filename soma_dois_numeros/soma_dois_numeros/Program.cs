﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soma_dois_numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            nt valor1, valor2, soma;


            Console.WriteLine("digite um numero inteiro: ");
            valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o segundo numero inteiro: ");
            valor2 = int.Parse(Console.ReadLine());
            soma = valor1 + valor2;
            Console.WriteLine(soma);





        }
    }
}
        
    

