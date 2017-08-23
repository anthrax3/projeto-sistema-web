using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Ftec.Cadastro.Site.Models 
{
    public class CategoriaDoProduto : Base
    {
        public CategoriaDoProduto() {
            Id = Guid.NewGuid();
        }

        public string Nome { get; set; }

        public string Descricao { get; set; }
    }
}