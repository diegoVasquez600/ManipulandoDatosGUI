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
            mainPanel.Controls.Add(vuelo);

        }
    }
}