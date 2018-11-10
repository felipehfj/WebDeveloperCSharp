using System;
using Projeto02.Entidades;

namespace Projeto02.Impressao
{
    public class FuncionarioImpressao
    {
        // Método para impressão dos dados de um funcionário
        public void Imprimir(Funcionario funcionario)
        {
            Console.WriteLine("\nDados do Funcionário:");
            Console.WriteLine("\tID........:" + funcionario.IdFuncionario);
            Console.WriteLine("\tNome......:" + funcionario.Nome);
            Console.WriteLine("\tSalario...:" + funcionario.Salario);
        }
    }
}
