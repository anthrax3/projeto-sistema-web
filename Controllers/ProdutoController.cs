using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ftec.Cadastro.Site.Factory;
using Ftec.Cadastro.Site.Models;

namespace Ftec.Cadastro.Site.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index() 
        {
            
            var produtos = Factory.MoqFactory.GerarListaProdutos(10);
            
            // win
            ViewBag.produtos = produtos;
            //ViewData["produtos"] = produtos;

            return View();
        }

        public IActionResult Novo() 
        {
            return View();
        }

        public IActionResult Gravar(string descricao, int quantidade) 
        {
            // Executa uma ação
            return RedirectToAction("Index");
        }
    }
}