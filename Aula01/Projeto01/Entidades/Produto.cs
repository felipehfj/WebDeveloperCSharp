using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace -> local da classe dentro do projeto
namespace Projeto01.Entidades
{
    //public -> acesso total para a classe
    public class Produto 
    {
        //atributos (campos)
        //private -> permite acesso somente dentro
        //da propria classe (mais restritivo)
        private int codigo;
        private string nome;
        private decimal preco;
        private int quantidade;

        //métodos de encapsulamento
        public int Codigo
        {
            set { codigo = value; } //entrada
            get { return codigo; } //saida
        }

        public string Nome
        {
            set { nome = value; }
            get { return nome; }
        }

        public decimal Preco
        {
            set { preco = value; }
            get { return preco; }
        }

        public int Quantidade
        {
            set { quantidade = value; }
            get { return quantidade; }
        }        
    }
}
