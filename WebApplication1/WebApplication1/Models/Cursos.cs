using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class Cursos
    {
        public Cursos()
        {
            DetalleMatricula = new HashSet<DetalleMatricula>();
            Grupos = new HashSet<Grupos>();
            Notas = new HashSet<Notas>();
            Rubros = new HashSet<Rubros>();
        }

        public string IdCurso { get; set; }
        public string IdCarrera { get; set; }
        public int Creditos { get; set; }
        public string Descripcion { get; set; }
        public int Estado { get; set; }
        public string IdMateriarequerida { get; set; }
        public string IdPersona { get; set; }
        public int Precio { get; set; }

        public Carreras IdCarreraNavigation { get; set; }
        public ICollection<DetalleMatricula> DetalleMatricula { get; set; }
        public ICollection<Grupos> Grupos { get; set; }
        public ICollection<Notas> Notas { get; set; }
        public ICollection<Rubros> Rubros { get; set; }
    }
}
