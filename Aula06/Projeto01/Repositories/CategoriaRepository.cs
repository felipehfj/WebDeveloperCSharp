using Projeto01.Contracts;
using Projeto01.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Projeto01.Repositories
{
    public class CategoriaRepository : Conexao, IRepository<Categoria>
    {
        public void Atualizar(Categoria obj)
        {
            string query = "UPDATE Categoria SET Nome = @Nome "
                         + "WHERE CategoriaId = @CategoriaId";
            Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@Nome", obj.Nome);
            Command.Parameters.AddWithValue("@CategoriaId", obj.CategoriaId);
            Command.ExecuteNonQuery();
        }

        public List<Categoria> Consultar()
        {
            string query = "SELECT * FROM Categoria";
            Command = new SqlCommand(query, Connection);
            DataReader = Command.ExecuteReader();
            //declarar uma lista de Categoria
            List<Categoria> lista = new List<Categoria>();
            //varrer o DataReader..
            while (DataReader.Read()) //lendo cada registro contido no DataReader
            {
                Categoria categoria = new Categoria();
                categoria.CategoriaId = Convert.ToInt32(DataReader["CategoriaId"]);
                categoria.Nome = Convert.ToString(DataReader["Nome"]);
                lista.Add(categoria);
            }
            //retornando a lista..
            return lista;
        }

        public void Excluir(int id)
        {
            string query = "DELETE FROM Categoria WHERE CategoriaId = @CategoriaId";
            Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@CategoriaId", id);
            Command.ExecuteNonQuery();
        }

        public void Inserir(Categoria obj)
        {
            string query = "INSERT INTO Categoria(Nome) VALUES (@Nome)";
            Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@Nome", obj.Nome);
            Command.ExecuteNonQuery();
        }
    }
}
