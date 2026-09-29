using System.ComponentModel.DataAnnotations;

namespace rev01.Models
{
    public class Voto
    {
        [Required]
        public string RaAluno { get; set; }

        public DateTime DataVoto { get; set; } = DateTime.Now;

        [Required]
        [Range(10, 99)]
        public int NumeroCandidato { get; set; }
    }
}