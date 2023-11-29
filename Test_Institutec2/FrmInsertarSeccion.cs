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
    public partial class FrmInsertarSeccion : Form
    {

        ProxySeccion.ServicioSeccionClient objServiceSeccion = new ProxySeccion.ServicioSeccionClient();


        //data contractual - entidad de negocio
        ProxySeccion.SeccionDC objSeccionDC = new ProxySeccion.SeccionDC();


        public FrmInsertarSeccion()
        {
            InitializeComponent();
        }

        private void FrmInsertarSeccion_Load(object sender, EventArgs e)
        {


            try
            {
                //// Combo nomCurso se cargue al inicio
                cboNomCurso.DataSource = objServiceSeccion.ListarCursos();
                cboNomCurso.DisplayMember = "NomCur";
                cboNomCurso.ValueMember = "IdCurs";


                //// Combo nomProfesor se cargue al inicio
                cboNomProf.DataSource = objServiceSeccion.ListarProfesores();
                cboNomProf.DisplayMember = "nomProfesor";
                cboNomProf.ValueMember = "IdProf";


                //// Combo local se cargue al inicio
                cboCentroEst.DataSource = objServiceSeccion.ListarLocales();
                cboCentroEst.DisplayMember = "nomLocal";
                cboCentroEst.ValueMember = "IdCent";


            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido el error: " + ex.Message);
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {

            try
            {

                // Validamos que el número de vacantes sea menor a 40
                int vacante;
                if (!int.TryParse(txtVacante.Text, out vacante) || vacante <= 15 || vacante > 40)
                {
                    throw new Exception("El número de vacantes debe ser un número entero mayor de 15 y menor o igual a 40.");
                }

                // Validamos que se haya ingresado un día de la semana
                if (string.IsNullOrWhiteSpace(txtdia.Text))
                {
                    throw new Exception("Debe ingresar un día de la semana.");
                }


                // si todo esta validado
                objSeccionDC.IdCurs = cboNomCurso.SelectedValue.ToString();
                objSeccionDC.IdProf = cboNomProf.SelectedValue.ToString();
                objSeccionDC.Vacante = (short)vacante;
                objSeccionDC.dia = txtdia.Text.Trim();
                objSeccionDC.HoraIni = dtpInicio.Value.TimeOfDay;
                objSeccionDC.HoraFin = dtpFin.Value.TimeOfDay;
                objSeccionDC.IdCent = cboCentroEst.SelectedValue.ToString();



                //--para elegir si es activo o no
                if (chkActivo.Checked)
                {
                    objSeccionDC.Activo = 1;
                }

                else
                {
                    objSeccionDC.Activo = 0;
                }

                objSeccionDC.Usu_Registro = "afernandez";
                objSeccionDC.Activo = Convert.ToInt16(chkActivo.Checked);

                //se invoca a la operacion de insercion
                if (objServiceSeccion.InsertarSeccion(objSeccionDC) == true)

                {
                    this.Close();

                }
                else
                {
                    throw new Exception("No se inserto el registro, contacte con TI");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido el error: " + ex.Message);
            }




        }

        private void cboNomCurso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
