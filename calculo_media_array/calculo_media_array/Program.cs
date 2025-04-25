using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculo_media_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

                double[] notas = new double[30];
                double soma = 0;


                for (int i = 0; i < 30; i++)
                {
                    Console.WriteLine($"Digite a nota do aluno {i + 1}: ");
                    notas[i] = Convert.ToDouble(Console.ReadLine());
                    soma += notas[i];
                }


                double media = soma / 30;


                Console.WriteLine($"A média das notas dos 30 alunos é: {media:F2}");
            }
        }
    }


    

