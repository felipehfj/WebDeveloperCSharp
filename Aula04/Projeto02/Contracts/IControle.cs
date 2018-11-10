using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02.Contracts
{
    public interface IControle<T>
    {
        // Metodos abstratos

        void ImprimirDados(T objeto);
    }
}
