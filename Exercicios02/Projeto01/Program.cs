using Projeto01.Entities;
using Projeto01.Controllers;
using System;

namespace Projeto01
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente(1, "Felipe", "Ferreira", "056.895.047-00", "felipehfj@gmail.com");

            ClienteControle clienteControle = new ClienteControle();           

            #region CSV
            try
            {
                Console.Write("Exportando para CSV...");
                DateTime start = DateTime.Now;
                clienteControle.ExportarCsv(cliente);
                DateTime end = DateTime.Now;
                Console.WriteLine($"ok! [{(end - start).TotalMilliseconds} ms]");

            }
            catch (Exception ex)
            {
                Console.WriteLine("falha.");
                Console.WriteLine(ex.Message);
            }
            #endregion

            #region JSON
            try
            {
                Console.Write("Exportando para JSON...");
                DateTime start = DateTime.Now;
                clienteControle.ExportarJson(cliente);
                DateTime end = DateTime.Now;
                Console.WriteLine($"ok! [{(end - start).TotalMilliseconds} ms]");
            }
            catch (Exception ex)
            {
                Console.WriteLine("falha.");
                Console.WriteLine(ex.Message);
            }
            #endregion

            #region TXT
            try
            {
                Console.Write("Exportando para TXT...");
                DateTime start = DateTime.Now;
                clienteControle.ExportarTxt(cliente);
                DateTime end = DateTime.Now;
                Console.WriteLine($"ok! [{(end - start).TotalMilliseconds} ms]");
            }
            catch (Exception ex)
            {
                Console.WriteLine("falha.");
                Console.WriteLine(ex.Message);
            }
            #endregion

            #region XML
            try
            {
                Console.Write("Exportando para XML...");
                DateTime start = DateTime.Now;
                clienteControle.ExportarXml(cliente);
                DateTime end = DateTime.Now;
                Console.WriteLine($"ok! [{(end - start).TotalMilliseconds} ms]");
            }
            catch (Exception ex)
            {
                Console.WriteLine("falha.");
                Console.WriteLine(ex.Message);
            }
            #endregion

            Console.ReadKey();
        }
    }
}
