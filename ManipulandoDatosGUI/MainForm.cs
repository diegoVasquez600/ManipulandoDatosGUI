using ManipulandoDatosGUI.View;

namespace ManipulandoDatosGUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ButtonCapacidadVuelo_Click(object sender, EventArgs e)
        {
           UserControlCapacidadVuelo vuelo = new();
           CargarUserControl(vuelo);

        }

        private void buttonReservas_Click(object sender, EventArgs e)
        {
            UserControlReservas reservas = new();
            CargarUserControl(reservas);
        }


        private void CargarUserControl(UserControl userControl)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(userControl);
        }
    }
}