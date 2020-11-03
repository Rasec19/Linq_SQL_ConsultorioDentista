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
    public partial class Form_Citas : Form
    {
        Dentistas1 objCita = new Dentistas1();
        public Form_Citas()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form_Menu menu = new Form_Menu();
            menu.Show();
            this.Dispose();
        }

        private void btnMostrarCitas_Click(object sender, EventArgs e)
        {
            using (ConexionConsultorioDataContext bdConsultorio = new ConexionConsultorioDataContext())
            {
                dgVisualizarCitas.DataSource = bdConsultorio.MostrarCitasGeneral();
            }

        }

        private void Form_Citas_Load(object sender, EventArgs e)
        {
            using (ConexionConsultorioDataContext dbConsultorio = new ConexionConsultorioDataContext())
            {
                cmbCitas.DataSource = dbConsultorio.Pacientes.ToList();
                cmbCitas.DisplayMember = "Nombre";
                cmbCitas.ValueMember = "Id_Paciente";
                Pacientes objPacientes = cmbCitas.SelectedItem as Pacientes;
                if (objPacientes != null)
                {
                    dgVisualizarCitas.DataSource = dbConsultorio.MostrarCitas_Por_IdCita(objPacientes.Id_Paciente);
                }
            }
        }

        private void cmbCitas_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Pacientes objPacientes = cmbCitas.SelectedItem as Pacientes;
            if (objPacientes != null)
            {
                using (ConexionConsultorioDataContext bdConsultorio = new ConexionConsultorioDataContext())
                {
                    if (objPacientes != null)
                    {
                        dgVisualizarCitas.DataSource = bdConsultorio.MostrarCitas_Por_IdCita(objPacientes.Id_Paciente);
                    }
                }
            }
        }
    }
}
