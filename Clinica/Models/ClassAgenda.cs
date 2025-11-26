using System.ComponentModel.DataAnnotations;

namespace Clinica.Models
{
    public class ClassAgenda
    {
        [Key]
        public int IdAgenda { get; set; }

        [Required(ErrorMessage = "A data e horário são obrigatórios.")]
        public DateTime DataH { get; set; }

        [Required]
        [RegularExpression(@"^(Pendente|Cancelado|Disponivel)$", 
         ErrorMessage = "O status deve ser Pendente, Disponivel ou Cancelado.")]
        public string? StatusA { get; set; }

        [Required(ErrorMessage = "O CRM é obrigatório.")]
        [RegularExpression(@"^\d{4,10}$", ErrorMessage = "CRM deve ter apenas números.")]
        public string? CRM { get; set; }

        [Required(ErrorMessage = "A carteirinha é obrigatória.")]
        [RegularExpression(@"^\d{9}$", ErrorMessage = "A carteirinha deve conter apenas números (9 dígitos).")]
        public string? Carteirinha { get; set; }
    }
}
