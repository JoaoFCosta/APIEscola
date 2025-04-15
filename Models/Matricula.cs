using System.ComponentModel.DataAnnotations;

namespace APIEscola.Models
{
    public class Matricula
    {
        public Guid MatriculaId { get; set; }

        [Required(ErrorMessage = "A data da matricula é obrigatória!")]
        [DataType(DataType.Date, ErrorMessage = "A data da matricula é obrigatória!")]
        public DateOnly DataMatricula { get; set; }

        public Guid AlunoId { get; set; }
        public Aluno? Aluno { get; set; }

        public Guid CursoId { get; set; }
        public Curso? Curso { get; set; }

    }
}
