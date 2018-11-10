using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entidades; //importando..
using System.IO; //input, output

namespace Projeto01.Controles
{
    //public -> define acesso total..
    public class ProdutoControle
    {
        //método para exportar os dados do produto
        //para um arquivo de extensão TXT
        public void ExportarDados(Produto produto)
        {
            //abrindo um arquivo em modo de escrita..
            //true -> valor booleano que faz com que o StreamWriter trabalhe em modo Append
            //ou seja, adicione conteudo ao final do arquivo sem sobrescreve-lo.
            StreamWriter streamWriter = new StreamWriter("c:\\temp\\produtos.txt", true);

            streamWriter.WriteLine("Código......: " + produto.Codigo);
            streamWriter.WriteLine("Nome........: " + produto.Nome);
            streamWriter.WriteLine("Preço.......: " + produto.Preco);
            streamWriter.WriteLine("Quantidade..: " + produto.Quantidade);
            streamWriter.WriteLine("...");

            streamWriter.Close(); //fechar o arquivo..
        }

    }
}
