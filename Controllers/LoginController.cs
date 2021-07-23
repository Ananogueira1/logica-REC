using System.Collections.Generic;
using logica2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace logica_REC_main.Controllers
{

    [Route("Login")]
    public class LoginController : Controller
    {

        Musico m1 = new Musico();
        public IActionResult Index()
        {
            return View();
        }

        [Route("Logar")]
        public IActionResult Logar(IFormCollection form)
        {
            List<string> csv =m1.ReadAllLinesCSV("DataBase/Musico.csv");

            var Logado =
            csv.Find(
                x =>
                x.Split(";")[1] == form["Email"] &&
                x.Split(";")[2] == form["Senha"]
            );

            if (Logado != null)
            {
                return LocalRedirect("~/");
            }

            return LocalRedirect("~/Login");
        }
    }


}