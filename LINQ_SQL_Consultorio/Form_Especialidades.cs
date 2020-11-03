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
    public partial class Form_Especialidades : Form
    {
        Dentistas1 objEspe = new Dentistas1();
        public Form_Especialidades()
        {
            InitializeComponent();
        }

        private void btnMostrarEspecialidades_Click(object sender, EventArgs e)
        {
            using (ConexionConsultorioDataContext bdConsultorio = new ConexionConsultorioDataContext()) 
            {
                dgVisualizarEspecialidades.DataSource = bdConsultorio.MostrarEspecialidad();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form_Menu menu = new Form_Menu();
            menu.Show();
            this.Dispose();
        }
    }
}
