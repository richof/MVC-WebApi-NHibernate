using Filmes_Bussines.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmes_DataAccess.NHibernateConfiguration.Mapping
{
    public class DiretorMap:ClassMap<Diretor>
    {
        public DiretorMap()
        {
            Id(d => d.DiretorId);
            Map(d => d.Nome)
                .Column("Nome")
                .CustomSqlType("varchar")
                .Length(50)
                .Not.Nullable();
            Map(d => d.Pais)
               .Column("Pais")
               .CustomSqlType("varchar")
               .Length(50)
               .Not.Nullable();
            Map(d => d.Nacimento)
               .Column("Nacimento")
               .CustomSqlType("date")
               .Not.Nullable();
            HasMany(d => d.Filmes)
                .KeyColumn("DiretorId")
                .Inverse();
            Table("Diretor");
        }
    }
}
