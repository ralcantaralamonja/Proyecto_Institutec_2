using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCG_Institutec
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioFacultad" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioFacultad
    {
        [OperationContract]
        List<FacultadDC> ListarFacultad();

        [OperationContract]
        FacultadDC ConsultarFacultad(String strCodigo);

        [OperationContract]
        Boolean ActualizarFacultad(FacultadDC objFacultadDC);

        [OperationContract]
        Boolean EliminarFacultad(String strCodigo);
    }

    [DataContract]
    [Serializable]
    public class FacultadDC
    {
        [DataMember]
        public String IdFacu { get; set; }

        [DataMember]
        public String DesFac { get; set; }

        [DataMember]
        public DateTime Fec_Registro { get; set; }

        [DataMember]
        public String Usu_Registro { get; set; }

        [DataMember]
        public DateTime Fec_Ult_Mod { get; set; }

        [DataMember]
        public String Usu_Ult_Mod { get; set; }
    }


}
