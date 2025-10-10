using System.ComponentModel.DataAnnotations;
using System.Numerics;
namespace Clinica.Models
{
    public class Plano
    {
        [Key]
        public int IdPlano { get; set; }
        [Required]
        public string? Nome{ get; set; }
        [Required]
        public decimal Valor { get; set; }
        [Required]
        public string? Tipo { get; set; }
    }
}
