using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCG_Institutec
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioUsuario" en el código y en el archivo de configuración a la vez.
    public class ServicioUsuario : IServicioUsuario
    {
        public UsuarioDC ConsultarUsuario(String strLogin)
        {
            try
            {
                // Declaramos una instancia del modelo
                InstituTecEntities MiInstituto = new InstituTecEntities();

                // Llamamos al procedimiento almacenado y obtenemos el resultado
                var resultado = MiInstituto.usp_ConsultarUsuario(strLogin).FirstOrDefault();

                // Verificamos si se encontró algún resultado
                if (resultado != null)
                {
                    // Creamos un objeto UsuarioDC y lo llenamos con los datos del resultado
                    UsuarioDC usuarioDC = new UsuarioDC
                    {
                        Login_Usuario = resultado.Login_Usuario,
                        Pass_Usuario = resultado.Pass_Usuario,
                        Niv_Usuario = Convert.ToInt16(resultado.Niv_Usuario),
                        Est_Usuario = Convert.ToInt16(resultado.Est_usuario),
                        Fec_Registro = Convert.ToDateTime(resultado.Fec_Registro),
                        Usu_Registro = resultado.Usu_Registro
                    };

                    // Puedes realizar más acciones si es necesario, como guardar cambios en el contexto
                    MiInstituto.SaveChanges();

                    // Devolvemos el objeto UsuarioDC
                    return usuarioDC;
                }
                else
                {
                    // Puedes manejar el caso en que no se encuentra ningún usuario con el login proporcionado
                    // Por ejemplo, lanzar una excepción o devolver un valor predeterminado
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }




        }
    }
}
