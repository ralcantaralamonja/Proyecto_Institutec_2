using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyInstitutec_GUI
{
    public partial class FrmVerAlumno : Form
    {
        ProxyAlumno.ServicioAlumnoClient objServiceAlumno = new ProxyAlumno.ServicioAlumnoClient();
        ProxyAlumno.AlumnoDC alumnoDC = new ProxyAlumno.AlumnoDC();

        public FrmVerAlumno()
        {
            InitializeComponent();
        }

        private void VerAlumno_Load(object sender, EventArgs e)
        {
            try
            {
                dtgAlumno.AutoGenerateColumns = false;

                CargarDatos();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error : " + ex.Message);
            }

        }

        public void CargarDatos()
        {
            dtgAlumno.DataSource = objServiceAlumno.ListarAlumno();
            lblRegistros.Text = dtgAlumno.Rows.Count.ToString();
            foreach (DataGridViewColumn column in dtgAlumno.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {


            try
            {
                FrmActualizarAlumno objActualizarAlumno = new FrmActualizarAlumno();
                objActualizarAlumno.Codigo = dtgAlumno.CurrentRow.Cells[0].Value.ToString();
                objActualizarAlumno.ShowDialog();

                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }


        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                // instancia

                FrmInsertarAlumno objInsertarAlumno = new FrmInsertarAlumno();
                objInsertarAlumno.ShowDialog();


                //refrescamos el datagrid - para que se vea apenas se haga el cambio
                CargarDatos();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }


        }

        private void dtgAlumno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
