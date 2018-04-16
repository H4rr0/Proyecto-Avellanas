using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.Persona_por_tipo
{
    public class CrearViewModel
    {
        //combobox por mientras

        public ICollection<ApplicationUser> Persona { get; set; }

        [Required]
        [Display(Name = "Persona")]
        public string PersonaSelecionada { get; set; }

        public ICollection<TipoPersona> TipoPersona { get; set; }

        [Required]
        [Display(Name = "Tipo Persona")]
        public string TipoPersonaSelecionada { get; set; }

    }
}
