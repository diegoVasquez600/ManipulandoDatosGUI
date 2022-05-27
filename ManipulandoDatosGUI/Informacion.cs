using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulandoDatosGUI
{
    public partial class Informacion
    {
        public int IdInformacion { get; set; }
        public int Estado { get; set; }
        public string? Nombre { get; set; }
        public DateTime Fecha { get; set; }
    }
}
