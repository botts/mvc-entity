using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvc_entity.ViewModels
{
    public class CreateBookViewModel
    {
        [Required(ErrorMessage = "*")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "*")]
        public string ISBN { get; set; }
        [Required(ErrorMessage = "*")]
        public DateTime DataLancamento { get; set; }
        [Required(ErrorMessage = "*")]
        public int CategoriaId { get; set; }
    }
}