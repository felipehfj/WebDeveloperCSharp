using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Contracts;
using Projeto01.Entities;

namespace Projeto01.Controllers
{
    // Implementando a interface
    public class EstoqueControle : IEstoqueControle
    {
        // Implementando o método abstrado contido na interface
        public void ExportarParaTxt(Estoque estoque)
        {
            string path = System.IO.Directory.GetCurrentDirectory() + "Estoque.txt";
            StreamWriter streamWriter = new StreamWriter(path, true);

            streamWriter.WriteLine("=========== Estoque ===========");
            streamWriter.WriteLine("Id.....:" + estoque.IdEstoque);
            streamWriter.WriteLine("Nome...:" + estoque.Nome);

            #region Produtos
            // Verifica se o objeto estoque tem produtos
            if(estoque.Produtos.Count > 0)
            {
                // Varrer lista de produtos
                foreach (Produto produto in estoque.Produtos)
                {
                    streamWriter.WriteLine("\tId...........:" + produto.IdProduto);
                    streamWriter.WriteLine("\tNome.........:" + produto.Nome);
                    streamWriter.WriteLine("\tPreço........:" + produto.Preco);
                    streamWriter.WriteLine("\tQuantidade...:" + produto.Quantidade);
                }
            }
            #endregion

            streamWriter.WriteLine("============================================");

            // Fechando o stream
            streamWriter.Close();
        }
    }
}
