using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class Matricula
    {
        public Matricula()
        {
            DetalleMatricula = new HashSet<DetalleMatricula>();
        }

        public string IdMatricula { get; set; }
        public string Creidtomatriculado { get; set; }
        public DateTime Fecha { get; set; }
        public string IdEstudiante { get; set; }
        public string IdMatriculante { get; set; }
        public string Monto { get; set; }
        public int Nota { get; set; }
        public string Periodo { get; set; }

        public ApplicationUser IdEstudianteNavigation { get; set; }
        public ApplicationUser IdMatriculanteNavigation { get; set; }
        public ICollection<DetalleMatricula> DetalleMatricula { get; set; }
    }
}
