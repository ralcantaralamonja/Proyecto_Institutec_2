using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCG_Institutec
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioSeccion" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioSeccion
    {
        [OperationContract]
        Boolean EliminarSeccion(String strCodigo);

        [OperationContract]
        SeccionDC ConsultarSeccion(String strCodigo);

        [OperationContract]
        List<SeccionDC> ListarSeccion();


        [OperationContract]
        Boolean ActualizarSeccion(SeccionDC objSeccionDC);


        [OperationContract]
        Boolean InsertarSeccion(SeccionDC objSeccionDC);

        [OperationContract]
        List<SeccionDC> ListarCursos();

        [OperationContract]
        List<SeccionDC> ListarProfesores();

        [OperationContract]
        List<SeccionDC> ListarLocales();
    }


    [DataContract]
    [Serializable]
    public class SeccionDC
    {

        [DataMember]
        public String IdCods { get; set; }

        [DataMember]
        public String IdCurs { get; set; }

        [DataMember]
        public String IdProf { get; set; }

        [DataMember]
        public String NomCur { get; set; }

        [DataMember]
        public Int16 Activo { get; set; }

        [DataMember]
        public String Estado { get; set; }

        [DataMember]
        public Int16 Vacante { get; set; }

        [DataMember]
        public String dia { get; set; }

        [DataMember]
        public String IdCent { get; set; }

        [DataMember]
        public DateTime Fec_Registro { get; set; }

        [DataMember]
        public String Usu_Registro { get; set; }

        [DataMember]
        public DateTime Fec_Ult_Mod { get; set; }

        [DataMember]
        public String Usu_Ult_Mod { get; set; }


        [DataMember]
        public TimeSpan HoraIni { get; set; }

        [DataMember]
        public TimeSpan HoraFin { get; set; }

        [DataMember]
        public String nomProfesor { get; set; }


        [DataMember]
        public String nomLocal { get; set; }



    }


}
