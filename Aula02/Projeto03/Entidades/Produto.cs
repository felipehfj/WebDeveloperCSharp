namespace Projeto03.Entidades
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }

        public Produto()
        {

        }

        public Produto(int idProduto, string nome, decimal preco, int quantidade)
        {
            IdProduto = idProduto;
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        // Sobrescrita de método
        public override string ToString()
        {
            //retornando os dados como uma string
            return $"{{ \"Id\" : {IdProduto}, \"Nome\" : \"{Nome}\", \"Preço\" : {Preco}, \"Quantidade\" : {Quantidade} }}";
        }
    }
}
