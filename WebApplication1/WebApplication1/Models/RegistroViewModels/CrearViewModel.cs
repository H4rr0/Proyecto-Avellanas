using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.RegistroViewModels
{
    public class CrearViewModel
    {

        //[Required]
        //[StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        //[DataType(DataType.Password)]
        //[Display(Name = "Contraseña")]
        //public string Password { get; set; }

        [Display(Name = "Cedula")]
        [StringLength(9, ErrorMessage = "Longitud debe ser de 9 caracteres")]
        public string IdPersona { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [Display(Name = "Primer Apellido")]
        [StringLength(50)]
        public string Apellido1 { get; set; }

        [Required]
        [Display(Name = "Segundo Apellido")]
        [StringLength(50)]
        public string Apellido2 { get; set; }

        //[Required]
        //public string Usuario { get; set; }

        [Required]
        [StringLength(50)]
        [EmailAddress]
        public string Correo { get; set; }


        //[Required]
        //[StringLength(50)]

        //public string Password { get; set; }

        [Required]
        public string Pais { get; set; }

        public ICollection<Pais> Paises { get; set; }

        public string Ciudad { get; set; }

        [Required]
        public string Carnet { get; set; }

        [Display(Name = "Tipo Persona")]
        [StringLength(50)]
        public string IdTipoPersona { get; set; }

        [Display(Name = "Carrera")]
        public string CarreraSeleccionada { get; set; }

        [Display(Name = "Tipo Persona")]
        public ICollection<TipoPersona> Tipos { get; set; }

        public ICollection<Carreras> Carreras { get; set; }

        [Required]
        public string Genero { get; set; }


    }

    public class Pais
    {
        public string Valor { get; set; }
        public string Nombre { get; set; }
    }
}

