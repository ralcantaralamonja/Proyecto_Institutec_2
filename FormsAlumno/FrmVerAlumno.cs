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
                dtgAlumno.DataError += dtgAlumno_DataError;
                dtgAlumno.CellFormatting += dtgAlumno_CellFormatting; // Agregamos el evento CellFormatting
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmInsertarAlumno objInsertarAlumno = new FrmInsertarAlumno();
                objInsertarAlumno.ShowDialog();
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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
                if (dtgAlumno.SelectedRows.Count > 0)
                {
                    FrmActualizarAlumno objActualizarAlumno = new FrmActualizarAlumno();
                    objActualizarAlumno.Codigo = dtgAlumno.CurrentRow.Cells[0].Value.ToString();
                    objActualizarAlumno.ShowDialog();
                    CargarDatos();
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona una fila antes de actualizar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dtgAlumno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Puedes agregar lógica aquí si es necesario
        }

        private void mskDNIAlumno_TextChanged(object sender, EventArgs e)
        {
            // Puedes agregar lógica aquí si es necesario
        }

        private void dtgAlumno_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show($"Error en el DataGridView: {e.Exception.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dtgAlumno_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                // Manejar la representación de imágenes nulas
                if (e.Value != null && e.Value is Image)
                {
                    // Puedes realizar más validaciones si es necesario
                    e.Value = null; // O realiza alguna acción para evitar que se muestre la imagen
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción, puedes registrarla, mostrar un mensaje, etc.
                Console.WriteLine($"Error en CellFormatting: {ex.Message}");
            }
        }
    }
}
