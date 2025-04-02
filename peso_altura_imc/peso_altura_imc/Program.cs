﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peso_altura_imc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double peso, altura, imc;

            Console.WriteLine("Calculo de IMC ");

            Console.WriteLine("Digite o seu peso: ");
            peso = double.Parse(Console.ReadLine());

            Console.Write("Digite a sua altura: ");
            altura = double.Parse(Console.ReadLine());

            imc = peso / (altura * altura);

            Console.Write("O seu IMC é: " + imc);

            if (imc <= 18.5)
            {
                Console.WriteLine("Abaixo do peso, O seu IMC é: " + imc);
            }
            else if (imc >= 18.6 && imc <= 24.9)
            {
                Console.WriteLine("Peso ideal(parabéns), O seu IMC é: " + imc);
            }
            else if (imc >= 25 && imc <= 29.9)
            {
                Console.WriteLine("Levemente acima do peso, O seu IMC é: " + imc);
            }
            else if (imc > 30 && imc < 34.9)
            {
                Console.WriteLine("Obesidade grau I, O seu IMC é: " + imc);
            }
            else if (imc >= 35 && imc <= 39.9)
            {
                Console.WriteLine("Obesidade grau II(severa), O seu IMC é: " + imc);
            }
            else
            {
                Console.WriteLine("Obesidade grau III(mórbida), O seu IMC é: " + imc);
            }
        }
    }
}
