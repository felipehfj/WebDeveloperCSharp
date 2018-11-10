namespace Projeto01.Entities
{
    /// <summary>
    /// Entidade Cliente
    /// </summary>
    public class Cliente
    {
        #region Atributos (Encapsulamento reduzido)
        /// <summary>
        /// Método de encapsulamento reduzido para o atributo idCliente
        /// </summary>
        public int IdCliente { get; set; }

        /// <summary>
        /// Método de encapsulamento reduzido para o atributo nome
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Método de encapsulamento reduzido para o atributo sobrnome
        /// </summary>
        public string Sobrenome { get; set; }

        /// <summary>
        /// Método de encapsulamento reduzido para o atributo cpf
        /// </summary>
        public string Cpf { get; set; }

        /// <summary>
        /// Método de encapsulamento reduzido para o atributo email
        /// </summary>
        public string Email { get; set; }
        #endregion

        #region Construtores
        /// <summary>
        /// Instancia um objeto Cliente vazio
        /// </summary>
        public Cliente()
        {

        }

        /// <summary>
        /// Instancia um objeto Cliente com passagem completa de parâmetros
        /// </summary>
        /// <param name="idCliente"></param>
        /// <param name="nome"></param>
        /// <param name="sobrenome"></param>
        /// <param name="cpf"></param>
        /// <param name="email"></param>
        public Cliente(int idCliente, string nome, string sobrenome, string cpf, string email)
        {
            IdCliente = idCliente;
            Nome = nome;
            Sobrenome = sobrenome;
            Cpf = cpf;
            Email = email;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Objeto Cliente para String
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Id: {IdCliente}, Nome: {Nome}, Sobrenome: {Sobrenome}, Cpf: {Cpf}, Email: {Email}";
        }
        #endregion
    }
}
