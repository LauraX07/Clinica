using System.ComponentModel.DataAnnotations;
using System.Numerics;
namespace Clinica.Models
{
    public class CadMec
    {
        [Key]
        [Required(ErrorMessage = "O CRM é obrigatório.")]
        public int Crm { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        public string? Nome { get; set; }

        [EmailAddress(ErrorMessage = "Informe um e-mail válido.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "A senha é obrigatória.")]
        [DataType(DataType.Password)]
        public string? Senha { get; set; }

        [Required(ErrorMessage = "O telefone é obrigatório.")]
        [Phone(ErrorMessage = "Informe um número de telefone válido.")]
        [RegularExpression(@"^\d{10,11}$", ErrorMessage = "O telefone deve conter apenas números")]
        public string? Telefone { get; set; }

        [Required(ErrorMessage = "A especialidade é obrigatória.")]
        public string? Especialidade {  get; set; }
    }
}
