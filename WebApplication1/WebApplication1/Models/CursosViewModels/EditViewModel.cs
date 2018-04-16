using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.CursosViewModels
{
    public class EditViewModel
	{
		[Display(Name = "Codigo del Curso")]
		public string IdCurso { get; set; }


        [Display(Name = "Identificacion del Curso")]
        public string IdCurso2 { get; set; }

        [Display(Name = "Codigo de Carrera")]
		public string CarreraId { get; set; }

		[Display(Name = "Nombre del Curso")]
		public string Descripcion { get; set; }

		[Display(Name = "Codigo de Materia Requerida")]
		public string IdMateriarequerida { get; set; }

		[Display(Name = "Cantidad de Creditos")]
		public int Creditos { get; set; }

		[Display(Name = "Estado del Curso")]
		public string Estado { get; set; }

		[Display(Name = "Precio del Curso")]
		public int Precio { get; set; }

		[Display(Name = "Código de Persona")]
		public string IdPersona { get; set; }

		[Display(Name = "Carreras")]
		public ICollection<Carreras> Carreras { get; set; }
		[Display(Name = "Detalle de Matricula")]
		public ICollection<DetalleMatricula> DetalleMatricula { get; set; }
		[Display(Name = "Detalle de Grupos")]
		public ICollection<Grupos> Grupos { get; set; }
		[Display(Name = "Detalle de Notas")]
		public ICollection<Notas> Notas { get; set; }
		[Display(Name = "Detalle de Rubros")]
		public ICollection<Rubros> Rubros { get; set; }
	}
}
