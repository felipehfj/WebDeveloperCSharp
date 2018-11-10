using Projeto01.Entities;

namespace Projeto01.Controllers
{
    /// <summary>
    /// Interface de controle de Cliente
    /// </summary>
    public interface IControleCliente
    {
        /// <summary>
        /// Exporta um objeto Cliente para arquivo TXT
        /// </summary>
        /// <param name="cliente"></param>
        void ExportarTxt(Cliente cliente);

        /// <summary>
        /// Exporta um objeto Cliente para arquivo CSV
        /// </summary>
        /// <param name="cliente"></param>
        void ExportarCsv(Cliente cliente);

        /// <summary>
        /// Exporta um objeto Cliente para arquivo XML
        /// </summary>
        /// <param name="cliente"></param>
        void ExportarXml(Cliente cliente);

        /// <summary>
        /// Exporta um objeto Cliente para arquivo JSON
        /// </summary>
        /// <param name="cliente"></param>
        void ExportarJson(Cliente cliente);
    }
}
