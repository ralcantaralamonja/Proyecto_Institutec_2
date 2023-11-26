using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;// para la clase File

namespace ProyInstitutec_GUI
{
    public partial class FrmInsertarProfesor : Form
    {
        ProxyProfesor.ServicioProfesorClient objServiceProfesor = new ProxyProfesor.ServicioProfesorClient();
        ProxyProfesor.ProfesorDC objProfesorDC = new ProxyProfesor.ProfesorDC();
        ProxyUbigeo.ServicioUbigeoClient objServiceUbigeo = new ProxyUbigeo.ServicioUbigeoClient();


        public FrmInsertarProfesor()
        {
            InitializeComponent();
        }

        private void FrmInsertarProfesor_Load(object sender, EventArgs e)
        {
            try
            {
                CargarUbigeo("14", "01", "01");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void CargarUbigeo(String IdDepartamento, String IdProvincia, String IdDistrito)
        {
            EnlazarDepartamento(IdDepartamento);
            EnlazarProvincia(IdDepartamento, IdProvincia);
            EnlazarDistrito(IdDepartamento, IdProvincia, IdDistrito);
        }

        private void EnlazarDepartamento(String IdDepartamento)
        {
            cboDep.DataSource = objServiceUbigeo.GetDepartamentos();
            cboDep.ValueMember = "IdDepartamento";
            cboDep.DisplayMember = "NomDepartamento";
            cboDep.SelectedValue = IdDepartamento;
        }

        private void EnlazarProvincia(String IdDepartamento, String IdProvincia)
        {
            cboProvincia.DataSource = objServiceUbigeo.GetProvincias(IdDepartamento);
            cboProvincia.ValueMember = "IdProvincia";
            cboProvincia.DisplayMember = "NomProvincia";
            cboProvincia.SelectedValue = IdProvincia;
        }
        private void EnlazarDistrito(String IdDepartamento, String IdProvincia, String IdDistrito)
        {
            cboDistrito.DataSource = objServiceUbigeo.GetDistritos(IdDepartamento, IdProvincia);
            cboDistrito.ValueMember = "IdDistrito";  //este nombre viene de la data contractual
            cboDistrito.DisplayMember = "NomDistrito";
            cboDistrito.SelectedValue = IdDistrito;
        }


        private void cboDep_SelectionChangeCommitted(object sender, EventArgs e)
        {
            EnlazarProvincia(cboDep.SelectedValue.ToString(), "01");
            EnlazarDistrito(cboDep.SelectedValue.ToString(),
                cboProvincia.SelectedValue.ToString(), "01");
        }

        private void cboProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            EnlazarDistrito(cboDep.SelectedValue.ToString(),
                             cboProvincia.SelectedValue.ToString(), "01");
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNomPro.Text.Trim() == String.Empty)
                {

                    throw new Exception("El Nombre del profesor es un campo obligatorio");
                }
                if (txtApePat.Text.Trim() == String.Empty)
                {
                    throw new Exception("El apellido paterno del profesor es un campo obligatorio");
                }
                if (txtApeMat.Text.Trim() == String.Empty)
                {
                    throw new Exception("El apellido Marteno del profesor es un campo obligatorio");
                }
                if (txtDni.Text.Trim() == String.Empty || txtDni.Text.Length != 8)
                {
                    throw new Exception("Dni vacio o no contiene 8 digitos");
                }
                if (txtTelf.Text.Trim() == String.Empty)
                {
                    throw new Exception("Numero de telefono invalido");
                }
                if (pcbFoto.Image == null)
                {
                    throw new Exception("Debe registrar la foto.");
                }
                objProfesorDC.Foto = File.ReadAllBytes(openFileDialog1.FileName);

                String Genero = "";
                if (optM.Checked == true)
                {
                    Genero = "M";
                }
                else
                {
                    Genero = "F";
                }
                Boolean activo;
                if (chkActivo.Checked == true)
                {
                    activo = true;
                }
                else
                {
                    activo = false;
                }

                // Convertimos la foto en un arreglo de Bytes y lo almacenamos en su respectiva propiedad

                objProfesorDC.Foto = File.ReadAllBytes(openFileDialog1.FileName);
                objProfesorDC.Usu_Registro = "Kimmy";


                DateTime fechaIng = dtpFecIng.Value;
                //Pasamos valores alas propiedades de la instancia...
                objProfesorDC.NomPro = txtNomPro.Text.Trim();
                objProfesorDC.ApeMat = txtApeMat.Text.Trim();
                objProfesorDC.ApePat = txtApePat.Text.Trim();
                objProfesorDC.Ndocum = txtDni.Text.Trim();
                objProfesorDC.TelPro = txtTelf.Text.Trim();
                objProfesorDC.Sexopr = Genero;
                objProfesorDC.Estado = activo;
                objProfesorDC.FecIng = fechaIng;
                objProfesorDC.Id_Ubi = cboDep.SelectedValue.ToString() + cboProvincia.SelectedValue.ToString() +
                    cboDistrito.SelectedValue.ToString();
                if (objServiceProfesor.InsertarProfesor(objProfesorDC) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se inserto ");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error : " + ex.Message);

            }

        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8)
            {
                if (char.IsDigit(e.KeyChar) == false) // Ni tampoco es digito
                {

                    e.Handled = true; //Se atrapa el caracter y no se imprime 
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.FileName = String.Empty;
                openFileDialog1.Multiselect = false;
                openFileDialog1.ShowDialog();

                // Si se escogio una foto se carga en el picture Box
                if (openFileDialog1.FileName != String.Empty)
                {
                    pcbFoto.Image = Image.FromFile(openFileDialog1.FileName);
                }


            }
            catch (Exception)
            {

                throw;
            }
        }

        private void pcbFoto_Click(object sender, EventArgs e)
        {

        }
    }
}
