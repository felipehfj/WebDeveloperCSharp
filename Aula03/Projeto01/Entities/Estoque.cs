using System.Collections.Generic;

namespace Projeto01.Entities
{
    public class Estoque
    {
        public int IdEstoque { get; set; }
        public string Nome { get; set; }
        public List<Produto> Produtos { get; set; } //TER-Muitos

        public Estoque()
        {

        }

        public Estoque(int idEstoque, string nome)
        {
            IdEstoque = idEstoque;
            Nome = nome;
        }

        public Estoque(int idEstoque, string nome, List<Produto> produtos)
            : this(idEstoque, nome)
        {
            Produtos = produtos;
        }

        // Sobrescrita (override) do metodo ToString
        public override string ToString()
        {
            return $"ID: {IdEstoque}, Nome: {Nome}";
        }
    }
}
