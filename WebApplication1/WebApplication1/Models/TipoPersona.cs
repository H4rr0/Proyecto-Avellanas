using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class TipoPersona
    {
        public TipoPersona()
        {
            Persona = new HashSet<ApplicationUser>();
            PersonaXtipo = new HashSet<PersonaXtipo>();
        }

        public string IdTipoPersona { get; set; }
        public string Descripción { get; set; }

        public ICollection<ApplicationUser> Persona { get; set; }
        public ICollection<PersonaXtipo> PersonaXtipo { get; set; }
    }
}
