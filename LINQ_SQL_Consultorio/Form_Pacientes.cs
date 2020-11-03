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
    public partial class Form_Pacientes : Form
    {
        Dentistas1 objPacientes = new Dentistas1();
        public Form_Pacientes()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form_Menu menu = new Form_Menu();
            menu.Show();
            this.Dispose();
        }

        private void btnMostrarPacientes_Click(object sender, EventArgs e)
        {
            using (ConexionConsultorioDataContext bdConsultorio = new ConexionConsultorioDataContext())
            {
                dgVisualizarPacientes.DataSource = bdConsultorio.MostrarPacientesGeneral();
            }
        }

        private void Form_Pacientes_Load(object sender, EventArgs e)
        {
            using (ConexionConsultorioDataContext dbConsultorio = new ConexionConsultorioDataContext())
            {
                cmbPacientes.DataSource = dbConsultorio.Pacientes.ToList();
                cmbPacientes.DisplayMember = "Nombre";
                cmbPacientes.ValueMember = "Id_Paciente";
                Pacientes objPacientes = cmbPacientes.SelectedItem as Pacientes;
                if (objPacientes != null)
                {
                    dgVisualizarPacientes.DataSource = dbConsultorio.MostrarCitas_Por_Id_Paciente(objPacientes.Id_Paciente);
                }
            }
        }

        private void cmbPacientes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Pacientes objPacientes = cmbPacientes.SelectedItem as Pacientes;
            if (objPacientes != null)
            {
                using (ConexionConsultorioDataContext bdConsultorio = new ConexionConsultorioDataContext())
                {
                    if (cmbPacientes != null)
                    {
                        dgVisualizarPacientes.DataSource = bdConsultorio.MostrarCitas_Por_Id_Paciente(objPacientes.Id_Paciente);
                    }
                }
            }
        }
    }
}
