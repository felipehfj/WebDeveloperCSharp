using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto02.Contracts;
using Projeto02.Entities;
using Newtonsoft.Json;
using System.IO;

namespace Projeto02.Controllers
{
    public class ClienteControle : IClienteControle
    {
        string path = System.IO.Directory.GetCurrentDirectory() + "Cliente.json";

        public void ExportarJson(Cliente cliente)
        {                
            // Abrindo o arquivo
            StreamWriter streamWriter = new StreamWriter(path);

            // Escrevendo os dados do cliente em formato JSON
            streamWriter.WriteLine(JsonConvert.SerializeObject(cliente));

            // Fechando o Arquivo
            streamWriter.Close();

        }

        public Cliente ImportarJson()
        {
            StreamReader streamReader = new StreamReader(path);

            Cliente cliente = JsonConvert.DeserializeObject<Cliente>(streamReader.ReadToEnd());

            streamReader.Close();

            return cliente;
        }
    }
}
