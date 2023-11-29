
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
using ProxyUsuario;

namespace ProyInstitutec_GUI
{
    public partial class frmLogin : Form
    {
        Int16 intentos = 0;
        Int16 tiempo = 30;

        public static class clsCredenciales
        {
            public static String Login_Usuario;
            public static String Pass_Usuario;
            public static Int16 Niv_Usuario;

        }

        ProxyUsuario.ServicioUsuarioClient objUsuario = new ProxyUsuario.ServicioUsuarioClient();
        //data contractual - entidad de negocio
        ProxyUsuario.UsuarioDC objUsuarioDC = new ProxyUsuario.UsuarioDC();


        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (txtLogin.Text.Trim() != String.Empty & txtPassword.Text.Trim() != String.Empty)
            {
                // Codifique...
                //obtenemos las credenciales del usuario logueado
                objUsuarioDC = objUsuario.ConsultarUsuario(txtLogin.Text.Trim());

                if (objUsuarioDC.Login_Usuario == null) // si el usuario no existe
                {
                    MessageBox.Show("Usuario no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intentos += 1;
                    ValidaAccesos();
                }
                else if (objUsuarioDC.Login_Usuario == txtLogin.Text.Trim() && objUsuarioDC.Pass_Usuario == txtPassword.Text.Trim()) //si existe usuario
                {
                    //si las credenciales son correctas...
                    this.Hide();
                    timer1.Enabled = false;
                    clsCredenciales.Login_Usuario = objUsuarioDC.Login_Usuario;
                    clsCredenciales.Pass_Usuario = objUsuarioDC.Pass_Usuario;
                    clsCredenciales.Niv_Usuario = objUsuarioDC.Niv_Usuario;
                    MDIPrincipal mdi = new MDIPrincipal();
                    mdi.ShowDialog();

                }



                else
                {
                    MessageBox.Show("Usuario o Password incorrectos",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intentos += 1;
                    ValidaAccesos();

                }
            }
            else
            {
                MessageBox.Show("Usuario o Password obligatorios",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                intentos += 1;
                ValidaAccesos();
            }

        }
        private void ValidaAccesos()
        {
            if (intentos == 3)
            {
                MessageBox.Show("Lo sentimos,  sobrepaso el numero de intentos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tiempo -= 1;
            this.Text = "Ingrese su login y contraseña. Le quedan ...." + tiempo;
            if (tiempo == 0)
            {
                MessageBox.Show("Lo sentimos, sobrepaso el tiempo de espera", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Enabled = false;
            Application.Exit();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Application.Exit();
        }


        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnAceptar.PerformClick();
            }
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void frmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnAceptar.PerformClick();
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load_1(object sender, EventArgs e)
        {

        }
    }
}
