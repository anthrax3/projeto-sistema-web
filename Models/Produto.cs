using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Ftec.Cadastro.Site.Models
{
    public class Produto : Base
    {
        // private in id;

        // public int GetId() {
        //     return id;
        // }

        // public void SetId(int id) {
        //     this.id = id;
        // }

        // Fere o conceito de POO
        // private int id;

        // public int Id {
        //     get {
        //         return id;
        //     }
        //     set {
        //         if (value = 0)
        //             throw new Expection('Valor invalido');
        //         id = value;
        //     }
        // }
        public Produto() {
            Id = Guid.NewGuid();
        }

        public string Nome { get; set; }

        public decimal Preco { get; set; }

        public string Descricao { get; set; }

        public int Quantidade { get; set; }
        
        public Guid CategoriaId { get; set; }
    }
}