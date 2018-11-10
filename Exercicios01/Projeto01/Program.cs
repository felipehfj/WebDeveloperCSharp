using Projeto01.Controles;
using Projeto01.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01
{
    class Program
    {
        static void Main(string[] args)
        {
            Professor professor = new Professor();

            Console.WriteLine("Entre com os dados do Professor:");
            Console.Write("ID: ");
            professor.IdProfessor = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            professor.Nome = Console.ReadLine();
            Console.Write("Sobrenome: ");
            professor.Sobrenome = Console.ReadLine();


            Console.WriteLine("\nDados do Professor: ");
            Console.WriteLine(professor);

            Console.Write("\nSalvando dados em arquivo...");
            ProfessorControle professorControle = new ProfessorControle();
            professorControle.SalvarEmArquivo(professor);
            Console.WriteLine("ok!");


            Console.ReadKey();
        }
    }
}
