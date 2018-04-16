using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class PersonaXtipo
    {
        public PersonaXtipo()
        {
            Notas = new HashSet<Notas>();
        }

        public string IdPersona { get; set; }
        public string IdTipoPersona { get; set; }

        public ApplicationUser IdPersonaNavigation { get; set; }
        public TipoPersona IdTipoPersonaNavigation { get; set; }
        public ICollection<Notas> Notas { get; set; }
    }
}
