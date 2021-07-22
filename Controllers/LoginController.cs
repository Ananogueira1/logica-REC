using Microsoft.AspNetCore.Mvc;

namespace logica_REC_main.Controllers
{

    [Route("Login")]
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}