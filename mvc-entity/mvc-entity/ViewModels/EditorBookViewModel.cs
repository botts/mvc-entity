using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace mvc_entity.ViewModels
{
    public class EditorBookViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome invalido")]
        [Display(Name = "Nome do livro")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "ISBN invalido")]
        public string ISBN { get; set; }
        [Required(ErrorMessage = "Data de lancamento invalido")]
        [Display(Name = "Data de lancamento")]
        [DataType(DataType.Date)]
        public DateTime DataLancamento { get; set; }
        [Required(ErrorMessage = "Categoria invalida")]
        public int CategoriaId { get; set; }
        public SelectList CategoriaOpcoes { get; set; }
    }
}