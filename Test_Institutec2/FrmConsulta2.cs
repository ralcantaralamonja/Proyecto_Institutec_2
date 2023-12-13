
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

    public partial class FrmConsulta2 : Form
    {
        ProxyProfesor.ServicioProfesorClient objServiceProfesor = new ProxyProfesor.ServicioProfesorClient();
        ProxyProfesor.ProfesorDC objProfesorDC = new ProxyProfesor.ProfesorDC();
        public FrmConsulta2()
        {
            InitializeComponent();
        }

        private void FrmConsulta2_Load(object sender, EventArgs e)
        {
            // objServiceProfesor.Listar

            // objServiceProfesor.Listar
            // objServiceProfesor.ListarProfesor
            //List<ProxyProfesor.ProfesorDC> listaEspecialidades = objServiceProfesor

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Single especialidad = Convert.ToByte(txtNumero.Text);

            //objServiceProfesor.ListarProfesorEspecialidad(especialidad);
            try
            {
                dtgEspecialistas.AutoGenerateColumns = false;
                CargarDatos();
                label4.Text = dtgEspecialistas.Rows.Count.ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        public void CargarDatos()
        {
            //Codifique
            Byte especialidad = Convert.ToByte(txtNumero.Text);
            dtgEspecialistas.DataSource = objServiceProfesor.ListarProfesorEspecialidad(especialidad);
            // contador de registros 
            //dtgAlumnoNrc.DataSource = objServiceAlumno.ListarAlumnoNRC(texLblNrc.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
