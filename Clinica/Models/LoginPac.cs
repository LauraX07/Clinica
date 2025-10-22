using System.ComponentModel.DataAnnotations;

namespace Clinica.Models
{
    public class LoginPac
    {
        [Key]
        [Required(ErrorMessage = "A carteirinha é obrigatória.")]
        [RegularExpression(@"^\d{9}$", ErrorMessage = "A carteirinha deve conter apenas números (9 dígitos).")]
        public string? Carteirinha { get; set; }
 
        [Required(ErrorMessage = "O CPF é obrigatório.")]
        [RegularExpression(@"^\d{11}$", ErrorMessage = "O CPF deve conter apenas números (11 dígitos).")]
        public string? Cpf { get; set; }
       
        [Required(ErrorMessage = "A senha é obrigatória.")]
        [DataType(DataType.Password)]
        public string? Senha { get; set; }

    }
}
