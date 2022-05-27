using ManipulandoDatosGUI.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManipulandoDatosGUI.View
{
    public partial class UserControlReservas : UserControl
    {
        private CapacidadDTO capacidad;
        public UserControlReservas()
        {
            InitializeComponent();
            capacidad = new CapacidadDTO();
        }

        private void tabDisponibles_Click(object sender, EventArgs e)
        {
            capacidad.MostrarDsponibles();
        }
    }
}
