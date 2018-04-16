using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.CarrerasViewModel
{
    public class EditarViewModel
    {

        [StringLength(50)]
        [Display(Name = "Codigo Carrera")]
        public string Cod_Carrera { get; set; }

        [StringLength(50)]
        [Display(Name = "Persona Asignada")]
        public string IdPersona { get; set; }

        [Display(Name = "Cursos de la Carrera")]
        public ICollection<ApplicationUser> Personas { get; set; }


        [StringLength(50)]
        [Display(Name = "Nombre Carrera")]
        public string NombreCarrera { get; set; }

        [Display(Name = "Cursos de la Carrera")]
        public ICollection<Cursos> Cursos { get; set; }

        [Display(Name = "Carreras")]
        public ICollection<Carreras> Carreras { get; set; }

    }
}
