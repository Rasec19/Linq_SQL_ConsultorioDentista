namespace LINQ_SQL_Consultorio
{
    partial class Form_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Menu));
            this.btnMenuDentistas = new System.Windows.Forms.Button();
            this.btnMenuCitas = new System.Windows.Forms.Button();
            this.btnMenuEspe = new System.Windows.Forms.Button();
            this.btnMenuPacientes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Consultorio = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMenuDentistas
            // 
            this.btnMenuDentistas.BackColor = System.Drawing.SystemColors.Window;
            this.btnMenuDentistas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMenuDentistas.BackgroundImage")));
            this.btnMenuDentistas.Location = new System.Drawing.Point(45, 103);
            this.btnMenuDentistas.Name = "btnMenuDentistas";
            this.btnMenuDentistas.Size = new System.Drawing.Size(139, 132);
            this.btnMenuDentistas.TabIndex = 0;
            this.btnMenuDentistas.UseVisualStyleBackColor = false;
            this.btnMenuDentistas.Click += new System.EventHandler(this.btnMenuDentistas_Click);
            // 
            // btnMenuCitas
            // 
            this.btnMenuCitas.BackColor = System.Drawing.SystemColors.Window;
            this.btnMenuCitas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMenuCitas.BackgroundImage")));
            this.btnMenuCitas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMenuCitas.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuCitas.Image")));
            this.btnMenuCitas.Location = new System.Drawing.Point(207, 103);
            this.btnMenuCitas.Name = "btnMenuCitas";
            this.btnMenuCitas.Size = new System.Drawing.Size(139, 132);
            this.btnMenuCitas.TabIndex = 1;
            this.btnMenuCitas.UseVisualStyleBackColor = false;
            this.btnMenuCitas.Click += new System.EventHandler(this.btnMenuCitas_Click);
            // 
            // btnMenuEspe
            // 
            this.btnMenuEspe.BackColor = System.Drawing.SystemColors.Window;
            this.btnMenuEspe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMenuEspe.BackgroundImage")));
            this.btnMenuEspe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMenuEspe.Location = new System.Drawing.Point(387, 101);
            this.btnMenuEspe.Name = "btnMenuEspe";
            this.btnMenuEspe.Size = new System.Drawing.Size(139, 134);
            this.btnMenuEspe.TabIndex = 2;
            this.btnMenuEspe.UseVisualStyleBackColor = false;
            this.btnMenuEspe.Click += new System.EventHandler(this.btnMenuEspe_Click);
            // 
            // btnMenuPacientes
            // 
            this.btnMenuPacientes.BackColor = System.Drawing.SystemColors.Window;
            this.btnMenuPacientes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMenuPacientes.BackgroundImage")));
            this.btnMenuPacientes.Location = new System.Drawing.Point(582, 103);
            this.btnMenuPacientes.Name = "btnMenuPacientes";
            this.btnMenuPacientes.Size = new System.Drawing.Size(130, 134);
            this.btnMenuPacientes.TabIndex = 3;
            this.btnMenuPacientes.UseVisualStyleBackColor = false;
            this.btnMenuPacientes.Click += new System.EventHandler(this.btnMenuPacientes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dentistas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(239, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Citas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(357, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Especialidades";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(585, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Pacientes";
            // 
            // Consultorio
            // 
            this.Consultorio.AutoSize = true;
            this.Consultorio.Font = new System.Drawing.Font("Lucida Sans Typewriter", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consultorio.Location = new System.Drawing.Point(261, 25);
            this.Consultorio.Name = "Consultorio";
            this.Consultorio.Size = new System.Drawing.Size(226, 37);
            this.Consultorio.TabIndex = 8;
            this.Consultorio.Text = "Consultorio";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(326, 322);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(90, 36);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.Consultorio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMenuPacientes);
            this.Controls.Add(this.btnMenuEspe);
            this.Controls.Add(this.btnMenuCitas);
            this.Controls.Add(this.btnMenuDentistas);
            this.Name = "Form_Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMenuDentistas;
        private System.Windows.Forms.Button btnMenuCitas;
        private System.Windows.Forms.Button btnMenuEspe;
        private System.Windows.Forms.Button btnMenuPacientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Consultorio;
        private System.Windows.Forms.Button btnCerrar;
    }
}