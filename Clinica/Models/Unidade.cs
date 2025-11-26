using System.ComponentModel.DataAnnotations;

namespace Clinica.Models
{
    public class Unidade
    {
        [Key]
        public int IdUnidade { get; set; }

        [Required]
        public string? NomeU { get; set; }

        [Required]
        public string? Endereco { get; set; }
    }
}
