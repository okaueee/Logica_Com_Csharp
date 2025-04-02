using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eleitor_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um algoritmo em PORTUGOL que leia a idade de uma pessoa e informe a sua classe eleitoral:
            // - - - não eleitor (abaixo de 16 anos); 
            //eleitor obrigatório (entre a faixa de 18 e menor de 65 anos); 
            //eleitor facultativo (de 16 até 18 anos e maior de 65 anos, inclusive).


            int idade;

            Console.Write("Digite sua idade: ");

            idade = int.Parse(Console.ReadLine());

            if (idade < 16)
            {

                Console.Write("Não eleitor");

            }


            else if (idade >= 18 && idade < 65)
            {

                Console.Write("Eleitor obrigatorio");

            }

            else
            {

                Console.Write("Eleitor facultativo");

            }
        }
    }
}