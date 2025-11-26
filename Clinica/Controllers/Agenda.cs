using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using Clinica.Models;

namespace Clinica.Controllers
{
    public class Agenda : Controller
    {
        private readonly IConfiguration _configuration;

        public Agenda(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public ActionResult Index()
        {
                        string? connectionString = _configuration.GetConnectionString("DefaultConnection");
            using var connection = new MySqlConnection(connectionString);
            connection.Open();

            string sql = "SELECT IdAgenda, DataH, StatusA, Crm FROM tbAgenda WHERE StatusA = 'Disponível'";
            MySqlCommand command = new MySqlCommand(sql, connection);

            List<ClassAgenda> listaAgenda = new List<ClassAgenda>();
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    ClassAgenda a = new ClassAgenda();
                    a.IdAgenda = reader.GetInt32("IdAgenda");
                    a.DataH = reader.GetDateTime("DataH");
                    a.StatusA = reader.GetString("StatusA");
                    a.CRM = reader.GetString("Crm");
                    listaAgenda.Add(a);
                }
            }

            return View(listaAgenda);

        }
    }
}
