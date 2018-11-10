using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Controllers;
using Projeto01.Entities;
using Projeto01.Entities.Types;

namespace Projeto01
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente(1,"Felipe", "felipehfj@gmail.com", Sexo.Masculino, EstadoCivil.Solteiro);
            Cliente c2 = new Cliente(2, "Luiz", "luiz@gmail.com", Sexo.Masculino, EstadoCivil.Solteiro);
            Cliente c3 = new Cliente(3, "Conceição", "conceicao@gmail.com", Sexo.Feminino, EstadoCivil.Casado);
            Cliente c4 = new Cliente(4, "Ana Paula", "anapaula@gmail.com", Sexo.Feminino, EstadoCivil.Casado);
            Cliente c5 = new Cliente(5, "Ana Maria", "anamaria@gmail.com", Sexo.Feminino, EstadoCivil.Solteiro);

            ClienteControleLINQ controle = new ClienteControleLINQ();
            controle.Clientes = new List<Cliente>();
            controle.Clientes.Add(c1);
            controle.Clientes.Add(c2);
            controle.Clientes.Add(c3);
            controle.Clientes.Add(c4);
            controle.Clientes.Add(c5);

            Console.WriteLine("\nFILTRO DE CLIENTES POR NOME\n");
            Console.Write("Informe um nome: ");
            string nome = Console.ReadLine();

            var resultado = controle.FiltrarPorNome(nome);

            if(resultado.Count > 0)
            {
                controle.Imprimir(resultado);
            }
            else
            {
                Console.WriteLine("Nenhum Cliente foi encontrado");
            }

            //#region Meu código
            //Console.WriteLine("LINQ");
            //ClienteControleLINQ clienteControleLINQ = new ClienteControleLINQ();
            //clienteControleLINQ.Clientes = new List<Cliente>();
            //clienteControleLINQ.Clientes.Add(c1);
            //clienteControleLINQ.Clientes.Add(c2);
            //clienteControleLINQ.Clientes.Add(c3);
            //clienteControleLINQ.Clientes.Add(c4);
            //clienteControleLINQ.Clientes.Add(c5);

            //Console.WriteLine("Filtro por Sexo");
            //clienteControleLINQ.Imprimir(clienteControleLINQ.FiltrarPorSexo(Sexo.Masculino));

            //Console.WriteLine("Filtro por Estado Civil");
            //clienteControleLINQ.Imprimir(clienteControleLINQ.FiltrarPorEstadoCivil(EstadoCivil.Solteiro));

            //Console.WriteLine("Filtro por Nome");
            //clienteControleLINQ.Imprimir(clienteControleLINQ.FiltrarPorNome("Ana"));

            //Console.WriteLine("Filtro por Id");
            //clienteControleLINQ.Imprimir(clienteControleLINQ.ObterPorId(1));

            //Console.WriteLine("LINQ");
            //ClienteControleLAMBDA clienteControleLAMBDA = new ClienteControleLAMBDA();
            //clienteControleLAMBDA.Clientes = new List<Cliente>();
            //clienteControleLAMBDA.Clientes.Add(c1);
            //clienteControleLAMBDA.Clientes.Add(c2);
            //clienteControleLAMBDA.Clientes.Add(c3);
            //clienteControleLAMBDA.Clientes.Add(c4);
            //clienteControleLAMBDA.Clientes.Add(c5);

            //Console.WriteLine("Filtro por Sexo");
            //clienteControleLAMBDA.Imprimir(clienteControleLINQ.FiltrarPorSexo(Sexo.Masculino));

            //Console.WriteLine("Filtro por Estado Civil");
            //clienteControleLAMBDA.Imprimir(clienteControleLINQ.FiltrarPorEstadoCivil(EstadoCivil.Solteiro));

            //Console.WriteLine("Filtro por Nome");
            //clienteControleLAMBDA.Imprimir(clienteControleLINQ.FiltrarPorNome("Ana"));

            //Console.WriteLine("Filtro por Id");
            //clienteControleLAMBDA.Imprimir(clienteControleLINQ.ObterPorId(1));
            //#endregion
            
            Console.ReadKey();
        }
    }
}
