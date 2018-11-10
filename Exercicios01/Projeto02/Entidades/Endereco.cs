using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02.Entidades
{
    public class Endereco
    {
        public int IdEndereco { get; set; }
        public string Logradouro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }

        public Endereco()
        {

        }

        public Endereco(int idEndereco, string logradouro, string cidade, string estado, string cep)
        {
            IdEndereco = idEndereco;
            Logradouro = logradouro;
            Cidade = cidade;
            Estado = estado;
            Cep = cep;
        }

        public override string ToString()
        {
            return $"ID: {IdEndereco}, Logradouro: {Logradouro}, Cidade: {Cidade}, Estado: {Estado}, Cep: {Cep}";
        }
    }
}
