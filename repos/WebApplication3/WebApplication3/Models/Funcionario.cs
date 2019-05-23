using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class Funcionario
    {
        public int ID { get; set; }

        [StringLength(50, ErrorMessage =
            "Nome muito Longo")]
        public string Nome { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="0:dd/MM/yyyy",
            ApplyFormatInEditMode =true)]
        public DateTime DataNascimento { get; set; }

        public virtual Departamento 
            Departamento { get; set; }
    }
}