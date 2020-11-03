using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ_SQL_Consultorio
{
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent(
                   
                );
        }

        private void btnMenuDentistas_Click(object sender, EventArgs e)
        {
            Form_Dentistas fDentista = new Form_Dentistas();
            Form_Menu menu = new Form_Menu();
            fDentista.Show();
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnMenuEspe_Click(object sender, EventArgs e)
        {
            Form_Especialidades fEspe = new Form_Especialidades();
            Form_Menu menu = new Form_Menu();
            fEspe.Show();
            this.Hide();
        }

        private void btnMenuPacientes_Click(object sender, EventArgs e)
        {
            Form_Pacientes fEspe = new Form_Pacientes();
            Form_Menu menu = new Form_Menu();
            fEspe.Show();
            this.Hide();
        }

        private void btnMenuCitas_Click(object sender, EventArgs e)
        {
            Form_Citas fEspe = new Form_Citas();
            Form_Menu menu = new Form_Menu();
            fEspe.Show();
            this.Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
