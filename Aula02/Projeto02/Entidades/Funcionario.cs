namespace Projeto02.Entidades
{
    public class Funcionario
    {
        public int IdFuncionario { get; set; }
        public string Nome { get; set; }
        public decimal Salario { get; set; }
        public Setor Setor { get; set; } // Associação (TER-1)

        // Construtor padrão
        public Funcionario()
        {
            //vazio
        }

        // Sobrecarga de construtor
        public Funcionario(int idFuncionario, string nome, decimal salario)
        {
            IdFuncionario = idFuncionario;
            Nome = nome;
            Salario = salario;
        }

        // Sobrecarga de construtor com 
        public Funcionario(int idFuncionario, string nome, decimal salario, Setor setor) 
            : this(idFuncionario, nome, salario) // this -> acesso a propriedades da própria classe
        {
            Setor = setor;
        }
    }
}
