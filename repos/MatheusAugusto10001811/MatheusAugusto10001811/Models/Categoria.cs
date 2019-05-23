using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MatheusAugusto10001811.Models
{
    public class Categoria
    {
        public int CategoriaID { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Produto> Produtos { get; set; }

    }
}