using System;
using System.IO;
using System.Xml;
using Newtonsoft.Json;
using System.Collections.Generic;
using Projeto01.Entities;

namespace Projeto01.Controllers
{
    /// <summary>
    /// Controle do Cliente
    /// </summary>
    public class ClienteControle : IControleCliente
    {
        #region Atributos
        /// <summary>
        /// Caminho-base para salvamento do arquivo
        /// </summary>
        private string basePath = System.IO.Directory.GetCurrentDirectory();

        /// <summary>
        /// Nome do arquivo gerado ( com caminho )
        /// </summary>
        private string Filename { get; set; }
        #endregion       

        #region Métodos
        /// <summary>
        /// Exporta um objeto Cliente para arquivo CSV (Comma-Separated Value)
        /// </summary>
        /// <param name="cliente">Objeto a ser exportado</param>
        public void ExportarCsv(Cliente cliente)
        {
            Filename = "Cliente.csv";
            try
            {
                StreamWriter streamWriter = new StreamWriter(basePath + Filename);

                streamWriter.WriteLine($"idCliente,nome,sobrenome,cpf,email");
                streamWriter.WriteLine($"{cliente.IdCliente},{cliente.Nome},{cliente.Sobrenome},{cliente.Cpf},{cliente.Email}");

                streamWriter.Close();
            }
            catch (Exception ex)
            {
                throw new Exception($"[ERROR][CSV][{DateTime.Now.ToLocalTime()}] {ex.Message}");
            }
        }

        /// <summary>
        /// Exporta um objeto Cliente para arquivo JSON (JavaScript Object Notation)
        /// </summary>
        /// <param name="cliente">Objeto a ser exportado</param>
        public void ExportarJson(Cliente cliente)
        {
            Filename = "Cliente.json";
            try
            {
                StreamWriter streamWriter = new StreamWriter(basePath + Filename);

                streamWriter.WriteLine(JsonConvert.SerializeObject(cliente));

                streamWriter.Close();
            }
            catch (Exception ex)
            {
                throw new Exception($"[ERROR][JSON][{DateTime.Now.ToLocalTime()}] {ex.Message}");
            }
        }

        /// <summary>
        /// Exporta um objeto Cliente para arquivo TXT (texto puro)
        /// </summary>
        /// <param name="cliente">Objeto a ser exportado</param>
        public void ExportarTxt(Cliente cliente)
        {
            Filename = "Cliente.txt";
            try
            {
                StreamWriter streamWriter = new StreamWriter(basePath + Filename);

                streamWriter.WriteLine("********** Dados do Cliente **********");
                streamWriter.WriteLine("\tId.........: " + cliente.IdCliente);
                streamWriter.WriteLine("\tNome.......: " + cliente.Nome);
                streamWriter.WriteLine("\tSobrenome..: " + cliente.Sobrenome);
                streamWriter.WriteLine("\tCPF........: " + cliente.Cpf);
                streamWriter.WriteLine("\tEmail......: " + cliente.Email);
                streamWriter.WriteLine("**************************************");

                streamWriter.Close();
            }
            catch (Exception ex)
            {
                throw new Exception($"[ERROR][TXT][{DateTime.Now.ToLocalTime()}] {ex.Message}");
            }
        }

        /// <summary>
        /// Exporta um objeto Cliente para arquivo XML (eXtensible Markup Language)
        /// </summary>
        /// <param name="cliente">Objeto a ser exportado</param>
        public void ExportarXml(Cliente cliente)
        {
            Filename = "Cliente.xml";

            try
            {
                XmlWriter xmlWriter = XmlWriter.Create(basePath + Filename);

                xmlWriter.WriteStartDocument();

                xmlWriter.WriteStartElement("cliente");
                xmlWriter.WriteElementString("id-cliente", cliente.IdCliente.ToString());
                xmlWriter.WriteElementString("nome", cliente.Nome);
                xmlWriter.WriteElementString("sobrenome", cliente.Sobrenome);
                xmlWriter.WriteElementString("cpf", cliente.Cpf);
                xmlWriter.WriteElementString("email", cliente.Email);
                xmlWriter.WriteEndElement();

                xmlWriter.WriteEndDocument();
                xmlWriter.Close();
            }
            catch (Exception ex)
            {
                throw new Exception($"[ERROR][XML][{DateTime.Now.ToLocalTime()}] {ex.Message}");
            }
        }
        #endregion
    }
}
