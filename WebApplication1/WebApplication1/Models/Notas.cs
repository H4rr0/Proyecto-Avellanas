using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class Notas
    {
        public Notas()
        {
            DetalleNotas = new HashSet<DetalleNotas>();
        }

        public string IdHistorico { get; set; }
        public string IdCurso { get; set; }
        public string IdPersona { get; set; }
        public string IdTipopersona { get; set; }
        public string Idcarrera { get; set; }
        public string IndEstado { get; set; }
        public int Nota { get; set; }
        public string Periodo { get; set; }

        public Cursos Id { get; set; }
        public PersonaXtipo IdNavigation { get; set; }
        public ApplicationUser IdPersonaNavigation { get; set; }
        public ICollection<DetalleNotas> DetalleNotas { get; set; }
    }
}
