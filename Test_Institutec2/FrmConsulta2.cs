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

        private Dictionary<byte, string> especialidades = new Dictionary<byte, string>
        {
            { 0, "--Seleccione--" },
            { 1, "Desarrollo de sistemas" },
            { 2, "Seguridad Informatica" },
            { 3, "Programacion" },
            { 4, "Robotica" },
            { 5, "Base de datos" },
            { 6, "Big data" },
            { 7, "Servidores" },
            { 8, "Iot" },
            { 9, "Desarrollo de aplicaciones en Cloud" },
            { 10, "Desarrollo móviles" }
        };

        public FrmConsulta2()
        {
            InitializeComponent();
            LlenarCombo();
            cboEspecialidad.SelectedIndexChanged += cboEspecialidad_SelectedIndexChanged;
        }

        private void LlenarCombo()
        {
            try
            {
                foreach (var especialidad in especialidades.Values)
                {
                    cboEspecialidad.Items.Add(especialidad);
                }
                cboEspecialidad.SelectedIndex = 0; // Selección inicial
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar especialidades: " + ex.Message);
            }
        }

        private void cboEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEspecialidad.SelectedIndex != 0)
            {
                byte numeroEspecialidad = especialidades.FirstOrDefault(x => x.Value == cboEspecialidad.SelectedItem.ToString()).Key;
                CargarDatos(numeroEspecialidad);
            }
            else
            {
                dtgEspecialistas.DataSource = null; // Vaciar la grilla si no se ha seleccionado una especialidad
                label4.Text = "0";
            }
        }

        public void CargarDatos(byte especialidad)
        {
            try
            {
                dtgEspecialistas.AutoGenerateColumns = false;
                dtgEspecialistas.DataSource = objServiceProfesor.ListarProfesorEspecialidad(especialidad);
                label4.Text = dtgEspecialistas.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        private void FrmConsulta2_Load(object sender, EventArgs e)
        {
            // objServiceProfesor.Listar
            // objServiceProfesor.ListarProfesor
            // List<ProxyProfesor.ProfesorDC> listaEspecialidades = objServiceProfesor
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cboEspecialidad.SelectedIndex != 0)
            {
                try
                {
                    dtgEspecialistas.AutoGenerateColumns = false;
                    CargarDatos((byte)(cboEspecialidad.SelectedIndex - 1)); // Restar 1 para obtener el número de especialidad
                    label4.Text = dtgEspecialistas.Rows.Count.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
