using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto03.Entidades
{
    public class PessoaFisica: Pessoa
    {
        public string Cpf { get; set; }

        public PessoaFisica()
        {

        }

        public PessoaFisica(int idPessoa, string nome, string cpf)
            :base(idPessoa, nome)
        {
            Cpf = cpf;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, CPF: {Cpf}";
        }
    }
}
