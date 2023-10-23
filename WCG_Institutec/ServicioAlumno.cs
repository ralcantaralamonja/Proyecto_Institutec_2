using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCG_Institutec
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioAlumno" en el código y en el archivo de configuración a la vez.
    public class ServicioAlumno : IServicioAlumno
    {
        public Boolean InsertarAlumno(AlumnoDC objAlumnoDC)
        {
            try
            {
                using (InstituTecEntities Alumnos = new InstituTecEntities())
                {
                    // Llama al procedimiento almacenado usp_InsertarAlumnos
                    Alumnos.usp_InsertarAlumnos(
                        objAlumnoDC.NomAlu,
                        objAlumnoDC.ApePat,
                        objAlumnoDC.ApeMat,
                        objAlumnoDC.Ndocum,
                        objAlumnoDC.Id_Ubi,  // Agregar el parámetro faltante
                        objAlumnoDC.Sexoal,
                        Convert.ToDateTime(objAlumnoDC.FecNac),
                        objAlumnoDC.CorAlu,
                        objAlumnoDC.TelAlu,
                        objAlumnoDC.Usu_Registro,
                        objAlumnoDC.Estado,
                        objAlumnoDC.CodCar,
                        objAlumnoDC.Foto,
                        objAlumnoDC.direccion
                    );

                    // Guarda los cambios en el contexto de Entity Framework
                    Alumnos.SaveChanges();

                    return true;
                }
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public AlumnoDC ConsultarAlumno(string strCodigo)
        {
            try
            {
                using (var context = new InstituTecEntities())
                {
                    // Obtenemos la instancia del alumno consultado
                    TB_Alumno objAlumno = context.TB_Alumno
                        .Where(alumnoConsultado => alumnoConsultado.IdAlum == strCodigo)
                        .FirstOrDefault(); // Asegura que se devuelva solo una instancia (FirstOrDefault).

                    // Creamos una instancia de la entidad de datos contractual AlumnoDC (aquí devolvemos la información del alumno).
                    AlumnoDC objAlumnoDC = new AlumnoDC();

                    // Verificamos si el alumno existe
                    if (objAlumno != null)
                    {
                        objAlumnoDC.IdAlum = objAlumno.IdAlum;
                        objAlumnoDC.NomAlu = objAlumno.NomAlu;
                        objAlumnoDC.ApePat = objAlumno.ApePat;
                        objAlumnoDC.ApeMat = objAlumno.ApeMat;
                        objAlumnoDC.TelAlu = objAlumno.TelAlu;
                        objAlumnoDC.CorAlu = objAlumno.CorAlu;
                        objAlumnoDC.Sexoal = objAlumno.Sexoal;
                        objAlumnoDC.Estado = objAlumno.Estado ?? false;
                        objAlumnoDC.Ndocum = objAlumno.Ndocum;
                        objAlumnoDC.Id_Ubi = objAlumno.Id_Ubi;
                        objAlumnoDC.FecNac = Convert.ToDateTime(objAlumno.FecNac);
                        objAlumnoDC.CodCar = objAlumno.CodCar;
                        objAlumnoDC.Fec_Registro = Convert.ToDateTime(objAlumno.Fec_Registro);
                        objAlumnoDC.Usu_Registro = objAlumno.Usu_Registro;
                        objAlumnoDC.Fec_Ult_Mod = Convert.ToDateTime(objAlumno.Fec_Ult_Mod);
                        objAlumnoDC.direccion = objAlumno.direccion;

                        // Obtén los datos binarios de la columna "Foto"
                        byte[] fotoData = objAlumno.foto;

                        // Asigna los datos binarios a la propiedad "Foto" de AlumnoDC
                        objAlumnoDC.Foto = fotoData;

                    }
                    else
                    {
                        // Si el alumno no existe, puedes devolver una instancia con valores predeterminados o nulos
                        objAlumnoDC.IdAlum = string.Empty;
                        // Aquí puedes establecer otras propiedades a valores predeterminados.
                    }

                    return objAlumnoDC;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<AlumnoDC> ListarAlumno()
        {
            try
            {
                //definiendo instancia
                InstituTecEntities instituTecEntities = new InstituTecEntities();

                //creamos lsita de AlumnoDC
                List<AlumnoDC> objListAlumnoDC = new List<AlumnoDC>();

                //consulta en LINQ
                var query = (from Alumno in instituTecEntities.TB_Alumno select Alumno);

                foreach (var resultado in query)
                {
                    AlumnoDC objAlumnoDC = new AlumnoDC();


                    objAlumnoDC.IdAlum = resultado.IdAlum;
                    objAlumnoDC.NomAlu = resultado.NomAlu;
                    objAlumnoDC.ApePat = resultado.ApePat;
                    objAlumnoDC.ApeMat = resultado.ApeMat;
                    objAlumnoDC.TelAlu = resultado.TelAlu;
                    objAlumnoDC.CorAlu = resultado.CorAlu;
                    objAlumnoDC.Sexoal = resultado.Sexoal;
                    objAlumnoDC.Estado = resultado.Estado ?? false;
                    objAlumnoDC.Ndocum = resultado.Ndocum;
                    objAlumnoDC.Id_Ubi = resultado.Id_Ubi;
                    objAlumnoDC.FecNac = Convert.ToDateTime(resultado.FecNac);
                    objAlumnoDC.CodCar = resultado.CodCar;
                    objAlumnoDC.Fec_Registro = Convert.ToDateTime(resultado.Fec_Registro);
                    objAlumnoDC.Usu_Registro = resultado.Usu_Registro;
                    objAlumnoDC.Fec_Ult_Mod = Convert.ToDateTime(resultado.Fec_Ult_Mod);
                    objAlumnoDC.direccion = resultado.direccion;

                    // Obtén los datos binarios de la columna "Foto"
                    byte[] fotoData = resultado.foto;

                    // Asigna los datos binarios a la propiedad "Foto" de AlumnoDC
                    objAlumnoDC.Foto = fotoData;

                    // Agrega el objeto AlumnoDC a la lista
                    objListAlumnoDC.Add(objAlumnoDC);
                }

                return objListAlumnoDC;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        SqlConnection cnx = new SqlConnection(@"server=localhost;DataBase=Institutec;Integrated Security=true");
        SqlCommand cmd = new SqlCommand();
        DataSet dts = new DataSet();
        SqlDataAdapter ada;
        public List<AlumnoDC> ListarAlumnoNRC(String Nrc)
        {
            try
            {
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarAlumnoNRC";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nrc", Nrc);

                ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "AlumnoNrc");

                //convertir el dataTable en una coleccion
                List<AlumnoDC> objLista = new List<AlumnoDC>();
                foreach (DataRow drFila in dts.Tables[0].Rows)
                {
                    AlumnoDC alumno = new AlumnoDC();
                    alumno.NomCur = drFila["Curso"].ToString();
                    alumno.FullName = drFila["Alumno"].ToString();
                    alumno.IdAlum = drFila["ID"].ToString();
                    alumno.CorAlu = drFila["Correo"].ToString();
                    alumno.DesCar = drFila["Carrera"].ToString();
                    alumno.DesFac = drFila["Facultad"].ToString();




                    objLista.Add(alumno);
                }
                return objLista;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public Boolean EliminarAlumno(String strCodigo)
        {
            try
            {
                //definiendo instancia
                InstituTecEntities instituTecEntities = new InstituTecEntities();

                //llamando SP
                instituTecEntities.usp_BorrarAlumno(strCodigo);

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
                    throw new Exception("Error al eliminar alumno: " + innerException.Message);
                }
                else
                {
                    throw new Exception("Error al eliminar el alumno: " + ex.Message);
                }
            }
        }

        public Boolean ActualizarAlumno(AlumnoDC objAlumnoDC)
        {
            try
            {
                //definiendo instancia
                InstituTecEntities instituTecEntities = new InstituTecEntities();

                //store
                instituTecEntities.usp_ActualizarAlumno(
                        objAlumnoDC.IdAlum,
                        objAlumnoDC.NomAlu,
                        objAlumnoDC.ApePat,
                        objAlumnoDC.ApeMat,
                        objAlumnoDC.TelAlu,
                        Convert.ToDateTime(objAlumnoDC.FecNac),
                        objAlumnoDC.Estado,
                        objAlumnoDC.Ndocum,
                        objAlumnoDC.Id_Ubi,
                        objAlumnoDC.Sexoal,
                        objAlumnoDC.CorAlu,
                        objAlumnoDC.Usu_Registro,
                        objAlumnoDC.CodCar,
                        objAlumnoDC.Foto,
                        objAlumnoDC.direccion
                    );

                instituTecEntities.SaveChanges();
                return true;

            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
<<<<<<< HEAD

=======
   
>>>>>>> 3b21434e1da9302c7bae04dac150e555dae32ff6



    }
}
