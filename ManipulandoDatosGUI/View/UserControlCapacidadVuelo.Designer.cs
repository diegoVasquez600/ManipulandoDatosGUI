namespace ManipulandoDatosGUI.View
{
    partial class UserControlCapacidadVuelo
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.capacidadVuelo = new System.Windows.Forms.NumericUpDown();
            this.buttonCapacidad = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCapacidad = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.capacidadVuelo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(182, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Capacidad Vuelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresa Capacidad Vuelo";
            // 
            // capacidadVuelo
            // 
            this.capacidadVuelo.Location = new System.Drawing.Point(177, 223);
            this.capacidadVuelo.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.capacidadVuelo.Name = "capacidadVuelo";
            this.capacidadVuelo.Size = new System.Drawing.Size(168, 23);
            this.capacidadVuelo.TabIndex = 3;
            this.capacidadVuelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.capacidadVuelo.ThousandsSeparator = true;
            // 
            // buttonCapacidad
            // 
            this.buttonCapacidad.Location = new System.Drawing.Point(193, 270);
            this.buttonCapacidad.Name = "buttonCapacidad";
            this.buttonCapacidad.Size = new System.Drawing.Size(137, 23);
            this.buttonCapacidad.TabIndex = 4;
            this.buttonCapacidad.Text = "Ingresar Capacidad";
            this.buttonCapacidad.UseVisualStyleBackColor = true;
            this.buttonCapacidad.Click += new System.EventHandler(this.buttonCapacidad_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Capacidad Actual";
            // 
            // labelCapacidad
            // 
            this.labelCapacidad.AutoSize = true;
            this.labelCapacidad.Location = new System.Drawing.Point(254, 167);
            this.labelCapacidad.Name = "labelCapacidad";
            this.labelCapacidad.Size = new System.Drawing.Size(13, 15);
            this.labelCapacidad.TabIndex = 6;
            this.labelCapacidad.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(193, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Ir a Reservas";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // UserControlCapacidadVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelCapacidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonCapacidad);
            this.Controls.Add(this.capacidadVuelo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserControlCapacidadVuelo";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(589, 450);
            ((System.ComponentModel.ISupportInitialize)(this.capacidadVuelo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private NumericUpDown capacidadVuelo;
        private Button buttonCapacidad;
        private Label label3;
        private Label labelCapacidad;
        private Button button1;
    }
}
