﻿using System.ComponentModel.DataAnnotations;
using System.Numerics;
namespace Clinica.Models
{
    public class CadMec
    {
        [Key]
        [RegularExpression(@"^\d{10,11}$", ErrorMessage = "O CRM deve conter apenas números")]
        public int CRM { get; set; }

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

        public int IdEspecialidade { get; set; }
        public required Especialidade EspecialidadeM {  get; set; }
    }
}
