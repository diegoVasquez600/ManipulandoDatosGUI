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
    public partial class UserControlCapacidadVuelo : UserControl
    {
        private readonly CapacidadDTO capacidadDTO;
        public UserControlCapacidadVuelo()
        {
            InitializeComponent();
            capacidadDTO = new();
        }

        private void buttonCapacidad_Click(object sender, EventArgs e)
        {
            capacidadDTO.CargarCapacidadVuelo(int.Parse(capacidadVuelo.Value.ToString()));
        }
    }
}
