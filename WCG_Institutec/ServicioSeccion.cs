using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCG_Institutec
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioSeccion" en el código y en el archivo de configuración a la vez.
    public class ServicioSeccion : IServicioSeccion
    {
        public Boolean EliminarSeccion(String strCodigo)
        {
            try
            {

                try
                {
                    using (InstituTecEntities MiInstituto = new InstituTecEntities())
                    {
                        // Intenta eliminar el curso
                        MiInstituto.usp_BorrarSeccion(strCodigo);
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


        public SeccionDC ConsultarSeccion(String strCodigo)
        {
            try
            {
                //declaramos una instancia del modelo
                InstituTecEntities MiInstituto = new InstituTecEntities();


                //identidicamos el curso a consultar
                Tb_Seccion objSeccion = (from miSeccion in MiInstituto.Tb_Seccion
                                         where miSeccion.IdCods == strCodigo
                                         select miSeccion).FirstOrDefault();

                SeccionDC objSeccionDC = new SeccionDC();

                if (objSeccionDC == null)
                {
                    objSeccionDC.IdCods = String.Empty;
                }
                else
                {
                    objSeccionDC.IdCods = objSeccion.IdCods;
                    objSeccionDC.IdCurs = objSeccion.IdCurs;
                    objSeccionDC.IdProf = objSeccion.IdProf;
                    objSeccionDC.Vacante = Convert.ToByte(objSeccion.Vacant);
                    objSeccionDC.dia = objSeccion.DIA;
                    objSeccionDC.IdCent = objSeccion.IdCent;
                    objSeccionDC.Fec_Registro = Convert.ToDateTime(objSeccion.Fec_Registro);
                    objSeccionDC.Usu_Registro = objSeccion.Usu_Registro;
                    objSeccionDC.Fec_Ult_Mod = Convert.ToDateTime(objSeccion.Fec_Ult_Mod);
                    objSeccionDC.Usu_Ult_Mod = objSeccion.Usu_Ult_Mod;

                    objSeccionDC.NomCur = objSeccion.Tb_Curso.NomCur;
                    objSeccionDC.nomProfesor = objSeccion.TB_Profesor.NomPro + " " +
                                                objSeccion.TB_Profesor.ApePat + " " +
                                                objSeccion.TB_Profesor.ApeMat;

                    objSeccionDC.nomLocal = objSeccion.TB_local.Desloc;

                    if (objSeccion.HorIni != null)
                    {
                        objSeccionDC.HoraIni = objSeccion.HorIni.Value;
                    }
                    if (objSeccion.HorFin != null)
                    {
                        objSeccionDC.HoraFin = objSeccion.HorFin.Value;
                    }


                    objSeccionDC.Activo = Convert.ToInt16(objSeccion.Activo);

                    if (objSeccionDC.Activo == 1)
                    {
                        objSeccionDC.Estado = "Activo";
                    }
                    else
                    {
                        objSeccionDC.Estado = "Inactivo";
                    }
                }

                return objSeccionDC;


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public List<SeccionDC> ListarSeccion()
        {
            try
            {
                //es mejor instanciar dentro, ecuerda definir en cada metodo!
                InstituTecEntities MiInstituto = new InstituTecEntities();


                //creamos una lista de SeccionDC
                List<SeccionDC> objListSeccionDC = new List<SeccionDC>();


                //hacemos la consulta LINQ para obtener todos las seccion
                var query = from miSeccion in MiInstituto.Tb_Seccion
                            join miProfesor in MiInstituto.TB_Profesor on miSeccion.IdProf equals miProfesor.IdProf
                            join miCurso in MiInstituto.Tb_Curso on miSeccion.IdCurs equals miCurso.IdCurs
                            join miLocal in MiInstituto.TB_local on miSeccion.IdCent equals miLocal.IdCent
                            select new
                            {
                                miSeccion.IdCods,
                                miSeccion.IdCurs,
                                nomCurso = miCurso.NomCur,
                                miSeccion.IdProf,
                                nomProfesor = miProfesor.NomPro + " " + miProfesor.ApePat + " " + miProfesor.ApeMat,
                                miSeccion.Activo,
                                miSeccion.Vacant,
                                miSeccion.DIA,
                                miSeccion.IdCent,
                                nomLocal = miLocal.Desloc,
                                miSeccion.Fec_Registro,
                                miSeccion.Usu_Registro,
                                miSeccion.Fec_Ult_Mod,
                                miSeccion.Usu_Ult_Mod,
                                miSeccion.HorIni,
                                miSeccion.HorFin

                            };



                foreach (var resultado in query)
                {
                    SeccionDC objSeccionDC = new SeccionDC();

                    objSeccionDC.IdCods = resultado.IdCods;
                    objSeccionDC.IdCurs = resultado.IdCurs;
                    objSeccionDC.IdProf = resultado.IdProf;
                    objSeccionDC.Vacante = Convert.ToByte(resultado.Vacant);
                    objSeccionDC.dia = resultado.DIA;
                    objSeccionDC.IdCent = resultado.IdCent;
                    objSeccionDC.Fec_Registro = Convert.ToDateTime(resultado.Fec_Registro);
                    objSeccionDC.Usu_Registro = resultado.Usu_Registro;
                    objSeccionDC.Fec_Ult_Mod = Convert.ToDateTime(resultado.Fec_Ult_Mod);
                    objSeccionDC.Usu_Ult_Mod = resultado.Usu_Ult_Mod;
                    objSeccionDC.nomProfesor = resultado.nomProfesor;
                    objSeccionDC.NomCur = resultado.nomCurso;
                    objSeccionDC.nomLocal = resultado.nomLocal;

                    if (resultado.HorIni != null)
                    {
                        objSeccionDC.HoraIni = resultado.HorIni.Value;
                    }
                    if (resultado.HorFin != null)
                    {
                        objSeccionDC.HoraFin = resultado.HorFin.Value;
                    }


                    objSeccionDC.Activo = Convert.ToInt16(resultado.Activo);

                    if (objSeccionDC.Activo == 1)
                    {
                        objSeccionDC.Estado = "Activo";
                    }
                    else
                    {
                        objSeccionDC.Estado = "Inactivo";
                    }

                    objListSeccionDC.Add(objSeccionDC);


                }

                return objListSeccionDC;


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public Boolean ActualizarSeccion(SeccionDC objSeccionDC)
        {
            try
            {
                //es mejor instanciar dentro, ecuerda definir en cada metodo!
                InstituTecEntities MiInstituto = new InstituTecEntities();

                //identificamos la seccion para actualizar
                Tb_Seccion objSeccion = (from miSeccion in MiInstituto.Tb_Seccion
                                         where miSeccion.IdCods == objSeccionDC.IdCods
                                         select miSeccion).FirstOrDefault();


                //actualizamos 
                objSeccion.IdCurs = objSeccionDC.IdCurs;
                objSeccion.IdProf = objSeccionDC.IdProf;
                objSeccion.Vacant = Convert.ToByte(objSeccionDC.Vacante);
                objSeccion.DIA = objSeccionDC.dia;
                objSeccion.IdCent = objSeccionDC.IdCent;
               // objSeccion.Fec_Ult_Mod = Convert.ToDateTime(objSeccionDC.Fec_Ult_Mod);
              //  objSeccion.Usu_Ult_Mod = objSeccionDC.Usu_Ult_Mod;

                objSeccion.Activo = Convert.ToBoolean(objSeccionDC.Activo);

                objSeccion.HorIni = objSeccionDC.HoraIni;
                objSeccion.HorFin = objSeccionDC.HoraFin;


                //actualizar el modelo
                MiInstituto.SaveChanges();

                return true;
            }
            catch (DbUpdateException ex)
            {
                // Muestra la información detallada de la excepción interna
                if (ex.InnerException != null)
                {
                    var innerException = ex.InnerException;
                    throw new Exception("Error al actualizar la sección: " + innerException.Message, innerException);
                }
                else
                {
                    throw new Exception("Error al actualizar la sección: " + ex.Message, ex);
                }
            }
        }


        public Boolean InsertarSeccion(SeccionDC objSeccionDC)
        {



            try
            {


                //es mejor instanciar dentro, ecuerda definir en cada metodo!
                InstituTecEntities MiInstituto = new InstituTecEntities();


                //llamar al store
                MiInstituto.usp_InsertarSeccion(objSeccionDC.IdCurs,
                                                objSeccionDC.IdProf,
                                                Convert.ToBoolean(objSeccionDC.Activo),
                                                Convert.ToByte(objSeccionDC.Vacante),
                                                objSeccionDC.dia,
                                                objSeccionDC.HoraIni,
                                                objSeccionDC.HoraFin,
                                                objSeccionDC.IdCent
                                                );



                //actualizar el modelo
                MiInstituto.SaveChanges();

                return true;



            }
            catch (EntityException ex)
            {
                // Accede a la excepción interna si existe
                if (ex.InnerException != null)
                {
                    var innerException = ex.InnerException;
                    throw new Exception("Error al insertar el curso: " + innerException.Message);
                }
                else
                {
                    throw new Exception("Error al insertar el curso: " + ex.Message);
                }
            }


        }

        public List<SeccionDC> ListarCursos()
        {
            //vendedores definidos como supervisores
            try
            {
                //es mejor instanciar dentro, ecuerda definir en cada metodo!
                InstituTecEntities MiInstituto = new InstituTecEntities();

                List<SeccionDC> objListaSeccionDC = new List<SeccionDC>();


                //con LINQ
                var query = (from micursos in MiInstituto.Tb_Curso
                             where micursos.Activo.HasValue && micursos.Activo.Value
                             orderby micursos.NomCur
                             select micursos).ToList();

                foreach (var objcursos in query)
                {
                    SeccionDC objSeccionDC = new SeccionDC();

                    //solo se necesita el codigo dsel vendedor asiu como su apellido y nombre concatenado
                    objSeccionDC.IdCurs = objcursos.IdCurs;
                    objSeccionDC.NomCur = objcursos.NomCur;

                    objListaSeccionDC.Add(objSeccionDC);

                }

                return objListaSeccionDC;

            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }

        }


        public List<SeccionDC> ListarLocales()
        {
            //vendedores definidos como supervisores
            try
            {
                //es mejor instanciar dentro, ecuerda definir en cada metodo!
                InstituTecEntities MiInstituto = new InstituTecEntities();

                List<SeccionDC> objListaSeccionDC = new List<SeccionDC>();


                //con LINQ
                var query = (from milocal in MiInstituto.TB_local
                             orderby milocal.Desloc
                             select milocal).ToList();

                foreach (var objlocal in query)
                {
                    SeccionDC objSeccionDC = new SeccionDC();

                    //solo se necesita el codigo dsel vendedor asiu como su apellido y nombre concatenado
                    objSeccionDC.IdCent = objlocal.IdCent;
                    objSeccionDC.nomLocal = objlocal.Desloc;

                    objListaSeccionDC.Add(objSeccionDC);

                }

                return objListaSeccionDC;

            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }

        }


        public List<SeccionDC> ListarProfesores()
        {
            //vendedores definidos como supervisores
            try
            {
                //es mejor instanciar dentro, ecuerda definir en cada metodo!
                InstituTecEntities MiInstituto = new InstituTecEntities();

                List<SeccionDC> objListaSeccionDC = new List<SeccionDC>();


                //con LINQ
                var query = (from miprofesor in MiInstituto.TB_Profesor
                             where miprofesor.Estado.HasValue && miprofesor.Estado.Value
                             orderby miprofesor.ApePat
                             select miprofesor).ToList();

                foreach (var objprofesor in query)
                {
                    SeccionDC objSeccionDC = new SeccionDC();

                    //solo se necesita el codigo dsel vendedor asiu como su apellido y nombre concatenado
                    objSeccionDC.IdProf = objprofesor.IdProf;
                    objSeccionDC.nomProfesor = objprofesor.ApePat + " " + objprofesor.ApeMat
                                            + " " + objprofesor.NomPro;

                    objListaSeccionDC.Add(objSeccionDC);

                }

                return objListaSeccionDC;

            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }

        }

    }
}
