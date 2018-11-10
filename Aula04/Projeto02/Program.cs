using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto02.Controllers;
using Projeto02.Entities;

namespace Projeto02
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente(1,"Felipe Ferreira", "056.895.047-00");

            ClienteControle controle = new ClienteControle();

            controle.ImprimirDados(cliente);

            Console.ReadKey();
        }
    }
}
