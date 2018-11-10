using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto02.Entidades; //importando..

namespace Projeto02
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pessoaFisica = new PessoaFisica();
            pessoaFisica.IdPessoa = 1;
            pessoaFisica.Nome = "Sergio Mendes";
            pessoaFisica.Cpf = "123.456.789-00";

            PessoaJuridica pessoaJuridica = new PessoaJuridica();
            pessoaJuridica.IdPessoa = 2;
            pessoaJuridica.Nome = "COTI Informática";
            pessoaJuridica.Cnpj = "1234.56789-00";

            Console.WriteLine("Pessoa Fisica...: " + pessoaFisica.Nome);
            Console.WriteLine("CPF.............: " + pessoaFisica.Cpf);

            Console.WriteLine("Pessoa Juridica.: " + pessoaJuridica.Nome);
            Console.WriteLine("CNPJ............: " + pessoaJuridica.Cnpj);

            Console.ReadKey();
        }
    }
}
