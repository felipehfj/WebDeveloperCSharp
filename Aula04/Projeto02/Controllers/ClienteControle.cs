using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto02.Contracts;
using Projeto02.Entities;

namespace Projeto02.Controllers
{
    class ClienteControle : IControle<Cliente>
    {
        public void ImprimirDados(Cliente cliente)
        {
            Console.WriteLine(cliente);
        }
    }
}
