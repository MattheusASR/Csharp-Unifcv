using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace MatheusAugusto10001811.Models
{
    public class Produto
    {
        public int ID { get; set; }
        public int CategoriaID { get; set; }
        public string Nome { get; set; }
        public string Descrição { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "0:dd/MM/yyyy",
            ApplyFormatInEditMode = true)]
        public DateTime DataValidade { get; set; }

        public virtual Categoria Categoria { get; set; }


    }
}