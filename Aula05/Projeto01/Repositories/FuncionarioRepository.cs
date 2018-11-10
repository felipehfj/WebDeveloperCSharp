using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Projeto01.Entities;

namespace Projeto01.Repositories
{
    public class FuncionarioRepository : Conexao
    {
        /// <summary>
        /// Gravar objeto no banco
        /// </summary>
        /// <param name="funcionario"></param>
        public void Inserir(Funcionario funcionario)
        {
            AbrirConexao();

            // Query SQL
            string query = "INSERT INTO Funcionario(FuncionarioId, Nome, Salario, DataAdmissao) "
                         + "VALUES (@FuncionarioId, @Nome, @Salario, @DataAdmissao)";
            
            Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("@FuncionarioId", funcionario.FuncionarioId);
            Command.Parameters.AddWithValue("@Nome", funcionario.Nome);
            Command.Parameters.AddWithValue("@Salario", funcionario.Salario);
            Command.Parameters.AddWithValue("@DataAdmissao", funcionario.DataAdmissao);
            Command.ExecuteNonQuery();

            FecharConexao();

        }

        public Funcionario Obter(int id)
        {
            AbrirConexao();
            string query = "SELECT * FROM Funcionario WHERE FuncionarioId = @FuncionarioId";

            Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("@FuncionarioId", id);

            DataReader = Command.ExecuteReader();

            foreach (var item in collection)
            {

            }
            Funcionario funcionario = new Funcionario(DataReader.Read)


            FecharConexao();
        }
    }
}
