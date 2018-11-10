using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entities;
using Projeto01.Entities.Types;

namespace Projeto01.Abstracts
{
    // Classe abstrata
    public abstract class ClienteControleAbstract
    {
        // Propriedade
        public List<Cliente> Clientes { get; set; }

        // Métodos abstratos

        /// <summary>
        /// Filtrar Clientes na lista que correspondam ao Nome passado como parâmetro
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        public abstract List<Cliente> FiltrarPorNome(string nome);

        /// <summary>
        /// Filtrar Clientes na lista que correspondam ao Sexo passado como parâmetro
        /// </summary>
        /// <param name="sexo"></param>
        /// <returns></returns>
        public abstract List<Cliente> FiltrarPorSexo(Sexo sexo);

        /// <summary>
        /// Filtrar Clientes na lista que correspondam ao Estado Civil passado como parâmetro
        /// </summary>
        /// <param name="civil"></param>
        /// <returns></returns>
        public abstract List<Cliente> FiltrarPorEstadoCivil(EstadoCivil estadoCivil);

        /// <summary>
        /// Obter Cliente que correspondam o IdCliente passado por parâmetro
        /// </summary>
        /// <param name="idCliente"></param>
        /// <returns></returns>
        public abstract Cliente ObterPorId(int idCliente);
    }
}
