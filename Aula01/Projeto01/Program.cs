using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entidades; //importando
using Projeto01.Controles; //importando

namespace Projeto01
{
    class Program
    {
        //método utilizado para executar
        //o projeto Console Application
        static void Main(string[] args)
        {
            //imprimir mensagem no prompt
            Console.WriteLine("Seja bem vindo ao .NET");

            /*
            //cw + 2xtab
            Console.Write("Informe seu nome: ");
            string nome = Console.ReadLine();

            //imprimindo
            Console.WriteLine("Seja bem vindo: " + nome);
            */

            Produto produto = new Produto();

            Console.Write("Informe o codigo do produto..: ");
            produto.Codigo = int.Parse(Console.ReadLine());

            Console.Write("Informe o nome do produto....: ");
            produto.Nome = Console.ReadLine();

            Console.Write("Informe o preço do produto...: ");
            produto.Preco = decimal.Parse(Console.ReadLine());

            Console.Write("Informe a quantidade.........: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

            //imprimir os dados do produto..
            Console.WriteLine("\nDados do Produto:");
            Console.WriteLine("\tCodigo.....: " + produto.Codigo);
            Console.WriteLine("\tNome.......: " + produto.Nome);
            Console.WriteLine("\tPreço......: " + produto.Preco);
            Console.WriteLine("\tQuantidade.: " + produto.Quantidade);

            //gravar em arquivo..
            ProdutoControle produtoControle = new ProdutoControle();
            produtoControle.ExportarDados(produto);

            Console.WriteLine("\nDados exportados com sucesso.");

            //pausar
            Console.ReadKey();
        }
    }
}
