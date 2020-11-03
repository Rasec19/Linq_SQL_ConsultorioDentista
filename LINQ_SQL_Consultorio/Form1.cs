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
    public partial class Form1 : Form
    {
        Dentistas1 objDentistas = new Dentistas1();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgVisualizar.DataSource = objDentistas.MostrarDatos();
        }
    }
}
