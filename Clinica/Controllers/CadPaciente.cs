using Clinica.Models;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System.Data;

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
        public IActionResult LoginP()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoginP(CadPac cadpac)
        {

            string? connectionString = _configuration.GetConnectionString("DefaultConnection");
            using var connection = new MySqlConnection(connectionString);
            connection.Open();
           

            string sql = "SELECT * FROM tbPaciente WHERE Cpf = @Cpf AND Senha = @Senha";

            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@Cpf", cadpac.Cpf);
            command.Parameters.AddWithValue("@Senha", cadpac.Senha);

            using var reader = command.ExecuteReader();

            // Usuário encontrado
            if (reader.Read())
            {
                return RedirectToAction("Index", "Home");

            }

            // Usuário inválido
            ViewBag.Erro = "CPF ou senha incorretos.";
            return View(cadpac);

        }
                
        [HttpGet]
        public IActionResult CadastroP()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastroP(CadPac cadpac)
        {
            if (!ModelState.IsValid)
            {
                return View ("CadastroP", cadpac);
            }

            string? connectionString = _configuration.GetConnectionString("DefaultConnection");
            using var connection = new MySqlConnection(connectionString);
            connection.Open();

            string sql = "INSERT INTO tbPaciente (Carteirinha, Cpf, Nome, DataNasci, Email, Senha, Telefone, Sexo, IdPlano) " +
                                         "VALUES(@Carteirinha, @Cpf, @Nome,@DataNasci, @Email, @Senha, @Telefone, @Sexo, @IdPlano)";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@Carteirinha", cadpac.Carteirinha);
            command.Parameters.AddWithValue("@Cpf", cadpac.Cpf);
            command.Parameters.AddWithValue("@Nome", cadpac.Nome);
            command.Parameters.AddWithValue("@DataNasci", cadpac.DataNasci);
            command.Parameters.AddWithValue("@Email", cadpac.Email);
            command.Parameters.AddWithValue("@Senha", cadpac.Senha);
            command.Parameters.AddWithValue("@Telefone", cadpac.Telefone);
            command.Parameters.AddWithValue("@Sexo", cadpac.Sexo);
            command.Parameters.AddWithValue("@IdPlano", cadpac.IdPlano);
            command.ExecuteNonQuery();

            return RedirectToAction("Index", "Home");
        }
    }
}

