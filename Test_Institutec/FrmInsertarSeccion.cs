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
using Test_Institutec.ProxySeccion;


namespace Test_Institutec
{
    public partial class FrmInsertarSeccion : Form
    {
        public FrmInsertarSeccion()
        {
            InitializeComponent();
        }

        private void FrmInsertarSeccion_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
