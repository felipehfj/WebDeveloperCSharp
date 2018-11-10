using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02.Entidades
{
    //PessoaFisica É-UMA Pessoa
    public class PessoaFisica : Pessoa
    {
        //propfull + 2xtab
        private string cpf;

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }        
    }    
    
}
