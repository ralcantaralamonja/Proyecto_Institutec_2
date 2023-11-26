using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCG_Institutec
{
    internal class ServicioCarrera : IServicioCarrera
    {

        SqlConnection cnx = new SqlConnection(@"server=localhost;DataBase=Institutec;Integrated Security=true");
        SqlCommand cmd = new SqlCommand();
        DataSet dts = new DataSet();
        SqlDataAdapter ada;
        public List<CarreraDC> ListarCarrera()
        {
            try
            {
                DataTable dts = new DataTable(); // Inicializa un nuevo DataTable

                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarCarrera";
                cmd.Parameters.Clear();

                using (SqlDataAdapter ada = new SqlDataAdapter(cmd))
                {
                    ada.Fill(dts); // Llena el DataTable con los resultados de la consulta
                }

                // Convertir el DataTable en una colección de objetos
                List<CarreraDC> listaCarreras = new List<CarreraDC>();
                foreach (DataRow drFila in dts.Rows)
                {
                    CarreraDC carrera = new CarreraDC();
                    carrera.CodCar = drFila["CodCar"].ToString();
                    carrera.DesCar = drFila["DesCar"].ToString();
                    carrera.DesFac = drFila["DesFac"].ToString();
                    carrera.Est_carr_String = drFila["Est_carr"].ToString();
                    listaCarreras.Add(carrera);
                }
                return listaCarreras;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }
}
