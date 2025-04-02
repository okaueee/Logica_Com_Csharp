using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_nota
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, numero3, numero4, media;


            Console.Write("Digite a nota primeira nota: ");
    numero1 = int.Parse(Console.ReadLine());


            Console.Write("Digite a nota segunda nota: ");
            numero2 = int.Parse(Console.ReadLine());

            Console.Write("Digite a nota terceira nota: ");
             numero3 = int.Parse(Console.ReadLine());

            Console.Write("Digite a nota quarta nota: ");
            numero4 = int.Parse(Console.ReadLine());

            media = (numero1 + numero2 + numero3 + numero4) / 4;


            Console.Write("Media: " + media);
  }
    }

}
    

