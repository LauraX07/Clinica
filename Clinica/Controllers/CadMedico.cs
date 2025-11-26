using Clinica.Models;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace Clinica.Controllers
{
    public class CadMedico : Controller
    {

        private readonly IConfiguration _configuration;
        public CadMedico(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public IActionResult CadastroM()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(CadMec cadmec)
        {

            if (!ModelState.IsValid)
            {
                return View("CadastroP", cadmec);
            }

            string? connectionString = _configuration.GetConnectionString("DefaultConnection");
            using var connection = new MySqlConnection(connectionString);
            connection.Open();

            string sql = "INSERT INTO tbMedico (CRM, Nome, Telefone, Email, Senha, IdEspecialidade) " +
                                         "VALUES(@CRM, @Nome, @Telefone, @Email, @Senha, @IdEspecialidade)";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@CRM", cadmec.CRM);
            command.Parameters.AddWithValue("@Nome", cadmec.Nome);
            command.Parameters.AddWithValue("@Telefone", cadmec.Telefone);
            command.Parameters.AddWithValue("@Email", cadmec.Email);
            command.Parameters.AddWithValue("@Senha", cadmec.Senha);
            command.Parameters.AddWithValue("@Especialidade", cadmec.Especialidade);
            command.ExecuteNonQuery();

            return RedirectToAction("Sucesso");
        }
    }
}

