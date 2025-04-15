using System.ComponentModel.DataAnnotations;

namespace APIEscola.Models
{
    public class Turma
    {
        public Guid TurmaId { get; set; }

        [Required(ErrorMessage = "O Campo Descrição é Obrigatório")]
        [MaxLength(255, ErrorMessage = "A descrição deve ter no máximo 255 caracteres")]
        public string Descricao { get; set; }


        [Required(ErrorMessage = "A Sigla do curso é Obrigatório")]
        [MaxLength(15, ErrorMessage = "A Sigla deve ter no máximo 15 caracteres")]
        public string Sigla { get; set; }

        [Required(ErrorMessage = "O Campo Data de Início é Obrigatório")]
        public DateTime DataInicio { get; set; }

        [Required(ErrorMessage = "O Campo Data de Fim é Obrigatório")]
        public DateTime DataFim { get; set; }

        public Guid CursoId { get; set; }
        public Curso? Curso { get; set; }
    }
}
