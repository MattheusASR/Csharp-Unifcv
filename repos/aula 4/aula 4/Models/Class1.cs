using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aula_4.Models
{
    public class Aluno
    {
        public int ID { get; set; }
        public string nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Fone { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string cep { get; set; }

        public virtual ICollection<Matricula>
            Matriculas { get; set; }
    }
}