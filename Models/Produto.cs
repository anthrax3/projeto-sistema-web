// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;
// using System.ComponentModel.DataAnnotations;

// namespace Ftec.Cadastro.Site.Models
// {
//     public class Produto : Base
//     {
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Ftec.Cadastro.Site.Models
{
    public class Produto : Base
    {
        public Produto() {
            Id = Guid.NewGuid();
        }

        [Required]
        [StringLength(255)]
        public string Nome { get; set; }

        [Required]
        public decimal Preco { get; set; }

        [Required]
        [StringLength(500)]
        public string Descricao { get; set; }

        [Required]
        public int Quantidade { get; set; }

        [Required]
        public Guid CategoriaId { get; set; }
    }
}
