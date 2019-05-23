using System.Collections.Generic;

namespace aula_4.Models
{
    public class Curso
    {
        public int CursoID { get; set; }
        public string Nome { get; set; }
        public int CargaHoraria { get; set; }


        public virtual ICollection<Matricula>
            Matriculas { get; set; }
    }
}