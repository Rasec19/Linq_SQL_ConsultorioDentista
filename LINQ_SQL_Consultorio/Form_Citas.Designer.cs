namespace LINQ_SQL_Consultorio
{
    partial class Form_Citas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgVisualizarCitas = new System.Windows.Forms.DataGridView();
            this.btnMostrarCitas = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.cmbCitas = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVisualizarCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgVisualizarCitas);
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(699, 245);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Citas";
            // 
            // dgVisualizarCitas
            // 
            this.dgVisualizarCitas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgVisualizarCitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgVisualizarCitas.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgVisualizarCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVisualizarCitas.Location = new System.Drawing.Point(6, 19);
            this.dgVisualizarCitas.Name = "dgVisualizarCitas";
            this.dgVisualizarCitas.Size = new System.Drawing.Size(687, 220);
            this.dgVisualizarCitas.TabIndex = 0;
            // 
            // btnMostrarCitas
            // 
            this.btnMostrarCitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarCitas.Location = new System.Drawing.Point(261, 278);
            this.btnMostrarCitas.Name = "btnMostrarCitas";
            this.btnMostrarCitas.Size = new System.Drawing.Size(178, 26);
            this.btnMostrarCitas.TabIndex = 2;
            this.btnMostrarCitas.Text = "Mostrar Info General";
            this.btnMostrarCitas.UseVisualStyleBackColor = true;
            this.btnMostrarCitas.Click += new System.EventHandler(this.btnMostrarCitas_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(307, 327);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 26);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // cmbCitas
            // 
            this.cmbCitas.FormattingEnabled = true;
            this.cmbCitas.Location = new System.Drawing.Point(476, 278);
            this.cmbCitas.Name = "cmbCitas";
            this.cmbCitas.Size = new System.Drawing.Size(198, 21);
            this.cmbCitas.TabIndex = 4;
            this.cmbCitas.SelectionChangeCommitted += new System.EventHandler(this.cmbCitas_SelectionChangeCommitted);
            // 
            // Form_Citas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(701, 450);
            this.Controls.Add(this.cmbCitas);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnMostrarCitas);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_Citas";
            this.Text = "Citas";
            this.Load += new System.EventHandler(this.Form_Citas_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgVisualizarCitas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgVisualizarCitas;
        private System.Windows.Forms.Button btnMostrarCitas;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ComboBox cmbCitas;
    }
}