using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto02.Contracts;

namespace Projeto02.Entities
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }

        public Cliente()
        {

        }

        public Cliente(int idCliente, string nome, string cpf)
        {
            IdCliente = idCliente;
            Nome = nome;
            Cpf = cpf;
        }

        public override string ToString()
        {
            return $"IdCliente: {IdCliente}, Nome: {Nome}, Cpf: {Cpf}";
        }
    }
}
