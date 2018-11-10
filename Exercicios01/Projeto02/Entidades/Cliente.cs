using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02.Entidades
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public Endereco Endereco { get; set; }


        public Cliente()
        {

        }

        public Cliente(int idCliente, string nome, string email)
        {
            IdCliente = idCliente;
            Nome = nome;
            Email = email;
        }

        public Cliente(int idCliente, string nome, string email, Endereco endereco)
            : this(idCliente, nome, email)
        {
            Endereco = endereco;
        }

        public override string ToString()
        {
            return $"ID: {IdCliente}, Nome: {Nome}, E-mail: {Email}, Endereço: {Endereco}";
        }
    }
}
