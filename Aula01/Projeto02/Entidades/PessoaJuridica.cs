using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02.Entidades
{
    public class PessoaJuridica : Pessoa
    {
        //propfull + 2xtab
        private string cnpj;

        public string Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }

    }
}
