using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Entities
{
    public class Funcionario
    {
        public int FuncionarioId { get; set; }
        public string Nome { get; set; }
        public decimal Salario { get; set; }
        public DateTime DataAdmissao { get; set; }

        public Funcionario()
        {

        }

        public Funcionario(int funcionarioId, string nome, decimal salario, DateTime dataAdmissao)
        {
            FuncionarioId = funcionarioId;
            Nome = nome;
            Salario = salario;
            DataAdmissao = dataAdmissao;
        }

        public override string ToString()
        {           
            return String.Format("FuncionarioId: {0}, Nome: {1}, Salario: {2}, Data de Admissao: {3}",
                                    FuncionarioId, Nome, Salario, DataAdmissao);
        }
    }
}
