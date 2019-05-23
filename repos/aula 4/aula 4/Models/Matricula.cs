using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;





namespace aula_4.Models
{


    public enum Turma
    {
        A, B, C, D, F
    }

    public class Matricula
    {
        public int MatriculaID { get; set; }
        public int CursoID { get; set; }
        public int AlunoID { get; set; }
        public Turma? Turma { get; set; }

        public virtual Aluno Aluno { get; set; }
        public virtual Curso Curso { get; set; }
    }


}