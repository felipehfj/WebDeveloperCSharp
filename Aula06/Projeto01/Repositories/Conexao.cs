using System.Configuration;
using System.Data.SqlClient;

namespace Projeto01.Repositories
{
    public class Conexao
    {
        public SqlConnection Connection { get; set; }
        public SqlCommand Command { get; set; }
        public SqlDataReader DataReader { get; set; }
        public SqlTransaction Transaction { get; set; }

        public void AbrirConexao()
        {
            Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Aula06"].ConnectionString);
            Connection.Open();
        }

        public void FecharConexao()
        {
            Connection.Close();
        }

    }
}
