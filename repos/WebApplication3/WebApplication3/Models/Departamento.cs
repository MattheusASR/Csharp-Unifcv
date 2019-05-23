using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models

{
    public class Departamento
    {
        public int DepartamentoID { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Funcionario>
            Funcionarios { get; set; }
    }
}