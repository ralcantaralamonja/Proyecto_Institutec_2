using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCG_Institutec
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioCursoo" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioCursoo
    {
        [OperationContract]
        Boolean EliminarCurso(String strCodigo);


        [OperationContract]
        CursoDC ConsultarCurso(String strCodigo);


        [OperationContract]
        List<CursoDC> ListarCurso();

        [OperationContract]
        Boolean ActualizarCurso(CursoDC objCursoDC);
    }

    [DataContract]
    [Serializable]
    public class CursoDC
    {
        [DataMember]
        public String IdCurs { get; set; }

        [DataMember]
        public String NomCur { get; set; }

        [DataMember]
        public Int16 Activo { get; set; }

        [DataMember]
        public String CodCar { get; set; }

        [DataMember]
        public String DesCar { get; set; }

        [DataMember]
        public DateTime Fec_Registro { get; set; }

        [DataMember]
        public String Usu_Registro { get; set; }

        [DataMember]
        public DateTime Fec_Ult_Mod { get; set; }

        [DataMember]
        public String Usu_Ult_Mod { get; set; }


        [DataMember]
        public String Estado { get; set; }


        [DataMember]
        public String carreraNombre { get; set; }

        [DataMember]
        public String facultadNombre { get; set; }
    }


}
