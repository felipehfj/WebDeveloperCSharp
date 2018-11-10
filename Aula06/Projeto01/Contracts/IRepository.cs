using System.Collections.Generic;

namespace Projeto01.Contracts
{
    public interface IRepository<T>
        where T : class
    {
        void Inserir(T t);
        void Atualizar(T t);
        void Excluir(int id);
        List<T> Consultar();
    }
}
