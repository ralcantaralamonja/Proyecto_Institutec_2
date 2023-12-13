using ProxyProfesor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Institutec2
{

    public partial class FrmConsulta2 : Form
    {
        ProxyProfesor.ServicioProfesorClient objServiceProfesor = new ProxyProfesor.ServicioProfesorClient();
        ProxyProfesor.ProfesorDC objProfesorDC = new ProxyProfesor.ProfesorDC();
        public FrmConsulta2()
        {
            InitializeComponent();
        }

        private void FrmConsulta2_Load(object sender, EventArgs e)
        {

           // objServiceProfesor.Listar
            // objServiceProfesor.ListarProfesor
            //List<ProxyProfesor.ProfesorDC> listaEspecialidades = objServiceProfesor

        }
       


    }
}
