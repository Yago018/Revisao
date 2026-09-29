using System.ComponentModel.DataAnnotations;

namespace rev01.Models
{
    public class Candidato
    {
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Nome { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Range(1, 8)]
        public int Turma { get; set; }

        [Required]
        [MaxLength(500)]
        public string Descricao { get; set; }

        [Required]
        [Range(10, 99)]
        public int NumeroCandidato { get; set; }
    }
}