using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;// para la clase File

namespace ProyInstitutec_GUI
{
    public partial class FrmActualizarAlumno : Form
    {
        ProxyAlumno.ServicioAlumnoClient objServiceAlumno = new ProxyAlumno.ServicioAlumnoClient();
        ProxyAlumno.AlumnoDC objAlumnoDC = new ProxyAlumno.AlumnoDC();
        ProxyCarrera.CarreraDC objCarreraDC = new ProxyCarrera.CarreraDC();
        ProxyFacultad.FacultadDC objFacultadDC = new ProxyFacultad.FacultadDC();
        ProxyUbigeo.ServicioUbigeoClient objServiceUbigeo = new ProxyUbigeo.ServicioUbigeoClient();

        public FrmActualizarAlumno()
        {
            InitializeComponent();
        }
        public String Codigo { get; set; }
        public byte[] FotoOriginal { get; private set; }

        public bool blnCambio { get; set; }


        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (mskDNIAlu.Text.Trim() == String.Empty || mskDNIAlu.Text.Length != 8)
                {
                    throw new Exception("Dni vacio o no contiene 8 digitos");
                }
                if (txtNombre.Text.Trim() == String.Empty)
                {

                    throw new Exception("El Nombre del alumno es un campo obligatorio");
                }
                if (txtApePat.Text.Trim() == String.Empty)
                {
                    throw new Exception("El apellido paterno del alumno es un campo obligatorio");
                }
                if (txtApeMat.Text.Trim() == String.Empty)
                {
                    throw new Exception("El apellido Materno del alumno es un campo obligatorio");
                }

                if (mskTelAlu.Text.Trim() == String.Empty)
                {
                    throw new Exception("Numero de telefono invalido");
                }
                if (txtCorreoAlu.Text.Trim() == String.Empty)
                {
                    throw new Exception("Correo es un campo obligatorio");
                }
                if (textDireccionAlum.Text.Trim() == String.Empty)
                {
                    throw new Exception("La direccion es un campo obligatorio");
                }
                if (pcbFoto.Image == null)
                {
                    throw new Exception("Debe registrar la foto.");
                }


                DateTime fechaNac = dtpFecNac.Value;

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



                // si cambio foto
                if (blnCambio == true)
                {
                    objAlumnoDC.Foto = File.ReadAllBytes(openFileDialog1.FileName);
                }
                else
                {
                    objAlumnoDC.Foto = FotoOriginal;
                }

                //Pasamos valores alas propiedades de la instancia...
                objAlumnoDC.IdAlum = lblCodigo.Text.Trim();
                objAlumnoDC.Ndocum = mskDNIAlu.Text.Trim();
                objAlumnoDC.NomAlu = txtNombre.Text.Trim();
                objAlumnoDC.ApePat = txtApePat.Text.Trim();
                objAlumnoDC.ApeMat = txtApeMat.Text.Trim();
                objAlumnoDC.Sexoal = Genero;
                objAlumnoDC.Estado = activo;
                objAlumnoDC.CorAlu = txtCorreoAlu.Text.Trim();
                objAlumnoDC.FecNac = fechaNac;
                objAlumnoDC.TelAlu = mskTelAlu.Text.Trim();
                objAlumnoDC.direccion = textDireccionAlum.Text.Trim();
                objAlumnoDC.IdFacu = cboFacultad.SelectedValue.ToString();
                objAlumnoDC.CodCar = cboCarrera.SelectedValue.ToString();


                objAlumnoDC.Id_Ubi = cboDep.SelectedValue.ToString() + cboProvincia.SelectedValue.ToString() +
                    cboDistrito.SelectedValue.ToString();



                if (objServiceAlumno.ActualizarAlumno(objAlumnoDC) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se inserto el alumno ");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error : " + ex.Message);

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }



