using System;
using Projeto03.Entidades;

namespace Projeto03
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto(1, "Notebook", 2000 , 2);

            Console.WriteLine("Dados do Produto");
            Console.WriteLine(produto);

            Console.ReadKey();
        }
    }
}
