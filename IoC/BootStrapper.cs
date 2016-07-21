using Filmes_Bussines.Interfaces.Repository;
using Filmes_DataAccess.NHibernateConfiguration;
using Filmes_DataAccess.NHibernateConfiguration.Interfaces;
using Filmes_DataAccess.Repository;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC
{
    public class BootStrapper
    {
        public static void RegisterServices(Container container)
        {
            container.RegisterPerWebRequest<INHibernateSession, HNibernateSession>();
            container.RegisterPerWebRequest<IDiretorRepository, DiretorRepository>();

        }
    }
}
