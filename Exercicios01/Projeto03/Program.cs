using Projeto03.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto03
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pessoaFisica = new PessoaFisica(1,"Felipe", "056.895.047-00");
            PessoaJuridica pessoaJuridica = new PessoaJuridica(1, "GestQual", "123.456.55/0001-82");

            Console.WriteLine("Pessoa Fisica");
            Console.WriteLine(pessoaFisica);

            Console.WriteLine("Pessoa Jurídica");
            Console.WriteLine(pessoaJuridica);

            Console.ReadKey();
        }
    }
}
