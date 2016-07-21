using Filmes_Bussines.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Filmes_DataAccess.NHibernateConfiguration.Mapping
{
    public class FilmeMap:ClassMap<Filme>
    {
        public FilmeMap()
        {
            Id(f => f.FilmeId);
            Map(f => f.Titulo)
                .Column("Titulo")
                .CustomSqlType("varchar")
                .Length(50)
                .Not.Nullable();
            Map(f => f.Descricao)
               .Column("Descricao")
               .CustomSqlType("varchar")
               .Length(150)
               .Not.Nullable();

            References(f => f.Diretor)
                .ForeignKey()
                .Column("DirectorId")
                .Not.Nullable();
        }
    }
}
