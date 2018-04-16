using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class Grupos
    {
        public Grupos()
        {
            AsistenciaEstudiantes = new HashSet<AsistenciaEstudiantes>();
            AsistenciaProfesor = new HashSet<AsistenciaProfesor>();
            Persona = new HashSet<ApplicationUser>();
            Rubros = new HashSet<Rubros>();
        }

        public string IdGrupo { get; set; }
        public string Descripcion { get; set; }
        public string IdCarrera { get; set; }
        public string IdCurso { get; set; }
        public string IdHorario { get; set; }

        public Cursos IdC { get; set; }
        public ICollection<AsistenciaEstudiantes> AsistenciaEstudiantes { get; set; }
        public ICollection<AsistenciaProfesor> AsistenciaProfesor { get; set; }
        public ICollection<ApplicationUser> Persona { get; set; }
        public ICollection<Rubros> Rubros { get; set; }
    }
}
