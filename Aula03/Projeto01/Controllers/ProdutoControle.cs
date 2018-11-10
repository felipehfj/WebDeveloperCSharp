using System;
using System.Xml;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Contracts;
using Projeto01.Entities;

namespace Projeto01.Controllers
{
    public class ProdutoControle : IProdutoControle
    {
        public void ExportarParaXml(Produto produto)
        {
            // Criar um arquivo xml

            string path = System.IO.Directory.GetCurrentDirectory() + "Produto.xml";
            XmlWriter xmlWriter = XmlWriter.Create(path);

            #region XML
            // Escrevendo o cabeçalho do XML
            xmlWriter.WriteStartDocument();

            #region Produto
            // Abrindo a TAG <produto>
            xmlWriter.WriteStartElement("produto");

            // Escrevendo os dados do produto
            xmlWriter.WriteElementString("idProduto", produto.IdProduto.ToString());
            xmlWriter.WriteElementString("nome", produto.Nome);
            xmlWriter.WriteElementString("preco", produto.Preco.ToString());
            xmlWriter.WriteElementString("quantidade", produto.Quantidade.ToString());

            #region Estoque
            // Abrindo a TAG <estoque>
            xmlWriter.WriteStartElement("estoque");

            // Escrevendo os dados do estoque
            xmlWriter.WriteElementString("idEstoque", produto.Estoque.IdEstoque.ToString());
            xmlWriter.WriteElementString("nome", produto.Estoque.Nome);
            // Fechando a TAG <estoque>
            xmlWriter.WriteEndElement();
            #endregion

            // Fechar a TAG <produto>
            xmlWriter.WriteEndElement();
            #endregion

            // Fechando o arquivo
            xmlWriter.Close();
            #endregion

        }
    }
}
