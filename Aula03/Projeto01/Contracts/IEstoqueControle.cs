using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entities;

namespace Projeto01.Contracts
{
    public interface IEstoqueControle
    {
        // Método abstrato
        void ExportarParaTxt(Estoque estoque);
    }
}
