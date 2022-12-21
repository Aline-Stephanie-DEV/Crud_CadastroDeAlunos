using EM.Domain;
using EM.Repository;
using System.ComponentModel.DataAnnotations;

namespace EM.Web.Models
{
    public class AlunoViewModel
    {
        public List<Aluno> Alunos = new();
        public Aluno? Aluno { get; set; }

        [Required(ErrorMessage = "(Campo Obrigatório)")]
        [Range(1, 999999999, ErrorMessage = "(Campo Obrigatório) A matricula deve estar entre 1 e 999999999!")]
        public int Matricula { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "(Campo Obrigatório)")]
        [RegularExpression (@"^[a-zA-Z ]+$", ErrorMessage = "(Campo Obrigatório) O nome deve conter somente letras!")]
        public string Nome { get; set; } = string.Empty;

        [Required]
        public EnumeradorSexo Sexo { get; set; }

        [Required(ErrorMessage = "(Campo Obrigatório) Digite uma data válida!")]
        [DataType(DataType.Date)]
        public DateTime Nascimento { get; set; }

        public string? CPF { get; set; } = string.Empty;

        public string? Pesquisa { get; set; }
    }
}

