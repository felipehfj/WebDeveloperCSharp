using System.Collections.Generic;

namespace Projeto01.Entities
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string Nome { get; set; }

        public List<Produto> Produtos { get; set; }

        public Categoria()
        {

        }

        public Categoria(int categoriaId, string nome)
        {
            CategoriaId = categoriaId;
            Nome = nome;
        }

        public Categoria(int categoriaId, string nome, List<Produto> produtos)
            : this(categoriaId, nome)
        {
            Produtos = produtos;
        }

        public override string ToString()
        {
            return $"CategoriaId: {CategoriaId}, Nome: {Nome}";
        }
    }
}
