using System;
using logica2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace logica_REC.Controllers
{
    public class CadastrarController : Controller
    {
        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection form)
        {
            Usuario novoUsuario = new Usuario();

            novoUsuario.Nome=form["Nome"];
            novoUsuario.Email = form["Email"];
            novoUsuario.Senha  = form["Senha"];

            return LocalRedirect("~/Usuario");
        }
    }
}