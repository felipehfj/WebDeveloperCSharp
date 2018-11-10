using Projeto01.Contracts;
using Projeto01.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Projeto01.Repositories
{
    public class ProdutoRepository : Conexao, IRepository<Produto>
    {
        public void Atualizar(Produto obj)
        {
            string query = "UPDATE Produto SET Nome = @Nome, Preco = @Preco, "
                         + "Quantidade = @Quantidade, CategoriaId = @CategoriaId "
                         + "WHERE ProdutoId = @ProdutoId";
            Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@Nome", obj.Nome);
            Command.Parameters.AddWithValue("@Preco", obj.Preco);
            Command.Parameters.AddWithValue("@Quantidade", obj.Quantidade);
            Command.Parameters.AddWithValue("@CategoriaId", obj.Categoria.CategoriaId);
            Command.Parameters.AddWithValue("@ProdutoId", obj.ProdutoId);
            Command.ExecuteNonQuery();
        }

        public List<Produto> Consultar()
        {
            string query = "SELECT p.IdProduto, p.Nome, p.Quantidade, p.Preco, "
                         + "c.CategoriaId, c.Nome as NomeCategoria "
                         + "FROM Produto p INNER JOIN Categoria c "
                         + "on p.CategoriaId = c.CategoriaId";

            Command = new SqlCommand(query, Connection);
            DataReader = Command.ExecuteReader();
            List<Produto> lista = new List<Produto>();
            while (DataReader.Read())
            {
                Produto produto = new Produto();
                produto.Categoria = new Categoria();
                produto.ProdutoId = Convert.ToInt32(DataReader["ProdutoId"]);
                produto.Nome = Convert.ToString(DataReader["Nome"]);
                produto.Preco = Convert.ToDecimal(DataReader["Preco"]);
                produto.Quantidade = Convert.ToInt32(DataReader["Quantidade"]);
                produto.Categoria.CategoriaId = Convert.ToInt32
                (DataReader["CategoriaId"]);
                produto.Categoria.Nome = Convert.ToString
                (DataReader["NomeCategoria"]);
                lista.Add(produto);
            }
            return lista;
        }

        public void Excluir(int id)
        {
            string query = "DELETE FROM Produto WHERE ProdutoId = @ProdutoId";
            Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@ProdutoId", id);
            Command.ExecuteNonQuery();
        }

        public void Inserir(Produto obj)
        {
            string query = "INSERT INTO Produto(Nome, Preco, Quantidade, CategoriaId) "
                         + "VALUES (@Nome, @Preco, @Quantidade, @CategoriaId)";
            Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@Nome", obj.Nome);
            Command.Parameters.AddWithValue("@Preco", obj.Preco);
            Command.Parameters.AddWithValue("@Quantidade", obj.Quantidade);
            Command.Parameters.AddWithValue("@CategoriaId", obj.Categoria.CategoriaId);
            Command.ExecuteNonQuery();
        }
    }
}
