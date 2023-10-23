using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCG_Institutec
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioProfesor" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioProfesor
    {
        [OperationContract]
        Boolean InsertarProfesor(ProfesorDC objProfesorDC);

        [OperationContract]
        Boolean ActualizarProfesor(ProfesorDC objProfesorDC);

        [OperationContract]
        Boolean EliminarProfesor(String strCodigo);


        [OperationContract]
        ProfesorDC ConsultarProfesor(String strCodigo);

        [OperationContract]
        List<ProfesorDC> ListarProfesor();


        [OperationContract]
        List<ProfesorDC> ListarProfesorEspecialidad(int num_esp);

        //Adicionales....

    }

    [DataContract]
    [Serializable]
    public class ProfesorDC 
    {
        [DataMember]
        public string IdProf { get; set; }

        [DataMember]
        public string Ndocum { get; set; }
        
        [DataMember]
        public string NomPro { get; set; }

        [DataMember]
        public string ApePat { get; set; }

        [DataMember]
        public string ApeMat { get; set; }

        [DataMember]

        public String ApellPat_Mat { get; set; }

        [DataMember]
        public string CorIns { get; set; }

        [DataMember]
        public string TelPro { get; set; }

        [DataMember]
        public DateTime FecNac { get; set; }

        [DataMember]
        public string Sexopr { get; set; }

        [DataMember]
        public DateTime FecIng { get; set; }

        [DataMember]
        public Boolean Estado { get; set; }
        [DataMember]
        public string EstadoTexto { get; set; }


        [DataMember]
        public DateTime Fec_Registro { get; set; }

        [DataMember]
        public string Usu_Registro { get; set; }

        [DataMember] 
        public DateTime Fec_Ult_Mod { get; set; }

        [DataMember]
        public string Usu_Ult_Mod { get; set; }

        [DataMember]
        public byte[] Foto { get; set; }

        [DataMember]
        public string Direccion { get; set; }

        [DataMember]
        public string Id_Ubi { get; set; }
        [DataMember]

        public String Fullname{ get; set; }

    }
}
