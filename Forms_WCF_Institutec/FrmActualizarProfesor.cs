using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Agregamos
namespace ProyInstitutec_GUI;

public partial class FrmActualizarProfesor : Form
{
    ProxyProfesor.ServicioProfesorClient objServiceProfesor = new ProxyProfesor.ServicioProfesorClient();
    ProxyProfesor.ProfesorDC objProfesorDC = new ProxyProfesor.ProfesorDC();
    ProxyUbigeo.ServicioUbigeoClient objServiceUbigeo = new ProxyUbigeo.ServicioUbigeoClient();

    public FrmActualizarProfesor()
    {
        InitializeComponent();
    }
    public String Codigo { get; set; }
    public byte[] FotoOriginal { get; private set; }

    public bool blnCambio { get; set; }

    private void FrmActualizarProfesor_Load(object sender, EventArgs e)
    {
        try
        {


            objProfesorDC = objServiceProfesor.ConsultarProfesor(this.Codigo);
            if (objProfesorDC.Foto == null || objProfesorDC.Foto.Length == 0)
            {
                pcbFoto.Image = null;
            }
            else
            {
                MemoryStream fotoStream = new MemoryStream(objProfesorDC.Foto);
                pcbFoto.Image = Image.FromStream(fotoStream);
                FotoOriginal = objProfesorDC.Foto;
            }
            DateTime ingreso = objProfesorDC.FecIng;
            lblCodigo.Text = objProfesorDC.IdProf;
            txtNompro.Text = objProfesorDC.NomPro;
            txtApeMat.Text = objProfesorDC.ApeMat;
            txtApePat.Text = objProfesorDC.ApePat;
            txtTelf.Text = objProfesorDC.TelPro;
            txtDNI.Text = objProfesorDC.Ndocum;
            dtpFecIng.Value = ingreso;
            if (objProfesorDC.Estado == true)
            {
                optActivo.Checked = true;
            }
            else
            {
                optInactivo.Checked = true;
            }
            if (objProfesorDC.Sexopr == "M")
            {
                optMasculino.Checked = true;
            }
            else
            {
                optFemenino.Checked = true;
            }

            String Id_Ubigeo = objProfesorDC.Id_Ubi;

            CargarUbigeo(Id_Ubigeo.Substring(0, 2), Id_Ubigeo.Substring(2, 2),
                Id_Ubigeo.Substring(4, 2));


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


    private void cboDep_SelectionChangeCommitted_1(object sender, EventArgs e)
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
            if (txtNompro.Text.Trim() == String.Empty)
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

            if (txtTelf.Text.Trim() == String.Empty)
            {
                throw new Exception("Numero de telefono debe tener 9 digitos");
            }

            if (blnCambio == true)
            {
                objProfesorDC.Foto = File.ReadAllBytes(openFileDialog1.FileName);
            }
            else
            {
                objProfesorDC.Foto = FotoOriginal;
            }


            Boolean activo;
            if (optActivo.Checked == true)
            {
                activo = true;
            }
            else
            {
                activo = false;
            }
            String Sexo;
            if (optMasculino.Checked == true)
            {
                Sexo = "M";
            }
            else
            {
                Sexo = "F";
            }
            DateTime fechaIng = dtpFecIng.Value;
            //Pasamos valores alas propiedades de la instancia...

            objProfesorDC.IdProf = lblCodigo.Text.Trim();
            objProfesorDC.NomPro = txtNompro.Text.Trim();
            objProfesorDC.ApeMat = txtApeMat.Text.Trim();
            objProfesorDC.ApePat = txtApePat.Text.Trim();
            objProfesorDC.TelPro = txtTelf.Text.Trim();
            objProfesorDC.Estado = activo;
            objProfesorDC.FecIng = fechaIng;
            objProfesorDC.Sexopr = Sexo;
            objProfesorDC.Ndocum = txtDNI.Text.Trim();
            objProfesorDC.Id_Ubi = cboDep.SelectedValue.ToString() + cboProvincia.SelectedValue.ToString() +
                      cboDistrito.SelectedValue.ToString();
            if (objServiceProfesor.ActualizarProfesor(objProfesorDC) == true)
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

            MessageBox.Show("Error " + ex.Message);
        }


    }


    private void btnSalir_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void gbActulizar_Enter(object sender, EventArgs e)
    {

    }

    private void optActivo_CheckedChanged(object sender, EventArgs e)
    {

    }



    private void btnFoto_Click(object sender, EventArgs e)
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
                blnCambio = true;
            }
            else
            {
                blnCambio = false;
            }

        }
        catch (Exception ex)
        {

            MessageBox.Show("Error:" + ex.Message);
        }
    }

    private void txtNompro_TextChanged(object sender, EventArgs e)
    {

    }
}
