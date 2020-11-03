namespace LINQ_SQL_Consultorio
{
    partial class Form_Especialidades
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
            this.dgVisualizarEspecialidades = new System.Windows.Forms.DataGridView();
            this.btnMostrarEspecialidades = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVisualizarEspecialidades)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgVisualizarEspecialidades);
            this.groupBox1.Location = new System.Drawing.Point(-1, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(699, 245);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Especialidades";
            // 
            // dgVisualizarEspecialidades
            // 
            this.dgVisualizarEspecialidades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgVisualizarEspecialidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgVisualizarEspecialidades.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgVisualizarEspecialidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVisualizarEspecialidades.Location = new System.Drawing.Point(6, 19);
            this.dgVisualizarEspecialidades.Name = "dgVisualizarEspecialidades";
            this.dgVisualizarEspecialidades.Size = new System.Drawing.Size(687, 220);
            this.dgVisualizarEspecialidades.TabIndex = 0;
            // 
            // btnMostrarEspecialidades
            // 
            this.btnMostrarEspecialidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarEspecialidades.Location = new System.Drawing.Point(264, 265);
            this.btnMostrarEspecialidades.Name = "btnMostrarEspecialidades";
            this.btnMostrarEspecialidades.Size = new System.Drawing.Size(171, 26);
            this.btnMostrarEspecialidades.TabIndex = 2;
            this.btnMostrarEspecialidades.Text = "Mostrar Info General";
            this.btnMostrarEspecialidades.UseVisualStyleBackColor = true;
            this.btnMostrarEspecialidades.Click += new System.EventHandler(this.btnMostrarEspecialidades_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(308, 306);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 26);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // Form_Especialidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnMostrarEspecialidades);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_Especialidades";
            this.Text = "Especialidades";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgVisualizarEspecialidades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgVisualizarEspecialidades;
        private System.Windows.Forms.Button btnMostrarEspecialidades;
        private System.Windows.Forms.Button btnVolver;
    }
}