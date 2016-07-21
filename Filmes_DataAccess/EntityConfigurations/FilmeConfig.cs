using Filmes_Bussines.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmes_DataAccess.EntityConfigurations
{
    public class FilmeConfig:EntityTypeConfiguration<Filme>
    {
        public FilmeConfig()
        {
            HasKey(f => f.FilmeId);
            Property(f => f.Titulo)
                .IsRequired();
            Property(f => f.Descricao)
                .HasMaxLength(200)
                .IsRequired();
            HasRequired(f => f.Diretor)
                 .WithMany(d=>d.Filmes);
            ToTable("Filme");
        }
    }
}
