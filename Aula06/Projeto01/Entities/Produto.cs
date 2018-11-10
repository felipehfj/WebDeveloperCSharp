namespace Projeto01.Entities
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }

        public Categoria Categoria { get; set; }

        public Produto()
        {

        }

        public Produto(int produtoId, string nome, decimal preco, int quantidade)
        {
            ProdutoId = produtoId;
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto(int produtoId, string nome, decimal preco, int quantidade, Categoria categoria)
            : this(produtoId, nome, preco, quantidade)
        {
            Categoria = categoria;
        }

        public override string ToString()
        {
            return $"Id: {ProdutoId}, Nome: {Nome}, Preço: { Preco}, Quantidade: { Quantidade}";
}
    }
}
