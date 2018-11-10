using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto02.Entities;
using Projeto02.Controllers;

namespace Projeto02
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente(1, "Felipe", "felipehfj@gmail.com");
            ClienteControle clienteControle = new ClienteControle();

            try
            {
                Console.Write("Exportanto cliente..."); 
                clienteControle.ExportarJson(cliente);
                Console.WriteLine("ok!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[ERROR][EXPORT] {DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss,ff")}: {ex.Message}");                
            }

            try
            {
                Console.Write("Importanto cliente...");
                Cliente clienteLido = clienteControle.ImportarJson();
                Console.WriteLine("ok!");

                Console.WriteLine("Cliente lido: " + clienteLido);                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[ERROR][IMPORT] {DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss,ff")}: {ex.Message}");
            }

            Console.ReadKey();

        }
    }
}
