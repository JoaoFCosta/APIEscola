using System.ComponentModel.DataAnnotations;

namespace APIEscola.Models
{
    public class Curso
    {
        public Guid CursoId { get; set; }

        [Required(ErrorMessage = "A Sigla do curso é Obrigatório")]
        [MaxLength(10, ErrorMessage = "A Sigla deve ter no máximo 10 caracteres")]
        public string Sigla { get; set; }

        [Required(ErrorMessage = "A descrição do curso é Obrigatória")]
        [MaxLength(255, ErrorMessage = "A descrição deve ter no máximo 255 caracteres")]
        public string Descricao { get; set; }
    }
}
