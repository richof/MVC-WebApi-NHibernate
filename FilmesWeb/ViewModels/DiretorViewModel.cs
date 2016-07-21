using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FilmesWeb.ViewModels
{
    public class DiretorViewModel
    {
        [Key]
        public Guid DiretorId { get; set; }
        [Required(ErrorMessage ="Campo obrigatorio")]
        [MaxLength(50,ErrorMessage = "A longitude máxima deve ser de {1} carateres.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo obrigatorio")]
        [MaxLength(50, ErrorMessage = "A longitude máxima deve ser de {1} carateres.")]
        public string Pais { get; set; }
        [DataType(DataType.Date)]
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/mm/yyyy}")]
        public DateTime Nacimento { get; set; }

        public DiretorViewModel()
        {
            DiretorId = Guid.NewGuid();
        }
    }
}