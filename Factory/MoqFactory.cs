using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RandomTestValues;
using Ftec.Cadastro.Site.Models;

namespace Ftec.Cadastro.Site.Factory
{
    public class MoqFactory
    {
        public static List<Models.Produto> GerarListaProdutos(int quantidadeProdutos) 
        {
            List<Produto> produtos;

            produtos = RandomValue.List<Produto>(quantidadeProdutos);

            return produtos;
        }

        public static List<Models.CategoriaDoProduto> GerarListaCategorias(int quantidade) 
        {
            List<CategoriaDoProduto> categorias;

            categorias = RandomValue.List<CategoriaDoProduto>(quantidade);

            return categorias;
        }
    }
}