        private void FrmActualizarAlumno_Load(object sender, EventArgs e)
        {
            try
            {
                objAlumnoDC = objServiceAlumno.ConsultarAlumno(this.Codigo);




                if (objAlumnoDC.Foto == null || objAlumnoDC.Foto.Length == 0)
                {
                    pcbFoto.Image = null;
                }
                else
                {
                    MemoryStream fotoStream = new MemoryStream(objAlumnoDC.Foto);
                    pcbFoto.Image = Image.FromStream(fotoStream);
                    FotoOriginal = objAlumnoDC.Foto;
                }

                lblCodigo.Text = objAlumnoDC.IdAlum;
                txtNombre.Text = objAlumnoDC.NomAlu;
                txtApeMat.Text = objAlumnoDC.ApeMat;
                txtApePat.Text = objAlumnoDC.ApePat;
                mskTelAlu.Text = objAlumnoDC.TelAlu;
                mskDNIAlu.Text = objAlumnoDC.Ndocum;
                txtCorreoAlu.Text = objAlumnoDC.CorAlu;
                textDireccionAlum.Text = objAlumnoDC.direccion;
                dtpFecNac.Value = objAlumnoDC.FecNac;



                //String Id_Ubigeo = objAlumnoDC.Id_Ubi;
                //CargarUbigeo(Id_Ubigeo.Substring(0, 2), Id_Ubigeo.Substring(2, 2),
                //    Id_Ubigeo.Substring(4, 2));

                string idCarreraAlumno = objServiceAlumno.ObtenerCarreraAlumno(objAlumnoDC.IdAlum);


                //DataTable dt2 = objCarreraDC.ListarCarrera();
                ////instancia de datarow , instancia de fila
                //DataRow dtr;
                //dtr = dt2.NewRow(); // fila vacia
                //cboCarrera.DataSource = dt2;
                //cboCarrera.DisplayMember = "DesCar";
                //cboCarrera.ValueMember = "CodCar";


                //if (!string.IsNullOrEmpty(idCarreraAlumno))
                //{
                //    cboCarrera.SelectedValue = idCarreraAlumno;
                //}


                ////combos 
                //objAlumnoDC.CodCar = cboCarrera.SelectedValue.ToString();

                string idFacultadAlumno = objServiceAlumno.ObtenerFacultadAlumno(objAlumnoDC.IdAlum);
                //Reemplaza idAlumno con el valor correspondiente


                //// Cargar los datos en el combobox cboFacultad
                //DataTable dt = objFacultadDC.ListarFacultad();
                ////instancia de datarow , instancia de fila
                //DataRow dtrr;
                //dtrr = dt.NewRow(); // fila vacia
                //cboFacultad.DataSource = dt;
                //cboFacultad.DisplayMember = "DesFac";
                //cboFacultad.ValueMember = "IdFacu";



                // Establecer la facultad seleccionada en el combobox cboFacultad
                if (!string.IsNullOrEmpty(idFacultadAlumno))
                {
                    cboFacultad.SelectedValue = idFacultadAlumno;
                }



                if (objAlumnoDC.Estado == true)
                {
                    chkActivo.Checked = true;
                }
                else
                {
                    chkActivo.Checked = false;
                }
                if (objAlumnoDC.Sexoal == "M")
                {
                    optM.Checked = true;
                }
                else
                {
                    optF.Checked = true;
                }
            }
            catch (Exception)
            {

                throw;
            }



        }

        //private void CargarUbigeo(String IdDepa, String IdProv, String IdDist)
        //{

        //    EnlazarDepartamento(IdDepartamento);
        //    EnlazarProvincia(IdDepartamento, IdProvincia);
        //    EnlazarDistrito(IdDepartamento, IdProvincia, IdDistrito);

        //}
        //private void EnlazarDepartamento(String IdDepartamento)
        //{
        //    cboDep.DataSource = objServiceUbigeo.GetDepartamentos();
        //    cboDep.ValueMember = "IdDepartamento";
        //    cboDep.DisplayMember = "NomDepartamento";
        //    cboDep.SelectedValue = IdDepartamento;
        //}

