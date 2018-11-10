namespace Projeto01.Entidades
{
    public class Pessoa
    {
        public int IdPessoa { get; set; }
        public string Nome { get; set; }

        // Construtor padrão
        public Pessoa()
        {
            //vazio
        }

        // Construtor com parâmetros repassado para atributos da classe
        public Pessoa(int idPessoa, string nome)
        {
            IdPessoa = idPessoa;
            Nome = nome;
        }        
    }
}
