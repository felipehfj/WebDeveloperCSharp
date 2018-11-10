using Projeto01.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Controles
{
    public class ProfessorControle
    {
        public void SalvarEmArquivo(Professor professor)
        {            
            string path = System.IO.Directory.GetCurrentDirectory() ;
            string filename = "Dados.txt";
            StreamWriter streamWriter = new StreamWriter(path + filename);

            streamWriter.WriteLineAsync(professor.ToString().ToCharArray());

            streamWriter.Close();
        }
    }
}
