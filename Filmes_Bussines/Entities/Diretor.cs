using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmes_Bussines.Entities
{
    public class Diretor
    {
        public virtual Guid DiretorId { get; set; }
        public virtual string Nome { get; set; }

        public virtual string Pais { get; set; }
        public virtual DateTime Nacimento { get; set; }

        public virtual ICollection<Filme> Filmes { get; set; }
        public Diretor()
        {
            DiretorId = Guid.NewGuid();
            Filmes = new List<Filme>();
        }
    }
}
