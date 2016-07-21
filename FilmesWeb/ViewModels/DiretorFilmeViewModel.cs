using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FilmesWeb.ViewModels
{
    public class DiretorFilmeViewModel
    {
        [Key]
        public Guid DiretorId { get; set; }
        [Required(ErrorMessage = "Campo obrigatorio")]
        [MaxLength(50, ErrorMessage = "A longitude máxima deve ser de {1} carateres.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo obrigatorio")]
        [MaxLength(50, ErrorMessage = "A longitude máxima deve ser de {1} carateres.")]
        public string Pais { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime Nacimento { get; set; }

        [Key]
        public Guid FilmeId { get; set; }
        [Required(ErrorMessage = "Campo obrigatorio")]
        [MaxLength(50, ErrorMessage = "A longitude máxima deve ser de {1} carateres.")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "Campo obrigatorio")]
        [MaxLength(200, ErrorMessage = "A longitude máxima deve ser de {1} carateres.")]
        public string Descricao { get; set; }
        //public Guid DiretorId { get; set; }
        public DiretorFilmeViewModel()
        {
            DiretorId = Guid.NewGuid();
            FilmeId = Guid.NewGuid();
        }


    }
}