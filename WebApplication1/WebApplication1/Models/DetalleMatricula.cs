using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class DetalleMatricula
    {
        public string IdDetalleMatricula { get; set; }
        public string IdCarrera { get; set; }
        public string IdCurso { get; set; }
        public string IdMatricula { get; set; }
        public int Nota { get; set; }
        public int Submonto { get; set; }

        public Cursos IdC { get; set; }
        public Matricula IdMatriculaNavigation { get; set; }
    }
}
