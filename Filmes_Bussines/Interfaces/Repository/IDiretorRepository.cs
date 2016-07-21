using Filmes_Bussines.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmes_Bussines.Interfaces.Repository
{
    public interface IDiretorRepository:IDisposable
    {
        void Crear(Diretor diretor);
        Diretor GetPorId(Guid id);
        IEnumerable<Diretor> GetTodos();
        void Atualizar(Diretor diretor);
        void Remover(Guid id);

    }
}
