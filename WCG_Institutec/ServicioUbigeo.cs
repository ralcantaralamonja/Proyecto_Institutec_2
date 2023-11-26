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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioUbigeo" en el código y en el archivo de configuración a la vez.
    public class ServicioUbigeo : IServicioUbigeo
    {
        InstituTecEntities bd = new InstituTecEntities();


        public List<Departamentos> GetDepartamentos()
        {
            try
            {
                List<Departamentos> objListaDepartamentos = new List<Departamentos>();

                //obtenemos la lista de departamentos
                var query = bd.usp_Ubigeo_Departamentos();

                foreach (var resultado in query)
                {
                    Departamentos objDepartamentos = new Departamentos();
                    objDepartamentos.IdDepartamento = resultado.IDDEPA;
                    objDepartamentos.nomDepartamento = resultado.DEPARTAMENTO;
                    objListaDepartamentos.Add(objDepartamentos);
                }
                return objListaDepartamentos;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public List<Provincias> GetProvincias(String IdDepa)
        {
            try
            {

                List<Provincias> objListaProvincias = new List<Provincias>();

                //obtenemos la lista de departamentos
                var query = bd.usp_Ubigeo_ProvinciasDepartamento(IdDepa);

                foreach (var resultado in query)
                {
                    Provincias objProvincias = new Provincias();
                    objProvincias.IdProvincia = resultado.IDPROV;
                    objProvincias.nomProvincia = resultado.PROVINCIA;
                    objListaProvincias.Add(objProvincias);
                }
                return objListaProvincias;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Distritos> GetDistritos(String IdDepa, String IdProv)
        {
            try
            {

                List<Distritos> objListaDistritos = new List<Distritos>();

                //obtenemos la lista de departamentos
                var query = bd.usp_Ubigeo_DistritosProvinciaDepartamento(IdDepa, IdProv);

                foreach (var resultado in query)
                {
                    Distritos objDistritos = new Distritos();
                    objDistritos.IdDistrito = resultado.IDDIST;
                    objDistritos.nomDistrito = resultado.DISTRITO;
                    objListaDistritos.Add(objDistritos);
                }
                return objListaDistritos;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
