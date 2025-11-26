using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
namespace Clinica.Models
{
    public class CadPac
    {
        [Key]
        [Required(ErrorMessage = "A carteirinha é obrigatória.")]
        [RegularExpression(@"^\d{9}$", ErrorMessage = "A carteirinha deve conter apenas números (9 dígitos).")]
        public string? Carteirinha { get; set; }

        [Required(ErrorMessage = "O CPF é obrigatório.")]
        [RegularExpression(@"^\d{11}$", ErrorMessage = "O CPF deve conter apenas números (11 dígitos).")]
        public string? Cpf { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "A data de nascimento é obrigatória")]
        [DataType(DataType.Date)]
        public DateOnly? DataNasci { get; set; }

        [EmailAddress(ErrorMessage = "Informe um e-mail válido.")]
        public string?  Email { get; set; }

        [Required(ErrorMessage = "A senha é obrigatória.")]
        [DataType(DataType.Password)]
        public string? Senha { get; set; }

        [Required(ErrorMessage = "O sexo é obrigatório")]
        public string? Sexo { get; set; }

        [Required(ErrorMessage = "O telefone é obrigatório.")]
        [Phone(ErrorMessage = "Informe um número de telefone válido.")]
        [RegularExpression(@"^\d{10,11}$", ErrorMessage = "O telefone deve conter apenas números")]
        public string? Telefone { get; set; }

        [Required(ErrorMessage = "O Plano é obrigatório.")]
        public int?  IdPlano { get; set; }
        public Plano? PlanoPac { get; set; }


    }
}
