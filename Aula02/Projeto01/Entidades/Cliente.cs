namespace Projeto01.Entidades
{
    public class Cliente : Pessoa
    {
        public string Cpf { get; set; }
        public string Email { get; set; }
        public Endereco Endereco { get; set; }

        public Cliente()
        {

        }

        public Cliente(string cpf, string email)
        {
            Cpf = cpf;
            Email = email;
        }

        public Cliente(int idPessoa, string nome, string cpf, string email)
            : base(idPessoa, nome) // executando o construtor da superclasse
        {
            Cpf = cpf;
            Email = email;
        }
        
    }
}
