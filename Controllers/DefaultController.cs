using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Ftec.Cadastro.Site.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Gravar()
        {
            return View("Listar");
        }

        public ActionResult ConfirmarGravar()
        {
            //return View("Index");
            return RedirectToAction("Index");
        }
    }
}