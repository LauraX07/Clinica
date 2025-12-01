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
        public IActionResult LoginM()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoginM(CadMec cadmec)
        {

            string? connectionString = _configuration.GetConnectionString("DefaultConnection");
            using var connection = new MySqlConnection(connectionString);
            connection.Open();


            string sql = "SELECT * FROM tbMedico WHERE Crm = @Crm AND Senha = @Senha";

            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@Crm", cadmec.Crm);
            command.Parameters.AddWithValue("@Senha", cadmec.Senha);

            using var reader = command.ExecuteReader();

            // Usuário encontrado
            if (reader.Read())
            {
                return RedirectToAction("Index", "Home");
            }

            // Usuário inválido
            ViewBag.Erro = "CRM ou senha incorretos.";
            return View(cadmec);
        }

        [HttpGet]
        public IActionResult CadastroM()
        {
            var model = new MedicoViewModel();
            model.Medico = new CadMec();
            model.Unidades = BuscarUnidades();

            return View(model);
        }
        private List<Unidade> BuscarUnidades()
        {
            List<Unidade> lista = new List<Unidade>();

            string? connectionString = _configuration.GetConnectionString("DefaultConnection");
            using var connection = new MySqlConnection(connectionString);
            connection.Open();

            string sql = "SELECT IdUnidade, NomeU FROM tbUnidade";

            MySqlCommand cmd = new MySqlCommand(sql, connection);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lista.Add(
                    new Unidade
                {
                    IdUnidade = reader.GetInt32("IdUnidade"),
                    NomeU = reader.GetString("NomeU")
                });
            }

            return lista;

        }

        [HttpPost]
        public IActionResult CadastroM(MedicoViewModel vm)
        {

            if (!ModelState.IsValid)
            {
                vm.Unidades = BuscarUnidades();
                return View(vm);
            }

            string? connectionString = _configuration.GetConnectionString("DefaultConnection");
            using var connection = new MySqlConnection(connectionString);
            connection.Open();

            using var transaction = connection.BeginTransaction();
            try
            {

                string sql = "INSERT INTO tbMedico (Crm, Nome, Telefone, Email, Senha, Especialidade) " +
                                         "VALUES(@Crm, @Nome, @Telefone, @Email, @Senha, @Especialidade)";
            MySqlCommand cmd = new MySqlCommand(sql, connection, transaction);
            cmd.Parameters.AddWithValue("@Crm", vm.Medico.Crm);
            cmd.Parameters.AddWithValue("@Nome", vm.Medico.Nome);
            cmd.Parameters.AddWithValue("@Telefone", vm.Medico.Telefone);
            cmd.Parameters.AddWithValue("@Email", vm.Medico.Email);
            cmd.Parameters.AddWithValue("@Senha", vm.Medico.Senha);
            cmd.Parameters.AddWithValue("@Especialidade", vm.Medico.Especialidade);
            cmd.ExecuteNonQuery();

            string sql2 = @"INSERT INTO Unidade_Medico (IdUnidade, Crm)
                VALUES (@IdUnidade, @Crm)";
            using var cmd1 = new MySqlCommand(sql2, connection);
                foreach (var idUni in vm.UnidadesSelecionadas.Distinct())
                {
                    cmd1.Parameters.Clear();
                    cmd1.Parameters.AddWithValue("@IdUnidade", idUni);
                    cmd1.Parameters.AddWithValue("@Crm", vm.Medico.Crm);
                    cmd1.ExecuteNonQuery();
                }
                transaction.Commit();
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                vm.Unidades = BuscarUnidades();
                ModelState.AddModelError("", "Erro ao cadastrar médico: " + ex.Message);
                return View(vm);
            }
        }
    }   
}

