using mvc_entity.Domain;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace mvc_entity.ViewModels
{
    public class EditorAuthorViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Autor inválido")]
        [Display(Name = "Nome do Autor")]
        public string Nome { get; set; }
        public int SelectedBookId { get; set; }
        public List<Book> LivrosOpcoes { get; set; }
    }
}
