using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmes_DataAccess.NHibernateConfiguration.Interfaces
{
    public interface INHibernateSession
    {
        ISessionFactory Session();
    }
}
