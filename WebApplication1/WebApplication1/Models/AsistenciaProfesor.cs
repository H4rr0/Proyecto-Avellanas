using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class AsistenciaProfesor
    {
        public string IdAsistencia { get; set; }
        public string Comentarios { get; set; }
        public int Estado { get; set; }
        public DateTime Horaingreso { get; set; }
        public DateTime Horasalida { get; set; }
        public string IdGrupo { get; set; }
        public string IdPersona { get; set; }

        public Grupos IdGrupoNavigation { get; set; }
        public ApplicationUser IdPersonaNavigation { get; set; }
    }
}
