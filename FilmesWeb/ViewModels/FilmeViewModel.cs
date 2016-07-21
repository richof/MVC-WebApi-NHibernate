using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FilmesWeb.ViewModels
{
    public class FilmeViewModel
    {
        [Key]
        public Guid FilmeId { get; set; }
        [Required(ErrorMessage = "Campo obrigatorio")]
        [MaxLength(50, ErrorMessage = "A longitude máxima deve ser de {1} carateres.")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "Campo obrigatorio")]
        [MaxLength(200, ErrorMessage = "A longitude máxima deve ser de {1} carateres.")]
        public string Descricao { get; set; }
        public Guid DiretorId { get; set; }
    }
}