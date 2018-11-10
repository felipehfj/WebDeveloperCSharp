using System;
using Projeto02.Entidades;

namespace Projeto02.Impressao
{
    public class SetorImpressao
    {
        // Método para impressão dos dados de um setor
        public void Imprimir(Setor setor)
        {
            Console.WriteLine("\nDados do Setor:");
            Console.WriteLine("\tID.....:" + setor.idSetor);
            Console.WriteLine("\tNome...:" + setor.Nome);
        }
    }
}
