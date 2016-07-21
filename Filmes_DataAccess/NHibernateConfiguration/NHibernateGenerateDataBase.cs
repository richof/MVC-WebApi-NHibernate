using Filmes_DataAccess.NHibernateConfiguration.Mapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmes_DataAccess.NHibernateConfiguration
{
    public class NHibernateGenerateDataBase
    {
        public static void BuildSchemma()
        {
            var dbString = ConfigurationManager.ConnectionStrings["DBConnection2"].ConnectionString;

            var configuration = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012
                .ConnectionString(dbString).ShowSql())
                .Mappings(m =>
                {
                    m.FluentMappings.Add<DiretorMap>();
                    m.FluentMappings.Add<FilmeMap>();
                }).BuildConfiguration();

            var exporter=new SchemaExport(configuration);
            exporter.Execute(true, true, false);

                
                
        }
    }
}
