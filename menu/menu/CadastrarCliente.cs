﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu
{
    internal class CadastrarCliente
    {
       public static void Cliente()
        {
            Console.WriteLine("\n Cadastro de Clientes");
            Console.WriteLine(" Digite o nome do cliente: ");
            string nome = Console.ReadLine();
            Console.WriteLine($" Cliente {nome} cadastrado com sucesso");
        }
    }
}
