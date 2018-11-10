using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entities;
using Projeto01.Inputs;
using Projeto01.Repositories;

namespace Projeto01
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();

            try
            {
                funcionario.FuncionarioId = FuncionarioInput.LerId();
                funcionario.Nome = FuncionarioInput.LerNome();
                funcionario.Salario = FuncionarioInput.LerSalario();
                funcionario.DataAdmissao = FuncionarioInput.LerDataAdmissao();

                FuncionarioRepository funcionarioRepository = new FuncionarioRepository();

                funcionarioRepository.Inserir(funcionario);

                Console.WriteLine(funcionario);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
