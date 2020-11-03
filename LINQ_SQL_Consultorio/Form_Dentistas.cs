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
    public partial class Form_Dentistas : Form
    {
        ConexionConsultorioDataContext bdConsultorio = new ConexionConsultorioDataContext();
        Dentistas1 objDentistas = new Dentistas1();
        public Form_Dentistas()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            using (ConexionConsultorioDataContext bdConsultorio = new ConexionConsultorioDataContext())
            {
                dgVisualizarDentistas.DataSource = bdConsultorio.MostrarDatosDentistaGeneral();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form_Menu menu = new Form_Menu();
            menu.Show();
            this.Dispose();
        }

        private void Form_Dentistas_Load(object sender, EventArgs e)
        {
            using (ConexionConsultorioDataContext dbConsultorio = new ConexionConsultorioDataContext()) 
            {
                cmbDentistas.DataSource = bdConsultorio.Dentistas.ToList();
                cmbDentistas.DisplayMember = "Nombre";
                cmbDentistas.ValueMember = "Id_Dentista";
                Dentistas objDentista = cmbDentistas.SelectedItem as Dentistas;
                if (objDentista != null)
                {
                    dgVisualizarDentistas.DataSource = bdConsultorio.MostrarDatosDentistas(objDentista.Id_Dentista);
                }
            }
           
        }

        private void cmbDentistas_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Dentistas objDentista = cmbDentistas.SelectedItem as Dentistas;
            if (objDentista != null) 
            {
                using (ConexionConsultorioDataContext bdConsultorio = new ConexionConsultorioDataContext())
                {
                    if (objDentista != null)
                    {
                        dgVisualizarDentistas.DataSource = bdConsultorio.MostrarDatosDentistas(objDentista.Id_Dentista);
                    }
                }
            }
        }

        private void cmbDentistas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
