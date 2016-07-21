using Filmes_DataAccess.EntityConfigurations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmes_DataAccess.Contexto
{
    public class ContextoDB:DbContext
    {
        public ContextoDB()
            :base("DBConnection")
        {
                
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(50));
            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id");
            modelBuilder.Configurations.Add(new DiretorConfig());
            modelBuilder.Configurations.Add(new FilmeConfig());


        }
    }
}
