namespace ManipulandoDatosGUI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.Panel();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.buttonServicio = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonProfesor = new System.Windows.Forms.Button();
            this.buttonEstudiante = new System.Windows.Forms.Button();
            this.buttonReservas = new System.Windows.Forms.Button();
            this.buttonCapacidadVuelo = new System.Windows.Forms.Button();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.Window;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(211, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(589, 450);
            this.mainPanel.TabIndex = 3;
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.SystemColors.Window;
            this.menuPanel.Controls.Add(this.buttonServicio);
            this.menuPanel.Controls.Add(this.pictureBox1);
            this.menuPanel.Controls.Add(this.buttonProfesor);
            this.menuPanel.Controls.Add(this.buttonEstudiante);
            this.menuPanel.Controls.Add(this.buttonReservas);
            this.menuPanel.Controls.Add(this.buttonCapacidadVuelo);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(211, 450);
            this.menuPanel.TabIndex = 2;
            // 
            // buttonServicio
            // 
            this.buttonServicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonServicio.AutoSize = true;
            this.buttonServicio.BackColor = System.Drawing.SystemColors.Window;
            this.buttonServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonServicio.Location = new System.Drawing.Point(3, 270);
            this.buttonServicio.Margin = new System.Windows.Forms.Padding(10);
            this.buttonServicio.Name = "buttonServicio";
            this.buttonServicio.Size = new System.Drawing.Size(205, 27);
            this.buttonServicio.TabIndex = 5;
            this.buttonServicio.Text = "Servicio";
            this.buttonServicio.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Image = global::ManipulandoDatosGUI.Properties.Resources.download;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // buttonProfesor
            // 
            this.buttonProfesor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProfesor.AutoSize = true;
            this.buttonProfesor.BackColor = System.Drawing.SystemColors.Window;
            this.buttonProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProfesor.Location = new System.Drawing.Point(3, 176);
            this.buttonProfesor.Margin = new System.Windows.Forms.Padding(10);
            this.buttonProfesor.Name = "buttonProfesor";
            this.buttonProfesor.Size = new System.Drawing.Size(205, 27);
            this.buttonProfesor.TabIndex = 3;
            this.buttonProfesor.Text = "Profesor";
            this.buttonProfesor.UseVisualStyleBackColor = false;
            // 
            // buttonEstudiante
            // 
            this.buttonEstudiante.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEstudiante.AutoSize = true;
            this.buttonEstudiante.BackColor = System.Drawing.SystemColors.Window;
            this.buttonEstudiante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEstudiante.Location = new System.Drawing.Point(3, 223);
            this.buttonEstudiante.Margin = new System.Windows.Forms.Padding(10);
            this.buttonEstudiante.Name = "buttonEstudiante";
            this.buttonEstudiante.Size = new System.Drawing.Size(205, 27);
            this.buttonEstudiante.TabIndex = 2;
            this.buttonEstudiante.Text = "Estudiante";
            this.buttonEstudiante.UseVisualStyleBackColor = false;
            // 
            // buttonReservas
            // 
            this.buttonReservas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReservas.AutoSize = true;
            this.buttonReservas.BackColor = System.Drawing.SystemColors.Window;
            this.buttonReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReservas.Location = new System.Drawing.Point(3, 131);
            this.buttonReservas.Margin = new System.Windows.Forms.Padding(10);
            this.buttonReservas.Name = "buttonReservas";
            this.buttonReservas.Size = new System.Drawing.Size(205, 27);
            this.buttonReservas.TabIndex = 1;
            this.buttonReservas.Text = "Reservas";
            this.buttonReservas.UseVisualStyleBackColor = false;
            this.buttonReservas.Click += new System.EventHandler(this.buttonReservas_Click);
            // 
            // buttonCapacidadVuelo
            // 
            this.buttonCapacidadVuelo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCapacidadVuelo.AutoSize = true;
            this.buttonCapacidadVuelo.BackColor = System.Drawing.SystemColors.Window;
            this.buttonCapacidadVuelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCapacidadVuelo.Location = new System.Drawing.Point(3, 84);
            this.buttonCapacidadVuelo.Margin = new System.Windows.Forms.Padding(10);
            this.buttonCapacidadVuelo.Name = "buttonCapacidadVuelo";
            this.buttonCapacidadVuelo.Size = new System.Drawing.Size(205, 27);
            this.buttonCapacidadVuelo.TabIndex = 0;
            this.buttonCapacidadVuelo.Text = "Capacidad Vuelo";
            this.buttonCapacidadVuelo.UseVisualStyleBackColor = false;
            this.buttonCapacidadVuelo.Click += new System.EventHandler(this.ButtonCapacidadVuelo_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menuPanel);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Gestionar Reservas";
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel mainPanel;
        private Panel menuPanel;
        private Button buttonServicio;
        private PictureBox pictureBox1;
        private Button buttonProfesor;
        private Button buttonEstudiante;
        private Button buttonReservas;
        private Button buttonCapacidadVuelo;
    }
}