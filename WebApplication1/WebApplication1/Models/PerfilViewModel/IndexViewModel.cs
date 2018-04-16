using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.PerfilViewModel
{
    public class IndexViewModel
    {

        public string Cedula { get; set; }
        public string Carnet { get; set; }
        public string Correo { get; set; }
        public string Genero { get; set; }
        [Display(Name="Tipo" )]
        public string TipoPersona { get; set; }
        [Display(Name = "Nombre Completo")]
        public string NombreCompleto { get; set; }
        public string Pais { get; set; }

        //public ICollection<TipoPersona> Tipos { get; set; }

        //public string Password { get; set; }
        //public string GrupoIdGrupo { get; set; }


    }
}
