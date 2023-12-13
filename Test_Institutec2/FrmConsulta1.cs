using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Institutec2
{
    public partial class FrmConsulta1 : Form
    {
        ProxyAlumno.ServicioAlumnoClient objServiceAlumno = new ProxyAlumno.ServicioAlumnoClient();
        ProxyAlumno.AlumnoDC objAlumnoDC = new ProxyAlumno.AlumnoDC();
        public FrmConsulta1()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                if (texLblNrc.Text.Trim() == String.Empty || texLblNrc.Text.Length != 6)
                {
                    throw new Exception("NRC vacio o no contiene 6 caracteres");
                }
                //  dtgAlumnoNrc.AutoGenerateColumns = false;
                CargarDatos();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void CargarDatos()
        {
            //Codifique
            dtgAlumnoNrc.DataSource = objServiceAlumno.ListarAlumnoNRC(texLblNrc.Text);
            // contador de registros 
        }


        private void dtgAlumnoNrc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
