using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCG_Institutec
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioFacultad" en el código y en el archivo de configuración a la vez.
    public class ServicioFacultad : IServicioFacultad
    {
        InstituTecEntities bd = new InstituTecEntities(); // Asegúrate de que este contexto es correcto.

        public List<FacultadDC> ListarFacultad()
        {
            try
            {
                List<FacultadDC> objListaFacultad = new List<FacultadDC>();

                var query = (from facultad in bd.TB_Facultad
                             orderby facultad.IdFacu
                             select facultad).ToList();

                foreach (var objFacultad in query)
                {
                    // Crear instancias de FacultadDC
                    FacultadDC objFacultadDC = new FacultadDC
                    {
                        IdFacu = objFacultad.IdFacu,
                        DesFac = objFacultad.DesFac,
                        Fec_Registro = Convert.ToDateTime(objFacultad.Fec_Registro),
                        Usu_Registro = objFacultad.Usu_Registro,
                        Fec_Ult_Mod = Convert.ToDateTime(objFacultad.Fec_Ult_Mod),
                        Usu_Ult_Mod = objFacultad.Usu_Ult_Mod
                        // Agrega más propiedades según necesites
                    };

                    objListaFacultad.Add(objFacultadDC);
                }

                return objListaFacultad;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public FacultadDC ConsultarFacultad(String strCodigo)
        {
            try
            {
                var facultad = bd.TB_Facultad.Find(strCodigo);

                if (facultad != null)
                {
                    FacultadDC objFacultadDC = new FacultadDC
                    {
                        IdFacu = facultad.IdFacu,
                        DesFac = facultad.DesFac,
                        Fec_Registro = Convert.ToDateTime(facultad.Fec_Registro),
                        Usu_Registro = facultad.Usu_Registro,
                        Fec_Ult_Mod = Convert.ToDateTime(facultad.Fec_Ult_Mod),
                        Usu_Ult_Mod = facultad.Usu_Ult_Mod
                        // Agrega más propiedades según necesites
                    };

                    return objFacultadDC;
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean ActualizarFacultad(FacultadDC objFacultadDC)
        {
            try
            {
                var facultad = bd.TB_Facultad.Find(objFacultadDC.IdFacu);

                if (facultad != null)
                {
                    facultad.DesFac = objFacultadDC.DesFac;
                    facultad.Fec_Ult_Mod = objFacultadDC.Fec_Ult_Mod;
                    facultad.Usu_Ult_Mod = objFacultadDC.Usu_Ult_Mod;

                    bd.SaveChanges();
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean EliminarFacultad(String strCodigo)
        {
            try
            {
                var facultad = bd.TB_Facultad.Find(strCodigo);

                if (facultad != null)
                {
                    bd.TB_Facultad.Remove(facultad);
                    bd.SaveChanges();
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

