using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto03.Entidades
{
    public class PessoaJuridica : Pessoa
    {
        public string Cnpj { get; set; }

        public PessoaJuridica()
        {

        }

        public PessoaJuridica(int idPessoa, string nome, string cnpj)
            :base(idPessoa, nome)
        {
            Cnpj = cnpj;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, CNPJ: {Cnpj}";
        }
    }
}
