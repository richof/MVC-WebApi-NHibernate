using Filmes_Bussines.Interfaces.Repository;
using System;
using System.Collections.Generic;
using Filmes_Bussines.Entities;
using Filmes_DataAccess.NHibernateConfiguration.Interfaces;
using NHibernate;

namespace Filmes_DataAccess.Repository
{
    public class DiretorRepository : IDiretorRepository
    {
        ISessionFactory _session;
        public DiretorRepository(INHibernateSession session)
        {
            _session = session.Session();
        }
        public void Atualizar(Diretor diretor)
        {

            using (var session = _session.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Update(diretor);
                    transaction.Commit();
                }
            }
        }

        public void Crear(Diretor diretor)
        {
            using (var session = _session.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Save(diretor);
                    transaction.Commit();
                }
            }
        }

        public void Dispose()
        {
            _session.Dispose();
            GC.SuppressFinalize(this);
        }

        public Diretor GetPorId(Guid id)
        {
            using (var session = _session.OpenSession())
            {
                return session.Get<Diretor>(id);
            }
        }

        public IEnumerable<Diretor> GetTodos()
        {
            using (var session = _session.OpenSession())
            {
                var diretores = session.QueryOver<Diretor>().List();
                return diretores;
            }

        }

        public void Remover(Guid id)
        {
            using (var session = _session.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Delete(GetPorId(id));
                }
            }
        }
    }
}
