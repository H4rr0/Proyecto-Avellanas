using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class Carreras
    {
        public Carreras()
        {
            Cursos = new HashSet<Cursos>();
        }

        public string IdCarrera { get; set; }
        public string IdPersona { get; set; }
        public string NombreCarrera { get; set; }

        public ApplicationUser IdPersonaNavigation { get; set; }
        public ICollection<Cursos> Cursos { get; set; }
    }
}
