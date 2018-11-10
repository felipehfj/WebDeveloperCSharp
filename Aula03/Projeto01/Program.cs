using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entities;
using Projeto01.Controllers;

namespace Projeto01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando objetos

            Estoque estoque = new Estoque(1, "Informática");
            estoque.Produtos = new List<Produto>();

            Produto produto1 = new Produto(1, "Monitor", 400, 2, estoque);
            Produto produto2 = new Produto(2, "Teclado", 100, 4, estoque);

            // Adicionar os produtos na lista
            estoque.Produtos.Add(produto1);
            estoque.Produtos.Add(produto2);


            // Gerando arquivos
            EstoqueControle estoqueControle = new EstoqueControle();
            ProdutoControle produtoControle = new ProdutoControle();

            try // Tentantiva de execução de um comportamento potencialmente perigoso
            {
                estoqueControle.ExportarParaTxt(estoque);
                
                Console.WriteLine("Estoque gravado com sucesso!");
            }
            catch (Exception ex) // Captura do erros
            {
                Console.WriteLine($"[ERRO][Estoque] {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss:ff")}: { ex.Message }" );
            }

            try
            {
                produtoControle.ExportarParaXml(produto1);

                Console.WriteLine("Produto gravado com sucesso!");
            }            
            catch (Exception ex)
            {

                Console.WriteLine($"[ERRO][Produto] {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss:ff")}: { ex.Message }");
            }

            // Pausar
            Console.ReadKey();
        }
    }
}
