using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto02.Entities;

namespace Projeto02.Contracts
{
    public interface IClienteControle
    {
        // Método abstrato
        void ExportarJson(Cliente cliente);

        // Método abstrato
        Cliente ImportarJson();        
    }
}