        //private void EnlazarProvincia(String IdDepartamento, String IdProvincia)
        //{
        //    cboProvincia.DataSource = objServiceUbigeo.GetProvincias(IdDepartamento);
        //    cboProvincia.ValueMember = "IdProvincia";
        //    cboProvincia.DisplayMember = "NomProvincia";
        //    cboProvincia.SelectedValue = IdProvincia;
        //}
        //private void EnlazarDistrito(String IdDepartamento, String IdProvincia, String IdDistrito)
        //{
        //    cboDistrito.DataSource = objServiceUbigeo.GetDistritos(IdDepartamento, IdProvincia);
        //    cboDistrito.ValueMember = "IdDistrito";  //este nombre viene de la data contractual
        //    cboDistrito.DisplayMember = "NomDistrito";
        //    cboDistrito.SelectedValue = IdDistrito;
        //}

        //private void cboProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        //{
        //    EnlazarDistrito(cboDep.SelectedValue.ToString(),
        //                 cboProvincia.SelectedValue.ToString(), "01");
        //}

        //private void cboDep_SelectionChangeCommitted(object sender, EventArgs e)
        //{
        //    EnlazarProvincia(cboDep.SelectedValue.ToString(), "01");
        //    EnlazarDistrito(cboDep.SelectedValue.ToString(),
        //        cboProvincia.SelectedValue.ToString(), "01");
        //}


        //private void CargarFacultades(string codCar)
        //{
        //    DataTable dtFacultades = objFacultadDC.facultadCarrera(codCar);
        //    DataRow drFacultad;
        //    drFacultad = dtFacultades.NewRow();
        //    drFacultad["IdFacu"] = 0;
        //    drFacultad["DesFac"] = "--Seleccione--";
        //    dtFacultades.Rows.InsertAt(drFacultad, 0);

        //    cboFacultad.DataSource = dtFacultades;
        //    cboFacultad.DisplayMember = "DesFac";
        //    cboFacultad.ValueMember = "IdFacu";
        //}


        private void mskDNIAlu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8)
            {
                if (char.IsDigit(e.KeyChar) == false) // Ni tampoco es digito
                {

                    e.Handled = true; //Se atrapa el caracter y no se imprime 
                }
            }
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.FileName = String.Empty;
                openFileDialog1.Multiselect = false;
                openFileDialog1.ShowDialog();

                //  Si se escogio una foto se carga en el picture Box
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

        //private void cboCarrera_SelectedIndexChanged(object sender, EventArgs e)

        //{



        //    if (cboFacultad.SelectedValue != null)
        //    {
        //        string codCar = cboCarrera.SelectedValue.ToString();
        //        CargarFacultades(codCar);

        //        string idFacultadSeleccionada = cboFacultad.SelectedValue.ToString();
        //        FacultadDC facultadDC = new FacultadDC();
        //        DataTable carreras = facultadDC.facultadCarrera(idFacultadSeleccionada);

        //        cboCarrera.DisplayMember = "DesCar";
        //        cboCarrera.ValueMember = "CodCar";
        //        cboCarrera.DataSource = carreras;

        //        // Obtener el valor del campo carrera del alumno seleccionado
        //        string idCarreraAlumno = objServiceAlumno.ObtenerCarreraAlumno(objAlumnoDC.IdAlum); // Reemplaza idAlumno con el valor correspondiente

        //        // Establecer la carrera seleccionada en el combobox cboCarrera
        //        if (!string.IsNullOrEmpty(idCarreraAlumno))
        //        {
        //            cboCarrera.SelectedValue = idCarreraAlumno;

        //            DataTable dt2 = objCarreraDC.ListarCarrera();
        //            //instancia de datarow , instancia de fila
        //            DataRow dtr;
        //            dtr = dt2.NewRow(); // fila vacia
        //            cboCarrera.DataSource = dt2;
        //            cboCarrera.DisplayMember = "DesCar";
        //            cboCarrera.ValueMember = "CodCar";

        //            //combos 
        //            objAlumnoDC.CodCar = cboCarrera.SelectedValue.ToString();


        //        }
        //    }
        //}



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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cboFacultad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void mskDNIAlu_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void lblCodigo_Click(object sender, EventArgs e)
        {

        }
    }
}
