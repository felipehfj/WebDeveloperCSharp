using Projeto02.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02
{
    class Program
    {
        static void Main(string[] args)
        {
            Endereco endereco = new Endereco(1,"Rua A", "Niterói", "Rio de Janeiro", "12345-678");

            Cliente cliente = new Cliente(1, "Félix", "felix@email.com", endereco);

            Console.WriteLine(cliente);

            Console.ReadKey();
        }
    }
}
