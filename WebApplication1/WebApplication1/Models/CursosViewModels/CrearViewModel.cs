using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.CursosViewModels
{
	public class CrearViewModel
	{
		[Display(Name = "Codigo del Curso")]
		public string IdCurso { get; set; }

		[Display(Name = "Codigo de Carrera")]
		public string CarreraId { get; set; }

		[Display(Name = "Nombre del Curso")]
		public string Descripcion { get; set; }

		[Display(Name = "Codigo de Materia Requerida")]
		public string IdMateriarequerida { get; set; }

		[Display(Name = "Cantidad de Creditos")]
		public int Creditos { get; set; }

		[Display(Name = "Estado del Curso")]
		public int Estado { get; set; }

		[Display(Name = "Precio del Curso")]
		public int Precio { get; set; }

		[Display(Name = "Código de Persona")]
		public string IdPersona { get; set; }

		public ICollection<Carreras> CarrerasList { get; set; }
		public ICollection<DetalleMatricula> DetalleMatricula { get; set; }
		public ICollection<Grupos> Grupos { get; set; }
		public ICollection<Notas> Notas { get; set; }
		public ICollection<Rubros> Rubros { get; set; }
		public ICollection<Cursos> CursosRequerido { get; set; }
	}
}
