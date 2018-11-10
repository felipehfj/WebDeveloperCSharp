using System;
using System.Collections.Generic;
using System.Linq;
using Projeto02.Entidades;
using Projeto02.Impressao;

namespace Projeto02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Objetos do tipo Funcionário
            Funcionario funcionario1 = new Funcionario(1, "Felipe", 3000);
            Funcionario funcionario2 = new Funcionario(2, "Henrique", 1000);
            Funcionario funcionario3 = new Funcionario(3, "Ferreira", 4000);
            Funcionario funcionario4 = new Funcionario(4, "Jesus", 5000);

            // Objetos do tipo Setor
            Setor setor = new Setor(1, "Desenvolvimento de Sistemas");
            setor.Funcionarios = new List<Funcionario>();
            setor.Funcionarios.Add(funcionario1);
            setor.Funcionarios.Add(funcionario2);
            setor.Funcionarios.Add(funcionario3);
            setor.Funcionarios.Add(funcionario4);

            SetorImpressao setorImpressao = new SetorImpressao();
            setorImpressao.Imprimir(setor);

            FuncionarioImpressao funcionarioImpressao = new FuncionarioImpressao();
            //foreach (Funcionario funcionario in setor.Funcionarios)
            //{
            //    funcionarioImpressao.Imprimir(funcionario);
            //}


            for (int i = 0; i < setor.Funcionarios.Count; i++)
            {
                Funcionario funcionario = setor.Funcionarios.ElementAt(i);
                funcionarioImpressao.Imprimir(funcionario);
            }
            Console.ReadKey();
        }
    }
}
