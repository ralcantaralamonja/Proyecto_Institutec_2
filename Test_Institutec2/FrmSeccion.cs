using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//agregando

using ProxySeccion;


namespace Test_Institutec
{


    public partial class FrmSeccion : Form
    {

        //INSTANCIAR SERVICIO
        ServicioSeccionClient objProxySeccion = new ServicioSeccionClient();
        DataView dtv;

        public FrmSeccion()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void FrmSeccion_Load(object sender, EventArgs e)
        {

            try
            {
                dgtSeccion.AutoGenerateColumns = false;
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }


        }

        private void txtCodSeccion_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtCodSeccion.Text.Trim() != String.Empty)
                {

                    // Filtrar la lista por código
                    List<SeccionDC> seccionesFiltradas = objProxySeccion.ListarSeccion()
                        .Where(s => s.IdCods.Contains(txtCodSeccion.Text.Trim()))
                        .ToList();

                    // Asignar la lista filtrada al origen de datos de la DataGridView
                    dgtSeccion.DataSource = seccionesFiltradas;

                    // Mostrar la cantidad de filas filtradas
                    lblRegistros.Text = seccionesFiltradas.Count.ToString();

                }
                else
                {
                    // Si no hay código, mostrar todas las secciones
                    dgtSeccion.DataSource = objProxySeccion.ListarSeccion();

                    // Mostrar la cantidad total de filas
                    lblRegistros.Text = dgtSeccion.Rows.Count.ToString();
                }
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
                // Crear una instancia del formulario FrmInsertarSeccion
                FrmInsertarSeccion frmInsertarSeccion = new FrmInsertarSeccion();

                // Mostrar el formulario de inserción y esperar hasta que se cierre
                frmInsertarSeccion.ShowDialog();

                //refrescamos 
                CargarDatos();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            try
            {

                FrmActualizarSeccion objFrmActualizarSeccion = new FrmActualizarSeccion();
                objFrmActualizarSeccion.Codigo = dgtSeccion.CurrentRow.Cells[0].Value.ToString();
                objFrmActualizarSeccion.ShowDialog();

                CargarDatos();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }

        }


        public void CargarDatos()
        {
            //Codifique
            dgtSeccion.DataSource = objProxySeccion.ListarSeccion();
            lblRegistros.Text = dgtSeccion.Rows.Count.ToString();
        }

    }
}
