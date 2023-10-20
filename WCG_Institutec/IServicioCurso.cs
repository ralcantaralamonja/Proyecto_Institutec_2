using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCG_Institutec
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioCurso" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioCurso
    {
        [OperationContract]
        Boolean InsertarCurso(CursoDC objCursoDC);

        [OperationContract]
        Boolean ActualizarCurso(CursoDC objCursoDC);

        [OperationContract]
        Boolean EliminarCurso(String strCodigo);


        [OperationContract]
        CursoDC ConsultarCurso(String strCodigo);

        [OperationContract]
        List<CursoDC> ListarCurso();



        //Adicionales

        [OperationContract]
        List<CursoDC> ListarCarrera();
    }

    [DataContract]
    [Serializable]
    public class CursoDC 
    {
        [DataMember]
        public string IdCurs { get; set; }

        [DataMember]
        public string NomCur { get; set; }

        [DataMember]
        public bool Activo { get; set; }

        [DataMember]
        public string CodCar { get; set; }

        [DataMember]
        public DateTime Fec_Registro { get; set; }

        [DataMember]
        public string Usu_Registro { get; set; }

        [DataMember]
        public DateTime Fec_Ult_Mod { get; set; }

        [DataMember]
        public string Usu_Ult_Mod { get; set; }

        [DataMember]
        public string DesCar { get; set; }
    }
}
