using System.ComponentModel.DataAnnotations;

namespace mvc_entity.ViewModels
{
    public class EditorCategoryViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Categoria inválida")]
        [Display(Name = "Nome da categoria")]
        public string Nome { get; set; }
    }
}