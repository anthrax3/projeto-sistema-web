using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Ftec.Cadastro.Site.Factory;
using Ftec.Cadastro.Site.Models;
using Newtonsoft.Json;

namespace Ftec.Cadastro.Site.Controllers
{
    public class ProdutoController : Controller
    {
        const string SessionKeyList = "_Produto";

        // [Route("prod")]
        public IActionResult Index()
        {
            // var produtos = Factory.MoqFactory.GerarListaProdutos(10);

            var json = HttpContext.Session.GetString(SessionKeyList);

            // ViewBag - Destinado para transferir qualquer tipo de dado
            // da camada de controller para a view
            ViewBag.produtos = json == null ? new List<Produto>() : JsonConvert.DeserializeObject<List<Produto>>(json);

            return View();
        }

        // [HttpGet("prod1", Name = "novoregistro")]
        public IActionResult Novo()
        {
           var categorias = Factory.MoqFactory.GerarListaCategorias(5);

            ViewBag.categorias = categorias;

            return View();
        }

        [HttpPost] // Data Anotation - Utilizada para definir uma regra.
        public IActionResult Gravar(Produto produto)
        {
            // Cria uma variável de sessão contendo o produto.
            //Session["produto"] = produto;

            // Recuperar o produto da sessão
            // O retorno é um Objeto e neste caso é necessário
            // fazer um cast (convertendo o objeto para o tipo Produto)
            //produto = (Produto)Sessio["produto"];

            // Encerrar uma sessão
            //Session.Abandon();

            var json = HttpContext.Session.GetString(SessionKeyList);

            List<Produto> produtos = json == null ? new List<Produto>() : JsonConvert.DeserializeObject<List<Produto>>(json);

            var item = produtos.Where(p => p.Id == produto.Id).FirstOrDefault();

            if (item == null)
               produtos.Add(produto);
            else
            {
                //modifica os dados do produto encontrado
                item.Nome = produto.Nome;
                item.CategoriaId = produto.CategoriaId;
                item.Nome = produto.Nome;
                item.Preco = produto.Preco;
                item.Quantidade = produto.Quantidade;

            }


            HttpContext.Session.SetString(SessionKeyList, JsonConvert.SerializeObject(produtos));

            // Executa uma ação
            return RedirectToAction("Index");
        }

        // [HttpGet("prod2/{id}", Name = "editar")]
        public IActionResult Editar(Guid id)
        {
            ViewBag.Title = "Produtos";

            var json = HttpContext.Session.GetString(SessionKeyList);

            List<Produto> produtos = json == null ? new List<Produto>() : JsonConvert.DeserializeObject<List<Produto>>(json);

            foreach(Produto prod in produtos)
            {
                if (prod.Id == id)
                {
                    ViewBag.produto = prod;
                }
            }

            var categorias = Factory.MoqFactory.GerarListaCategorias(5);

            ViewBag.categorias = categorias;

            return View();
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