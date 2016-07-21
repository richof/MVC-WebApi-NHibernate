using Filmes_Bussines.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmes_DataAccess.EntityConfigurations
{
   public class DiretorConfig:EntityTypeConfiguration<Diretor>
    {
        public DiretorConfig()
        {
            HasKey(d => d.DiretorId);
            Property(d => d.Nome)
                .IsRequired();
            Property(d => d.Pais)
                .IsRequired();
            HasMany<Filme>(d => d.Filmes)
                .WithRequired(f => f.Diretor)
                .HasForeignKey(f => f.DiretorId);

            ToTable("Diretor");   

        }

    }
}
