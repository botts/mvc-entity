using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace mvc_entity.ViewModels
{
    public class EditorAuthorViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Autor inválido")]
        [Display(Name = "Nome do Autor")]
        public string Nome { get; set; }

        public SelectList LivrosOpcoes { get; set; }
    }
}
