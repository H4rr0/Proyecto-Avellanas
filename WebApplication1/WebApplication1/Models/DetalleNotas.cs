using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class DetalleNotas
    {
        public string IdDetalleNota { get; set; }
        public string IdHistorico { get; set; }
        public string IdRubro { get; set; }
        public int Porcentajeganado { get; set; }

        public Notas IdHistoricoNavigation { get; set; }
        public Rubros IdRubroNavigation { get; set; }
    }
}
