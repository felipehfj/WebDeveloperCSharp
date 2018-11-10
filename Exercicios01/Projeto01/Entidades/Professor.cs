using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Entidades
{
    public class Professor
    {
        public int IdProfessor { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public Professor()
        {

        }

        public Professor(int idProfessor, string nome, string sobrenome)
        {
            IdProfessor = idProfessor;
            Nome = nome;
            Sobrenome = sobrenome;
        }

        public override string ToString()
        {
            return $"Id: {IdProfessor}, Nome: {Nome}, Sobrenome: {Sobrenome}";
        }
    }
}
