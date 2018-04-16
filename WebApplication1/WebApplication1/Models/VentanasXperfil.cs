using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class VentanasXperfil
    {
        public string TipoPersona { get; set; }
        public string IdVentana { get; set; }

        public Ventanas IdVentanaNavigation { get; set; }
    }
}
