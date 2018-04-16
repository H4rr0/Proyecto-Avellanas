using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class Rubros
    {
        public Rubros()
        {
            DetalleNotas = new HashSet<DetalleNotas>();
        }

        public string IdRubro { get; set; }
        public string IdCarrera { get; set; }
        public string IdCurso { get; set; }
        public string NombreRubro { get; set; }
        public int Porcentaje { get; set; }
        public string GrupoIdGrupo { get; set; }

        public Grupos GrupoIdGrupoNavigation { get; set; }
        public Cursos IdC { get; set; }
        public ICollection<DetalleNotas> DetalleNotas { get; set; }
    }
}
