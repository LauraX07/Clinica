namespace Clinica.Models
{
    public class MedicoViewModel
    {
        public CadMec Medico { get; set; } = new CadMec();
        public List<Unidade> Unidades { get; set; } = new();
        public List<int> UnidadesSelecionadas { get; set; } = new List<int>();
    }
}
