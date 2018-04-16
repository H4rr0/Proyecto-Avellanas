using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class Ventanas
    {
        public Ventanas()
        {
            VentanasXperfil = new HashSet<VentanasXperfil>();
        }

        public string IdVentana { get; set; }
        public string Descripcion { get; set; }

        public ICollection<VentanasXperfil> VentanasXperfil { get; set; }
    }
}
