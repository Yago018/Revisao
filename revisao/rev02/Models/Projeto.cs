using System.ComponentModel.DataAnnotations;

namespace rev02.Models
{
    public class Projeto
    {
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Nome { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        [Range(1, 8)]
        public int Turma { get; set; }

        [Required]
        [MaxLength(500)]
        public string Descricao { get; set; } = string.Empty;

        [Required]
        [Range(10, 99)]
        public int NumeroProjeto { get; set; }
    }
}