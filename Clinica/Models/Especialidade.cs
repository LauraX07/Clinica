using System.ComponentModel.DataAnnotations;

namespace Clinica.Models
{
    public class Especialidade
    {
        [Key]
        public int IdEpecialidade { get; set; }
        public required string NomeE { get; set; }
    }
}
