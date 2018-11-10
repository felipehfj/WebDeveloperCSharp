using System.Collections.Generic;

namespace Projeto02.Entidades
{
    public class Setor
    {

        public int idSetor { get; set; }
        public string Nome { get; set; }
        public List<Funcionario> Funcionarios { get; set; } // Associação (TER-Muitos)

        public Setor()
        {

        }

        public Setor(int idSetor, string nome)
        {
            this.idSetor = idSetor;
            Nome = nome;
        }

        public Setor(int idSetor, string nome, List<Funcionario> funcionarios)
            :this(idSetor, nome)
        {
            Funcionarios = funcionarios;
        }
    }
}
