using Microsoft.AspNetCore.Mvc;

namespace Clinica.Controllers
{
    public class CadMedico : Controller
    {
        public IActionResult CadastroM()
        {
            return View();
        }
    }
}
