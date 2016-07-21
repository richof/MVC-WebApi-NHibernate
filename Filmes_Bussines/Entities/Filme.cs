using System;

namespace Filmes_Bussines.Entities
{
    public class Filme
    {
        public virtual Guid FilmeId { get; set; }
        public virtual string Titulo { get; set; }
        public virtual string Descricao { get; set; }
        public virtual Guid DiretorId { get; set; }
        public virtual Diretor Diretor { get; set; }
        public Filme()
        {
            FilmeId = Guid.NewGuid();
        }


    }
}