using Microsoft.AspNetCore.Mvc;
using Clinica.Models;
using MySql.Data.MySqlClient;

namespace Clinica.Controllers
{
    public class CadPaciente : Controller
    {

        private readonly IConfiguration _configuration;
        public CadPaciente(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public IActionResult CadastroP()
        {
            return View();
        }

       [HttpPost]
        public IActionResult Cadastrar(CadPac cadpac)
        {

            if (!ModelState.IsValid)
            {
                return View ("CadastroP", cadpac);
            }

            string? connectionString = _configuration.GetConnectionString("DefaultConnection");
            using var connection = new MySqlConnection(connectionString);
            connection.Open();

            string sql = "INSERT INTO tbPaciente (Carteirinha, Cpf, Nome, DataNasci, Email, Senha, Telefone, Sexo, IdPlano) " +
                               "VALUES(@Carteirinha, @Cpf, @Nome, STR_TO_DATE (@DataNasci, '%d/%m/%Y'), @Email, @Senha, @Sexo, @Telefone, @IdPlano)";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@Carteirinha", cadpac.Carteirinha);
            command.Parameters.AddWithValue("@Cpf", cadpac.Cpf);
            command.Parameters.AddWithValue("@Nome", cadpac.Nome);
            command.Parameters.AddWithValue("@DataNasci", cadpac.DataNasci);
            command.Parameters.AddWithValue("@Email", cadpac.Email);
            command.Parameters.AddWithValue("@Senha", cadpac.Senha);
            command.Parameters.AddWithValue("@Sexo", cadpac.Sexo);
            command.Parameters.AddWithValue("@Telefone", cadpac.Telefone);
            command.Parameters.AddWithValue("@IdPlano", cadpac.IdPlano);
            command.ExecuteNonQuery();

            return RedirectToAction("Sucesso");
        }
    }
}

