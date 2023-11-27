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
        ProxyAlumno.AlumnoDC objAlumnoDC = new ProxyAlumno.AlumnoDC();

        public FrmVerAlumno()
        {
            InitializeComponent();
        }

        public void CargarDatos()
        {
            try
            {
                dtgAlumno.DataSource = objServiceAlumno.ListarAlumno();
                lblRegistros.Text = dtgAlumno.Rows.Count.ToString();
                foreach (DataGridViewColumn column in dtgAlumno.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos en el DataGridView: " + ex.Message);
            }
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



        private void dtgAlumno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mskDNIAlumno_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
