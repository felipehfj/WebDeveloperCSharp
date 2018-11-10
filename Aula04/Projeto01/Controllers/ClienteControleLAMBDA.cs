using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entities;
using Projeto01.Abstracts;
using Projeto01.Entities.Types;

namespace Projeto01.Controllers
{
    public class ClienteControleLAMBDA : ClienteControleAbstract
    {
        public override List<Cliente> FiltrarPorEstadoCivil(EstadoCivil estadoCivil)
        {
            return Clientes
                    .Where(c => c.EstadoCivil == estadoCivil)
                    .ToList();
        }

        public override List<Cliente> FiltrarPorNome(string nome)
        {
            return Clientes
                    .Where(c => c.Nome.Contains(nome))
                    .OrderBy(c => c.Nome)
                    .ToList();
        }

        public override List<Cliente> FiltrarPorSexo(Sexo sexo)
        {
            return Clientes
                    .Where(c => c.Sexo.Equals(sexo))
                    .ToList();
        }

        public override Cliente ObterPorId(int idCliente)
        {
            return Clientes
                    .Where(c => c.IdCliente == idCliente)
                    .SingleOrDefault();
        }

        public void Imprimir(List<Cliente> clientes)
        {            
            foreach (var cliente in clientes)
            {
                Console.WriteLine("************* Dados do Cliente ***********");
                Console.WriteLine($"\tIdCliente: {cliente.IdCliente}");
                Console.WriteLine($"\tNome: {cliente.Nome}");
                Console.WriteLine($"\tE-mail: {cliente.Email}");
                Console.WriteLine($"\tSexo: {cliente.Sexo}");
                Console.WriteLine($"\tEstado Civil: {cliente.EstadoCivil}");
                Console.WriteLine("==========================================");
            }
        }

        public void Imprimir(Cliente cliente)
        {
            Console.WriteLine("************* Dados do Cliente ***********");
            Console.WriteLine($"\tIdCliente: {cliente.IdCliente}");
            Console.WriteLine($"\tNome: {cliente.Nome}");
            Console.WriteLine($"\tE-mail: {cliente.Email}");
            Console.WriteLine($"\tSexo: {cliente.Sexo}");
            Console.WriteLine($"\tEstado Civil: {cliente.EstadoCivil}");
            Console.WriteLine("==========================================");
        }
    }
}
