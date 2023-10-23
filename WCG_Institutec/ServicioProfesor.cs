using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


namespace WCG_Institutec
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioProfesor" en el código y en el archivo de configuración a la vez.
    public class ServicioProfesor : IServicioProfesor

    

    {
        InstituTecEntities bd = new InstituTecEntities();

        public List<ProfesorDC> ListarProfesor()
        {
            try
            {
                List<ProfesorDC> objListaProfesor = new List<ProfesorDC>();

                var query = (from Profesor in bd.TB_Profesor
                             orderby Profesor.IdProf
                             select Profesor ).ToList();
                foreach (var objProfesor in query)
                {
                    //creamos instancias de vendedorDC
                    ProfesorDC objProfesorDC = new ProfesorDC();
                    objProfesorDC.IdProf = objProfesor.IdProf;
                    objProfesorDC.NomPro = objProfesor.NomPro;
                    objProfesorDC.ApePat = objProfesor.ApePat;
                    objProfesorDC.ApeMat = objProfesor.ApeMat;
                    objProfesorDC.ApellPat_Mat = objProfesor.ApePat + " " + objProfesor.ApeMat + " " + objProfesor.NomPro;
                    objProfesorDC.Ndocum = objProfesor.Ndocum;
                    objProfesorDC.TelPro = objProfesor.TelPro;
                    objProfesorDC.FecNac = Convert.ToDateTime(objProfesor.FecNac);
                    objProfesorDC.Sexopr = objProfesor.Sexopr;
                    objProfesorDC.FecIng = Convert.ToDateTime(objProfesor.FecIng);
                    objProfesorDC.Fec_Registro = Convert.ToDateTime(objProfesor.Fec_Registro);
                    objProfesorDC.Usu_Registro = objProfesor.Usu_Registro;
                    objProfesorDC.Fec_Ult_Mod = Convert.ToDateTime(objProfesor.Fec_Ult_Mod);
                    objProfesorDC.Usu_Ult_Mod = objProfesor.Usu_Ult_Mod;
                    objProfesorDC.CorIns = objProfesor.CorIns;
                    objProfesorDC.Direccion = objProfesor.direccion;
                    objProfesorDC.Id_Ubi = objProfesor.Id_Ubi;
                    objProfesorDC.Estado = Convert.ToBoolean(objProfesor.Estado);
                    objListaProfesor.Add(objProfesorDC);
                }
                return objListaProfesor;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public ProfesorDC ConsultarProfesor(String strCodigo)
        {
            try
            {
                TB_Profesor objProfesor = (from ProfesorDC in bd.TB_Profesor
                                           where ProfesorDC.IdProf== strCodigo
                                           select ProfesorDC).FirstOrDefault();

                ProfesorDC objProfesorDC = new ProfesorDC();
                if (objProfesor == null)
                {
                    objProfesor.IdProf = "";
                }
                else
                {
                    objProfesorDC.IdProf = objProfesor.IdProf;
                    objProfesorDC.NomPro = objProfesor.NomPro;
                    objProfesorDC.ApePat = objProfesor.ApePat;
                    objProfesorDC.ApeMat = objProfesor.ApeMat;
                    objProfesorDC.ApellPat_Mat = objProfesor.ApePat + " " + objProfesor.ApeMat + " " + objProfesor.NomPro;
                    objProfesorDC.Ndocum = objProfesor.Ndocum;
                    objProfesorDC.TelPro = objProfesor.TelPro;
                    objProfesorDC.FecNac = Convert.ToDateTime(objProfesor.FecNac);
                    objProfesorDC.Sexopr = objProfesor.Sexopr;
                    objProfesorDC.FecIng = Convert.ToDateTime(objProfesor.FecIng);
                    objProfesorDC.Fec_Registro = Convert.ToDateTime(objProfesor.Fec_Registro);
                    objProfesorDC.Usu_Registro = objProfesor.Usu_Registro;
                    objProfesorDC.Fec_Ult_Mod = Convert.ToDateTime(objProfesor.Fec_Ult_Mod);
                    objProfesorDC.Usu_Ult_Mod = objProfesor.Usu_Ult_Mod;
                    objProfesorDC.Foto = (byte[])objProfesor.Foto;
                    objProfesorDC.CorIns = objProfesor.CorIns;
                    objProfesorDC.Direccion = objProfesor.direccion;
                    objProfesorDC.Id_Ubi = objProfesor.Id_Ubi;
                    objProfesorDC.Estado = Convert.ToBoolean(objProfesor.Estado);
                    

                }
                return objProfesorDC;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public Boolean InsertarProfesor(ProfesorDC objProfesorDC)
        {

            try
            {

                bd.usp_InsertarProfesor(
            objProfesorDC.Ndocum,
            objProfesorDC.NomPro,
            objProfesorDC.ApePat,
            objProfesorDC.ApeMat,
            objProfesorDC.Sexopr,
            objProfesorDC.Id_Ubi,
            (byte[])objProfesorDC.Foto,
            objProfesorDC.Usu_Registro,
            objProfesorDC.Estado,
            objProfesorDC.CorIns,
            objProfesorDC.TelPro,
            Convert.ToDateTime(objProfesorDC.FecNac),
            Convert.ToDateTime(objProfesorDC.FecIng)
                    );

                bd.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public Boolean ActualizarProfesor(ProfesorDC objProfesorDC)
        {
            
            try
            {
        

                bd.usp_ActulizarProfesor(
            objProfesorDC.IdProf,
            objProfesorDC.NomPro,
            objProfesorDC.ApePat,
            objProfesorDC.ApeMat,
            objProfesorDC.TelPro,
            objProfesorDC.Estado,
            objProfesorDC.FecIng,
            objProfesorDC.Ndocum,
            objProfesorDC.Sexopr,
            objProfesorDC.Id_Ubi,
            objProfesorDC.Usu_Ult_Mod,
            objProfesorDC.Foto
            
                    );

                bd.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public Boolean EliminarProfesor(String strCodigo)
        {
            try
            {
                //definiendo instancia
                InstituTecEntities instituTecEntities = new InstituTecEntities();

                //llamando SP
                instituTecEntities.usp_BorrarProfesor(strCodigo);

                //actualizando el modelo
                instituTecEntities.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {

                // Accede a la excepción interna si existe
                if (ex.InnerException != null)
                {
                    var innerException = ex.InnerException;
                    throw new Exception("Error al eliminar profesor: " + innerException.Message);
                }
                else
                {
                    throw new Exception("Error al eliminar el profesor: " + ex.Message);
                }
            }
        }

        SqlConnection cnx = new SqlConnection(@"server=localhost;DataBase=Institutec;Integrated Security=true");
        SqlCommand cmd = new SqlCommand();
        DataSet dts = new DataSet();
        SqlDataAdapter ada;
        public List<ProfesorDC> ListarProfesorEspecialidad(int num_esp)
        {
            try
            {
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarProfesorEspecialidad";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_esp", num_esp);

                ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "ProfesorEspecialidad");

                //convertir el dataTable en una coleccion
                List<ProfesorDC> objLista = new List<ProfesorDC>();
                foreach (DataRow drFila in dts.Tables[0].Rows)
                {
                    ProfesorDC profesor = new ProfesorDC();
                    profesor.Fullname = drFila["Profesor"].ToString();
                    objLista.Add(profesor);
                }
                return objLista;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
