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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioCursoo" en el código y en el archivo de configuración a la vez.
    public class ServicioCursoo : IServicioCursoo
    {
        SqlConnection cnx = new SqlConnection(@"server=localhost;DataBase=Institutec;Integrated Security=true");
        SqlCommand cmd = new SqlCommand();
        DataSet dts = new DataSet();
        SqlDataAdapter ada;

        public Boolean EliminarCurso(String strCodigo)
        {
            try
            {

                try
                {
                    using (InstituTecEntities MiInstituto = new InstituTecEntities())
                    {
                        // Intenta eliminar el curso
                        MiInstituto.usp_BorrarCurso(strCodigo);
                        MiInstituto.SaveChanges();
                        return true;
                    }
                }
                catch (EntityException ex)
                {
                    // Accede a la excepción interna si existe
                    if (ex.InnerException != null)
                    {
                        var innerException = ex.InnerException;
                        throw new Exception("Error al eliminar el curso: " + innerException.Message);
                    }
                    else
                    {
                        throw new Exception("Error al eliminar el curso: " + ex.Message);
                    }
                }

            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }



        public CursoDC ConsultarCurso(String strCodigo)
        {
            try
            {
                //declaramos una instancia del modelo
                InstituTecEntities MiInstituto = new InstituTecEntities();

                //identidicamos el curso a consultar
                Tb_Curso objCurso = (from miCurso in MiInstituto.Tb_Curso
                                     where miCurso.IdCurs == strCodigo
                                     select miCurso).FirstOrDefault();

                CursoDC objCursoDC = new CursoDC();

                if (objCurso == null)
                {
                    objCursoDC.IdCurs = String.Empty;
                }
                else
                {
                    objCursoDC.IdCurs = objCurso.IdCurs;
                    objCursoDC.NomCur = objCurso.NomCur;
                    objCursoDC.CodCar = objCurso.CodCar;
                    objCursoDC.Fec_Registro = Convert.ToDateTime(objCurso.Fec_Registro);
                    objCursoDC.Usu_Registro = objCurso.Usu_Registro;
                    objCursoDC.Fec_Ult_Mod = Convert.ToDateTime(objCurso.Fec_Ult_Mod);
                    objCursoDC.Usu_Ult_Mod = objCurso.Usu_Ult_Mod;

                    objCursoDC.carreraNombre = objCurso.Tb_Carrera.DesCar;
                    objCursoDC.facultadNombre = objCurso.Tb_Carrera.TB_Facultad.DesFac;

                    objCursoDC.Activo = Convert.ToInt16(objCurso.Activo);

                    if (objCursoDC.Activo == 1)
                    {
                        objCursoDC.Estado = "Activo";
                    }
                    else
                    {
                        objCursoDC.Estado = "Inactivo";
                    }


                }




                return objCursoDC;


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



        public List<CursoDC> ListarCurso()
        {
            try
            {
                //es mejor instanciar dentro, ecuerda definir en cada metodo!
                InstituTecEntities MiInstituto = new InstituTecEntities();


                //creamos una lista de CursoDC
                List<CursoDC> objListCursoDC = new List<CursoDC>();

                //hacemos la consulta LINQ para obtener todos los cursos
                var query = from miCurso in MiInstituto.Tb_Curso
                            join miCarrera in MiInstituto.Tb_Carrera on miCurso.CodCar equals miCarrera.CodCar
                            join miFacultad in MiInstituto.TB_Facultad on miCarrera.IdFacu equals miFacultad.IdFacu
                            select new
                            {
                                miCurso.IdCurs,
                                miCurso.NomCur,
                                miCurso.CodCar,
                                miCurso.Fec_Registro,
                                miCurso.Usu_Registro,
                                miCurso.Fec_Ult_Mod,
                                miCurso.Usu_Ult_Mod,
                                miCurso.Activo,
                                carreraNombre = miCarrera.DesCar,
                                facultadNombre = miFacultad.DesFac
                            };

                foreach (var resultado in query)
                {
                    CursoDC objCursoDC = new CursoDC();

                    objCursoDC.IdCurs = resultado.IdCurs;
                    objCursoDC.NomCur = resultado.NomCur;
                    objCursoDC.CodCar = resultado.CodCar;
                    objCursoDC.Fec_Registro = Convert.ToDateTime(resultado.Fec_Registro);
                    objCursoDC.Usu_Registro = resultado.Usu_Registro;
                    objCursoDC.Fec_Ult_Mod = Convert.ToDateTime(resultado.Fec_Ult_Mod);
                    objCursoDC.Usu_Ult_Mod = resultado.Usu_Ult_Mod;

                    objCursoDC.carreraNombre = resultado.carreraNombre;
                    objCursoDC.facultadNombre = resultado.facultadNombre;

                    objCursoDC.Activo = Convert.ToByte(resultado.Activo);

                    if (objCursoDC.Activo == 1)
                    {
                        objCursoDC.Estado = "Activo";
                    }
                    else
                    {
                        objCursoDC.Estado = "Inactivo";
                    }

                    objListCursoDC.Add(objCursoDC);
                }

                return objListCursoDC;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public Boolean ActualizarCurso(CursoDC objCursoDC)
        {
            try
            {
                //es mejor instanciar dentro, ecuerda definir en cada metodo!
                InstituTecEntities MiInstituto = new InstituTecEntities();


                //identificamos el Curso para actualizar
                Tb_Curso objCurso = (from miCurso in MiInstituto.Tb_Curso
                                     where miCurso.IdCurs == objCursoDC.IdCurs
                                     select miCurso).FirstOrDefault();

                //actualizamos 
                objCurso.NomCur = objCursoDC.NomCur;
                objCurso.CodCar = objCursoDC.CodCar;
                objCurso.Fec_Ult_Mod = Convert.ToDateTime(objCursoDC.Fec_Ult_Mod);
                objCurso.Usu_Ult_Mod = objCursoDC.Usu_Ult_Mod;

                objCurso.Activo = Convert.ToBoolean(objCursoDC.Activo);



                //actualizar el modelo
                MiInstituto.SaveChanges();

                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<CursoDC> ObtenerCarreraXGenero()
        {
            try
            {
                DataTable dts = new DataTable(); // Inicializa un nuevo DataTable

                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_CarreraXGenero";
                cmd.Parameters.Clear();

                using (SqlDataAdapter ada = new SqlDataAdapter(cmd))
                {
                    ada.Fill(dts); // Llena el DataTable con los resultados de la consulta
                }

                // Convertir el DataTable en una colección de objetos
                List<CursoDC> listaCarreras = new List<CursoDC>();
                foreach (DataRow drFila in dts.Rows)
                {
                    CursoDC carrera = new CursoDC();
                    carrera.NumHombres = Convert.ToSingle(drFila["Hombres"]);
                    carrera.NumMujeres = Convert.ToSingle(drFila["Mujeres"]);
                    carrera.Curso = drFila["Carrera"].ToString();
                    carrera.Total = Convert.ToSingle(drFila["Total"]);
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
