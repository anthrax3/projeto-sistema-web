using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Ftec.Cadastro.Site.Factory;
using Ftec.Cadastro.Site.Models;
using Ftec.Cadastro.Site.Session;
// using Newtonsoft.Json;

namespace Ftec.Cadastro.Site.Controllers
{
    public class ProdutoController : Controller
    {
        const string SessionKeyDate = "_Date";
        // const string SessionKeyList = "_Produto";

        public IActionResult Index()
        {
            var produtos = Factory.MoqFactory.GerarListaProdutos(10);

            HttpContext.Session.Set<DateTime>(SessionKeyDate, DateTime.Now);

            // ViewBag - Destinado para transferir qualquer tipo de dado
            // da camada de controller para a view
            ViewBag.produtos = produtos;

            HttpContext.Session.SetString(SessionKeyList, JsonConvert.SerializeObject(produtos));

            return View();
        }

        public IActionResult Novo()
        {
            var categorias = Factory.MoqFactory.GerarListaCategorias(5);

            ViewBag.categorias = categorias;

            ViewBag.date = HttpContext.Session.Get<DateTime>(SessionKeyDate);

            var json = HttpContext.Session.GetString(SessionKeyList);

            ViewBag.produtos = json == null ? new List<Produto>() : JsonConvert.DeserializeObject(json);

            return View();
        }

        [HttpPost] // Data Anotation - Utilizada para definir uma regra.
        public IActionResult Gravar(Produto produto)
        {

            List<Produto> produtos = new List<Produto>();

            produtos.Add(produto);

            // Cria uma variável de sessão contendo o produto.
            //Session["produto"] = produto;

            // Recuperar o produto da sessão
            // O retorno é um Objeto e neste caso é necessário
            // fazer um cast (convertendo o objeto para o tipo Produto)
            //produto = (Produto)Sessio["produto"];

            // Encerrar uma sessão
            //Session.Abandon();

            HttpContext.Session.Set<List>("produtos", produtos);

            // Executa uma ação
            return RedirectToAction("Index");
        }
    }

    /*public static class SessionExtensions {
        public static void Set<T>(this ISession session, string key, T value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static T Get<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }
    }*/
}