using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace WebApplication1.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            AsistenciaEstudiantes = new HashSet<AsistenciaEstudiantes>();
            AsistenciaProfesor = new HashSet<AsistenciaProfesor>();
            Carreras = new HashSet<Carreras>();
            MatriculaIdEstudianteNavigation = new HashSet<Matricula>();
            MatriculaIdMatriculanteNavigation = new HashSet<Matricula>();
            Notas = new HashSet<Notas>();
            PersonaXtipo = new HashSet<PersonaXtipo>();
        }

        public string Cedula { get; set; }
        public string Carnet { get; set; }
        public string Ciudad { get; set; }
        public string Correo { get; set; }
        public string Genero { get; set; }
        public string TipoPersonaId { get; set; }
        public string NombreCompleto { get; set; }
        public string Pais { get; set; }
        public string Password { get; set; }
        public string GrupoIdGrupo { get; set; }

        public Grupos GrupoIdGrupoNavigation { get; set; }
        public TipoPersona IdTipoPersonaNavigation { get; set; }
        public ICollection<AsistenciaEstudiantes> AsistenciaEstudiantes { get; set; }
        public ICollection<AsistenciaProfesor> AsistenciaProfesor { get; set; }
        public ICollection<Carreras> Carreras { get; set; }
        public ICollection<Matricula> MatriculaIdEstudianteNavigation { get; set; }
        public ICollection<Matricula> MatriculaIdMatriculanteNavigation { get; set; }
        public ICollection<Notas> Notas { get; set; }
        public ICollection<PersonaXtipo> PersonaXtipo { get; set; }
    }
}
