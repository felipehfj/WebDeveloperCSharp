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
    public class ClienteControleLINQ : ClienteControleAbstract
    {
        public override List<Cliente> FiltrarPorEstadoCivil(EstadoCivil estadoCivil)
        {
            var query = from cliente in Clientes
                        where cliente.EstadoCivil == estadoCivil
                        select cliente;

            List<Cliente> retorno = query.ToList();

            return retorno;
        }

        public override List<Cliente> FiltrarPorNome(string nome)
        {
            var query = from cliente in Clientes
                        where cliente.Nome.Contains(nome)
                        orderby cliente.Nome ascending
                        select cliente;

            // Equals        -> exatamento igual
            // StartsWith    -> começando com 
            // EndsWith      -> terminando com
            // Contais       -> contendo            

            return query.ToList(); ;
        }

        public override List<Cliente> FiltrarPorSexo(Sexo sexo)
        {
            var query = from cliente in Clientes
                        where cliente.Sexo == sexo
                        select cliente;

            List<Cliente> retorno = query.ToList();

            return retorno;
        }

        public override Cliente ObterPorId(int idCliente)
        {
            var query = from cliente in Clientes
                        where cliente.IdCliente == idCliente
                        select cliente;

            Cliente retorno = query.SingleOrDefault();

            return retorno;
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
