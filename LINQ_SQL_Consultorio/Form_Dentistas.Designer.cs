namespace LINQ_SQL_Consultorio
{
    partial class Form_Dentistas
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgVisualizarDentistas = new System.Windows.Forms.DataGridView();
            this.btnMostrarDentistas = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.cmbDentistas = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVisualizarDentistas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgVisualizarDentistas);
            this.groupBox1.Location = new System.Drawing.Point(0, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(699, 245);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dentistas";
            // 
            // dgVisualizarDentistas
            // 
            this.dgVisualizarDentistas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgVisualizarDentistas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgVisualizarDentistas.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgVisualizarDentistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVisualizarDentistas.Location = new System.Drawing.Point(6, 19);
            this.dgVisualizarDentistas.Name = "dgVisualizarDentistas";
            this.dgVisualizarDentistas.Size = new System.Drawing.Size(687, 220);
            this.dgVisualizarDentistas.TabIndex = 0;
            // 
            // btnMostrarDentistas
            // 
            this.btnMostrarDentistas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarDentistas.Location = new System.Drawing.Point(262, 267);
            this.btnMostrarDentistas.Name = "btnMostrarDentistas";
            this.btnMostrarDentistas.Size = new System.Drawing.Size(165, 26);
            this.btnMostrarDentistas.TabIndex = 1;
            this.btnMostrarDentistas.Text = "Mostrar Info General";
            this.btnMostrarDentistas.UseVisualStyleBackColor = true;
            this.btnMostrarDentistas.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(305, 313);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 26);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // cmbDentistas
            // 
            this.cmbDentistas.FormattingEnabled = true;
            this.cmbDentistas.Location = new System.Drawing.Point(461, 267);
            this.cmbDentistas.Name = "cmbDentistas";
            this.cmbDentistas.Size = new System.Drawing.Size(198, 21);
            this.cmbDentistas.TabIndex = 3;
            this.cmbDentistas.SelectedIndexChanged += new System.EventHandler(this.cmbDentistas_SelectedIndexChanged);
            this.cmbDentistas.SelectionChangeCommitted += new System.EventHandler(this.cmbDentistas_SelectionChangeCommitted);
            // 
            // Form_Dentistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(699, 450);
            this.Controls.Add(this.cmbDentistas);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnMostrarDentistas);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_Dentistas";
            this.Text = "Dentistas";
            this.Load += new System.EventHandler(this.Form_Dentistas_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgVisualizarDentistas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgVisualizarDentistas;
        private System.Windows.Forms.Button btnMostrarDentistas;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ComboBox cmbDentistas;
    }
}

