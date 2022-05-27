namespace ManipulandoDatosGUI.View
{
    partial class UserControlReservas
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabDisponibles = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabReservados = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.tabDisponibles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(246, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reservas";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabDisponibles);
            this.tabControl.Controls.Add(this.tabReservados);
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl.Location = new System.Drawing.Point(13, 48);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(563, 389);
            this.tabControl.TabIndex = 2;
            // 
            // tabDisponibles
            // 
            this.tabDisponibles.Controls.Add(this.dataGridView1);
            this.tabDisponibles.Location = new System.Drawing.Point(4, 30);
            this.tabDisponibles.Name = "tabDisponibles";
            this.tabDisponibles.Padding = new System.Windows.Forms.Padding(3);
            this.tabDisponibles.Size = new System.Drawing.Size(555, 355);
            this.tabDisponibles.TabIndex = 0;
            this.tabDisponibles.Text = "Disponibles";
            this.tabDisponibles.UseVisualStyleBackColor = true;
            this.tabDisponibles.Click += new System.EventHandler(this.tabDisponibles_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(549, 349);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabReservados
            // 
            this.tabReservados.Location = new System.Drawing.Point(4, 30);
            this.tabReservados.Name = "tabReservados";
            this.tabReservados.Padding = new System.Windows.Forms.Padding(3);
            this.tabReservados.Size = new System.Drawing.Size(555, 355);
            this.tabReservados.TabIndex = 1;
            this.tabReservados.Text = "Reservados";
            this.tabReservados.UseVisualStyleBackColor = true;
            // 
            // UserControlReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.label1);
            this.Name = "UserControlReservas";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(589, 450);
            this.tabControl.ResumeLayout(false);
            this.tabDisponibles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private TabControl tabControl;
        private TabPage tabDisponibles;
        private TabPage tabReservados;
        private DataGridView dataGridView1;
    }
}
