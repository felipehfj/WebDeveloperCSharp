using System;
using Projeto01.Entidades;

namespace Projeto01
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Cliente cliente = new Cliente(1, "Felipe Ferreira", "056.895.047.00","felipehfj@gmail.com");
            cliente.Endereco = new Endereco(1, "Rua E","Mombaça", "Saquarema", "RJ", "28990-051");

            Console.WriteLine("Dados do Cliente:");
            Console.WriteLine("\tID..........:\t" + cliente.IdPessoa);
            Console.WriteLine("\tNome........:\t" + cliente.Nome);
            Console.WriteLine("\tCPF.........:\t" + cliente.Cpf);
            Console.WriteLine("\tE-mail......:\t" + cliente.Email);
            Console.WriteLine("\tLogradouro..:\t" + cliente.Endereco.Logradouro);
            Console.WriteLine("\tBairro......:\t" + cliente.Endereco.Bairro);
            Console.WriteLine("\tCidade......:\t" + cliente.Endereco.Cidade);
            Console.WriteLine("\tEstado......:\t" + cliente.Endereco.Estado);
            Console.WriteLine("\tCEP.........:\t" + cliente.Endereco.Cep);

            Console.ReadKey();           
        }
    }
}
