using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Ftec.Cadastro.Site.Controllers
{
    public class LoginController : Controller
    {
        const string SessionKeyLogin = "_Login";

        // GET: Default
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string usuario, string senha)
        {
            if (usuario == "ramon" && senha == "123") {
                // deu certo
                HttpContext.Session.SetString(SessionKeyLogin, usuario);
                return RedirectToAction("Index", "Produto");
            } else {
                // usuario e senhas incorretos
                return RedirectToAction("Index");
            }
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove(SessionKeyLogin);
            return RedirectToAction("Index");
        }

        public IActionResult LockScreen() 
        {
            HttpContext.Session.Remove(SessionKeyLogin);
            return View();
        }
    }
}