﻿namespace Projeto01.Entidades
{
    public class Endereco
    {
        public int IdEndereco { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        public Cliente Cliente { get; set; }

        public Endereco()
        {
            //vazio
        }

        public Endereco(int idEndereco, string logradouro, string bairro, string cidade, string estado, string cep)
        {
            IdEndereco = idEndereco;
            Logradouro = logradouro;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Cep = cep;
        }        
    }
}
