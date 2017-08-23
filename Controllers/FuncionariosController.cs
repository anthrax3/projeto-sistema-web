using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Ftec.Cadastro.Site.Controllers
{
    public class FuncionariosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Listar()
        {
            return View();
        }

        public IActionResult Gravar()
        {
            return View();
        }

        public IActionResult Excluir()
        {
            return View();
        }

        public IActionResult Procurar()
        {
            return View();
        }
    }
}
