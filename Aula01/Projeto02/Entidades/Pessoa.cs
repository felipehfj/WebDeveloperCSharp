using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02.Entidades
{
    public class Pessoa
    {
        #region Atributos da Classe

        private int idPessoa;
        private string nome;

        #endregion

        #region Métodos da Classe

        public int IdPessoa
        {
            set { idPessoa = value; }
            get { return idPessoa; }
        }

        public string Nome
        {
            set { nome = value; }
            get { return nome; }
        }

        #endregion
    }
}
