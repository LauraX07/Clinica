using Microsoft.AspNetCore.Mvc;

namespace Clinica.Controllers
{
    public class LoginP : Controller
    {
        public IActionResult LoginPaciente()
        {
            return View();
        }
    }
}
