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
using Test_Institutec;

namespace ProyInstitutec_GUI
{
    public partial class MDIPrincipal : Form
    {

        public static class clsCredenciales
        {
            public static String Login_Usuario;
            public static String Pass_Usuario;
            public static Int16 Niv_Usuario;

        }


        public MDIPrincipal()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MDIPrincipal_Load(object sender, EventArgs e)
        {
            this.lblUsuario.Text = clsCredenciales.Login_Usuario;

            //para niveles de acceso: roles y opciones a ver ... parcial solo Mantenimiento
            if (clsCredenciales.Niv_Usuario == 1)
            {
                //consultasToolStripMenuItem.Visible = true;
                mantenimientoToolStripMenuItem.Visible = false; //EJEMPLO ANTES DEL PARCIAL CON USUARIO JLEON

            }
            else if (clsCredenciales.Niv_Usuario == 2)
            {
                mantenimientoToolStripMenuItem.Visible = true;
                //consultasToolStripMenuItem.Visible = true;
            }
        }

        private void carreraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSeccion objFormSeccion = new FrmSeccion();
            objFormSeccion.MdiParent = this;
            objFormSeccion.Show();
        }



        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MDIPrincipal_Resize(object sender, EventArgs e)
        {
            this.Refresh();
        }







        private void MDIPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MDIPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult vrpta;
            vrpta = MessageBox.Show("Seguro de salir de la aplicación", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (vrpta == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void sALIRToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void profesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmSeccion objFormSeccion = new FrmSeccion();
            //objFormSeccion.MdiParent = this;
            //objFormSeccion.Show();
        }
    }
}