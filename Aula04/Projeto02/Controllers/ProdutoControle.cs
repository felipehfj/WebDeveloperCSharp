using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto02.Contracts;
using Projeto02.Entities;

namespace Projeto02.Controllers
{
    class ProdutoControle : IControle<Produto>
    {
        public void ImprimirDados(Produto produto)
        {
            Console.WriteLine(produto);
        }
    }
}
