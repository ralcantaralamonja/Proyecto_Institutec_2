
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
    public partial class FrmProfesor : Form
    {
        ProxyProfesor.ServicioProfesorClient objServiceProfesor = new ProxyProfesor.ServicioProfesorClient();
        ProxyProfesor.ProfesorDC objProfesorDC = new ProxyProfesor.ProfesorDC();

        public FrmProfesor()
        {
            InitializeComponent();
            //dtgProfesor.CellFormatting += dtgProfesor_CellFormatting;
        }

        public void CargarDatos()
        {
            dtgProfesor.DataSource = objServiceProfesor.ListarProfesor();
            LblRegistros.Text = dtgProfesor.Rows.Count.ToString();
            foreach (DataGridViewColumn column in dtgProfesor.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }


        private void FrmProfesor_Load(object sender, EventArgs e)
        {
            try
            {
                dtgProfesor.AutoGenerateColumns = false;

                dtgProfesor.DataError += dtgProfesor_DataError;


                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void dtgProfesor_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dtgProfesor.Columns["Foto"].Index && e.Value != null)
            {
                byte[] bytes = (byte[])e.Value;
                Image imagen = ByteArrayToImage(bytes);
                e.Value = imagen;
            }
            if (e.ColumnIndex == dtgProfesor.Columns["Estado"].Index && e.Value != null)
            {
                bool estado = (bool)e.Value;
                e.Value = estado ? "activo" : "inactivo";
                e.FormattingApplied = true;
            }
        }

        // Método para convertir un array de bytes a una imagen
        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        private void dtgProfesor_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Manejar el error y evitar que se muestre el cuadro de diálogo predeterminado
            e.ThrowException = false;

            // Mostrar un mensaje de error (puedes personalizarlo según tus necesidades)
            Console.WriteLine("Error al cargar datos de la imagen: " + e.Exception.ToString());
        }


        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                //Codifique
                FrmInsertarProfesor objVend02 = new FrmInsertarProfesor();
                objVend02.ShowDialog();

                // Refrescamos...
                CargarDatos();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }



        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                //Codifique
                FrmActualizarProfesor objVend03 = new FrmActualizarProfesor();

                // Obtenemos el codigo del vendedor seleccionado en el dtgVendedor
                String strCodigo = dtgProfesor.CurrentRow.Cells[0].Value.ToString();
                objVend03.Codigo = strCodigo;
                objVend03.ShowDialog();

                // Refrescamos...
                CargarDatos();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mskDNIProfesor_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgProfesor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

