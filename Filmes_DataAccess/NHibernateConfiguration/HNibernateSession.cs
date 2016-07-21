using Filmes_DataAccess.NHibernateConfiguration.Interfaces;
using Filmes_DataAccess.NHibernateConfiguration.Mapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Driver;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmes_DataAccess.NHibernateConfiguration
{
    public class HNibernateSession:INHibernateSession
    {
       
        public ISessionFactory Session()
        {
            var dbString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;

            var session = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012.Driver<Sql2008ClientDriver>().ConnectionString(dbString).ShowSql())
                .Mappings(m =>
                {
                    m.FluentMappings.Add<DiretorMap>();
                    m.FluentMappings.Add<FilmeMap>();
                })
                .BuildSessionFactory();
            return session;
        }
    }
}
