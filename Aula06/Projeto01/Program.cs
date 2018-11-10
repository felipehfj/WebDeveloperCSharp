using Projeto01.Entities;
using Projeto01.Repositories;
using System;

namespace Projeto01
{
    class Program
    {
        static void Main(string[] args)
        {
            CategoriaRepository categoriaRepository = new CategoriaRepository();
            try
            {
                Console.WriteLine("\nCADASTRO DE CATEGORIA\n");
                Categoria categoria = new Categoria();
                Console.Write("Informe o nome da Categoria....: ");
                categoria.Nome = Console.ReadLine();
                categoriaRepository.AbrirConexao();
                categoriaRepository.Inserir(categoria);
                Console.WriteLine("\nCategoria cadastrado com sucesso.");

                //exibindo a consulta..
                Console.WriteLine("\n\tCONSULTA DE CATEGORIAS");
                foreach (Categoria registro in categoriaRepository.Consultar())
                {
                    Console.WriteLine("\n\tCategoria ->" + registro.ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\nOcorreu um erro: " + e.Message);
            }

            finally
            {
                categoriaRepository.FecharConexao();
            }
            Console.ReadKey();
        }
    }
}
